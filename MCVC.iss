[Setup]
; Ogólne ustawienia instalatora
AppName=MirthConnectVersionControl
AppVersion=2.0
DefaultDirName={pf}\MCVC
DefaultGroupName=MCVC
OutputDir=.
OutputBaseFilename=MirthConnectVersionControl_Setup
Compression=lzma
SolidCompression=yes
SetupIconFile=MirthConnectVersionControl\Resources\MCVCicon.ico
WizardImageFile=MirthConnectVersionControl\Resources\MCVClogo.bmp
WizardSmallImageFile=MirthConnectVersionControl\Resources\MCVClogo.bmp

[Files]
; Dodaj wszystkie pliki z katalogu publikacji
Source: "MirthConnectVersionControl\bin\Release\net8.0-windows\publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
; Skrót na pulpicie
Name: "{autoprograms}\MCVC"; Filename: "{app}\MirthConnectVersionControl.exe"; IconFilename: "{app}\MirthConnectVersionControl.exe"
Name: "{autodesktop}\MCVC"; Filename: "{app}\MirthConnectVersionControl.exe"; IconFilename: "{app}\MirthConnectVersionControl.exe"

[Messages]
WelcomeLabel1=Welcome to the [name] [version] Setup Wizard
WelcomeLabel2=This wizard will guide you through the installation of [name] [version].
FinishedLabel1=Setup has finished installing [name] [version] on your computer.
FinishedLabel2=You can run [name] [version] by selecting the installed shortcuts.

[Run]
; Uruchom aplikację po instalacji (opcjonalne)
Filename: "{app}\MirthConnectVersionControl.exe"; Description: "{cm:LaunchProgram,MirthConnectVersionControl}"; Flags: nowait postinstall skipifsilent
