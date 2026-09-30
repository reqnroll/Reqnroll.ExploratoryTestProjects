# ReqnrollSampleCorpus

Synthetic corpus: 60 independent Reqnroll test projects + one slnx solution, generated with
`Reqnroll.SampleProjectGenerator` (from `Reqnroll.IdeSupport` repo, `tests/Reqnroll.SampleProjectGenerator`).

Used as a large-solution test corpus for Reqnroll IDE support / LSP work (project detection,
connector binding discovery, feature parsing) — a single solution with 60+ projects, the
majority being Reqnroll projects (100% actually: every project is a Reqnroll test project).

## Layout

- `ReqnrollSampleCorpus.slnx` — solution containing all 60 projects (folder `/SampleProjects/`)
- `manifest.json` — per-project generation options (provider, TFM, feature/scenario counts)
- `SampleProject00` … `SampleProject59` — one generated project each

Each project: `AutomationStub.cs`, `Features/*.feature`, `StepDefinitions/*.cs`,
`reqnroll.json`, `<Name>.csproj`. Assembly name = project name (`SampleProjectNN.dll`);
`RootNamespace` pinned to `DeveroomSample` so the generated code-behind matches the
step-definition namespaces the generator emits.

## Matrix (deterministic)

| Dimension | Distribution |
|---|---|
| Test framework | 36× NUnit, 14× xUnit, 10× MSTest |
| Target framework | 40× net8.0, 10× net9.0, 10× net10.0 |
| Feature files / scenarios | cycle of 8 sizes: 2×3 … 10×12 (default 3×5 / 15 scenarios) |
| Step definition coverage | 50% … 100% of steps defined (70% default) |
| Scenario outlines | 0% … 100% of scenarios (30% default) |
| Reqnroll version | 3.3.4 (all projects) |

260 feature files total. Reproducible: index → (provider, TFM, size) is a pure function of
`i` (`provider_for`/`tfm_for`/`SIZES[i % 8]` in `gen_corpus.py`).

## Generation

```bash
# per project:
Reqnroll.SampleProjectGenerator.exe --targetFolder <abs> --force --sfVer 3.3.4 \
  --unitTestProvider NUnit --targetFramework net8.0 --featureFileCount 3 \
  --scenarioPerFeatureFileCount 5 --stepDefPerClassCount 6 \
  --stepDefPerStepPercent 70 --scenarioOutlinePerScenarioPercent 30
```

Post-processed after generation: nested `.git` repos removed, `DeveroomSample.csproj`
renamed to the per-project name, `<AssemblyName>`/`<RootNamespace>` pinned.

## Verification

`dotnet build ReqnrollSampleCorpus.slnx` — exit 0, 0 errors, 60/60 projects produced
`SampleProjectNN.dll` (log: `build.log`). Reqnroll build-time generation confirmed via
`obj/<tfm>/Features/*.feature.ndjson` artifacts.

The generator's template pinned `Microsoft.NET.Test.Sdk 15.9.0` (ancient); it broke test
runs — `xunit.runner.visualstudio 4.0.0` needs `IFrameworkHandle2` (Test.Sdk ≥17) and
threw `TypeLoadException` in the VS Test Explorer for the xUnit projects. All 60 projects
now use **Microsoft.NET.Test.Sdk 17.11.1** (same as Reqnroll.IdeSupport itself); that also
cleared the `NU1903` (Newtonsoft.Json 9.0.1) restore warnings, which were transitive via
the old Test.Sdk. Verified with `dotnet test` on all provider/TFM combinations.

**Full-solution test run: 4,478/4,478 tests pass across all 60 projects** (exit 0,
`testall2.log`). Gotcha from the first run: two projects kept stale
`Microsoft.TestPlatform.*` binaries (dated 2018, from the pre-bump build) in `bin/` because
MSBuild's incremental build skipped re-copying them after the package-version change —
testhost then died with a `TypeLoadException` on `IDeploymentAwareTestRequestHandler`.
After `dotnet clean`-style rebuild (delete `bin`/`obj`), 60/60 run clean.

Note: modern Reqnroll (3.x) does not emit `.feature.cs` code-behind — generation happens at
build time into `obj/` as `.feature.ndjson`.
