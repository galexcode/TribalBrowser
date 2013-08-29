; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Tribal Browser"
#define MyAppVersion "1.0"
#define MyAppPublisher "Frugal Disruptive"
#define MyAppURL "http://www.frugaldisruptive.com"
#define MyAppExeName "TribalBrowser.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{4E87CBB2-3764-4C54-A563-27CBA41AF07A}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputBaseFilename=setup
SetupIconFile=C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalImages\cat_logo.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\TribalBrowser.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\MongoDB.Bson.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\MongoDB.Bson.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\MongoDB.Bson.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\MongoDB.Driver.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\MongoDB.Driver.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\MongoDB.Driver.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\TribalAdmin.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\TribalAdmin.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\TribalBrowser.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\TribalBrowser.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\TribalHelper.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\TribalHelper.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\TribalLogin.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\TribalLogin.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\TribalMessageBox.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\TribalMessageBox.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\darren\Code\GitHub\FDBrowser\TribalBrowser\TribalBuildOutput\UserInfo.ini"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

