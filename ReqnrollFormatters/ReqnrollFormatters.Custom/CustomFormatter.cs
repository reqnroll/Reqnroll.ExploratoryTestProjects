using System.Text;
using Io.Cucumber.Messages.Types;
using Reqnroll.Formatters;
using Reqnroll.Formatters.Configuration;
using Reqnroll.Formatters.RuntimeSupport;
using Reqnroll.Utils;

namespace ReqnrollFormatters.Custom;

public class CustomFormatter(IFormattersConfigurationProvider configurationProvider, IFormatterLog logger, IFileSystem fileSystem)
    : FileWritingFormatterBase(configurationProvider, logger, fileSystem, "custom", ".txt", "output.txt")
{
    private TextWriter? _outputWriter;
    private readonly Dictionary<string, Pickle> _picklesById = new();
    private readonly Dictionary<string, TestCase> _testCasesById = new();
    private readonly Dictionary<string, TestCaseStarted> _testCaseStartsById = new();
    private readonly Dictionary<string, TestStepResultStatus> _testCaseStatusesByStartId = new();

    protected override void OnTargetFileStreamInitialized(Stream targetFileStream)
    {
        // We use AutoFlush to ensure that the output is written immediately.
        // Without this setting, we would need to override FlushTargetFileStream
        // to ensure that the output is written at the end of the test run.
        _outputWriter = new StreamWriter(targetFileStream) { AutoFlush = true };
    }

    protected override void OnTargetFileStreamDisposing()
    {
        _outputWriter?.Dispose();
        _outputWriter = null;
    }

    protected override async Task WriteToFile(Envelope? envelope, CancellationToken cancellationToken)
    {
        if (_outputWriter == null)
            return;

        if (envelope?.Pickle != null)
        {
            _picklesById[envelope.Pickle.Id] = envelope.Pickle;
        }
        if (envelope?.TestCase != null)
        {
            _testCasesById[envelope.TestCase.Id] = envelope.TestCase;
        }
        if (envelope?.TestCaseStarted != null)
        {
            _testCaseStartsById[envelope.TestCaseStarted.Id] = envelope.TestCaseStarted;
            _testCaseStatusesByStartId[envelope.TestCaseStarted.Id] = TestStepResultStatus.UNKNOWN;
        }
        if (envelope?.TestStepFinished != null)
        {
            TestStepResultStatus AggregateStatus(TestStepResultStatus previous, TestStepResultStatus next)
            {
                if (previous == TestStepResultStatus.UNKNOWN)
                    return next;
                if (next != TestStepResultStatus.UNKNOWN && next != TestStepResultStatus.SKIPPED)
                    return next;
                return (TestStepResultStatus)Math.Max((int)previous, (int)next);
            }

            _testCaseStatusesByStartId[envelope.TestStepFinished.TestCaseStartedId] = 
                AggregateStatus(_testCaseStatusesByStartId[envelope.TestStepFinished.TestCaseStartedId], envelope.TestStepFinished.TestStepResult.Status);
        }
        if (envelope?.TestCaseFinished != null)
        {
            if (_testCaseStartsById.TryGetValue(envelope.TestCaseFinished.TestCaseStartedId, out var testCaseStarted) &&
                _testCasesById.TryGetValue(testCaseStarted.TestCaseId, out var testCase) &&
                _picklesById.TryGetValue(testCase.PickleId, out var pickle))
            {
                var output = new StringBuilder($"TEST: {pickle.Name}, RESULT: {_testCaseStatusesByStartId[envelope.TestCaseFinished.TestCaseStartedId]}");
                await _outputWriter.WriteLineAsync(output, cancellationToken);
            }
        }
    }
}
