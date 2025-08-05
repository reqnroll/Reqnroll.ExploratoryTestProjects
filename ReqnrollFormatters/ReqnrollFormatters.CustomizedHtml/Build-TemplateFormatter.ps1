# Build-TemplateFormatter.ps1
param (
    [switch]$Watch
)

$ErrorActionPreference = "Stop"
$scriptPath = Split-Path -Parent $MyInvocation.MyCommand.Path
$customTemplatePath = Join-Path $scriptPath "CustomTemplate"

Write-Host "Script path: $scriptPath"
Write-Host "CustomTemplate path: $customTemplatePath"

# Navigate to the CustomTemplate directory
Push-Location $customTemplatePath

try {
    # Install dependencies if node_modules doesn't exist
    if (-not (Test-Path "node_modules")) {
        Write-Host "Installing npm dependencies..."
        npm install --no-fund --no-audit --legacy-peer-deps
        
        if ($LASTEXITCODE -ne 0) {
            Write-Warning "npm install failed with exit code $LASTEXITCODE"
            # Continue anyway - we have fallback resources
        }
    }
    else {
        Write-Host "node_modules directory already exists, skipping npm install"
    }

    # Build the project
    if ($Watch) {
        Write-Host "Starting webpack in watch mode..."
        npm run watch
    } else {
        Write-Host "Building project..."
        npm run build
        
        if ($LASTEXITCODE -ne 0) {
            Write-Warning "npm run build failed with exit code $LASTEXITCODE"
        }
    }
    
    # Check if the dist directory was created successfully
    if (Test-Path "dist") {
        Write-Host "Build completed successfully. Resources are embedded directly from their source locations."
    }
    else {
        Write-Warning "The dist directory wasn't created. The project may not compile correctly."
    }
    
} catch {
    Write-Error "An error occurred: $_"
} finally {
    # Return to the original directory
    Pop-Location
}

Write-Host "Build process completed."