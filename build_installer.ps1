# Check if ISCC (Inno Setup) is in PATH
$iscc = Get-Command "iscc" -ErrorAction SilentlyContinue

if (-not $iscc) {
    # Try common default path
    $defaultPath = "C:\Program Files (x86)\Inno Setup 6\ISCC.exe"
    if (Test-Path $defaultPath) {
        $iscc = $defaultPath
    } else {
        Write-Error "Inno Setup Compiler (ISCC.exe) not found. Please install Inno Setup or add it to PATH."
        exit 1
    }
}

Write-Host "Building .NET Project..." -ForegroundColor Cyan
dotnet publish MirthConnectVersionControl\MirthConnectVersionControl.csproj -c Release -r win-x64 --self-contained false -o MirthConnectVersionControl\bin\Release\net8.0-windows\publish

if ($LASTEXITCODE -ne 0) {
    Write-Error "Build failed."
    exit 1
}

Write-Host "Creating Installer..." -ForegroundColor Cyan
& $iscc MCVC.iss

if ($LASTEXITCODE -eq 0) {
    Write-Host "Installer created successfully!" -ForegroundColor Green
} else {
    Write-Error "Installer creation failed."
}
