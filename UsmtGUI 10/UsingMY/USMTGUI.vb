Option Explicit On

Imports System
Imports System.IO
Imports System.DirectoryServices
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Text

Public Class USMTGUI
    ' ***************** General Section ******************

    Public WsShell
    '   Public fso As New FileSystemObject
    Public objNetwork As Object
    Public objShell, objExec
    Public objWMIService As Object

    Public sDName As String                     ' Domain Name
    Public sOldComputerName As String           ' Old Computer Name
    Public sNewComputerName As String           ' New Computer Name
    Public sComputerName As String              ' Computer Name
    Public sOldUserName As String               ' Old User for MU in loadstate
    Public sNewUserName As String               ' New User for MU in loadstate
    Public sOldIPAddress As String              ' Old Computer IP Address
    Public sNewIPAddress As String              ' New Computer IP Address
    Public sOldDomainName As String             ' Old Domain Name
    Public sNewDomainName As String             ' New Domain Name
    Public sMoveDomain As String                ' New and old Domain String
    Public sMoveUser As String                  ' String for Move User
    Public sLae As String                       ' String for Local User Acct Enable
    Public sLac As String                       ' String for Local User acct Create

    Public sLogStore As String                  ' Usmt Network Log Folder 
    Public sUsmtDrive As String                 ' Usmt Network Folder Drive U:\
    Public sUsmtCpu As String                   ' Usmt CPU Folder Path
    Public sUsmtFolder As String                ' Usmt UNC Folder
    Public sExeSelectedFolder As String         ' Usmt Network Folder for for selected Verison of Exe


    Public sUsmtLogBase As String               ' Usmt Network Log Folder
    Public sLoadLogFolder As String             ' Usmt Network Logs\LoadLogs Folder
    Public sScanLogFolder As String             ' Usmt Network Logs\ScanLogs Folder
    Public sPstLogFolder As String              ' Usmt Network Logs\PstLogs Folder
    Public sLoadLogDateFolder As String         ' Usmt Network Logs\LoadLogs\ Date Folder
    Public sScanLogDateFolder As String         ' Usmt Network Logs\ScanLogs\ Date Folder
    Public sPstLogDateFolder As String          ' Usmt Network Logs\PstLogs\ Date Folder
    Public sLoadLogDateComputerFolder As String ' Usmt Network Logs\LoadLogs\ Date Folder
    Public sScanLogDateComputerFolder As String ' Usmt Network Logs\ScanLogs\ Date Folder
    Public sPstLogDateComputerFolder As String  ' Usmt Network Logs\PstLogs\ Date Folder


    Public sDataStoreDrive As String            ' Drive letter for Data Store
    Public sDataStore As String                 ' Usmt Data Store 
    Public sDataStoreFolder                     ' Data Store Folder UNC & Local Drive
    Public sStoreDateFolder As String           ' Usmt Store\Date Folder
    Public sStoreDateComputerFolder As String   ' Usmt  Store\Date Computer Folder

    Public sCmd As String                       ' Complete Command Line to pass to Load/ScanState
    Public sCmd2 As String                      ' cmd line for baretail

    Public slogPath As String                   ' Complete Path for Log Folder
    Public sProgressPath As String              ' Complete Path for Progress Folder
    Public sStorePath As String                 ' Complete StorePath String
    Public sUsmtPath As String                  ' Complete Path To Usmt Load/ScanState cmd.
    Public sUNCUsmtPath As String               ' UNC Path \\<server>\usmt10$

    Public sUNCServerFolder As String           ' UNC Server Folder
    Public sUNCShareFolder As String            ' UNC Share Folder

    Public sBareTailProgressLogPath As String   ' Scan Log Path for Baretail
    Public sBareTailScanLogPath As String       ' Progress Log Path for Baretail
    Public sBareTailCmd As String               ' Path to Baretail Exe

    Public sCustXmlFilesFolder As String        ' Custom XML Files Folder
    Public sXMLOption As String                 ' Complete XML Option String
    Public sMonitorOption As String             ' Complete Monitor Option String

    Public sUsers As String                     ' User for Command Line
    Public sLoggedInUser As String              ' Logged in User
    Public sSelection As String                 ' User selection for Command Line
    Public MigDate As String                    ' Date for cmd line
    Public MigTime As String                    ' Time for cmd line

    Public sExcludeAccts As String              ' User accounts to Exclude
    Public sIncludeAccts As String              ' User accounts to Include

    Public sMigAppXML As String
    Public sMigUserXML As String
    Public sMigDocsXML As String
    Public sCustAppXML As String
    Public sCustUserXML As String
    Public sNetworkPrinterXML As String
    Public sCust1XML As String
    Public sCust2XML As String
    Public sCust3XML As String
    Public sExcludeDrivesXML As String
    Public sExcludeSystemFolders As String
    Public sConfigSXML As String
    Public sConfigLXML As String
    Public sGenConfig As String
    Public sCmdGenConfig As String              ' Command to generate config.xml'

    Dim IPAddress As String
    Dim Result As Boolean
    Dim swResult As Boolean

    Dim MyDate As DateTime = DateTime.Now       ' Generates Date Value
    Dim sMyDate As String = MyDate.ToString("MM.dd.yyyy")  ' Date used for File names
    Dim sMyTime As String                       ' Time used for File names


    Public Sub DefineFolders()

        ' Determine Drive Letter
        Me.sComputerName = My.Computer.Name

        ' Determine Local or Network DataStore
        If Me.ChkBxLocalDataDrive.Checked = True Then
            Me.sDataStoreDrive = Me.CmboBoxLocalDataDriveLetter.Text & ":\"
            Me.sDataStore = Me.sDataStoreDrive & Me.sDataStoreFolder & " "
            Me.sStoreDateFolder = Me.sDataStore & "\" & Me.sMyDate
            Me.sStoreDateComputerFolder = Me.sStoreDateFolder & "\" & Me.sComputerName
        End If

        If Me.CheckBoxNetworkDataDrive.Checked = True Then
            If Me.CheckBoxConnected.Checked = True Then
                Me.sDataStoreDrive = "\\" & Me.sNewComputerName & "$" & "\"
                Me.sDataStore = Me.sDataStoreDrive & Me.sDataStoreFolder & " "
            Else
                Me.sDataStoreDrive = Me.sUNCServerFolder & Me.sUNCShareFolder & "$" & "\"
                Me.sDataStore = Me.sDataStoreDrive & Me.sDataStoreFolder & " "
            End If
        End If

        ' Determine Local or Network USMT Log Store
        If Me.CheckBoxLocalLogDataDrive.Checked = True Then
            Me.sUsmtDrive = Me.CmboBoxUsmtDriveLetter.Text & ":\"
            Me.sUsmtCpu = Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder
            Me.sLogStore = Me.sUsmtDrive
        End If

        If Me.CheckBoxNetworkLogDataDrive.Checked = True Then
            Me.sUsmtDrive = Me.sUNCServerFolder & Me.sUNCShareFolder & "$"
            Me.sLogStore = Me.sUsmtDrive & "\"
            Me.sUsmtCpu = Me.sUsmtDrive & "\" & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder
        End If

        ' Define Log Folders
        Me.sUsmtLogBase = Me.sUsmtDrive & "Logs"
        Me.sScanLogFolder = Me.sUsmtLogBase & "\Scan_Logs"
        Me.sLoadLogFolder = Me.sUsmtLogBase & "\Load_Logs"
        Me.sPstLogFolder = Me.sUsmtLogBase & "\Pst_Logs"
        Me.sScanLogDateFolder = Me.sScanLogFolder & "\" & Me.sMyDate
        Me.sLoadLogDateFolder = Me.sLoadLogFolder & "\" & Me.sMyDate
        Me.sPstLogDateFolder = Me.sPstLogFolder & "\" & Me.sMyDate

        ' Define Log Date Folders
        Me.sScanLogDateComputerFolder = Me.sScanLogDateFolder & "\" & Me.sComputerName
        Me.sLoadLogDateComputerFolder = Me.sLoadLogDateFolder & "\" & Me.sComputerName
        Me.sPstLogDateComputerFolder = Me.sPstLogDateFolder & "\" & Me.sComputerName
    End Sub

    Public Sub BuildUsmtBaseFolders()

        Dim sDrive As String

        If (My.Computer.FileSystem.DirectoryExists(sUsmtDrive)) = True Then

            '     Create Usmt 10.0 X86 Exe Folder
            sDrive = Me.sUsmtDrive & My.Settings.USMTFolder & "\" & My.Settings.Usmt5Exex86Folder
            If (My.Computer.FileSystem.DirectoryExists(sDrive)) = False Then
                My.Computer.FileSystem.CreateDirectory(sDrive)

                MsgBox("Create Directory " & vbCrLf & sDrive)
            End If

            '     Create Usmt 10.0 AMD64  Exe Folder
            sDrive = Me.sUsmtDrive & My.Settings.USMTFolder & "\" & My.Settings.Usmt5ExeAmd64Folder
            If (My.Computer.FileSystem.DirectoryExists(sDrive)) = False Then
                My.Computer.FileSystem.CreateDirectory(sDrive)

                MsgBox("Create Directory " & vbCrLf & sDrive)
            End If

        Else
            MsgBox("USMT Share Using Drive Selected - not Valid  " & vbCrLf & sUsmtDrive)
        End If

    End Sub


    Public Sub BuildLogBaseFolders()

        If (My.Computer.FileSystem.DirectoryExists(sUsmtDrive)) = True Then

            '     Create Usmt Log Folder
            If (My.Computer.FileSystem.DirectoryExists(sUsmtLogBase)) = False Then
                My.Computer.FileSystem.CreateDirectory(sUsmtLogBase)

                MsgBox("Create Directory " & vbCrLf & sUsmtLogBase)
            End If

            '     Create Usmt Scan Log  Folder
            If (My.Computer.FileSystem.DirectoryExists(sScanLogFolder)) = False Then
                My.Computer.FileSystem.CreateDirectory(sScanLogFolder)

                MsgBox("Create Directory " & vbCrLf & sScanLogFolder)
            End If

            '     Create Usmt Load Log Folder
            If (My.Computer.FileSystem.DirectoryExists(sLoadLogFolder)) = False Then
                My.Computer.FileSystem.CreateDirectory(sLoadLogFolder)

                MsgBox("Create Directory " & vbCrLf & sLoadLogFolder)
            End If

            '     Create Usmt Pst Log Folder
            If (My.Computer.FileSystem.DirectoryExists(sPstLogFolder)) = False Then
                My.Computer.FileSystem.CreateDirectory(sPstLogFolder)

                MsgBox("Create Directory " & vbCrLf & sPstLogFolder)
            End If

        Else
            MsgBox("USMT Share Using Drive Selected - not Valid  " & vbCrLf & sUsmtDrive)

        End If

    End Sub

    Public Sub BuildDataStoreFolders()

        If (My.Computer.FileSystem.DirectoryExists(sDataStoreDrive)) = True Then

            '     Create Data Store Folder
            If (My.Computer.FileSystem.DirectoryExists(sDataStore)) = False Then
                My.Computer.FileSystem.CreateDirectory(sDataStore)

                MsgBox("Create Directory " & vbCrLf & sDataStore)
            End If

        Else
            MsgBox("USMT Share Using Drive Selected - not Valid  " & vbCrLf & sUsmtDrive)

        End If

    End Sub


    Public Sub BuildCurrentFolders()

        If (My.Computer.FileSystem.DirectoryExists(sUsmtDrive)) = True Then

            '     Create Usmt Store Date Folder
            If (My.Computer.FileSystem.DirectoryExists(sStoreDateFolder)) = False Then
                My.Computer.FileSystem.CreateDirectory(sStoreDateFolder)

                MsgBox("Create Directory " & vbCrLf & sStoreDateFolder)
            End If

            '     Create Usmt ScanLog Date Folder
            If (My.Computer.FileSystem.DirectoryExists(sScanLogDateFolder)) = False Then
                My.Computer.FileSystem.CreateDirectory(sScanLogDateFolder)

                MsgBox("Create Directory " & vbCrLf & sScanLogDateFolder)
            End If

            '     Create Usmt Load Log Date Folder
            If (My.Computer.FileSystem.DirectoryExists(sLoadLogDateFolder)) = False Then
                My.Computer.FileSystem.CreateDirectory(sLoadLogDateFolder)

                MsgBox("Create Directory " & vbCrLf & sLoadLogDateFolder)
            End If

            '     Create Pst Log Date Folder
            If (My.Computer.FileSystem.DirectoryExists(sPstLogDateFolder)) = False Then
                My.Computer.FileSystem.CreateDirectory(sPstLogDateFolder)

                MsgBox("Create Directory " & vbCrLf & sPstLogDateFolder)
            End If

            '     Create Store Date Computer Folder
            If (My.Computer.FileSystem.DirectoryExists(sStoreDateComputerFolder)) = False Then
                My.Computer.FileSystem.CreateDirectory(sStoreDateComputerFolder)

                MsgBox("Create Directory " & vbCrLf & sStoreDateComputerFolder)
            End If

            '     Create Scan Log Date Computer Folder
            If (My.Computer.FileSystem.DirectoryExists(sScanLogDateComputerFolder)) = False Then
                My.Computer.FileSystem.CreateDirectory(sScanLogDateComputerFolder)

                MsgBox("Create Directory " & vbCrLf & sScanLogDateComputerFolder)
            End If

            '     Create Pst Log Date Computer Folder
            If (My.Computer.FileSystem.DirectoryExists(sPstLogDateComputerFolder)) = False Then
                My.Computer.FileSystem.CreateDirectory(sPstLogDateComputerFolder)

                MsgBox("Create Directory " & vbCrLf & sPstLogDateComputerFolder)
            End If

        Else
            MsgBox("USMT Share Using Drive Selected - not Valid " & vbCrLf & Me.sUsmtDrive)

        End If

    End Sub

    Public Sub GetPstFiles()
        'Demonstrates how to get a list of files (example uses Windows folder)
        Dim file As String
        Me.ListBoxPstFiles.Items.Clear()
        '      Dim files() As String = Directory.GetFiles("C:\")
        '  If Not ((Dir.Attributes And IO.FileAttributes.System) = IO.FileAttributes.System) Then

        Dim files() As String = Directory.GetFiles("C:\", "*.pst", SearchOption.AllDirectories)
        For Each file In files
            Me.ListBoxPstFiles.Items.Add(file)
        Next
    End Sub


    Private Sub BuildXMLOption()
        Me.sXMLOption = ""

        If Me.ChkBxMigApp.CheckState = CheckState.Checked Then
            If Me.ChkBxLocalDataDrive.Checked = True Then
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigAppXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigAppXML & " "
                End If
            Else
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigAppXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigAppXML & " "
                End If
            End If
        End If

        If Me.CheckBoxMigUser.Checked = True Then
            If Me.ChkBxLocalDataDrive.Checked = True Then
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigUserXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigUserXML & " "
                End If
            Else
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigUserXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigUserXML & " "
                End If
            End If
        End If

        If Me.CheckBoxMigDocs.Checked = True Then
            If Me.ChkBxLocalDataDrive.Checked = True Then
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigDocsXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigDocsXML & " "
                End If
            Else
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigDocsXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigDocsXML & " "
                End If
            End If
        End If


        If Me.ChkbxCustApps.Checked = True Then
            If Me.ChkBxLocalDataDrive.Checked = True Then
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCustAppXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCustAppXML & " "
                End If
            Else
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCustAppXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCustAppXML & " "
                End If
            End If
        End If

        If Me.ChkBxCustUsers.CheckState = CheckState.Checked Then
            If Me.ChkBxLocalDataDrive.Checked = True Then
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCustUserXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCustUserXML & " "
                End If
            Else
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCustUserXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCustUserXML & " "
                End If
            End If
        End If


        If Me.ChkBxNetworkPrn.CheckState = CheckState.Checked Then
            If Me.ChkBxLocalDataDrive.Checked = True Then
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sNetworkPrinterXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sNetworkPrinterXML & " "
                End If
            Else
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sNetworkPrinterXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sNetworkPrinterXML & " "
                End If
            End If
        End If

        If Me.CheckBoxExcludeDrives.CheckState = CheckState.Checked Then
            If Me.ChkBxLocalDataDrive.Checked = True Then
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sExcludeDrivesXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sExcludeDrivesXML & " "
                End If
            Else
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sExcludeDrivesXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sExcludeDrivesXML & " "
                End If
            End If
        End If


        If Me.CheckBoxExcludeSysFolders.CheckState = CheckState.Checked Then
            If Me.ChkBxLocalDataDrive.Checked = True Then
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sExcludeSystemFolders)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sExcludeSystemFolders & " "
                End If
            Else
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sExcludeSystemFolders)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sExcludeSystemFolders & " "
                End If
            End If
        End If


        If Me.CheckBoxCust1XML.CheckState = CheckState.Checked Then
            If Me.ChkBxLocalDataDrive.Checked = True Then
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCust1XML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCust1XML & " "
                End If
            Else
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCust1XML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCust1XML & " "
                End If
            End If
        End If


        If Me.CheckBoxCust2XML.CheckState = CheckState.Checked Then
            If Me.ChkBxLocalDataDrive.Checked = True Then
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCust2XML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCust2XML & " "
                End If
            Else
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCust2XML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCust2XML & " "
                End If
            End If
        End If


        If Me.CheckBoxCust3XML.CheckState = CheckState.Checked Then
            If Me.ChkBxLocalDataDrive.Checked = True Then
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCust3XML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCust3XML & " "
                End If
            Else
                If (My.Computer.FileSystem.FileExists(sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCust3XML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sCust3XML & " "
                End If
            End If
        End If


        If Me.RdBtnBackup.Checked = True Then
            If Me.ChkbxConfig.CheckState = CheckState.Checked Then
                If Me.ChkBxLocalDataDrive.Checked = True Then
                    If (My.Computer.FileSystem.FileExists(sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sConfigSXML)) = True Then
                        Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sConfigSXML & " "
                    End If
                Else
                    If (My.Computer.FileSystem.FileExists(sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sConfigSXML)) = True Then
                        Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sConfigSXML & " "
                    End If
                End If
            End If
        End If


        If Me.RdBtnRestore.Checked = True Then
            If Me.ChkbxConfig.CheckState = CheckState.Checked Then
                If Me.ChkBxLocalDataDrive.Checked = True Then
                    If (My.Computer.FileSystem.FileExists(sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sConfigLXML)) = True Then
                        Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sConfigLXML & " "
                    End If
                Else
                    If (My.Computer.FileSystem.FileExists(sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sConfigLXML)) = True Then
                        Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sConfigLXML & " "
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub BuildMonitorOption()

        ' Monitoring Log Options

        Me.sMonitorOption = ""

        If Me.ChkBxContinue.CheckState = CheckState.Checked Then
            Me.sMonitorOption = Me.sMonitorOption & " " & "/c"
            If Me.ChkBxRetry.CheckState = CheckState.Checked Then
                Me.sMonitorOption = Me.sMonitorOption & " " & "/r:" & Me.CmboBxRetrys.Text
            End If

            If Me.ChkBxWait.CheckState = CheckState.Checked Then
                Me.sMonitorOption = Me.sMonitorOption & " " & "/w:" & Me.CmboBxWait.Text
            End If
        End If

        If Me.ChkBxNoCompress.CheckState = CheckState.Checked Then
            Me.sMonitorOption = Me.sMonitorOption & " " & "/nocompress"
        End If

        If Me.RdBtnBackup.Checked = True Then

            If Me.ChkBxOverwrite.CheckState = CheckState.Checked Then
                Me.sMonitorOption = Me.sMonitorOption & " " & "/o"
            End If

            If Me.ChkBxVsc.CheckState = CheckState.Checked Then
                Me.sMonitorOption = Me.sMonitorOption & " " & "/vsc"
            End If

            If Me.ChkbxTargetWin7.CheckState = CheckState.Checked Then
                Me.sMonitorOption = Me.sMonitorOption & " " & "/targetwindows7"
            End If

            If Me.ChkbxTargetWin8.CheckState = CheckState.Checked Then
                Me.sMonitorOption = Me.sMonitorOption & " " & "/targetwindows8"
            End If

            If Me.ChkBxLocalOnly.CheckState = CheckState.Checked Then
                Me.sMonitorOption = Me.sMonitorOption & " " & "/localonly"
            End If

            If Me.ChkBxEFS.CheckState = CheckState.Checked Then
                Me.sMonitorOption = Me.sMonitorOption & " "
                If Me.RdoBtnEFSAbort.Checked = True Then
                    Me.sMonitorOption = Me.sMonitorOption & " " & "/efs:abort"
                End If
                If Me.RdoBtnEFSSkip.Checked = True Then
                    Me.sMonitorOption = Me.sMonitorOption & " " & "/efs:skip"
                End If
                If Me.RdoBtnEFSCopyRaw.Checked = True Then
                    Me.sMonitorOption = Me.sMonitorOption & " " & "/efs:copyraw"
                End If
                If Me.RdoBtnEFSDecrypt.Checked = True Then
                    Me.sMonitorOption = Me.sMonitorOption & " " & "/efs:decryptcopy"
                End If
            End If
        End If

        If Me.ChkBxVerbosity.CheckState = CheckState.Checked Then
            Me.sMonitorOption = Me.sMonitorOption & " " & "/v:" & Me.CmboBxVerbosityLevel.Text & " "
        End If

        If Me.ChkBxListFiles.CheckState = CheckState.Checked Then
            Me.sMonitorOption = Me.sMonitorOption & " " & "/Listfiles:" & Me.sScanLogDateComputerFolder & "\Listfiles.txt" & " "
        End If

        If Me.ChkBxSpaceEst.CheckState = CheckState.Checked Then
            Me.sMonitorOption = Me.sMonitorOption & " " & "/p:" & Me.sScanLogDateComputerFolder & "\SpaceEst.xml" & " "
        End If

    End Sub

    Public Sub BuildMoveDomain()

        Me.sMoveDomain = ""

        ' Get Domain Name
        Me.sOldDomainName = Me.TextBoxOldDomain.Text
        Me.sNewDomainName = Me.TextBoxNewDomain.Text

        If Me.CheckBoxMoveDomain.Checked = True Then
            Me.sMoveDomain = "/md:" & Me.sOldDomainName & ":" & Me.sNewDomainName & " "
        End If

    End Sub


    Public Sub BuildMoveUser()
        ' loadstate \fs1\migr\userdata /mu:/ui:corp\user:/ui:corp2\user /i:miguser.xml /i:migapp.xml - not sure if this is now correct
        ' "/mu: OldDomain\OldUserName:NewDomain\NewUserName" - latest example

        If Me.CheckBoxMoveUser.Checked = True Then
            Me.sMoveUser = " " & "/mu:" & Me.sOldDomainName & "\" & Me.sOldUserName & ":" & Me.sNewDomainName & "\" & Me.sNewUserName
        End If

    End Sub


    Private Sub BuildLae()

        If Me.CheckBoxLae.Checked = True Then
            Me.sLae = " " & "/lae" & " "
        End If

    End Sub


    Private Sub BuildLac()

        If Me.CheckBoxLac.Checked = True Then
            Me.sLac = " " & "/lac:" & Me.TextBoxLacPassword.Text
        End If

    End Sub


    Public Sub BuildTime()

        Dim MyTime As DateTime = DateTime.Now       ' Generates Time Value
        Me.sMyTime = MyTime.ToString("HH.mm")

    End Sub

    Private Sub BuildLogPath()
        slogPath = ""
        sBareTailScanLogPath = ""
        If Me.RdBtnBackup.Checked = True Then
            If Me.ChkbxNetworkLog.CheckState = CheckState.Checked Then
                If Me.ChkBxLocalDataDrive.Checked = True Then
                    Me.slogPath = "" & Me.slogPath & "" & "/l:" & Me.sUsmtDrive & "Logs\Scan_Logs\" & Me.sMyDate & "\" & Me.lblComputerName2.Text & "\" & Me.sMyTime & "_scan.log" & " "
                    Me.sBareTailScanLogPath = "-tc 3 -ti 0" & " " & Me.sUsmtDrive & "Logs\Scan_Logs\" & Me.sMyDate & "\" & Me.lblComputerName2.Text & "\" & Me.sMyTime & "_scan.log" & " "
                Else
                    Me.slogPath = "" & Me.slogPath & "" & "/l:" & Me.sUsmtDrive & "\Logs\Scan_Logs\" & Me.sMyDate & "\" & Me.lblComputerName2.Text & "\" & Me.sMyTime & "_scan.log" & " "
                    Me.sBareTailScanLogPath = "-tc 3 -ti 0" & " " & Me.sUsmtDrive & "\Logs\Scan_Logs\" & Me.sMyDate & "\" & Me.lblComputerName2.Text & "\" & Me.sMyTime & "_scan.log" & " "
                End If
            End If
        End If

        If Me.RdBtnRestore.Checked = True Then
            If Me.ChkbxNetworkLog.CheckState = CheckState.Checked Then
                If Me.ChkBxLocalDataDrive.Checked = True Then
                    Me.slogPath = "" & Me.slogPath & "" & "/l:" & Me.sUsmtDrive & "Logs\Load_Logs\" & Me.sMyDate & "\" & Me.TxtBoxOldComputer.Text & "\" & Me.sMyTime & "_load.log" & " "
                    Me.sBareTailScanLogPath = "-tc 3 -ti 0" & " " & Me.sUsmtDrive & "Logs\Load_Logs\" & Me.sMyDate & "\" & Me.TxtBoxOldComputer.Text & "\" & Me.sMyTime & "_load.log" & " "
                Else
                    Me.slogPath = "" & Me.slogPath & "" & "/l:" & Me.sUsmtDrive & "\Logs\Load_Logs\" & Me.sMyDate & "\" & Me.TxtBoxOldComputer.Text & "\" & Me.sMyTime & "_load.log" & " "
                    Me.sBareTailScanLogPath = "-tc 3 -ti 0" & " " & Me.sUsmtDrive & "\Logs\Load_Logs\" & Me.sMyDate & "\" & Me.TxtBoxOldComputer.Text & "\" & Me.sMyTime & "_load.log" & " "
                End If
            End If
        End If
    End Sub


    Private Sub BuildProgressPath()
        Me.sProgressPath = ""

        Me.sBareTailProgressLogPath = ""

        If Me.RdBtnBackup.Checked = True Then
            If Me.ChkbxProgressLog.CheckState = CheckState.Checked Then
                If Me.ChkBxLocalDataDrive.Checked = True Then
                    Me.sProgressPath = "" & Me.sProgressPath & "" & "/progress:" & Me.sUsmtDrive & "Logs\Scan_Logs\" & Me.sMyDate & "\" & Me.lblComputerName2.Text & "\" & Me.sMyTime & "_Progress.log" & " "
                    Me.sBareTailProgressLogPath = "-tc 3 -ti 2" & " " & Me.sUsmtDrive & "Logs\Scan_Logs\" & Me.sMyDate & "\" & Me.lblComputerName2.Text & "\" & Me.sMyTime & "_Progress.log" & " "
                Else
                    Me.sProgressPath = "" & Me.sProgressPath & "" & "/progress:" & Me.sUsmtDrive & "\Logs\Scan_Logs\" & Me.sMyDate & "\" & Me.lblComputerName2.Text & "\" & Me.sMyTime & "_Progress.log" & " "
                    Me.sBareTailProgressLogPath = "-tc 3 -ti 2" & " " & Me.sUsmtDrive & "\Logs\Scan_Logs\" & Me.sMyDate & "\" & Me.lblComputerName2.Text & "\" & Me.sMyTime & "_Progress.log" & " "
                End If
            End If
        End If
        If Me.RdBtnRestore.Checked = True Then
            If Me.ChkbxProgressLog.CheckState = CheckState.Checked Then
                If Me.ChkBxLocalDataDrive.Checked = True Then
                    Me.sProgressPath = "" & Me.sProgressPath & "" & "/progress:" & Me.sUsmtDrive & "Logs\Load_Logs\" & Me.sMyDate & "\" & Me.TxtBoxOldComputer.Text & "\" & Me.sMyTime & "_Progress.log" & " "
                    Me.sBareTailProgressLogPath = "-tc 3 -ti 2" & " " & Me.sUsmtDrive & "Logs\Load_Logs\" & Me.sMyDate & "\" & Me.TxtBoxOldComputer.Text & "\" & Me.sMyTime & "_Progress.log" & " "
                Else
                    Me.sProgressPath = "" & Me.sProgressPath & "" & "/progress:" & Me.sUsmtDrive & "\Logs\Load_Logs\" & Me.sMyDate & "\" & Me.TxtBoxOldComputer.Text & "\" & Me.sMyTime & "_Progress.log" & " "
                    Me.sBareTailProgressLogPath = "-tc 3 -ti 2" & " " & Me.sUsmtDrive & "\Logs\Load_Logs\" & Me.sMyDate & "\" & Me.TxtBoxOldComputer.Text & "\" & Me.sMyTime & "_Progress.log" & " "
                End If
            End If
        End If
    End Sub


    Private Sub BuildStorePath()

        Me.sStorePath = ""

        If Me.RdBtnBackup.Checked = True Then
            If Me.CheckBoxNetworkDataDrive.Checked = True Then
                Me.sStorePath = Me.sDataStore & " "
                '     MsgBox("UNC Storepath " & vbCrLf & Me.sStorePath)
            End If

            If Me.ChkBxLocalDataDrive.Checked = True Then
                Me.sStorePath = Me.sDataStore & " "
                '      MsgBox("Local Storepath " & vbCrLf & Me.sStorePath)
            End If
        End If

        If Me.RdBtnRestore.Checked = True Then
            Me.sStorePath = Me.sDataStore & "\" & Me.sMyDate & "\" & Me.TxtBoxOldComputer.Text & " "
            '    MsgBox("UNC Storepath " & vbCrLf & Me.sStorePath)
        End If

    End Sub


    Private Sub BuildUsmtPath()
        Me.sUsmtPath = ""

        If Me.RdBtnBackup.Checked = True Then
            Me.sUsmtPath = Me.sUsmtCpu & "\Scanstate.exe" & " "
            Me.sBareTailCmd = Me.sUsmtCpu & "\" & "Baretail.exe"
        End If
        If Me.RdBtnRestore.Checked = True Then
            Me.sUsmtPath = Me.sUsmtCpu & "\Loadstate.exe" & " "
            Me.sBareTailCmd = Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & "\" & "Baretail.exe"
        End If
    End Sub


    Private Sub BuildExcludeAccts()
        Me.sExcludeAccts = ""

        If Me.RdBtnBackup.Checked = True Then
            If Me.RdBtnExcludeAllAccts.Checked = True Then
                Me.sExcludeAccts = "/ue:*\*" & " "
            End If
            If Me.RdBtnExcludeLocalAccts.Checked = True Then
                Me.sExcludeAccts = "/ue:" & Me.sComputerName & "\*" & " "
            End If
            If Me.RdBtnExcludeDomainAccts.Checked = True Then
                Me.sExcludeAccts = "/ue:" & Me.sDName & "\*" & " "
            End If
            If Me.RdBtnBackupDate.Checked = True Then
                Me.sExcludeAccts = "/uel:" & Me.TxtboxBackupDate.Text & " "
            End If
            If Me.RdBtnBackupDays.Checked = True Then
                Me.sExcludeAccts = "/uel:" & Me.txtBoxBackupDays.Text & " "
            End If
        End If

        If Me.RdBtnRestore.Checked = True Then
            If Me.RdBtnExcludeAllAccts.Checked = True Then
                Me.sExcludeAccts = "/ue:*\*" & " "
            End If
            If Me.RdBtnExcludeLocalAccts.Checked = True Then
                Me.sExcludeAccts = "/ue:" & Me.sComputerName & "\*" & " "
            End If
            If Me.RdBtnExcludeDomainAccts.Checked = True Then
                Me.sExcludeAccts = "/ue:" & Me.sDName & "\*" & " "
            End If
            If Me.RdBtnBackupDate.Checked = True Then
                Me.sExcludeAccts = "/uel:" & Me.TxtboxBackupDate.Text & " "
            End If
            If Me.RdBtnBackupDays.Checked = True Then
                Me.sExcludeAccts = "/uel:" & Me.txtBoxBackupDays.Text & " "
            End If
        End If
    End Sub

    Private Sub BuildIncludeAccts()

        Me.sIncludeAccts = ""

        If Me.RdBtnBackup.Checked = True Then
            If Me.RdbtnIncludeAllAccts.Checked = True Then
                Me.sIncludeAccts = "/ui:*\*" & " "
            End If
            If Me.RdBtnIncludeCurrentUser.Checked = True Then
                Me.sIncludeAccts = "/uel:0" & " "
            End If
            If Me.rdbtnIncludeLocalAccts.Checked = True Then
                Me.sIncludeAccts = "/ui:" & Me.sComputerName & "\*" & " "
            End If
            If Me.rdbtnIncludeDomainAccts.Checked = True Then
                Me.sIncludeAccts = "/ui:" & Me.sDName & "\*" & " "
            End If
            If Me.RdBtnIncludeSelectedlocalAccts.Checked = True Then
                Me.sIncludeAccts = "/ui:" & Me.sComputerName & "\" & " "
            End If
            If Me.rdbtnIncludeSelectedDomainAccts.Checked = True Then
                Me.sIncludeAccts = "/ui:" & Me.sDName & "\" & " "
            End If
        End If

        If Me.RdBtnRestore.Checked = True Then
            If Me.RdbtnIncludeAllAccts.Checked = True Then
                Me.sIncludeAccts = "/ui:*\*" & " "
            End If
            If Me.RdBtnIncludeCurrentUser.Checked = True Then
                Me.sIncludeAccts = "/uel:0" & " "
            End If
            If Me.rdbtnIncludeLocalAccts.Checked = True Then
                Me.sIncludeAccts = "/ui:" & Me.sComputerName & "\*" & " "
            End If
            If Me.rdbtnIncludeDomainAccts.Checked = True Then
                Me.sIncludeAccts = "/ui:" & Me.sDName & "\*" & " "
            End If
            If Me.RdBtnIncludeSelectedlocalAccts.Checked = True Then
                Me.sIncludeAccts = "/ui:" & Me.sComputerName & "\" & " "
            End If
            If Me.rdbtnIncludeSelectedDomainAccts.Checked = True Then
                Me.sIncludeAccts = "/ui:" & Me.sDName & "\" & " "
            End If
        End If
    End Sub


    Private Sub BuildUsers()

        ' Get only Checked Items

        Dim UserList As New ArrayList()
        If Me.ChklstbxUsersID.CheckedItems.Count <> 0 Then
            ' If so, loop through all checked items and list results.
            Dim x As Integer

            For x = 0 To Me.ChklstbxUsersID.CheckedItems.Count - 1
                UserList.Add(CStr(Me.ChklstbxUsersID.CheckedItems(x)))
            Next x
        End If
        Dim sParam As String = ""
        Dim sParamBase As String = "/ui:" & Me.sDName & "\"
        Dim i As Integer
        For i = 0 To UserList.Count - 1
            If i = 0 Then
                sParam = sParamBase & UserList(i) & " "
            Else
                sParam = sParam & " " & sParamBase
                sParam = sParam & UserList(i) & " "
            End If
        Next

        If rdbtnIncludeSelectedDomainAccts.Checked = True Then
            Me.sIncludeAccts = sParam
        End If

    End Sub


    Private Function GetLocalUsers(ByVal MachineName As String) As List(Of String)
        Dim WinNt As New DirectoryServices.DirectoryEntry("WinNT://" & MachineName)
        Dim UserList As New List(Of String)

        For Each User As DirectoryServices.DirectoryEntry In WinNt.Children
            If User.SchemaClassName = "User" Then
                UserList.Add(User.Name)
            End If
        Next

        Return UserList
    End Function


    Private Sub BuildGenConfig()

        ' F:\Amd64\CustomXML\Config.XML
        ' "scanstate /i:migapp.xml /i:migdocs.xml /genconfig:config.xml /v:13"
        Me.sUsmtPath = Me.sUsmtCpu & "\Scanstate.exe" & " "
        Me.sMonitorOption = " " & "/o" & " " & "/v:" & Me.CmboBxVerbosityLevel.Text
        Me.sXMLOption = ""

        If Me.ChkBxMigApp.CheckState = CheckState.Checked Then
            If Me.ChkBxLocalDataDrive.Checked = True Then
                If (My.Computer.FileSystem.FileExists(Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigAppXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigAppXML & " "
                End If
            Else
                If (My.Computer.FileSystem.FileExists(Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigAppXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigAppXML & " "
                End If
            End If
        End If

        If Me.CheckBoxMigUser.Checked = True Then
            If Me.ChkBxLocalDataDrive.Checked = True Then
                If (My.Computer.FileSystem.FileExists(Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigUserXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigUserXML & " "
                End If
            Else
                If (My.Computer.FileSystem.FileExists(Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigUserXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigUserXML & " "
                End If
            End If
        End If

        If Me.CheckBoxMigDocs.Checked = True Then
            If Me.ChkBxLocalDataDrive.Checked = True Then
                If (My.Computer.FileSystem.FileExists(Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigDocsXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigDocsXML & " "
                End If
            Else
                If (My.Computer.FileSystem.FileExists(Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigDocsXML)) = True Then
                    Me.sXMLOption = Me.sXMLOption & " " & "/i:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & Me.sMigDocsXML & " "
                End If
            End If
        End If

        If Me.ChkBxLocalDataDrive.Checked = True Then
            Me.slogPath = "" & Me.slogPath & "" & "/l:" & Me.sUsmtDrive & "Logs\Scan_Logs\" & Me.sMyDate & "\" & "GenConfig.log" & " "
        Else
            Me.slogPath = "" & Me.slogPath & "" & "/l:" & Me.sUsmtDrive & "\Logs\Scan_Logs\" & Me.sMyDate & "\" & "GenConfig.log" & " "
        End If

        If Me.ChkBxLocalDataDrive.Checked = True Then
            Me.sGenConfig = "/genconfig:" & Me.sUsmtDrive & Me.sUsmtFolder & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & "\" & "Config.xml "
        Else
            Me.sGenConfig = "/genconfig:" & Me.sUsmtDrive & "\" & Me.sExeSelectedFolder & Me.sCustXmlFilesFolder & "\" & "Config.xml "
        End If

        Me.sCmdGenConfig = Me.sXMLOption & Me.sGenConfig & Me.slogPath & Me.sMonitorOption

    End Sub


    Private Sub BuildCmdLine()

        Me.sCmd = ""
        Me.sCmd2 = ""

        Me.sCmd = Me.sUsmtPath & Me.sStorePath & Me.sExcludeAccts & Me.sIncludeAccts & Me.sSelection & Me.sXMLOption & Me.slogPath & Me.sProgressPath & Me.sMonitorOption & Me.sMoveDomain & Me.sLac & Me.sLae
        Me.sCmd2 = Me.sStorePath & Me.sExcludeAccts & Me.sIncludeAccts & Me.sSelection & Me.sXMLOption & Me.slogPath & Me.sProgressPath & Me.sMonitorOption & Me.sMoveDomain & Me.sLac & Me.sLae

    End Sub

    Private Sub BuildCmd()

        DefineFolders()
        BuildUsmtBaseFolders()
        BuildCurrentFolders()
        BuildUsmtPath()
        BuildStorePath()
        '      GetDirectoryContents()
        BuildExcludeAccts()
        BuildIncludeAccts()
        BuildUsers()
        BuildXMLOption()
        BuildTime()
        BuildLogPath()
        BuildProgressPath()
        BuildMonitorOption()
        BuildMoveUser()
        BuildLac()
        BuildLae()
        BuildCmdLine()

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' My.Application

        ' Initailize Text Boxes

        Me.txtBoxBackupDays.Text = ""
        Me.TxtBoxOldComputer.Text = ""
        Me.TxtBoxNewComputer.Text = ""
        Me.TxtBxEfsBackupKey.Text = ""
        Me.TxtBxEFSRestoreKey.Text = ""

        ' Initial settings for Input Boxes

        Me.TxtboxBackupDate.Visible = False
        Me.txtBoxBackupDays.Visible = False
        Me.TxtBoxOldComputer.Visible = True
        Me.TxtBxEfsBackupKey.Visible = False
        Me.TxtBxEFSRestoreKey.Visible = False

        ' Initialize buttons
        ButtonAccts.Hide()
        ButtonMonitor.Hide()
        ButtonGenConfig.Hide()
        ButtonStorage.Hide()
        ButtonXML.Hide()
        ButtonCMD.Hide()
        Button1.Hide()

        ' My.Computer

        Me.TxtBoxOldComputer.Text = My.Computer.Name
        Me.lblComputerName2.Text = My.Computer.Name
        Me.lblclock.Text = My.Computer.Clock.LocalTime.ToString("MM/dd/yyyy hh:mm")
        Me.currentDirTextBox.Text = My.Computer.FileSystem.CurrentDirectory


        ' Get Domain Name
        Me.sOldDomainName = Me.TextBoxOldDomain.Text
        Me.sNewDomainName = Me.TextBoxNewDomain.Text

        ' Get Old Computer IP Address

        Me.sOldIPAddress = GetIPv4Address()      'System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList(2).ToString
        Me.TxtBoxOldIPAddress.Text = Me.sOldIPAddress

        ' Get New Computer IP Address
        Me.sNewIPAddress = ""                    ' System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList(2).ToString
        Me.TxtBoxNewIPAddress.Text = Me.sNewIPAddress

        ' Drive information

        AddHandler drivesDataGridView.DataError, AddressOf drivesDataGridView_DataError
        Me.drivesDataGridView.DataSource = My.Computer.FileSystem.Drives
        Me.drivesDataGridView.AutoGenerateColumns = True
        Me.computerInfoPropertyGrid.SelectedObject = My.Computer.Info

        ' My.User

        Me.lbluserName.Text = My.User.Name
        If My.User.IsInRole("Administrators") Then
            Me.lbluserName.ForeColor = Color.Red
        End If

        ' Base Folder Settings

        Me.sDataStoreFolder = My.Settings.DataStoreFolder
        Me.sUsmtFolder = My.Settings.USMTFolder
        Me.sCustXmlFilesFolder = My.Settings.XmlCustomFilesFolder
        Me.sUNCServerFolder = My.Settings.UNCServerFolder
        Me.sUNCShareFolder = My.Settings.UNCShareFolder

        If System.Environment.Is64BitOperatingSystem = True Then
            Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
        Else
            Me.sExeSelectedFolder = My.Settings.Usmt5Exex86Folder
        End If

        ' My.MappedDrive

        Me.ChkBxLocalDataDrive.Checked = My.Settings.LocalDriveDataShareChkBx
        Me.txtBoxUsmtDrivePath.Text = My.Settings.UNCUsmtDrivePath
        Me.CmboBoxUsmtDriveLetter.Text = My.Settings.LocalUsmtDriveLetter
        Me.CmboBoxLocalDataDriveLetter.Text = My.Settings.LocalDriveLetterDataShare

        ' Base Settings for Backup / Restore OS Options

        Me.RdBtnSourceWin7.Checked = My.Settings.BackupSourceOSWin7RdBtn
        Me.RdBtnTargetWin10.Checked = My.Settings.BackupTargetOSWin10RdBtn
        Me.RdBtnBackup.Checked = My.Settings.BackupBackupRdBtn


        ' Base Settings for Backup / Restore User Accts Options

        Me.RdBtnExcludeAllAccts.Checked = My.Settings.UserAcctsExcludeAllRdBtn
        Me.RdbtnIncludeAllAccts.Checked = My.Settings.UserAcctsIncludeAllRdBtn



        ' Base Settings for Config Target OS Options


        ' Base Settings for Storage Options

        Me.ChkbxTargetWin7.Checked = My.Settings.StorageConfigTargetWin7ChkBx
        Me.ChkbxTargetWin8.Checked = My.Settings.StorageConfigTargetWin8ChkBx
        Me.ChkBxLocalOnly.Checked = My.Settings.StorageConfigLocalOnlyChkBx
        Me.ChkBxNoCompress.Checked = My.Settings.StorageConfigNoCompressChkBx
        Me.ChkBxOverwrite.Checked = My.Settings.StorageConfigOverWriteChkBx
        Me.ChkBxVsc.Checked = My.Settings.StorageConfigVscChkBx

        ' Base Settings for EFS Options

        Me.ChkBxEFS.Checked = My.Settings.EFSEnabledChkBx
        Me.RdoBtnEFSAbort.Checked = My.Settings.EFSConfigAbortRdBtn
        Me.RdoBtnEFSSkip.Checked = My.Settings.EFSConfigSkipRdBtn
        Me.RdoBtnEFSDecrypt.Checked = My.Settings.EFSConfigDecryptCopyRdBtn
        Me.RdoBtnEFSCopyRaw.Checked = My.Settings.EFSConfigCopyRawRdBtn

        ' Base Settings for Log Options

        Me.ChkbxNetworkLog.Checked = My.Settings.MonitoringNetworkLogChkBx
        Me.ChkbxProgressLog.Checked = My.Settings.MonitoringProgressLogChkBx
        Me.ChkBxVerbosity.Checked = My.Settings.MonitoringConfigVerbosityChkBx
        Me.CmboBxVerbosityLevel.SelectedIndex = My.Settings.MonitoringConfigVerbosityLevel
        Me.ChkbxEnabeBareTail.Checked = My.Settings.MonitoringEnableBareTailLogChkBx

        ' Base Settings for Monitoring Options

        Me.ChkBxRetry.Checked = My.Settings.MonitoringConfigRetryChkBx
        Me.CmboBxRetrys.SelectedIndex = My.Settings.MonitoringConfigRetryTime
        Me.ChkBxWait.Checked = My.Settings.MonitoringConfigWaitChkBx
        Me.CmboBxWait.SelectedIndex = My.Settings.MonitoringConfigWaitTime
        Me.ChkBxContinue.Checked = My.Settings.MonitoringConfigContinueOnErrorChkBx
        Me.ChkBxSpaceEst.Checked = My.Settings.MonitoringConfigSpaceEstimateChkBx
        Me.ChkBxListFiles.Checked = My.Settings.MonitoringConfigListFilesChkBx


        ' Base Settings XML Options

        Me.ChkBxMigApp.Checked = My.Settings.XMLConfigMigAppChkBx
        Me.CheckBoxMigUser.Checked = My.Settings.XMLConfigMigUserChkBx
        Me.CheckBoxMigDocs.Checked = My.Settings.XMLConfigMigDocsChkBx
        Me.ChkBxNetworkPrn.Checked = My.Settings.XMLConfigNetworkPrnChkBx
        Me.ChkbxCustApps.Checked = My.Settings.XMLConfigCustAppsChkBx
        Me.ChkBxCustUsers.Checked = My.Settings.XMLConfigCustUsersChkBx
        Me.CheckBoxExcludeDrives.Checked = My.Settings.XMLConfigExcludeDrivesChkBx
        Me.CheckBoxExcludeSysFolders.Checked = My.Settings.XMLConfigExcludeSysFoldersChkBx
        Me.ChkbxConfig.Checked = My.Settings.XMLConfigConfigChkBx


        ' Base Settings XML Files Options

        Me.sMigAppXML = My.Settings.MigAppXMLFile
        Me.sMigUserXML = My.Settings.MigUserXMLFile
        Me.sMigDocsXML = My.Settings.MigDocsXMLFile
        Me.sCustAppXML = My.Settings.CustAppXMLFile
        Me.sCustUserXML = My.Settings.CustUserXMLFile
        Me.sNetworkPrinterXML = My.Settings.NetworkPrinterXMLFile
        Me.sCust1XML = My.Settings.Cust1XMLFIle
        Me.sCust2XML = My.Settings.Cust2XMLFile
        Me.sCust3XML = My.Settings.Cust3XMLFile
        Me.sExcludeSystemFolders = My.Settings.ExcludeSystemFoldersXMLFile
        Me.sExcludeDrivesXML = My.Settings.ExcludeDrivesXMLFile
        Me.sConfigSXML = My.Settings.ConfigSXMLFile
        Me.sConfigLXML = My.Settings.ConfigLXMLFile

        ' Load the list box with user accounts
        GetDirectoryContents()

        ' Get the Domain Name
        Me.sDName = GetUserDomain()

    End Sub

    Private Sub drivesDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        ' Not all drive information is available
        ' Ignore errors
    End Sub


    Private Sub RdBIncludeAllAccts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbtnIncludeAllAccts.CheckedChanged

        ' Turn off the Include all Accounts Button
        '   Me.RdbtnIncludeAllAccts.Checked = True
        Me.RdbtnIncludeAllAccts.Enabled = True

        ' Turn off the Textbox for Date Input YYYY/MM/DD
        Me.TxtboxBackupDate.Visible = False

        ' Turn off the Textbox for Days Input
        Me.txtBoxBackupDays.Visible = False

        ' Set Label Value
        Me.lblIncludeAccts.Text = "All Accts."

        ' Turn off the Checked list box for user selection
        Me.ChklstbxUsersID.Visible = False
    End Sub


    Private Sub RdBtnIncludeCurrentUser_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnIncludeCurrentUser.CheckedChanged

        ' Turn off the Textbox for Date Input YYYY/MM/DD
        Me.TxtboxBackupDate.Visible = False

        ' Turn off the Textbox for Days Input
        Me.txtBoxBackupDays.Visible = False

        ' Set Label Value
        Me.lblIncludeAccts.Text = "Current User."


        ' Turn off the Checked list box for user selection
        Me.ChklstbxUsersID.Visible = False

    End Sub


    Private Sub RdBtnIncludeLocalAccts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnIncludeLocalAccts.CheckedChanged

        ' Turn off the Textbox for Date Input YYYY/MM/DD
        Me.TxtboxBackupDate.Visible = False

        ' Turn off the Textbox for Days Input
        Me.txtBoxBackupDays.Visible = False

        ' Set Label Value
        Me.lblIncludeAccts.Text = "local Accts."

        ' Turn off the Checked list box for user selection
        Me.ChklstbxUsersID.Visible = False

    End Sub

    Private Sub RdBtnIncludeDomainAccts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnIncludeDomainAccts.CheckedChanged

        ' Turn off the Textbox for Date Input YYYY/MM/DD
        Me.TxtboxBackupDate.Visible = False

        ' Turn off the Textbox for Days Input
        Me.txtBoxBackupDays.Visible = False

        ' Set Label Value
        Me.lblIncludeAccts.Text = "Domain Accts."

        ' Turn off the Checked list box for user selection
        Me.ChklstbxUsersID.Visible = False

    End Sub

    Private Sub RdBtnIncludeSelectedDomainAccts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnIncludeSelectedDomainAccts.CheckedChanged

        ' Turn off the Textbox for Date Input YYYY/MM/DD
        Me.TxtboxBackupDate.Visible = False

        ' Turn off the Textbox for Days Input
        Me.txtBoxBackupDays.Visible = False

        ' Set Label Value
        Me.lblIncludeAccts.Text = "Selected Domain Accts."

        ' Turn on the Checked list box for user selection
        Me.ChklstbxUsersID.Visible = True
    End Sub

    Private Sub RdBtnIncludeSelectedlocalAccts_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnIncludeSelectedlocalAccts.CheckedChanged

        ' Turn off the Textbox for Date Input YYYY/MM/DD
        Me.TxtboxBackupDate.Visible = False

        ' Turn off the Textbox for Days Input
        Me.txtBoxBackupDays.Visible = False

        ' Set Label Value
        Me.lblIncludeAccts.Text = "Selected local Accts."

        ' Turn on the Checked list box for user selection
        Me.ChklstbxUsersID.Visible = True
    End Sub



    Private Sub RdBtnExcludeAllAccts_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnExcludeAllAccts.CheckedChanged

        ' Turn off the Textbox for Date Input YYYY/MM/DD
        Me.TxtboxBackupDate.Visible = False

        ' Turn off the Textbox for Days Input
        Me.txtBoxBackupDays.Visible = False

        ' Set Label Value
        Me.LblExcludeAccts.Text = "Exclude All Accts."

        ' Turn on the Checked list box for user selection
        Me.ChklstbxUsersID.Visible = True

    End Sub

    Private Sub RdBtnExcludeLocalAccts_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnExcludeLocalAccts.CheckedChanged

        ' Turn off the Textbox for Date Input YYYY/MM/DD
        Me.TxtboxBackupDate.Visible = False

        ' Turn off the Textbox for Days Input
        Me.txtBoxBackupDays.Visible = False

        ' Set Label Value
        Me.LblExcludeAccts.Text = "Exclude local Accts."

        ' Turn on the Checked list box for user selection
        Me.ChklstbxUsersID.Visible = True

    End Sub

    Private Sub RdBtnExcludeDomainAccts_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnExcludeDomainAccts.CheckedChanged

        ' Turn off the Textbox for Date Input YYYY/MM/DD
        Me.TxtboxBackupDate.Visible = False

        ' Turn off the Textbox for Days Input
        Me.txtBoxBackupDays.Visible = False

        ' Set Label Value
        Me.LblExcludeAccts.Text = "Exclude Domain Accts."

        ' Turn on the Checked list box for user selection
        Me.ChklstbxUsersID.Visible = True

    End Sub


    Private Sub RdBtnBackupDays_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBtnBackupDays.CheckedChanged
        ' Turn on the Textbox for Day Input ###
        Me.txtBoxBackupDays.Visible = True

        ' Set Label Value
        Me.LblExcludeAccts.Text = "Number of Days ###."

        ' Turn off the Textbox for Date Input
        Me.TxtboxBackupDate.Visible = False

        ' Turn off the Checked list box for user selection
        Me.ChklstbxUsersID.Visible = False
    End Sub

    Private Sub RdBtnBackupDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBtnBackupDate.CheckedChanged
        ' Turn on the Textbox for Date Input YYYY/MM/DD
        Me.TxtboxBackupDate.Visible = True

        ' Set Label Value
        Me.LblExcludeAccts.Text = "Date YYYY/MM/DD."

        ' Turn off the Textbox for Days Input
        Me.txtBoxBackupDays.Visible = False

        ' Turn off the Checked list box for user selection
        Me.ChklstbxUsersID.Visible = False
    End Sub


    Private Sub RdBtnBackup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBtnBackup.CheckedChanged

        ' Set Old Computer text Boxes
        Me.TxtBoxOldComputer.Text = My.Computer.Name

        ' Set Old IP Address text Box
        Me.sOldIPAddress = GetIPv4Address()  ' System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList(2).ToString
        Me.TxtBoxOldIPAddress.Text = Me.sOldIPAddress

        ' Set New Computer text Box
        Me.TxtBoxNewComputer.Text = ""

        ' Set New IP Address text Box
        Me.TxtBoxNewIPAddress.Text = ""

        ' Turn off the Textbox for Days Input 
        Me.txtBoxBackupDays.Visible = False

        ' Turn off the Textbox for Date Input YYYY/MM/DD
        Me.TxtboxBackupDate.Visible = False

        ' Turn on check box for Listfiles
        Me.ChkBxListFiles.Visible = True

        ' Turn on check box for Size Estimate
        Me.ChkBxSpaceEst.Visible = True

        ' Turn on check box for Packages
        Me.CheckBoxPpkg.Visible = True

        ' Turn on check box for Apps
        Me.CheckBoxApps.Visible = True

        ' Turn off old domain textbox
        Me.LabelOldDomain.Visible = False
        Me.TextBoxOldDomain.Visible = False

        ' Turn off New domain textbox
        Me.LabelNewDomain.Visible = False
        Me.TextBoxNewDomain.Visible = False

        ' turn off Lac password textbox
        Me.LabelPassword.Visible = False
        Me.TextBoxLacPassword.Visible = False

        ' Turn off check box for Move Domain
        Me.CheckBoxMoveDomain.Visible = False

        ' Turn off check box for Move User
        Me.CheckBoxMoveUser.Visible = False

        ' Turn off check box for LAC
        Me.CheckBoxLac.Visible = False

        ' Turn off check box for LAE
        Me.CheckBoxLae.Visible = False


        ' Turn on the Exclude Accounts Button
        Me.RdBtnExcludeAllAccts.Checked = True
        Me.RdBtnExcludeAllAccts.Enabled = True
        Me.RdBtnExcludeLocalAccts.Enabled = True
        Me.RdBtnExcludeDomainAccts.Enabled = True
        Me.RdBtnBackupDays.Enabled = True
        Me.RdBtnBackupDate.Enabled = True

        ' Turn on the Include Accounts Button
        Me.RdbtnIncludeAllAccts.Checked = False
        Me.RdbtnIncludeAllAccts.Enabled = True
        Me.RdBtnIncludeCurrentUser.Enabled = True
        Me.rdbtnIncludeLocalAccts.Enabled = True
        Me.rdbtnIncludeDomainAccts.Enabled = True
        Me.rdbtnIncludeSelectedDomainAccts.Enabled = True
        Me.rdbtnIncludeSelectedDomainAccts.Checked = True
        Me.RdBtnIncludeSelectedlocalAccts.Enabled = True

        ' Set Label Value
        Me.LblExcludeAccts.Text = ""
        Me.lblIncludeAccts.Text = ""

        ' Turn on the Checked list box for user selection
        Me.ChklstbxUsersID.Visible = True
    End Sub


    Private Sub RdBtnRestore_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBtnRestore.CheckedChanged

        ' Turn on the Text Box for Old Computer Name
        Me.TxtBoxOldComputer.Visible = True
        Me.TxtBoxOldComputer.Text = ""


        ' Set Old IP Address text Box
        Me.TxtBoxOldIPAddress.Text = ""

        ' Set New Computer text Box
        Me.TxtBoxNewComputer.Text = My.Computer.Name

        ' Set New IP Address text Box
        Me.sNewIPAddress = GetIPv4Address()           ' System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList(2).ToString
        Me.TxtBoxNewIPAddress.Text = Me.sNewIPAddress

        ' Turn off the Textbox for Day Input 
        Me.txtBoxBackupDays.Visible = False

        ' Turn off the Textbox for Date Input YYYY/MM/DD
        Me.TxtboxBackupDate.Visible = False


        ' Turn off check box for Listfiles
        Me.ChkBxListFiles.Visible = False

        ' Turn off check box for Size Estimate
        Me.ChkBxSpaceEst.Visible = False

        ' Turn off check box for Packages
        Me.CheckBoxPpkg.Visible = False

        ' Turn on check box for Apps
        Me.CheckBoxApps.Visible = False

        ' Turn on old domain textbox
        Me.LabelOldDomain.Visible = True
        Me.TextBoxOldDomain.Visible = True

        ' Turn on New domain textbox
        Me.LabelNewDomain.Visible = True
        Me.TextBoxNewDomain.Visible = True

        ' turn on password textbox
        Me.LabelPassword.Visible = True
        Me.TextBoxLacPassword.Visible = True

        ' Turn on check box for Move Domain
        Me.CheckBoxMoveDomain.Visible = True

        ' Turn on check box for Move User
        Me.CheckBoxMoveUser.Visible = True

        ' Turn on check box for LAC
        Me.CheckBoxLac.Visible = True

        ' Turn on check box for LAE
        Me.CheckBoxLae.Visible = True

        ' Turn off the Exclude Accounts Button
        Me.RdBtnExcludeAllAccts.Checked = True
        Me.RdBtnExcludeAllAccts.Enabled = True
        Me.RdBtnExcludeLocalAccts.Enabled = True
        Me.RdBtnExcludeDomainAccts.Enabled = True
        Me.RdBtnBackupDays.Enabled = True
        Me.RdBtnBackupDate.Enabled = True

        ' Turn off the Include Accounts Button
        Me.RdbtnIncludeAllAccts.Checked = False
        Me.RdbtnIncludeAllAccts.Enabled = True
        Me.RdBtnIncludeCurrentUser.Enabled = True
        Me.rdbtnIncludeLocalAccts.Enabled = True
        Me.rdbtnIncludeDomainAccts.Enabled = True
        Me.rdbtnIncludeSelectedDomainAccts.Enabled = True
        Me.rdbtnIncludeSelectedDomainAccts.Checked = True
        Me.RdBtnIncludeSelectedlocalAccts.Enabled = True

        ' Set Label Value
        Me.LblExcludeAccts.Text = ""

        ' Turn off the Checked list box for user selection
        Me.ChklstbxUsersID.Visible = False

    End Sub


    Private Sub RdBtnSourceWin7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBtnSourceWin7.CheckedChanged

        ' Enable TargetWin7 Option
        Me.RdBtnTargetWin7.Enabled = True
        Me.RdBtnTargetWin7.Checked = True

        ' Enable TargetWin8 Option
        Me.RdbtnTargetWin8.Enabled = True
        Me.RdbtnTargetWin8.Checked = True

        ' Enable TargetOSWin7 for Win transfers
        Me.ChkbxTargetWin7.Enabled = True
        Me.ChkbxTargetWin7.Checked = True

        ' Disable TargeOStWin8 for Win7 transfers
        Me.ChkbxTargetWin8.Enabled = False
        Me.ChkbxTargetWin8.Checked = False

        ' Enable VSC for Non XP
        Me.ChkBxVsc.Enabled = True
        Me.ChkBxVsc.Checked = True

        ' Set TargetWin7 as Default
        Me.RdBtnTargetWin7.Checked = True

    End Sub

    Private Sub RdBtnSourceWin8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBtnSourceWin8.CheckedChanged

        ' Disable TargetWin7 Option
        Me.RdBtnTargetWin7.Enabled = False
        Me.RdBtnTargetWin7.Checked = False

        ' Enable TargetWin8 Option
        Me.RdbtnTargetWin8.Enabled = True
        Me.RdbtnTargetWin8.Checked = True

        ' Disable TargetWin7 for Win8 transfers
        Me.ChkbxTargetWin7.Enabled = False
        Me.ChkbxTargetWin7.Checked = False

        ' Enable TargetWin8 for Win8 transfers
        Me.ChkbxTargetWin8.Enabled = True
        Me.ChkbxTargetWin8.Checked = True

        ' Enable VSC for Non XP
        Me.ChkBxVsc.Enabled = True
        Me.ChkBxVsc.Checked = True

        ' Set TargetWin8 as Default
        Me.RdbtnTargetWin8.Checked = True

    End Sub


    Private Sub RdBtnSourceWin10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBtnSourceWin10.CheckedChanged

        ' Disable TargetWin7 Option
        Me.RdBtnTargetWin7.Enabled = False
        Me.RdBtnTargetWin7.Checked = False

        ' Disable TargetWin8 Option
        Me.RdbtnTargetWin8.Enabled = False
        Me.RdbtnTargetWin8.Checked = False

        ' Disable TargetWin7 for Win10 transfers
        Me.ChkbxTargetWin7.Enabled = False
        Me.ChkbxTargetWin7.Checked = False

        ' Disable TargetWin8 for Win10 transfers
        Me.ChkbxTargetWin8.Enabled = False
        Me.ChkbxTargetWin8.Checked = False

        ' Enable VSC for Non XP
        Me.ChkBxVsc.Enabled = True
        Me.ChkBxVsc.Checked = True

        ' Set TargetWin10 as Default
        Me.RdBtnTargetWin10.Checked = True

    End Sub

    Private Sub RdBtnTargetWin7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBtnTargetWin7.CheckedChanged

        ' Set the Usmt Exe Folder to the selected version for USMT 10.0
        If Me.RdBtnTargetWin10.Checked = True Then
            If Me.RdBtnx86.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
            If Me.RdBtnAmd64.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
        End If
        If Me.RdBtnTargetWin7.Checked = True Then
            If Me.RdBtnx86.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
            If Me.RdBtnAmd64.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
        End If

        ' Enable TargetWin7 for Win7 transfers
        Me.ChkbxTargetWin7.Enabled = True
        Me.ChkbxTargetWin7.Checked = True

        ' Disable TargetWin8 for Win7 transfers
        Me.ChkbxTargetWin8.Enabled = False
        Me.ChkbxTargetWin8.Checked = False

        ' Enable VSC for Non XP
        Me.ChkBxVsc.Enabled = True
        Me.ChkBxVsc.Checked = True

    End Sub


    Private Sub RdBtnTargetWin8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbtnTargetWin8.CheckedChanged

        ' Set the Usmt Exe Folder to the selected version for USMT 4.0
        If Me.RdBtnTargetWin10.Checked = True Then
            If Me.RdBtnx86.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
            If Me.RdBtnAmd64.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
        End If
        If Me.RdbtnTargetWin8.Checked = True Then
            If Me.RdBtnx86.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
            If Me.RdBtnAmd64.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
        End If

        ' Disable TargetWin7 for Win10 transfers
        Me.ChkbxTargetWin7.Enabled = False
        Me.ChkbxTargetWin7.Checked = False


        ' Enable TargetWin8 for Win8 transfers
        Me.ChkbxTargetWin7.Enabled = True
        Me.ChkbxTargetWin7.Checked = True

        ' Enable VSC for Non XP
        Me.ChkBxVsc.Enabled = True
        Me.ChkBxVsc.Checked = True

    End Sub


    Private Sub RdBtnTargetWin10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBtnTargetWin10.CheckedChanged

        ' Set the Usmt Exe Folder to the selected version for USMT 4.0
        If Me.RdBtnTargetWin10.Checked = True Then
            If Me.RdBtnx86.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
            If Me.RdBtnAmd64.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
        End If
        If Me.RdBtnTargetWin10.Checked = True Then
            If Me.RdBtnx86.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
            If Me.RdBtnAmd64.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
        End If

        ' Disable TargetWin7 for Win10 transfers
        Me.ChkbxTargetWin7.Enabled = False
        Me.ChkbxTargetWin7.Checked = False

        ' Disable TargetWin8 for Win10 transfers
        Me.ChkbxTargetWin8.Enabled = False
        Me.ChkbxTargetWin8.Checked = False

        ' Enable VSC for Non XP
        Me.ChkBxVsc.Enabled = True
        Me.ChkBxVsc.Checked = True

    End Sub


    Private Sub RdBtnx86_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBtnx86.CheckedChanged

        ' Set the Usmt Exe Folder to the selected version for USMT 4.0
        If Me.RdBtnTargetWin10.Checked = True Then
            If Me.RdBtnx86.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
            If Me.RdBtnAmd64.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
        End If
        If Me.RdBtnTargetWin7.Checked = True Then
            If Me.RdBtnx86.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
            If Me.RdBtnAmd64.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
        End If

    End Sub

    Private Sub RdBtnAmd64_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdBtnAmd64.CheckedChanged

        ' Set the Usmt Exe Folder to the selected version for USMT 4.0
        If Me.RdBtnTargetWin10.Checked = True Then
            If Me.RdBtnx86.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
            If Me.RdBtnAmd64.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
        End If
        If Me.RdBtnTargetWin7.Checked = True Then
            If Me.RdBtnx86.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
            If Me.RdBtnAmd64.Checked = True Then
                Me.sExeSelectedFolder = My.Settings.Usmt5ExeAmd64Folder
            End If
        End If

    End Sub


    Private Sub GetDirectoryContents()

        Dim Mypath As String, MyName As String, iCount As Integer
        iCount = 0
        Mypath = ""
        '  ChklstbxUsersID.Items.Clear()
        If (My.Computer.FileSystem.DirectoryExists("c:\Documents and settings\")) = True Then
            Mypath = "c:\Documents and settings\"   ' Set the path.
        End If
        If (My.Computer.FileSystem.DirectoryExists("c:\users\")) = True Then
            Mypath = "c:\users\"   ' Set the path.
        End If

        MyName = Dir(Mypath, vbDirectory)   ' Retrieve the first entry.
        Do While MyName <> ""   ' Start the loop.
            ' Ignore the current directory and the encompassing directory.
            If MyName <> "." And MyName <> ".." And MyName <> "All Users" And MyName <> "AppData" And MyName <>
            "Default" And MyName <> "Default User" And MyName <> "Public" And MyName <> "Administrator" And MyName <>
            "LocalService" And MyName <> "NetworkService" Then
                ' Use bitwise comparison to make sure MyName is a directory.
                If (GetAttr(Mypath & MyName) And vbDirectory) = vbDirectory Then
                    '    Debug.Print(MyName)   ' Display entry only if it
                    '    MsgBox(MyName)
                    ChklstbxUsersID.Items.Add(MyName)
                    iCount = iCount + 1
                End If   ' it represents a directory.
            End If
            MyName = Dir()   ' Get next entry.
        Loop
    End Sub

    Private Sub DisplayOperatingSystemInformation()
        Dim osInfo As OperatingSystem
        osInfo = Environment.OSVersion
        Dim verInfo As Version
        verInfo = osInfo.Version
        'Display Version Information
        MessageBox.Show(
        "Major Version   = " & verInfo.Major & vbCrLf &
        "Minor Version   = " & verInfo.Minor & vbCrLf &
        "Revision        = " & verInfo.Revision & vbCrLf &
        "Build           = " & verInfo.Build & vbCrLf &
        "Platform        = " & osInfo.Platform & vbCrLf &
        "Platform String = " & osInfo.VersionString,
        "Operating System Information", MessageBoxButtons.OK,
         MessageBoxIcon.Information)
    End Sub

    Sub DisplayOperatingSystemInformation2()
        Dim osInfo As New FindOSInfo
        'Display Version Information
        MessageBox.Show(
        "Computer Name = " & osInfo.ComputerName & vbCrLf &
        "Manufacturer = " & osInfo.Manufacturer & vbCrLf &
        "Model = " & osInfo.Model & vbCrLf &
        "OS Name = " & osInfo.OsName & vbCrLf &
        "Version = " & osInfo.OSVersion & vbCrLf &
        "System Type = " & osInfo.SystemType & vbCrLf &
        "Physical Memory = " & osInfo.TotalPhysicalMemory & vbCrLf &
        "Windows Folder = " & osInfo.WindowsDirectory,
        "Operating System Information", MessageBoxButtons.OK,
        MessageBoxIcon.Information)
    End Sub

    Function GetUserDomain() As String
        If TypeOf My.User.CurrentPrincipal Is
        Security.Principal.WindowsPrincipal Then
            ' My.User is using Windows authentication.
            ' The name format is DOMAIN\USERNAME.
            Dim parts() As String = Split(My.User.Name, "\")
            Dim domain As String = parts(0)
            Return domain
        Else
            ' My.User is using custom authentication.
            Return ""
        End If
    End Function

    Function getAllFolders(ByVal directory As String) As String()
        'Create object
        Dim fi As New IO.DirectoryInfo(directory)
        'Array to store paths
        Dim path() As String = {}
        'Loop through subfolders
        For Each subfolder As IO.DirectoryInfo In fi.GetDirectories()
            'Add this folders name
            Array.Resize(path, path.Length + 1)
            path(path.Length - 1) = subfolder.FullName
            'Recall function with each subdirectory
            For Each s As String In getAllFolders(subfolder.FullName)
                Array.Resize(path, path.Length + 1)
                path(path.Length - 1) = s
            Next
        Next
        Return path
    End Function

    Private Function GetIPv4Address() As String
        GetIPv4Address = String.Empty

        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then  ' InterNetwork = Address Family for IP version 4
                GetIPv4Address = ipheal.ToString()                                        ' InterNetwork6 = Address Family for IP version 6
            Else
                If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetworkV6 Then  ' InterNetwork = Address Family for IP version 4
                    GetIPv4Address = ipheal.ToString()                                          ' InterNetwork6 = Address Family for IP version 6
                End If
            End If
        Next

    End Function

    Private Function GetNewIPv4Address() As String

        GetNewIPv4Address = String.Empty
        Dim strHostName As String

        strHostName = TxtBoxNewComputer.Text

        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then  ' InterNetwork = Address Family for IP version 4
                GetNewIPv4Address = ipheal.ToString()                                        ' InterNetwork6 = Address Family for IP version 6
            Else
                If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetworkV6 Then  ' InterNetwork = Address Family for IP version 4
                    GetNewIPv4Address = ipheal.ToString()                                          ' InterNetwork6 = Address Family for IP version 6
                End If
            End If
        Next

    End Function


    Public Shared Sub PingComputer(ByVal args() As String)
        Dim pingSender As New Ping()
        Dim options As New PingOptions()

        ' Use the default Ttl value which is 128,  
        ' but change the fragmentation behavior.  
        options.DontFragment = True

        ' Create a buffer of 32 bytes of data to be transmitted.  
        Dim data As String = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        Dim buffer() As Byte = Encoding.ASCII.GetBytes(data)
        Dim timeout As Integer = 120
        Dim reply As PingReply = pingSender.Send(args(0), timeout, buffer, options)
        If reply.Status = IPStatus.Success Then
            Console.WriteLine("Address: {0}", reply.Address.ToString())
            Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime)
            Console.WriteLine("Time to live: {0}", reply.Options.Ttl)
            Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment)
            Console.WriteLine("Buffer size: {0}", reply.Buffer.Length)
        End If
    End Sub



    Private Sub TestNewConnection()
        Try
            Me.sNewComputerName = TxtBoxNewComputer.Text
            If Me.sNewComputerName <> "" Then
                Dim Result As Net.NetworkInformation.PingReply
                Dim SendPing As New Net.NetworkInformation.Ping
                Result = SendPing.Send(Me.sNewComputerName)

                If Result.Status = Net.NetworkInformation.IPStatus.Success Then
                    '     MsgBox("ping success!")
                    TxtBoxNewIPAddress.Text = GetNewIPv4Address()
                Else
                    MsgBox("ping failed!")
                End If

            Else
                MsgBox("Please enter new computer Name!  ")
            End If

        Catch ex As Exception
            MsgBox("Computer Not Found  -  " & Me.sNewComputerName)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DefineFolders()

        MsgBox("sUsmtDrive " & vbCrLf & Me.sUsmtDrive)
        MsgBox("sUsmtFolder " & vbCrLf & Me.sUsmtFolder)
        MsgBox("sUsmtCpu " & vbCrLf & Me.sUsmtCpu)
        MsgBox("sUsmtPath " & vbCrLf & Me.sUsmtPath)
        MsgBox("sUNCUsmtPath " & vbCrLf & Me.sUNCUsmtPath)
        MsgBox("sUNCServerFolder " & vbCrLf & Me.sUNCServerFolder)
        MsgBox("sDataStoreDrive " & vbCrLf & Me.sDataStoreDrive)
        MsgBox("sDataStore " & vbCrLf & Me.sDataStore)

    End Sub


    Public Sub ButtonAccts_Click(sender As Object, e As EventArgs) Handles ButtonAccts.Click
        ' Show Accounts - Include and Exclude
        DefineFolders()
        BuildExcludeAccts()
        MsgBox("Exclude Accts " & vbCrLf & Me.sExcludeAccts)
        BuildIncludeAccts()
        MsgBox("Include Accts " & vbCrLf & Me.sIncludeAccts)
    End Sub

    Private Sub ButtonXML_Click(sender As Object, e As EventArgs) Handles ButtonXML.Click
        ' Show XML Options
        DefineFolders()
        BuildXMLOption()
        MsgBox("XML Option " & vbCrLf & Me.sXMLOption)
    End Sub

    Private Sub ButtonMonitor_Click(sender As Object, e As EventArgs) Handles ButtonMonitor.Click
        DefineFolders()
        BuildMonitorOption()
        MsgBox("Monitor Option " & vbCrLf & Me.sMonitorOption)
    End Sub

    Private Sub ButtonStorage_Click(sender As Object, e As EventArgs) Handles ButtonStorage.Click

        ' Show cmd Line for both
        ' BuildCmd()
        DefineFolders()
        MsgBox("USMTDrive " & vbCrLf & Me.sUsmtDrive)
        MsgBox("USMTFolder " & vbCrLf & Me.sUsmtFolder)

        BuildUsmtPath()
        BuildLogPath()
        BuildStorePath()
        MsgBox("USMT Data Store " & vbCrLf & Me.sDataStore)
        MsgBox("USMT Path " & vbCrLf & Me.sUsmtPath)
    End Sub

    Private Sub ButtonCMD_Click(sender As Object, e As EventArgs) Handles ButtonCMD.Click

        DefineFolders()

        '   BuildBaseFolders()
        '   BuildCurrentFolders()
        BuildUsmtPath()
        BuildStorePath()
        '    GetDirectoryContents()
        BuildExcludeAccts()
        BuildIncludeAccts()
        BuildUsers()
        BuildXMLOption()
        BuildTime()
        BuildLogPath()
        BuildProgressPath()
        BuildMonitorOption()
        BuildMoveDomain()
        BuildLac()
        BuildLae()
        BuildCmdLine()
        MsgBox("sCmd " & vbCrLf & Me.sCmd)
    End Sub

    Private Sub ButtonGenConfig_Click(sender As Object, e As EventArgs) Handles ButtonGenConfig.Click

        DefineFolders()
        BuildGenConfig()
        MsgBox("Gen Config File Complete" & vbCrLf & Me.sCmdGenConfig)
        Process.Start(sUsmtPath, sCmdGenConfig)
    End Sub


    Private Sub CmdBtnRunUsmt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBtnRunUsmt.Click
        '  MsgBox("Map the Network Drive to the Data Share Using the Drive Letter Selected On the Mapped Drive Tab")

        BuildCmd()

        Process.Start(sUsmtPath, sCmd2)
        Process.Start(sBareTailCmd, sBareTailProgressLogPath)
        Process.Start(sBareTailCmd, sBareTailScanLogPath)
        MsgBox("Usmt Complete")
    End Sub

    Private Sub CheckBoxMigUser_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMigUser.CheckedChanged
        If Me.CheckBoxMigUser.Checked = True Then
            Me.CheckBoxMigDocs.Checked = False
        Else
            Me.CheckBoxMigDocs.Checked = True
        End If
    End Sub

    Private Sub CheckBoxMigDocs_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMigDocs.CheckedChanged
        If Me.CheckBoxMigDocs.Checked = True Then
            Me.CheckBoxMigUser.Checked = False
        Else
            Me.CheckBoxMigUser.Checked = True
        End If
    End Sub


    Private Sub ChklstbxUsersID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For i As Integer = 0 To ChklstbxUsersID.SelectedItems.Count - 1
            ChklstbxUsersID.SetItemCheckState((ChklstbxUsersID.Items.IndexOf(ChklstbxUsersID.SelectedItems.Item(i))), CheckState.Checked)

        Next
    End Sub

    Private Sub CmdBtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBtnExit.Click
        Application.Exit()
    End Sub

    Private Sub CheckBoxShowBtns_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowBtns.CheckedChanged

        If Me.CheckBoxShowBtns.Checked = True Then
            ButtonAccts.Show()
            ButtonMonitor.Show()
            ButtonGenConfig.Show()
            ButtonStorage.Show()
            ButtonXML.Show()
            ButtonCMD.Show()
            Button1.Show()

        Else

            ' Initialize buttons
            ButtonAccts.Hide()
            ButtonMonitor.Hide()
            ButtonGenConfig.Hide()
            ButtonStorage.Hide()
            ButtonXML.Hide()
            ButtonCMD.Hide()
            Button1.Hide()
        End If
    End Sub

    Private Sub ChkBxEFSBackupKey_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxEFSBackupKey.CheckedChanged
        If Me.ChkBxEFSBackupKey.Checked = True Then
            Me.TxtBxEfsBackupKey.Visible = True
            Me.ChkBxNoCompress.Checked = False
        Else
            Me.TxtBxEfsBackupKey.Visible = False
        End If
    End Sub

    Private Sub ChkBxEFSRestoreKey_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxEFSRestoreKey.CheckedChanged
        If Me.ChkBxEFSRestoreKey.Checked = True Then
            Me.TxtBxEFSRestoreKey.Visible = True
            Me.ChkBxNoCompress.Checked = False
        Else
            Me.TxtBxEFSRestoreKey.Visible = False
        End If
    End Sub

    Private Sub ChkBxLocalDataDrive_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxLocalDataDrive.CheckedChanged
        If Me.ChkBxLocalDataDrive.Checked Then ' true
            Me.CheckBoxNetworkDataDrive.CheckState = CheckState.Unchecked
            DefineFolders()
            Me.TextBoxDataDrivePath.Text = Me.sDataStore
        Else
            Me.TextBoxDataDrivePath.Text = ""
        End If
    End Sub

    Private Sub CheckBoxNetworkDataDrive_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxNetworkDataDrive.CheckedChanged
        If Me.CheckBoxNetworkDataDrive.Checked = True Then
            Me.ChkBxLocalDataDrive.CheckState = CheckState.Unchecked
            DefineFolders()
            Me.TextBoxDataDrivePath.Text = Me.sDataStore
        Else
            Me.TextBoxDataDrivePath.Text = ""
        End If
    End Sub


    Private Sub CheckBoxLocalLogDataDrive_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxLocalLogDataDrive.CheckedChanged
        If Me.CheckBoxLocalLogDataDrive.Checked = True Then
            Me.CheckBoxNetworkLogDataDrive.CheckState = CheckState.Unchecked
            DefineFolders()
            Me.txtBoxUsmtDrivePath.Text = Me.sUsmtDrive
        Else
            Me.txtBoxUsmtDrivePath.Text = ""
        End If
    End Sub

    Private Sub CheckBoxNetworkLogDataDrive_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxNetworkLogDataDrive.CheckedChanged
        If Me.CheckBoxNetworkLogDataDrive.Checked = True Then
            Me.CheckBoxLocalLogDataDrive.CheckState = CheckState.Unchecked
            DefineFolders()
            Me.txtBoxUsmtDrivePath.Text = Me.sUsmtDrive
        Else
            Me.txtBoxUsmtDrivePath.Text = ""
        End If
    End Sub


    Private Sub CheckBoxConnected_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxConnected.CheckedChanged
        If Me.CheckBoxConnected.Checked = True Then
            DefineFolders()
            Me.TextBoxDataDrivePath.Text = Me.sDataStore
        Else
            Me.TextBoxDataDrivePath.Text = ""
        End If
    End Sub

    Private Sub BtnTestConnection_Click(sender As Object, e As EventArgs) Handles BtnTestConnection.Click

        TestNewConnection()


    End Sub

    Private Sub CheckBoxHardlink_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxHardlink.CheckedChanged
        If Me.CheckBoxHardlink.Checked = True Then
            Me.ChkBxNoCompress.Checked = True
        End If
    End Sub

    Private Sub ChkBxListFiles_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxListFiles.CheckedChanged
        If Me.ChkBxListFiles.Checked = True Then
            Me.ChkBxSpaceEst.Checked = False
        End If
    End Sub

    Private Sub ChkBxSpaceEst_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxSpaceEst.CheckedChanged
        If Me.ChkBxSpaceEst.Checked = True Then
            Me.ChkBxListFiles.Checked = False
        End If
    End Sub

    Private Sub RadioButtonEFSHardlink_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonEFSHardlink.CheckedChanged
        If RadioButtonEFSHardlink.Checked = True Then
            Me.ChkBxNoCompress.Checked = True
            Me.ChkBxVsc.Checked = False
        End If
    End Sub

    Private Sub txtBoxUncDrivePathUSMT_TextChanged(sender As Object, e As EventArgs) Handles txtBoxUsmtDrivePath.TextChanged

    End Sub


    Private Sub CmdBtnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBtnAbout.Click
        AboutUSMTGUI.Show()
    End Sub

End Class
