# Usage:
# 
# For single measurement:
# 
# .\Measure-CommandPerformance.ps1 -Commands @("dotnet test --no-build")
# 
# For standard build / test measurements:
# 
# $commandSetsBase = @(
#     @{ Command = "dotnet build"; Preparation = "dotnet clean" },
#     @{ Command = "dotnet build" },
#     @{ Command = "dotnet test --no-build" }
# )
# .\Measure-CommandPerformance.ps1 -CommandSets $commandSetsBase
# 
# For Cucumber Messages measurements
# 
# $commandSetsCM = @(
#     @{ Command = "dotnet build"; Preparation = "dotnet clean" },
#     @{ Command = "dotnet build" },
#     @{ Command = "dotnet test --no-build"; Preparation = '$env:REQNROLL_FORMATTERS_DISABLED = "true"' },
#     @{ Command = "dotnet test --no-build"; Preparation = '$env:REQNROLL_FORMATTERS_DISABLED = "false"' }
# )
# .\Measure-CommandPerformance.ps1 -CommandSets $commandSetsCM
param(
    [Parameter(Mandatory = $false)]
    [string[]]$Commands,
    [Parameter(Mandatory = $false)]
    [hashtable[]]$CommandSets
)

function Measure-Command {
    param(
        [string]$Command,
        [string]$PreparationCommand = $null
    )

    Write-Host "Warming up: $Command"
    # Warmup run (not measured)
    if ($PreparationCommand) {
        Invoke-Expression $PreparationCommand | Out-Null
    }
    Invoke-Expression $Command | Out-Null

    $measurements = @()

    for ($i = 1; $i -le 3; $i++) {
        if ($PreparationCommand) {
            Write-Host "  Preparation ($i/3): $PreparationCommand"
            Invoke-Expression $PreparationCommand | Out-Null
        }
        Write-Host "Measuring ($i/3): $Command"
        $sw = [System.Diagnostics.Stopwatch]::StartNew()
        Invoke-Expression $Command | Out-Null
        $sw.Stop()
        $elapsed = $sw.Elapsed.TotalSeconds
        $measurements += $elapsed
        Write-Host ("  Run ${i}: {0:N3} seconds" -f $elapsed)
    }

    $avg = ($measurements | Measure-Object -Average).Average
    $min = ($measurements | Measure-Object -Minimum).Minimum
    $max = ($measurements | Measure-Object -Maximum).Maximum

    Write-Host ("Summary for '$Command':")
    Write-Host ("  Average: {0:N3} s" -f $avg)
    Write-Host ("  Min:     {0:N3} s" -f $min)
    Write-Host ("  Max:     {0:N3} s" -f $max)
    Write-Host ""
}

# Backwards compatibility: If CommandSets is not given, fall back to Commands array
if ($CommandSets -and $CommandSets.Count -gt 0) {
    foreach ($cmdset in $CommandSets) {
        $cmd = $cmdset.Command
        $prep = $null
        if ($cmdset.ContainsKey("Preparation")) {
            $prep = $cmdset.Preparation
        }
        Measure-Command -Command $cmd -PreparationCommand $prep
    }
} else {
    foreach ($cmd in $Commands) {
        Measure-Command -Command $cmd
    }
}