<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class USMTGUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.StatusStripInfo = New System.Windows.Forms.StatusStrip()
        Me.lblComputerName2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbluserName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblblankSpacer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblclock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DirectorySearcherGui = New System.DirectoryServices.DirectorySearcher()
        Me.GroupBoxMyComputer = New System.Windows.Forms.GroupBox()
        Me.LabelCurrentDirectory = New System.Windows.Forms.Label()
        Me.currentDirTextBox = New System.Windows.Forms.TextBox()
        Me.drivesDataGridView = New System.Windows.Forms.DataGridView()
        Me.LabelDrives = New System.Windows.Forms.Label()
        Me.TbCtrlMain = New System.Windows.Forms.TabControl()
        Me.TabPageBackup = New System.Windows.Forms.TabPage()
        Me.GroupBoxBuildXML = New System.Windows.Forms.GroupBox()
        Me.CheckBoxSharedFavorites = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSharedDesktop = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSharedVideo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSharedMusic = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSharedPictures = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSharedDocuments = New System.Windows.Forms.CheckBox()
        Me.CheckBoxFavorites = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMyDesktop = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMyVideo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMyMusic = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMyPictures = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMyDocuments = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDownloads = New System.Windows.Forms.CheckBox()
        Me.CheckBoxWallpapers = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRecycleBin = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPrinters = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLocalAppData = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAppData = New System.Windows.Forms.CheckBox()
        Me.GrpBoxSourceOS = New System.Windows.Forms.GroupBox()
        Me.RdBtnSourceWin8 = New System.Windows.Forms.RadioButton()
        Me.RdBtnSourceWin7 = New System.Windows.Forms.RadioButton()
        Me.RdBtnSourceWin10 = New System.Windows.Forms.RadioButton()
        Me.GrpBoxTargetOS = New System.Windows.Forms.GroupBox()
        Me.RdbtnTargetWin8 = New System.Windows.Forms.RadioButton()
        Me.RdBtnTargetWin7 = New System.Windows.Forms.RadioButton()
        Me.RdBtnTargetWin10 = New System.Windows.Forms.RadioButton()
        Me.GrpBoxCpuType = New System.Windows.Forms.GroupBox()
        Me.RdBtnx86 = New System.Windows.Forms.RadioButton()
        Me.RdBtnAmd64 = New System.Windows.Forms.RadioButton()
        Me.GroupBoxComputerInfo = New System.Windows.Forms.GroupBox()
        Me.CheckBoxConnected = New System.Windows.Forms.CheckBox()
        Me.BtnTestConnection = New System.Windows.Forms.Button()
        Me.LblIPAddress = New System.Windows.Forms.Label()
        Me.LblCompName = New System.Windows.Forms.Label()
        Me.LblNewComputer = New System.Windows.Forms.Label()
        Me.LblOldComputer = New System.Windows.Forms.Label()
        Me.TxtBoxNewIPAddress = New System.Windows.Forms.TextBox()
        Me.TxtBoxOldIPAddress = New System.Windows.Forms.TextBox()
        Me.TxtBoxNewComputer = New System.Windows.Forms.TextBox()
        Me.TxtBoxOldComputer = New System.Windows.Forms.TextBox()
        Me.GrpBoxDriveData = New System.Windows.Forms.GroupBox()
        Me.CheckBoxNetworkDataDrive = New System.Windows.Forms.CheckBox()
        Me.TextBoxDataDrivePath = New System.Windows.Forms.TextBox()
        Me.CmboBoxUsmtDriveLetter = New System.Windows.Forms.ComboBox()
        Me.ChkBxLocalDataDrive = New System.Windows.Forms.CheckBox()
        Me.LblMappedDriveLetterUsmt = New System.Windows.Forms.Label()
        Me.LblUncUSMTSharePath = New System.Windows.Forms.Label()
        Me.txtBoxUsmtDrivePath = New System.Windows.Forms.TextBox()
        Me.CmboBoxLocalDataDriveLetter = New System.Windows.Forms.ComboBox()
        Me.LblLocalDataShareDriveLetter = New System.Windows.Forms.Label()
        Me.GrpBoxBackupRestore = New System.Windows.Forms.GroupBox()
        Me.RdBtnRestore = New System.Windows.Forms.RadioButton()
        Me.RdBtnBackup = New System.Windows.Forms.RadioButton()
        Me.TabPageUserSettings = New System.Windows.Forms.TabPage()
        Me.CheckedListBoxLocalUsers = New System.Windows.Forms.CheckedListBox()
        Me.GroupBoxDomainRedirection = New System.Windows.Forms.GroupBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxLacPassword = New System.Windows.Forms.TextBox()
        Me.CheckBoxLae = New System.Windows.Forms.CheckBox()
        Me.CheckBoxLac = New System.Windows.Forms.CheckBox()
        Me.LabelNewDomain = New System.Windows.Forms.Label()
        Me.LabelOldDomain = New System.Windows.Forms.Label()
        Me.TextBoxNewDomain = New System.Windows.Forms.TextBox()
        Me.TextBoxOldDomain = New System.Windows.Forms.TextBox()
        Me.CheckBoxMoveUser = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMoveDomain = New System.Windows.Forms.CheckBox()
        Me.ChklstbxUsersID = New System.Windows.Forms.CheckedListBox()
        Me.GrpBoxExcludeAccts = New System.Windows.Forms.GroupBox()
        Me.LblExcludeAccts = New System.Windows.Forms.Label()
        Me.lblIncludeAccts = New System.Windows.Forms.Label()
        Me.ListBoxExcludeFilter = New System.Windows.Forms.ListBox()
        Me.ListBoxIncludeFilter = New System.Windows.Forms.ListBox()
        Me.TxtboxBackupDate = New System.Windows.Forms.TextBox()
        Me.RdBtnBackupDate = New System.Windows.Forms.RadioButton()
        Me.RdBtnExcludeDomainAccts = New System.Windows.Forms.RadioButton()
        Me.RdBtnExcludeAllAccts = New System.Windows.Forms.RadioButton()
        Me.RdBtnExcludeLocalAccts = New System.Windows.Forms.RadioButton()
        Me.txtBoxBackupDays = New System.Windows.Forms.TextBox()
        Me.RdBtnBackupDays = New System.Windows.Forms.RadioButton()
        Me.GrpBoxIncludeAccts = New System.Windows.Forms.GroupBox()
        Me.RdBtnIncludeCurrentUser = New System.Windows.Forms.RadioButton()
        Me.RdBtnIncludeSelectedlocalAccts = New System.Windows.Forms.RadioButton()
        Me.rdbtnIncludeSelectedDomainAccts = New System.Windows.Forms.RadioButton()
        Me.rdbtnIncludeDomainAccts = New System.Windows.Forms.RadioButton()
        Me.rdbtnIncludeLocalAccts = New System.Windows.Forms.RadioButton()
        Me.RdbtnIncludeAllAccts = New System.Windows.Forms.RadioButton()
        Me.TabPageConfigO = New System.Windows.Forms.TabPage()
        Me.GrpBxEFSOptions = New System.Windows.Forms.GroupBox()
        Me.RadioButtonEFSHardlink = New System.Windows.Forms.RadioButton()
        Me.RdoBtnEFSCopyRaw = New System.Windows.Forms.RadioButton()
        Me.RdoBtnEFSDecrypt = New System.Windows.Forms.RadioButton()
        Me.RdoBtnEFSSkip = New System.Windows.Forms.RadioButton()
        Me.RdoBtnEFSAbort = New System.Windows.Forms.RadioButton()
        Me.ChkBxEFS = New System.Windows.Forms.CheckBox()
        Me.GroupBoxFileExclusions = New System.Windows.Forms.GroupBox()
        Me.GroupBoxFileInclusions = New System.Windows.Forms.GroupBox()
        Me.GroupBoxExtraDirectoryExclusions = New System.Windows.Forms.GroupBox()
        Me.GrpBxXMLFiles = New System.Windows.Forms.GroupBox()
        Me.CheckBoxCust3XML = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCust2XML = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCust1XML = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMigDocs = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMigUser = New System.Windows.Forms.CheckBox()
        Me.CheckBoxExcludeSysFolders = New System.Windows.Forms.CheckBox()
        Me.ChkbxConfig = New System.Windows.Forms.CheckBox()
        Me.ChkbxCustApps = New System.Windows.Forms.CheckBox()
        Me.ChkBxNetworkPrn = New System.Windows.Forms.CheckBox()
        Me.CheckBoxExcludeDrives = New System.Windows.Forms.CheckBox()
        Me.ChkBxCustUsers = New System.Windows.Forms.CheckBox()
        Me.ChkBxMigApp = New System.Windows.Forms.CheckBox()
        Me.GroupBoxExtraDirectoriesInclusion = New System.Windows.Forms.GroupBox()
        Me.DataGridViewExtraDirInclude = New System.Windows.Forms.DataGridView()
        Me.GrpBxEFSRestore = New System.Windows.Forms.GroupBox()
        Me.ComboBoxDecryptStrength = New System.Windows.Forms.ComboBox()
        Me.lblDecryptKeystring = New System.Windows.Forms.Label()
        Me.TxtBxEFSRestoreKey = New System.Windows.Forms.TextBox()
        Me.ChkBxEFSRestoreKey = New System.Windows.Forms.CheckBox()
        Me.GrpBxEFSBackup = New System.Windows.Forms.GroupBox()
        Me.ComboBoxEncryptStrength = New System.Windows.Forms.ComboBox()
        Me.lblEncryptKey = New System.Windows.Forms.Label()
        Me.TxtBxEfsBackupKey = New System.Windows.Forms.TextBox()
        Me.ChkBxEFSBackupKey = New System.Windows.Forms.CheckBox()
        Me.GrpBxMonitoring = New System.Windows.Forms.GroupBox()
        Me.ChkBxListFiles = New System.Windows.Forms.CheckBox()
        Me.CmboBxWait = New System.Windows.Forms.ComboBox()
        Me.CmboBxRetrys = New System.Windows.Forms.ComboBox()
        Me.ChkBxSpaceEst = New System.Windows.Forms.CheckBox()
        Me.ChkBxContinue = New System.Windows.Forms.CheckBox()
        Me.ChkBxWait = New System.Windows.Forms.CheckBox()
        Me.ChkBxRetry = New System.Windows.Forms.CheckBox()
        Me.GrpBxLogOptions = New System.Windows.Forms.GroupBox()
        Me.ChkbxEnabeBareTail = New System.Windows.Forms.CheckBox()
        Me.ChkbxProgressLog = New System.Windows.Forms.CheckBox()
        Me.ChkbxNetworkLog = New System.Windows.Forms.CheckBox()
        Me.CmboBxVerbosityLevel = New System.Windows.Forms.ComboBox()
        Me.ChkBxVerbosity = New System.Windows.Forms.CheckBox()
        Me.GrpBxStorage = New System.Windows.Forms.GroupBox()
        Me.CheckBoxHardlink = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPpkg = New System.Windows.Forms.CheckBox()
        Me.CheckBoxApps = New System.Windows.Forms.CheckBox()
        Me.ChkbxTargetWin8 = New System.Windows.Forms.CheckBox()
        Me.ChkBxVsc = New System.Windows.Forms.CheckBox()
        Me.ChkbxTargetWin7 = New System.Windows.Forms.CheckBox()
        Me.ChkBxLocalOnly = New System.Windows.Forms.CheckBox()
        Me.ChkBxNoCompress = New System.Windows.Forms.CheckBox()
        Me.ChkBxOverwrite = New System.Windows.Forms.CheckBox()
        Me.TabPageDrives = New System.Windows.Forms.TabPage()
        Me.ComputerInfo = New System.Windows.Forms.Label()
        Me.computerInfoPropertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.TabPagePSTFiles = New System.Windows.Forms.TabPage()
        Me.ListBoxPstFiles = New System.Windows.Forms.ListBox()
        Me.CmdBtnFindPST = New System.Windows.Forms.Button()
        Me.TabPageSysInfo = New System.Windows.Forms.TabPage()
        Me.ListBoxPostScripts = New System.Windows.Forms.ListBox()
        Me.ListBoxPreScripts = New System.Windows.Forms.ListBox()
        Me.ButtonXML = New System.Windows.Forms.Button()
        Me.CmdBtnRunUsmt = New System.Windows.Forms.Button()
        Me.CmdBtnExit = New System.Windows.Forms.Button()
        Me.CmdBtnAbout = New System.Windows.Forms.Button()
        Me.ButtonMonitor = New System.Windows.Forms.Button()
        Me.ButtonAccts = New System.Windows.Forms.Button()
        Me.ButtonStorage = New System.Windows.Forms.Button()
        Me.ButtonCMD = New System.Windows.Forms.Button()
        Me.ButtonGenConfig = New System.Windows.Forms.Button()
        Me.CheckBoxShowBtns = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxLocalLogDataDrive = New System.Windows.Forms.CheckBox()
        Me.CheckBoxNetworkLogDataDrive = New System.Windows.Forms.CheckBox()
        Me.StatusStripInfo.SuspendLayout()
        Me.GroupBoxMyComputer.SuspendLayout()
        CType(Me.drivesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbCtrlMain.SuspendLayout()
        Me.TabPageBackup.SuspendLayout()
        Me.GroupBoxBuildXML.SuspendLayout()
        Me.GrpBoxSourceOS.SuspendLayout()
        Me.GrpBoxTargetOS.SuspendLayout()
        Me.GrpBoxCpuType.SuspendLayout()
        Me.GroupBoxComputerInfo.SuspendLayout()
        Me.GrpBoxDriveData.SuspendLayout()
        Me.GrpBoxBackupRestore.SuspendLayout()
        Me.TabPageUserSettings.SuspendLayout()
        Me.GroupBoxDomainRedirection.SuspendLayout()
        Me.GrpBoxExcludeAccts.SuspendLayout()
        Me.GrpBoxIncludeAccts.SuspendLayout()
        Me.TabPageConfigO.SuspendLayout()
        Me.GrpBxEFSOptions.SuspendLayout()
        Me.GrpBxXMLFiles.SuspendLayout()
        Me.GroupBoxExtraDirectoriesInclusion.SuspendLayout()
        CType(Me.DataGridViewExtraDirInclude, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBxEFSRestore.SuspendLayout()
        Me.GrpBxEFSBackup.SuspendLayout()
        Me.GrpBxMonitoring.SuspendLayout()
        Me.GrpBxLogOptions.SuspendLayout()
        Me.GrpBxStorage.SuspendLayout()
        Me.TabPageDrives.SuspendLayout()
        Me.TabPagePSTFiles.SuspendLayout()
        Me.TabPageSysInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStripInfo
        '
        Me.StatusStripInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblComputerName2, Me.lbluserName, Me.lblblankSpacer, Me.lblclock})
        Me.StatusStripInfo.Location = New System.Drawing.Point(0, 623)
        Me.StatusStripInfo.Name = "StatusStripInfo"
        Me.StatusStripInfo.Size = New System.Drawing.Size(669, 24)
        Me.StatusStripInfo.TabIndex = 0
        Me.StatusStripInfo.Text = "StatusStripInfo"
        '
        'lblComputerName2
        '
        Me.lblComputerName2.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblComputerName2.Name = "lblComputerName2"
        Me.lblComputerName2.Size = New System.Drawing.Size(97, 19)
        Me.lblComputerName2.Text = "ComputerName"
        '
        'lbluserName
        '
        Me.lbluserName.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lbluserName.Name = "lbluserName"
        Me.lbluserName.Size = New System.Drawing.Size(66, 19)
        Me.lbluserName.Text = "UserName"
        '
        'lblblankSpacer
        '
        Me.lblblankSpacer.Name = "lblblankSpacer"
        Me.lblblankSpacer.Size = New System.Drawing.Size(450, 19)
        Me.lblblankSpacer.Spring = True
        '
        'lblclock
        '
        Me.lblclock.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblclock.Name = "lblclock"
        Me.lblclock.Size = New System.Drawing.Size(41, 19)
        Me.lblclock.Text = "Clock"
        '
        'DirectorySearcherGui
        '
        Me.DirectorySearcherGui.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcherGui.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcherGui.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'GroupBoxMyComputer
        '
        Me.GroupBoxMyComputer.Controls.Add(Me.LabelCurrentDirectory)
        Me.GroupBoxMyComputer.Controls.Add(Me.currentDirTextBox)
        Me.GroupBoxMyComputer.Controls.Add(Me.drivesDataGridView)
        Me.GroupBoxMyComputer.Controls.Add(Me.LabelDrives)
        Me.GroupBoxMyComputer.Location = New System.Drawing.Point(15, 10)
        Me.GroupBoxMyComputer.Name = "GroupBoxMyComputer"
        Me.GroupBoxMyComputer.Size = New System.Drawing.Size(634, 287)
        Me.GroupBoxMyComputer.TabIndex = 5
        Me.GroupBoxMyComputer.TabStop = False
        Me.GroupBoxMyComputer.Text = "My.Computer"
        '
        'LabelCurrentDirectory
        '
        Me.LabelCurrentDirectory.AutoSize = True
        Me.LabelCurrentDirectory.Location = New System.Drawing.Point(6, 22)
        Me.LabelCurrentDirectory.Name = "LabelCurrentDirectory"
        Me.LabelCurrentDirectory.Size = New System.Drawing.Size(87, 13)
        Me.LabelCurrentDirectory.TabIndex = 4
        Me.LabelCurrentDirectory.Text = "Current directory:"
        '
        'currentDirTextBox
        '
        Me.currentDirTextBox.Location = New System.Drawing.Point(100, 19)
        Me.currentDirTextBox.Name = "currentDirTextBox"
        Me.currentDirTextBox.Size = New System.Drawing.Size(493, 20)
        Me.currentDirTextBox.TabIndex = 3
        '
        'drivesDataGridView
        '
        Me.drivesDataGridView.Location = New System.Drawing.Point(7, 60)
        Me.drivesDataGridView.Name = "drivesDataGridView"
        Me.drivesDataGridView.Size = New System.Drawing.Size(621, 221)
        Me.drivesDataGridView.TabIndex = 5
        Me.drivesDataGridView.Text = "DataGridView1"
        '
        'LabelDrives
        '
        Me.LabelDrives.AutoSize = True
        Me.LabelDrives.Location = New System.Drawing.Point(17, 44)
        Me.LabelDrives.Name = "LabelDrives"
        Me.LabelDrives.Size = New System.Drawing.Size(40, 13)
        Me.LabelDrives.TabIndex = 2
        Me.LabelDrives.Text = "Drives:"
        '
        'TbCtrlMain
        '
        Me.TbCtrlMain.Controls.Add(Me.TabPageBackup)
        Me.TbCtrlMain.Controls.Add(Me.TabPageUserSettings)
        Me.TbCtrlMain.Controls.Add(Me.TabPageConfigO)
        Me.TbCtrlMain.Controls.Add(Me.TabPageDrives)
        Me.TbCtrlMain.Controls.Add(Me.TabPagePSTFiles)
        Me.TbCtrlMain.Controls.Add(Me.TabPageSysInfo)
        Me.TbCtrlMain.Location = New System.Drawing.Point(0, 10)
        Me.TbCtrlMain.Name = "TbCtrlMain"
        Me.TbCtrlMain.SelectedIndex = 0
        Me.TbCtrlMain.Size = New System.Drawing.Size(669, 536)
        Me.TbCtrlMain.TabIndex = 1
        '
        'TabPageBackup
        '
        Me.TabPageBackup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPageBackup.Controls.Add(Me.GroupBox1)
        Me.TabPageBackup.Controls.Add(Me.GroupBoxBuildXML)
        Me.TabPageBackup.Controls.Add(Me.GrpBoxSourceOS)
        Me.TabPageBackup.Controls.Add(Me.GrpBoxTargetOS)
        Me.TabPageBackup.Controls.Add(Me.GrpBoxCpuType)
        Me.TabPageBackup.Controls.Add(Me.GroupBoxComputerInfo)
        Me.TabPageBackup.Controls.Add(Me.GrpBoxDriveData)
        Me.TabPageBackup.Controls.Add(Me.GrpBoxBackupRestore)
        Me.TabPageBackup.Location = New System.Drawing.Point(4, 22)
        Me.TabPageBackup.Name = "TabPageBackup"
        Me.TabPageBackup.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageBackup.Size = New System.Drawing.Size(661, 510)
        Me.TabPageBackup.TabIndex = 2
        Me.TabPageBackup.Text = "Backup/Restore"
        Me.TabPageBackup.UseVisualStyleBackColor = True
        '
        'GroupBoxBuildXML
        '
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxSharedFavorites)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxSharedDesktop)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxSharedVideo)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxSharedMusic)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxSharedPictures)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxSharedDocuments)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxFavorites)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxMyDesktop)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxMyVideo)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxMyMusic)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxMyPictures)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxMyDocuments)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxDownloads)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxWallpapers)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxRecycleBin)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxPrinters)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxLocalAppData)
        Me.GroupBoxBuildXML.Controls.Add(Me.CheckBoxAppData)
        Me.GroupBoxBuildXML.Location = New System.Drawing.Point(290, 125)
        Me.GroupBoxBuildXML.Name = "GroupBoxBuildXML"
        Me.GroupBoxBuildXML.Size = New System.Drawing.Size(357, 162)
        Me.GroupBoxBuildXML.TabIndex = 58
        Me.GroupBoxBuildXML.TabStop = False
        Me.GroupBoxBuildXML.Text = "Build XML"
        '
        'CheckBoxSharedFavorites
        '
        Me.CheckBoxSharedFavorites.AutoSize = True
        Me.CheckBoxSharedFavorites.Location = New System.Drawing.Point(232, 140)
        Me.CheckBoxSharedFavorites.Name = "CheckBoxSharedFavorites"
        Me.CheckBoxSharedFavorites.Size = New System.Drawing.Size(106, 17)
        Me.CheckBoxSharedFavorites.TabIndex = 34
        Me.CheckBoxSharedFavorites.Text = "Shared Favorites"
        Me.CheckBoxSharedFavorites.UseVisualStyleBackColor = True
        '
        'CheckBoxSharedDesktop
        '
        Me.CheckBoxSharedDesktop.AutoSize = True
        Me.CheckBoxSharedDesktop.Location = New System.Drawing.Point(232, 117)
        Me.CheckBoxSharedDesktop.Name = "CheckBoxSharedDesktop"
        Me.CheckBoxSharedDesktop.Size = New System.Drawing.Size(103, 17)
        Me.CheckBoxSharedDesktop.TabIndex = 33
        Me.CheckBoxSharedDesktop.Text = "Shared Desktop"
        Me.CheckBoxSharedDesktop.UseVisualStyleBackColor = True
        '
        'CheckBoxSharedVideo
        '
        Me.CheckBoxSharedVideo.AutoSize = True
        Me.CheckBoxSharedVideo.Location = New System.Drawing.Point(232, 94)
        Me.CheckBoxSharedVideo.Name = "CheckBoxSharedVideo"
        Me.CheckBoxSharedVideo.Size = New System.Drawing.Size(90, 17)
        Me.CheckBoxSharedVideo.TabIndex = 32
        Me.CheckBoxSharedVideo.Text = "Shared Video"
        Me.CheckBoxSharedVideo.UseVisualStyleBackColor = True
        '
        'CheckBoxSharedMusic
        '
        Me.CheckBoxSharedMusic.AutoSize = True
        Me.CheckBoxSharedMusic.Location = New System.Drawing.Point(232, 71)
        Me.CheckBoxSharedMusic.Name = "CheckBoxSharedMusic"
        Me.CheckBoxSharedMusic.Size = New System.Drawing.Size(91, 17)
        Me.CheckBoxSharedMusic.TabIndex = 31
        Me.CheckBoxSharedMusic.Text = "Shared Music"
        Me.CheckBoxSharedMusic.UseVisualStyleBackColor = True
        '
        'CheckBoxSharedPictures
        '
        Me.CheckBoxSharedPictures.AutoSize = True
        Me.CheckBoxSharedPictures.Location = New System.Drawing.Point(232, 48)
        Me.CheckBoxSharedPictures.Name = "CheckBoxSharedPictures"
        Me.CheckBoxSharedPictures.Size = New System.Drawing.Size(101, 17)
        Me.CheckBoxSharedPictures.TabIndex = 30
        Me.CheckBoxSharedPictures.Text = "Shared Pictures"
        Me.CheckBoxSharedPictures.UseVisualStyleBackColor = True
        '
        'CheckBoxSharedDocuments
        '
        Me.CheckBoxSharedDocuments.AutoSize = True
        Me.CheckBoxSharedDocuments.Location = New System.Drawing.Point(232, 24)
        Me.CheckBoxSharedDocuments.Name = "CheckBoxSharedDocuments"
        Me.CheckBoxSharedDocuments.Size = New System.Drawing.Size(117, 17)
        Me.CheckBoxSharedDocuments.TabIndex = 29
        Me.CheckBoxSharedDocuments.Text = "Shared Documents"
        Me.CheckBoxSharedDocuments.UseVisualStyleBackColor = True
        '
        'CheckBoxFavorites
        '
        Me.CheckBoxFavorites.AutoSize = True
        Me.CheckBoxFavorites.Location = New System.Drawing.Point(129, 140)
        Me.CheckBoxFavorites.Name = "CheckBoxFavorites"
        Me.CheckBoxFavorites.Size = New System.Drawing.Size(69, 17)
        Me.CheckBoxFavorites.TabIndex = 28
        Me.CheckBoxFavorites.Text = "Favorites"
        Me.CheckBoxFavorites.UseVisualStyleBackColor = True
        '
        'CheckBoxMyDesktop
        '
        Me.CheckBoxMyDesktop.AutoSize = True
        Me.CheckBoxMyDesktop.Location = New System.Drawing.Point(129, 117)
        Me.CheckBoxMyDesktop.Name = "CheckBoxMyDesktop"
        Me.CheckBoxMyDesktop.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxMyDesktop.TabIndex = 27
        Me.CheckBoxMyDesktop.Text = "Desktop"
        Me.CheckBoxMyDesktop.UseVisualStyleBackColor = True
        '
        'CheckBoxMyVideo
        '
        Me.CheckBoxMyVideo.AutoSize = True
        Me.CheckBoxMyVideo.Location = New System.Drawing.Point(129, 94)
        Me.CheckBoxMyVideo.Name = "CheckBoxMyVideo"
        Me.CheckBoxMyVideo.Size = New System.Drawing.Size(70, 17)
        Me.CheckBoxMyVideo.TabIndex = 26
        Me.CheckBoxMyVideo.Text = "My Video"
        Me.CheckBoxMyVideo.UseVisualStyleBackColor = True
        '
        'CheckBoxMyMusic
        '
        Me.CheckBoxMyMusic.AutoSize = True
        Me.CheckBoxMyMusic.Location = New System.Drawing.Point(129, 71)
        Me.CheckBoxMyMusic.Name = "CheckBoxMyMusic"
        Me.CheckBoxMyMusic.Size = New System.Drawing.Size(71, 17)
        Me.CheckBoxMyMusic.TabIndex = 25
        Me.CheckBoxMyMusic.Text = "My Music"
        Me.CheckBoxMyMusic.UseVisualStyleBackColor = True
        '
        'CheckBoxMyPictures
        '
        Me.CheckBoxMyPictures.AutoSize = True
        Me.CheckBoxMyPictures.Location = New System.Drawing.Point(129, 48)
        Me.CheckBoxMyPictures.Name = "CheckBoxMyPictures"
        Me.CheckBoxMyPictures.Size = New System.Drawing.Size(81, 17)
        Me.CheckBoxMyPictures.TabIndex = 24
        Me.CheckBoxMyPictures.Text = "My Pictures"
        Me.CheckBoxMyPictures.UseVisualStyleBackColor = True
        '
        'CheckBoxMyDocuments
        '
        Me.CheckBoxMyDocuments.AutoSize = True
        Me.CheckBoxMyDocuments.Location = New System.Drawing.Point(129, 24)
        Me.CheckBoxMyDocuments.Name = "CheckBoxMyDocuments"
        Me.CheckBoxMyDocuments.Size = New System.Drawing.Size(97, 17)
        Me.CheckBoxMyDocuments.TabIndex = 23
        Me.CheckBoxMyDocuments.Text = "My Documents"
        Me.CheckBoxMyDocuments.UseVisualStyleBackColor = True
        '
        'CheckBoxDownloads
        '
        Me.CheckBoxDownloads.AutoSize = True
        Me.CheckBoxDownloads.Location = New System.Drawing.Point(19, 140)
        Me.CheckBoxDownloads.Name = "CheckBoxDownloads"
        Me.CheckBoxDownloads.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoxDownloads.TabIndex = 22
        Me.CheckBoxDownloads.Text = "Downloads"
        Me.CheckBoxDownloads.UseVisualStyleBackColor = True
        '
        'CheckBoxWallpapers
        '
        Me.CheckBoxWallpapers.AutoSize = True
        Me.CheckBoxWallpapers.Location = New System.Drawing.Point(19, 117)
        Me.CheckBoxWallpapers.Name = "CheckBoxWallpapers"
        Me.CheckBoxWallpapers.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoxWallpapers.TabIndex = 21
        Me.CheckBoxWallpapers.Text = "Wallpapers"
        Me.CheckBoxWallpapers.UseVisualStyleBackColor = True
        '
        'CheckBoxRecycleBin
        '
        Me.CheckBoxRecycleBin.AutoSize = True
        Me.CheckBoxRecycleBin.Location = New System.Drawing.Point(19, 94)
        Me.CheckBoxRecycleBin.Name = "CheckBoxRecycleBin"
        Me.CheckBoxRecycleBin.Size = New System.Drawing.Size(83, 17)
        Me.CheckBoxRecycleBin.TabIndex = 20
        Me.CheckBoxRecycleBin.Text = "Recycle Bin"
        Me.CheckBoxRecycleBin.UseVisualStyleBackColor = True
        '
        'CheckBoxPrinters
        '
        Me.CheckBoxPrinters.AutoSize = True
        Me.CheckBoxPrinters.Location = New System.Drawing.Point(19, 71)
        Me.CheckBoxPrinters.Name = "CheckBoxPrinters"
        Me.CheckBoxPrinters.Size = New System.Drawing.Size(61, 17)
        Me.CheckBoxPrinters.TabIndex = 19
        Me.CheckBoxPrinters.Text = "Printers"
        Me.CheckBoxPrinters.UseVisualStyleBackColor = True
        '
        'CheckBoxLocalAppData
        '
        Me.CheckBoxLocalAppData.AutoSize = True
        Me.CheckBoxLocalAppData.Location = New System.Drawing.Point(19, 48)
        Me.CheckBoxLocalAppData.Name = "CheckBoxLocalAppData"
        Me.CheckBoxLocalAppData.Size = New System.Drawing.Size(97, 17)
        Me.CheckBoxLocalAppData.TabIndex = 18
        Me.CheckBoxLocalAppData.Text = "Local AppData"
        Me.CheckBoxLocalAppData.UseVisualStyleBackColor = True
        '
        'CheckBoxAppData
        '
        Me.CheckBoxAppData.AutoSize = True
        Me.CheckBoxAppData.Location = New System.Drawing.Point(19, 24)
        Me.CheckBoxAppData.Name = "CheckBoxAppData"
        Me.CheckBoxAppData.Size = New System.Drawing.Size(68, 17)
        Me.CheckBoxAppData.TabIndex = 17
        Me.CheckBoxAppData.Text = "AppData"
        Me.CheckBoxAppData.UseVisualStyleBackColor = True
        '
        'GrpBoxSourceOS
        '
        Me.GrpBoxSourceOS.Controls.Add(Me.RdBtnSourceWin8)
        Me.GrpBoxSourceOS.Controls.Add(Me.RdBtnSourceWin7)
        Me.GrpBoxSourceOS.Controls.Add(Me.RdBtnSourceWin10)
        Me.GrpBoxSourceOS.Location = New System.Drawing.Point(130, 125)
        Me.GrpBoxSourceOS.Name = "GrpBoxSourceOS"
        Me.GrpBoxSourceOS.Size = New System.Drawing.Size(75, 107)
        Me.GrpBoxSourceOS.TabIndex = 56
        Me.GrpBoxSourceOS.TabStop = False
        Me.GrpBoxSourceOS.Text = "Source OS"
        '
        'RdBtnSourceWin8
        '
        Me.RdBtnSourceWin8.AutoSize = True
        Me.RdBtnSourceWin8.Location = New System.Drawing.Point(7, 54)
        Me.RdBtnSourceWin8.Name = "RdBtnSourceWin8"
        Me.RdBtnSourceWin8.Size = New System.Drawing.Size(50, 17)
        Me.RdBtnSourceWin8.TabIndex = 12
        Me.RdBtnSourceWin8.TabStop = True
        Me.RdBtnSourceWin8.Text = "Win8"
        Me.RdBtnSourceWin8.UseVisualStyleBackColor = True
        '
        'RdBtnSourceWin7
        '
        Me.RdBtnSourceWin7.AutoSize = True
        Me.RdBtnSourceWin7.Checked = True
        Me.RdBtnSourceWin7.Location = New System.Drawing.Point(7, 23)
        Me.RdBtnSourceWin7.Name = "RdBtnSourceWin7"
        Me.RdBtnSourceWin7.Size = New System.Drawing.Size(50, 17)
        Me.RdBtnSourceWin7.TabIndex = 11
        Me.RdBtnSourceWin7.TabStop = True
        Me.RdBtnSourceWin7.Text = "Win7"
        Me.RdBtnSourceWin7.UseVisualStyleBackColor = True
        '
        'RdBtnSourceWin10
        '
        Me.RdBtnSourceWin10.AutoSize = True
        Me.RdBtnSourceWin10.Location = New System.Drawing.Point(7, 83)
        Me.RdBtnSourceWin10.Name = "RdBtnSourceWin10"
        Me.RdBtnSourceWin10.Size = New System.Drawing.Size(56, 17)
        Me.RdBtnSourceWin10.TabIndex = 13
        Me.RdBtnSourceWin10.Text = "Win10"
        Me.RdBtnSourceWin10.UseVisualStyleBackColor = True
        '
        'GrpBoxTargetOS
        '
        Me.GrpBoxTargetOS.Controls.Add(Me.RdbtnTargetWin8)
        Me.GrpBoxTargetOS.Controls.Add(Me.RdBtnTargetWin7)
        Me.GrpBoxTargetOS.Controls.Add(Me.RdBtnTargetWin10)
        Me.GrpBoxTargetOS.Location = New System.Drawing.Point(210, 125)
        Me.GrpBoxTargetOS.Name = "GrpBoxTargetOS"
        Me.GrpBoxTargetOS.Size = New System.Drawing.Size(76, 107)
        Me.GrpBoxTargetOS.TabIndex = 57
        Me.GrpBoxTargetOS.TabStop = False
        Me.GrpBoxTargetOS.Text = "Target OS"
        '
        'RdbtnTargetWin8
        '
        Me.RdbtnTargetWin8.AutoSize = True
        Me.RdbtnTargetWin8.Location = New System.Drawing.Point(6, 54)
        Me.RdbtnTargetWin8.Name = "RdbtnTargetWin8"
        Me.RdbtnTargetWin8.Size = New System.Drawing.Size(50, 17)
        Me.RdbtnTargetWin8.TabIndex = 15
        Me.RdbtnTargetWin8.TabStop = True
        Me.RdbtnTargetWin8.Text = "Win8"
        Me.RdbtnTargetWin8.UseVisualStyleBackColor = True
        '
        'RdBtnTargetWin7
        '
        Me.RdBtnTargetWin7.AutoSize = True
        Me.RdBtnTargetWin7.Checked = True
        Me.RdBtnTargetWin7.Location = New System.Drawing.Point(6, 23)
        Me.RdBtnTargetWin7.Name = "RdBtnTargetWin7"
        Me.RdBtnTargetWin7.Size = New System.Drawing.Size(50, 17)
        Me.RdBtnTargetWin7.TabIndex = 14
        Me.RdBtnTargetWin7.TabStop = True
        Me.RdBtnTargetWin7.Text = "Win7"
        Me.RdBtnTargetWin7.UseVisualStyleBackColor = True
        '
        'RdBtnTargetWin10
        '
        Me.RdBtnTargetWin10.AutoSize = True
        Me.RdBtnTargetWin10.Location = New System.Drawing.Point(6, 83)
        Me.RdBtnTargetWin10.Name = "RdBtnTargetWin10"
        Me.RdBtnTargetWin10.Size = New System.Drawing.Size(56, 17)
        Me.RdBtnTargetWin10.TabIndex = 16
        Me.RdBtnTargetWin10.Text = "Win10"
        Me.RdBtnTargetWin10.UseVisualStyleBackColor = True
        '
        'GrpBoxCpuType
        '
        Me.GrpBoxCpuType.Controls.Add(Me.RdBtnx86)
        Me.GrpBoxCpuType.Controls.Add(Me.RdBtnAmd64)
        Me.GrpBoxCpuType.Location = New System.Drawing.Point(15, 236)
        Me.GrpBoxCpuType.Name = "GrpBoxCpuType"
        Me.GrpBoxCpuType.Size = New System.Drawing.Size(271, 51)
        Me.GrpBoxCpuType.TabIndex = 21
        Me.GrpBoxCpuType.TabStop = False
        Me.GrpBoxCpuType.Text = "CPU Type"
        '
        'RdBtnx86
        '
        Me.RdBtnx86.AutoSize = True
        Me.RdBtnx86.Checked = True
        Me.RdBtnx86.Location = New System.Drawing.Point(204, 18)
        Me.RdBtnx86.Name = "RdBtnx86"
        Me.RdBtnx86.Size = New System.Drawing.Size(42, 17)
        Me.RdBtnx86.TabIndex = 1
        Me.RdBtnx86.TabStop = True
        Me.RdBtnx86.Text = "x86"
        Me.RdBtnx86.UseVisualStyleBackColor = True
        '
        'RdBtnAmd64
        '
        Me.RdBtnAmd64.AutoSize = True
        Me.RdBtnAmd64.Location = New System.Drawing.Point(124, 18)
        Me.RdBtnAmd64.Name = "RdBtnAmd64"
        Me.RdBtnAmd64.Size = New System.Drawing.Size(64, 17)
        Me.RdBtnAmd64.TabIndex = 0
        Me.RdBtnAmd64.Text = "AMD 64"
        Me.RdBtnAmd64.UseVisualStyleBackColor = True
        '
        'GroupBoxComputerInfo
        '
        Me.GroupBoxComputerInfo.Controls.Add(Me.CheckBoxConnected)
        Me.GroupBoxComputerInfo.Controls.Add(Me.BtnTestConnection)
        Me.GroupBoxComputerInfo.Controls.Add(Me.LblIPAddress)
        Me.GroupBoxComputerInfo.Controls.Add(Me.LblCompName)
        Me.GroupBoxComputerInfo.Controls.Add(Me.LblNewComputer)
        Me.GroupBoxComputerInfo.Controls.Add(Me.LblOldComputer)
        Me.GroupBoxComputerInfo.Controls.Add(Me.TxtBoxNewIPAddress)
        Me.GroupBoxComputerInfo.Controls.Add(Me.TxtBoxOldIPAddress)
        Me.GroupBoxComputerInfo.Controls.Add(Me.TxtBoxNewComputer)
        Me.GroupBoxComputerInfo.Controls.Add(Me.TxtBoxOldComputer)
        Me.GroupBoxComputerInfo.Location = New System.Drawing.Point(15, 10)
        Me.GroupBoxComputerInfo.Name = "GroupBoxComputerInfo"
        Me.GroupBoxComputerInfo.Size = New System.Drawing.Size(632, 113)
        Me.GroupBoxComputerInfo.TabIndex = 54
        Me.GroupBoxComputerInfo.TabStop = False
        Me.GroupBoxComputerInfo.Text = "ComputerInfo"
        '
        'CheckBoxConnected
        '
        Me.CheckBoxConnected.AutoSize = True
        Me.CheckBoxConnected.Location = New System.Drawing.Point(504, 82)
        Me.CheckBoxConnected.Name = "CheckBoxConnected"
        Me.CheckBoxConnected.Size = New System.Drawing.Size(78, 17)
        Me.CheckBoxConnected.TabIndex = 8
        Me.CheckBoxConnected.Text = "Connected"
        Me.CheckBoxConnected.UseVisualStyleBackColor = True
        '
        'BtnTestConnection
        '
        Me.BtnTestConnection.Location = New System.Drawing.Point(504, 36)
        Me.BtnTestConnection.Name = "BtnTestConnection"
        Me.BtnTestConnection.Size = New System.Drawing.Size(118, 23)
        Me.BtnTestConnection.TabIndex = 4
        Me.BtnTestConnection.Text = "Test Connection"
        Me.BtnTestConnection.UseVisualStyleBackColor = True
        '
        'LblIPAddress
        '
        Me.LblIPAddress.AutoSize = True
        Me.LblIPAddress.Location = New System.Drawing.Point(330, 14)
        Me.LblIPAddress.Name = "LblIPAddress"
        Me.LblIPAddress.Size = New System.Drawing.Size(58, 13)
        Me.LblIPAddress.TabIndex = 7
        Me.LblIPAddress.Text = "IP Address"
        '
        'LblCompName
        '
        Me.LblCompName.AutoSize = True
        Me.LblCompName.Location = New System.Drawing.Point(105, 14)
        Me.LblCompName.Name = "LblCompName"
        Me.LblCompName.Size = New System.Drawing.Size(83, 13)
        Me.LblCompName.TabIndex = 6
        Me.LblCompName.Text = "Computer Name"
        '
        'LblNewComputer
        '
        Me.LblNewComputer.AutoSize = True
        Me.LblNewComputer.Location = New System.Drawing.Point(16, 72)
        Me.LblNewComputer.Name = "LblNewComputer"
        Me.LblNewComputer.Size = New System.Drawing.Size(77, 13)
        Me.LblNewComputer.TabIndex = 5
        Me.LblNewComputer.Text = "New Computer"
        '
        'LblOldComputer
        '
        Me.LblOldComputer.AutoSize = True
        Me.LblOldComputer.Location = New System.Drawing.Point(16, 36)
        Me.LblOldComputer.Name = "LblOldComputer"
        Me.LblOldComputer.Size = New System.Drawing.Size(71, 13)
        Me.LblOldComputer.TabIndex = 1
        Me.LblOldComputer.Text = "Old Computer"
        '
        'TxtBoxNewIPAddress
        '
        Me.TxtBoxNewIPAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxNewIPAddress.Location = New System.Drawing.Point(333, 72)
        Me.TxtBoxNewIPAddress.Name = "TxtBoxNewIPAddress"
        Me.TxtBoxNewIPAddress.Size = New System.Drawing.Size(141, 29)
        Me.TxtBoxNewIPAddress.TabIndex = 7
        '
        'TxtBoxOldIPAddress
        '
        Me.TxtBoxOldIPAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxOldIPAddress.Location = New System.Drawing.Point(333, 33)
        Me.TxtBoxOldIPAddress.Name = "TxtBoxOldIPAddress"
        Me.TxtBoxOldIPAddress.Size = New System.Drawing.Size(141, 29)
        Me.TxtBoxOldIPAddress.TabIndex = 3
        '
        'TxtBoxNewComputer
        '
        Me.TxtBoxNewComputer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBoxNewComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxNewComputer.Location = New System.Drawing.Point(107, 72)
        Me.TxtBoxNewComputer.Name = "TxtBoxNewComputer"
        Me.TxtBoxNewComputer.Size = New System.Drawing.Size(203, 29)
        Me.TxtBoxNewComputer.TabIndex = 6
        '
        'TxtBoxOldComputer
        '
        Me.TxtBoxOldComputer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBoxOldComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxOldComputer.Location = New System.Drawing.Point(107, 31)
        Me.TxtBoxOldComputer.Name = "TxtBoxOldComputer"
        Me.TxtBoxOldComputer.Size = New System.Drawing.Size(203, 29)
        Me.TxtBoxOldComputer.TabIndex = 2
        '
        'GrpBoxDriveData
        '
        Me.GrpBoxDriveData.Controls.Add(Me.CheckBoxNetworkDataDrive)
        Me.GrpBoxDriveData.Controls.Add(Me.TextBoxDataDrivePath)
        Me.GrpBoxDriveData.Controls.Add(Me.ChkBxLocalDataDrive)
        Me.GrpBoxDriveData.Controls.Add(Me.CmboBoxLocalDataDriveLetter)
        Me.GrpBoxDriveData.Controls.Add(Me.LblLocalDataShareDriveLetter)
        Me.GrpBoxDriveData.Location = New System.Drawing.Point(15, 293)
        Me.GrpBoxDriveData.Name = "GrpBoxDriveData"
        Me.GrpBoxDriveData.Size = New System.Drawing.Size(632, 100)
        Me.GrpBoxDriveData.TabIndex = 59
        Me.GrpBoxDriveData.TabStop = False
        Me.GrpBoxDriveData.Text = "Data Share"
        '
        'CheckBoxNetworkDataDrive
        '
        Me.CheckBoxNetworkDataDrive.AutoSize = True
        Me.CheckBoxNetworkDataDrive.Location = New System.Drawing.Point(183, 77)
        Me.CheckBoxNetworkDataDrive.Name = "CheckBoxNetworkDataDrive"
        Me.CheckBoxNetworkDataDrive.Size = New System.Drawing.Size(120, 17)
        Me.CheckBoxNetworkDataDrive.TabIndex = 39
        Me.CheckBoxNetworkDataDrive.Text = "Network Data Drive"
        Me.CheckBoxNetworkDataDrive.UseVisualStyleBackColor = True
        '
        'TextBoxDataDrivePath
        '
        Me.TextBoxDataDrivePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDataDrivePath.Location = New System.Drawing.Point(183, 42)
        Me.TextBoxDataDrivePath.Name = "TextBoxDataDrivePath"
        Me.TextBoxDataDrivePath.Size = New System.Drawing.Size(442, 29)
        Me.TextBoxDataDrivePath.TabIndex = 38
        '
        'CmboBoxUsmtDriveLetter
        '
        Me.CmboBoxUsmtDriveLetter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmboBoxUsmtDriveLetter.FormattingEnabled = True
        Me.CmboBoxUsmtDriveLetter.Items.AddRange(New Object() {"D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.CmboBoxUsmtDriveLetter.Location = New System.Drawing.Point(16, 41)
        Me.CmboBoxUsmtDriveLetter.Name = "CmboBoxUsmtDriveLetter"
        Me.CmboBoxUsmtDriveLetter.Size = New System.Drawing.Size(40, 33)
        Me.CmboBoxUsmtDriveLetter.TabIndex = 41
        '
        'ChkBxLocalDataDrive
        '
        Me.ChkBxLocalDataDrive.AutoSize = True
        Me.ChkBxLocalDataDrive.Location = New System.Drawing.Point(183, 20)
        Me.ChkBxLocalDataDrive.Name = "ChkBxLocalDataDrive"
        Me.ChkBxLocalDataDrive.Size = New System.Drawing.Size(106, 17)
        Me.ChkBxLocalDataDrive.TabIndex = 37
        Me.ChkBxLocalDataDrive.Text = "Local Data Drive"
        Me.ChkBxLocalDataDrive.UseVisualStyleBackColor = True
        '
        'LblMappedDriveLetterUsmt
        '
        Me.LblMappedDriveLetterUsmt.AutoSize = True
        Me.LblMappedDriveLetterUsmt.Location = New System.Drawing.Point(19, 25)
        Me.LblMappedDriveLetterUsmt.Name = "LblMappedDriveLetterUsmt"
        Me.LblMappedDriveLetterUsmt.Size = New System.Drawing.Size(115, 13)
        Me.LblMappedDriveLetterUsmt.TabIndex = 40
        Me.LblMappedDriveLetterUsmt.Text = "Local Log Drive Letter:"
        '
        'LblUncUSMTSharePath
        '
        Me.LblUncUSMTSharePath.AutoSize = True
        Me.LblUncUSMTSharePath.Location = New System.Drawing.Point(379, 21)
        Me.LblUncUSMTSharePath.Name = "LblUncUSMTSharePath"
        Me.LblUncUSMTSharePath.Size = New System.Drawing.Size(122, 13)
        Me.LblUncUSMTSharePath.TabIndex = 42
        Me.LblUncUSMTSharePath.Text = "UNC Path to Log Share:"
        '
        'txtBoxUsmtDrivePath
        '
        Me.txtBoxUsmtDrivePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxUsmtDrivePath.Location = New System.Drawing.Point(182, 41)
        Me.txtBoxUsmtDrivePath.Name = "txtBoxUsmtDrivePath"
        Me.txtBoxUsmtDrivePath.Size = New System.Drawing.Size(442, 29)
        Me.txtBoxUsmtDrivePath.TabIndex = 43
        '
        'CmboBoxLocalDataDriveLetter
        '
        Me.CmboBoxLocalDataDriveLetter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmboBoxLocalDataDriveLetter.FormattingEnabled = True
        Me.CmboBoxLocalDataDriveLetter.Items.AddRange(New Object() {"D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.CmboBoxLocalDataDriveLetter.Location = New System.Drawing.Point(16, 38)
        Me.CmboBoxLocalDataDriveLetter.Name = "CmboBoxLocalDataDriveLetter"
        Me.CmboBoxLocalDataDriveLetter.Size = New System.Drawing.Size(40, 33)
        Me.CmboBoxLocalDataDriveLetter.TabIndex = 36
        '
        'LblLocalDataShareDriveLetter
        '
        Me.LblLocalDataShareDriveLetter.AutoSize = True
        Me.LblLocalDataShareDriveLetter.Location = New System.Drawing.Point(19, 20)
        Me.LblLocalDataShareDriveLetter.Name = "LblLocalDataShareDriveLetter"
        Me.LblLocalDataShareDriveLetter.Size = New System.Drawing.Size(117, 13)
        Me.LblLocalDataShareDriveLetter.TabIndex = 35
        Me.LblLocalDataShareDriveLetter.Text = "Local Data Drive Letter"
        '
        'GrpBoxBackupRestore
        '
        Me.GrpBoxBackupRestore.Controls.Add(Me.RdBtnRestore)
        Me.GrpBoxBackupRestore.Controls.Add(Me.RdBtnBackup)
        Me.GrpBoxBackupRestore.Location = New System.Drawing.Point(15, 125)
        Me.GrpBoxBackupRestore.Name = "GrpBoxBackupRestore"
        Me.GrpBoxBackupRestore.Size = New System.Drawing.Size(111, 107)
        Me.GrpBoxBackupRestore.TabIndex = 55
        Me.GrpBoxBackupRestore.TabStop = False
        Me.GrpBoxBackupRestore.Text = "Backup/ Restore"
        '
        'RdBtnRestore
        '
        Me.RdBtnRestore.AutoSize = True
        Me.RdBtnRestore.Location = New System.Drawing.Point(13, 54)
        Me.RdBtnRestore.Name = "RdBtnRestore"
        Me.RdBtnRestore.Size = New System.Drawing.Size(62, 17)
        Me.RdBtnRestore.TabIndex = 10
        Me.RdBtnRestore.TabStop = True
        Me.RdBtnRestore.Text = "Restore"
        Me.RdBtnRestore.UseVisualStyleBackColor = True
        '
        'RdBtnBackup
        '
        Me.RdBtnBackup.AutoSize = True
        Me.RdBtnBackup.Checked = True
        Me.RdBtnBackup.Location = New System.Drawing.Point(13, 23)
        Me.RdBtnBackup.Name = "RdBtnBackup"
        Me.RdBtnBackup.Size = New System.Drawing.Size(62, 17)
        Me.RdBtnBackup.TabIndex = 9
        Me.RdBtnBackup.TabStop = True
        Me.RdBtnBackup.Text = "Backup"
        Me.RdBtnBackup.UseVisualStyleBackColor = True
        '
        'TabPageUserSettings
        '
        Me.TabPageUserSettings.Controls.Add(Me.CheckedListBoxLocalUsers)
        Me.TabPageUserSettings.Controls.Add(Me.lblIncludeAccts)
        Me.TabPageUserSettings.Controls.Add(Me.GroupBoxDomainRedirection)
        Me.TabPageUserSettings.Controls.Add(Me.ChklstbxUsersID)
        Me.TabPageUserSettings.Controls.Add(Me.GrpBoxExcludeAccts)
        Me.TabPageUserSettings.Controls.Add(Me.GrpBoxIncludeAccts)
        Me.TabPageUserSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabPageUserSettings.Name = "TabPageUserSettings"
        Me.TabPageUserSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUserSettings.Size = New System.Drawing.Size(661, 510)
        Me.TabPageUserSettings.TabIndex = 12
        Me.TabPageUserSettings.Text = "User Settings"
        Me.TabPageUserSettings.UseVisualStyleBackColor = True
        '
        'CheckedListBoxLocalUsers
        '
        Me.CheckedListBoxLocalUsers.FormattingEnabled = True
        Me.CheckedListBoxLocalUsers.Location = New System.Drawing.Point(181, 138)
        Me.CheckedListBoxLocalUsers.Name = "CheckedListBoxLocalUsers"
        Me.CheckedListBoxLocalUsers.Size = New System.Drawing.Size(155, 229)
        Me.CheckedListBoxLocalUsers.TabIndex = 22
        '
        'GroupBoxDomainRedirection
        '
        Me.GroupBoxDomainRedirection.Controls.Add(Me.LabelPassword)
        Me.GroupBoxDomainRedirection.Controls.Add(Me.TextBoxLacPassword)
        Me.GroupBoxDomainRedirection.Controls.Add(Me.CheckBoxLae)
        Me.GroupBoxDomainRedirection.Controls.Add(Me.CheckBoxLac)
        Me.GroupBoxDomainRedirection.Controls.Add(Me.LabelNewDomain)
        Me.GroupBoxDomainRedirection.Controls.Add(Me.LabelOldDomain)
        Me.GroupBoxDomainRedirection.Controls.Add(Me.TextBoxNewDomain)
        Me.GroupBoxDomainRedirection.Controls.Add(Me.TextBoxOldDomain)
        Me.GroupBoxDomainRedirection.Controls.Add(Me.CheckBoxMoveUser)
        Me.GroupBoxDomainRedirection.Controls.Add(Me.CheckBoxMoveDomain)
        Me.GroupBoxDomainRedirection.Location = New System.Drawing.Point(15, 373)
        Me.GroupBoxDomainRedirection.Name = "GroupBoxDomainRedirection"
        Me.GroupBoxDomainRedirection.Size = New System.Drawing.Size(321, 131)
        Me.GroupBoxDomainRedirection.TabIndex = 21
        Me.GroupBoxDomainRedirection.TabStop = False
        Me.GroupBoxDomainRedirection.Text = "Domain Redirection"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(120, 110)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(53, 13)
        Me.LabelPassword.TabIndex = 9
        Me.LabelPassword.Text = "Password"
        '
        'TextBoxLacPassword
        '
        Me.TextBoxLacPassword.Location = New System.Drawing.Point(179, 105)
        Me.TextBoxLacPassword.Name = "TextBoxLacPassword"
        Me.TextBoxLacPassword.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxLacPassword.TabIndex = 8
        '
        'CheckBoxLae
        '
        Me.CheckBoxLae.AutoSize = True
        Me.CheckBoxLae.Location = New System.Drawing.Point(16, 83)
        Me.CheckBoxLae.Name = "CheckBoxLae"
        Me.CheckBoxLae.Size = New System.Drawing.Size(49, 17)
        Me.CheckBoxLae.TabIndex = 7
        Me.CheckBoxLae.Text = "/Lae"
        Me.CheckBoxLae.UseVisualStyleBackColor = True
        '
        'CheckBoxLac
        '
        Me.CheckBoxLac.AutoSize = True
        Me.CheckBoxLac.Location = New System.Drawing.Point(16, 106)
        Me.CheckBoxLac.Name = "CheckBoxLac"
        Me.CheckBoxLac.Size = New System.Drawing.Size(49, 17)
        Me.CheckBoxLac.TabIndex = 6
        Me.CheckBoxLac.Text = "/Lac"
        Me.CheckBoxLac.UseVisualStyleBackColor = True
        '
        'LabelNewDomain
        '
        Me.LabelNewDomain.AutoSize = True
        Me.LabelNewDomain.Location = New System.Drawing.Point(111, 72)
        Me.LabelNewDomain.Name = "LabelNewDomain"
        Me.LabelNewDomain.Size = New System.Drawing.Size(68, 13)
        Me.LabelNewDomain.TabIndex = 5
        Me.LabelNewDomain.Text = "New Domain"
        '
        'LabelOldDomain
        '
        Me.LabelOldDomain.AutoSize = True
        Me.LabelOldDomain.Location = New System.Drawing.Point(117, 37)
        Me.LabelOldDomain.Name = "LabelOldDomain"
        Me.LabelOldDomain.Size = New System.Drawing.Size(62, 13)
        Me.LabelOldDomain.TabIndex = 4
        Me.LabelOldDomain.Text = "Old Domain"
        '
        'TextBoxNewDomain
        '
        Me.TextBoxNewDomain.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNewDomain.Location = New System.Drawing.Point(179, 56)
        Me.TextBoxNewDomain.Name = "TextBoxNewDomain"
        Me.TextBoxNewDomain.Size = New System.Drawing.Size(136, 29)
        Me.TextBoxNewDomain.TabIndex = 3
        '
        'TextBoxOldDomain
        '
        Me.TextBoxOldDomain.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOldDomain.Location = New System.Drawing.Point(179, 21)
        Me.TextBoxOldDomain.Name = "TextBoxOldDomain"
        Me.TextBoxOldDomain.Size = New System.Drawing.Size(136, 29)
        Me.TextBoxOldDomain.TabIndex = 2
        '
        'CheckBoxMoveUser
        '
        Me.CheckBoxMoveUser.AutoSize = True
        Me.CheckBoxMoveUser.Location = New System.Drawing.Point(16, 43)
        Me.CheckBoxMoveUser.Name = "CheckBoxMoveUser"
        Me.CheckBoxMoveUser.Size = New System.Drawing.Size(83, 17)
        Me.CheckBoxMoveUser.TabIndex = 1
        Me.CheckBoxMoveUser.Text = "/Move User"
        Me.CheckBoxMoveUser.UseVisualStyleBackColor = True
        '
        'CheckBoxMoveDomain
        '
        Me.CheckBoxMoveDomain.AutoSize = True
        Me.CheckBoxMoveDomain.Location = New System.Drawing.Point(16, 20)
        Me.CheckBoxMoveDomain.Name = "CheckBoxMoveDomain"
        Me.CheckBoxMoveDomain.Size = New System.Drawing.Size(97, 17)
        Me.CheckBoxMoveDomain.TabIndex = 0
        Me.CheckBoxMoveDomain.Text = "/Move Domain"
        Me.CheckBoxMoveDomain.UseVisualStyleBackColor = True
        '
        'ChklstbxUsersID
        '
        Me.ChklstbxUsersID.FormattingEnabled = True
        Me.ChklstbxUsersID.Location = New System.Drawing.Point(15, 138)
        Me.ChklstbxUsersID.Name = "ChklstbxUsersID"
        Me.ChklstbxUsersID.Size = New System.Drawing.Size(155, 229)
        Me.ChklstbxUsersID.TabIndex = 20
        '
        'GrpBoxExcludeAccts
        '
        Me.GrpBoxExcludeAccts.Controls.Add(Me.LblExcludeAccts)
        Me.GrpBoxExcludeAccts.Controls.Add(Me.ListBoxExcludeFilter)
        Me.GrpBoxExcludeAccts.Controls.Add(Me.ListBoxIncludeFilter)
        Me.GrpBoxExcludeAccts.Controls.Add(Me.TxtboxBackupDate)
        Me.GrpBoxExcludeAccts.Controls.Add(Me.RdBtnBackupDate)
        Me.GrpBoxExcludeAccts.Controls.Add(Me.RdBtnExcludeDomainAccts)
        Me.GrpBoxExcludeAccts.Controls.Add(Me.RdBtnExcludeAllAccts)
        Me.GrpBoxExcludeAccts.Controls.Add(Me.RdBtnExcludeLocalAccts)
        Me.GrpBoxExcludeAccts.Controls.Add(Me.txtBoxBackupDays)
        Me.GrpBoxExcludeAccts.Controls.Add(Me.RdBtnBackupDays)
        Me.GrpBoxExcludeAccts.Location = New System.Drawing.Point(342, 10)
        Me.GrpBoxExcludeAccts.Name = "GrpBoxExcludeAccts"
        Me.GrpBoxExcludeAccts.Size = New System.Drawing.Size(307, 494)
        Me.GrpBoxExcludeAccts.TabIndex = 18
        Me.GrpBoxExcludeAccts.TabStop = False
        Me.GrpBoxExcludeAccts.Text = "Exclude Accts"
        '
        'LblExcludeAccts
        '
        Me.LblExcludeAccts.AutoSize = True
        Me.LblExcludeAccts.Location = New System.Drawing.Point(123, 110)
        Me.LblExcludeAccts.Name = "LblExcludeAccts"
        Me.LblExcludeAccts.Size = New System.Drawing.Size(72, 13)
        Me.LblExcludeAccts.TabIndex = 25
        Me.LblExcludeAccts.Text = "ExcludeAccts"
        '
        'lblIncludeAccts
        '
        Me.lblIncludeAccts.AutoSize = True
        Me.lblIncludeAccts.Location = New System.Drawing.Point(148, 120)
        Me.lblIncludeAccts.Name = "lblIncludeAccts"
        Me.lblIncludeAccts.Size = New System.Drawing.Size(69, 13)
        Me.lblIncludeAccts.TabIndex = 4
        Me.lblIncludeAccts.Text = "IncludeAccts"
        '
        'ListBoxExcludeFilter
        '
        Me.ListBoxExcludeFilter.FormattingEnabled = True
        Me.ListBoxExcludeFilter.Location = New System.Drawing.Point(157, 126)
        Me.ListBoxExcludeFilter.Name = "ListBoxExcludeFilter"
        Me.ListBoxExcludeFilter.Size = New System.Drawing.Size(145, 225)
        Me.ListBoxExcludeFilter.TabIndex = 11
        '
        'ListBoxIncludeFilter
        '
        Me.ListBoxIncludeFilter.FormattingEnabled = True
        Me.ListBoxIncludeFilter.Location = New System.Drawing.Point(6, 126)
        Me.ListBoxIncludeFilter.Name = "ListBoxIncludeFilter"
        Me.ListBoxIncludeFilter.Size = New System.Drawing.Size(145, 225)
        Me.ListBoxIncludeFilter.TabIndex = 10
        '
        'TxtboxBackupDate
        '
        Me.TxtboxBackupDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtboxBackupDate.Location = New System.Drawing.Point(214, 442)
        Me.TxtboxBackupDate.Name = "TxtboxBackupDate"
        Me.TxtboxBackupDate.Size = New System.Drawing.Size(66, 26)
        Me.TxtboxBackupDate.TabIndex = 8
        '
        'RdBtnBackupDate
        '
        Me.RdBtnBackupDate.AutoSize = True
        Me.RdBtnBackupDate.Location = New System.Drawing.Point(48, 448)
        Me.RdBtnBackupDate.Name = "RdBtnBackupDate"
        Me.RdBtnBackupDate.Size = New System.Drawing.Size(104, 17)
        Me.RdBtnBackupDate.TabIndex = 7
        Me.RdBtnBackupDate.Text = "Last Logon Date"
        Me.RdBtnBackupDate.UseVisualStyleBackColor = True
        '
        'RdBtnExcludeDomainAccts
        '
        Me.RdBtnExcludeDomainAccts.AutoSize = True
        Me.RdBtnExcludeDomainAccts.Location = New System.Drawing.Point(37, 74)
        Me.RdBtnExcludeDomainAccts.Name = "RdBtnExcludeDomainAccts"
        Me.RdBtnExcludeDomainAccts.Size = New System.Drawing.Size(61, 17)
        Me.RdBtnExcludeDomainAccts.TabIndex = 5
        Me.RdBtnExcludeDomainAccts.Text = "Domain"
        Me.RdBtnExcludeDomainAccts.UseVisualStyleBackColor = True
        '
        'RdBtnExcludeAllAccts
        '
        Me.RdBtnExcludeAllAccts.AutoSize = True
        Me.RdBtnExcludeAllAccts.Checked = True
        Me.RdBtnExcludeAllAccts.Location = New System.Drawing.Point(37, 16)
        Me.RdBtnExcludeAllAccts.Name = "RdBtnExcludeAllAccts"
        Me.RdBtnExcludeAllAccts.Size = New System.Drawing.Size(36, 17)
        Me.RdBtnExcludeAllAccts.TabIndex = 4
        Me.RdBtnExcludeAllAccts.TabStop = True
        Me.RdBtnExcludeAllAccts.Text = "All"
        Me.RdBtnExcludeAllAccts.UseVisualStyleBackColor = True
        '
        'RdBtnExcludeLocalAccts
        '
        Me.RdBtnExcludeLocalAccts.AutoSize = True
        Me.RdBtnExcludeLocalAccts.Location = New System.Drawing.Point(37, 44)
        Me.RdBtnExcludeLocalAccts.Name = "RdBtnExcludeLocalAccts"
        Me.RdBtnExcludeLocalAccts.Size = New System.Drawing.Size(51, 17)
        Me.RdBtnExcludeLocalAccts.TabIndex = 3
        Me.RdBtnExcludeLocalAccts.Text = "Local"
        Me.RdBtnExcludeLocalAccts.UseVisualStyleBackColor = True
        '
        'txtBoxBackupDays
        '
        Me.txtBoxBackupDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxBackupDays.Location = New System.Drawing.Point(214, 410)
        Me.txtBoxBackupDays.Name = "txtBoxBackupDays"
        Me.txtBoxBackupDays.Size = New System.Drawing.Size(66, 26)
        Me.txtBoxBackupDays.TabIndex = 2
        '
        'RdBtnBackupDays
        '
        Me.RdBtnBackupDays.AutoSize = True
        Me.RdBtnBackupDays.Location = New System.Drawing.Point(48, 416)
        Me.RdBtnBackupDays.Name = "RdBtnBackupDays"
        Me.RdBtnBackupDays.Size = New System.Drawing.Size(105, 17)
        Me.RdBtnBackupDays.TabIndex = 1
        Me.RdBtnBackupDays.Text = "Last Logon Days"
        Me.RdBtnBackupDays.UseVisualStyleBackColor = True
        '
        'GrpBoxIncludeAccts
        '
        Me.GrpBoxIncludeAccts.Controls.Add(Me.RdBtnIncludeCurrentUser)
        Me.GrpBoxIncludeAccts.Controls.Add(Me.RdBtnIncludeSelectedlocalAccts)
        Me.GrpBoxIncludeAccts.Controls.Add(Me.rdbtnIncludeSelectedDomainAccts)
        Me.GrpBoxIncludeAccts.Controls.Add(Me.rdbtnIncludeDomainAccts)
        Me.GrpBoxIncludeAccts.Controls.Add(Me.rdbtnIncludeLocalAccts)
        Me.GrpBoxIncludeAccts.Controls.Add(Me.RdbtnIncludeAllAccts)
        Me.GrpBoxIncludeAccts.Location = New System.Drawing.Point(15, 10)
        Me.GrpBoxIncludeAccts.Name = "GrpBoxIncludeAccts"
        Me.GrpBoxIncludeAccts.Size = New System.Drawing.Size(321, 107)
        Me.GrpBoxIncludeAccts.TabIndex = 19
        Me.GrpBoxIncludeAccts.TabStop = False
        Me.GrpBoxIncludeAccts.Text = "Include Accts"
        '
        'RdBtnIncludeCurrentUser
        '
        Me.RdBtnIncludeCurrentUser.AutoSize = True
        Me.RdBtnIncludeCurrentUser.Location = New System.Drawing.Point(173, 16)
        Me.RdBtnIncludeCurrentUser.Name = "RdBtnIncludeCurrentUser"
        Me.RdBtnIncludeCurrentUser.Size = New System.Drawing.Size(84, 17)
        Me.RdBtnIncludeCurrentUser.TabIndex = 7
        Me.RdBtnIncludeCurrentUser.TabStop = True
        Me.RdBtnIncludeCurrentUser.Text = "Current Acct"
        Me.RdBtnIncludeCurrentUser.UseVisualStyleBackColor = True
        '
        'RdBtnIncludeSelectedlocalAccts
        '
        Me.RdBtnIncludeSelectedlocalAccts.AutoSize = True
        Me.RdBtnIncludeSelectedlocalAccts.Location = New System.Drawing.Point(173, 44)
        Me.RdBtnIncludeSelectedlocalAccts.Name = "RdBtnIncludeSelectedlocalAccts"
        Me.RdBtnIncludeSelectedlocalAccts.Size = New System.Drawing.Size(126, 17)
        Me.RdBtnIncludeSelectedlocalAccts.TabIndex = 6
        Me.RdBtnIncludeSelectedlocalAccts.TabStop = True
        Me.RdBtnIncludeSelectedlocalAccts.Text = "Selected Local Accts"
        Me.RdBtnIncludeSelectedlocalAccts.UseVisualStyleBackColor = True
        '
        'rdbtnIncludeSelectedDomainAccts
        '
        Me.rdbtnIncludeSelectedDomainAccts.AutoSize = True
        Me.rdbtnIncludeSelectedDomainAccts.Checked = True
        Me.rdbtnIncludeSelectedDomainAccts.Location = New System.Drawing.Point(173, 74)
        Me.rdbtnIncludeSelectedDomainAccts.Name = "rdbtnIncludeSelectedDomainAccts"
        Me.rdbtnIncludeSelectedDomainAccts.Size = New System.Drawing.Size(136, 17)
        Me.rdbtnIncludeSelectedDomainAccts.TabIndex = 3
        Me.rdbtnIncludeSelectedDomainAccts.TabStop = True
        Me.rdbtnIncludeSelectedDomainAccts.Text = "Selected Domain Accts"
        Me.rdbtnIncludeSelectedDomainAccts.UseVisualStyleBackColor = True
        '
        'rdbtnIncludeDomainAccts
        '
        Me.rdbtnIncludeDomainAccts.AutoSize = True
        Me.rdbtnIncludeDomainAccts.Location = New System.Drawing.Point(16, 74)
        Me.rdbtnIncludeDomainAccts.Name = "rdbtnIncludeDomainAccts"
        Me.rdbtnIncludeDomainAccts.Size = New System.Drawing.Size(91, 17)
        Me.rdbtnIncludeDomainAccts.TabIndex = 2
        Me.rdbtnIncludeDomainAccts.Text = "Domain Accts"
        Me.rdbtnIncludeDomainAccts.UseVisualStyleBackColor = True
        '
        'rdbtnIncludeLocalAccts
        '
        Me.rdbtnIncludeLocalAccts.AutoSize = True
        Me.rdbtnIncludeLocalAccts.Location = New System.Drawing.Point(16, 44)
        Me.rdbtnIncludeLocalAccts.Name = "rdbtnIncludeLocalAccts"
        Me.rdbtnIncludeLocalAccts.Size = New System.Drawing.Size(81, 17)
        Me.rdbtnIncludeLocalAccts.TabIndex = 1
        Me.rdbtnIncludeLocalAccts.Text = "Local Accts"
        Me.rdbtnIncludeLocalAccts.UseVisualStyleBackColor = True
        '
        'RdbtnIncludeAllAccts
        '
        Me.RdbtnIncludeAllAccts.AutoSize = True
        Me.RdbtnIncludeAllAccts.Location = New System.Drawing.Point(16, 16)
        Me.RdbtnIncludeAllAccts.Name = "RdbtnIncludeAllAccts"
        Me.RdbtnIncludeAllAccts.Size = New System.Drawing.Size(131, 17)
        Me.RdbtnIncludeAllAccts.TabIndex = 0
        Me.RdbtnIncludeAllAccts.Text = "All - Local and Domain"
        Me.RdbtnIncludeAllAccts.UseVisualStyleBackColor = True
        '
        'TabPageConfigO
        '
        Me.TabPageConfigO.Controls.Add(Me.GrpBxEFSOptions)
        Me.TabPageConfigO.Controls.Add(Me.GroupBoxFileExclusions)
        Me.TabPageConfigO.Controls.Add(Me.GroupBoxFileInclusions)
        Me.TabPageConfigO.Controls.Add(Me.GroupBoxExtraDirectoryExclusions)
        Me.TabPageConfigO.Controls.Add(Me.GrpBxXMLFiles)
        Me.TabPageConfigO.Controls.Add(Me.GroupBoxExtraDirectoriesInclusion)
        Me.TabPageConfigO.Controls.Add(Me.GrpBxEFSRestore)
        Me.TabPageConfigO.Controls.Add(Me.GrpBxEFSBackup)
        Me.TabPageConfigO.Controls.Add(Me.GrpBxMonitoring)
        Me.TabPageConfigO.Controls.Add(Me.GrpBxLogOptions)
        Me.TabPageConfigO.Controls.Add(Me.GrpBxStorage)
        Me.TabPageConfigO.Location = New System.Drawing.Point(4, 22)
        Me.TabPageConfigO.Name = "TabPageConfigO"
        Me.TabPageConfigO.Size = New System.Drawing.Size(661, 510)
        Me.TabPageConfigO.TabIndex = 7
        Me.TabPageConfigO.Text = "Config-O"
        Me.TabPageConfigO.UseVisualStyleBackColor = True
        '
        'GrpBxEFSOptions
        '
        Me.GrpBxEFSOptions.Controls.Add(Me.RadioButtonEFSHardlink)
        Me.GrpBxEFSOptions.Controls.Add(Me.RdoBtnEFSCopyRaw)
        Me.GrpBxEFSOptions.Controls.Add(Me.RdoBtnEFSDecrypt)
        Me.GrpBxEFSOptions.Controls.Add(Me.RdoBtnEFSSkip)
        Me.GrpBxEFSOptions.Controls.Add(Me.RdoBtnEFSAbort)
        Me.GrpBxEFSOptions.Controls.Add(Me.ChkBxEFS)
        Me.GrpBxEFSOptions.Location = New System.Drawing.Point(240, 200)
        Me.GrpBxEFSOptions.Name = "GrpBxEFSOptions"
        Me.GrpBxEFSOptions.Size = New System.Drawing.Size(210, 118)
        Me.GrpBxEFSOptions.TabIndex = 13
        Me.GrpBxEFSOptions.TabStop = False
        Me.GrpBxEFSOptions.Text = "EFS Options"
        '
        'RadioButtonEFSHardlink
        '
        Me.RadioButtonEFSHardlink.AutoSize = True
        Me.RadioButtonEFSHardlink.Location = New System.Drawing.Point(115, 67)
        Me.RadioButtonEFSHardlink.Name = "RadioButtonEFSHardlink"
        Me.RadioButtonEFSHardlink.Size = New System.Drawing.Size(68, 17)
        Me.RadioButtonEFSHardlink.TabIndex = 9
        Me.RadioButtonEFSHardlink.TabStop = True
        Me.RadioButtonEFSHardlink.Text = "HardLink"
        Me.RadioButtonEFSHardlink.UseVisualStyleBackColor = True
        '
        'RdoBtnEFSCopyRaw
        '
        Me.RdoBtnEFSCopyRaw.AutoSize = True
        Me.RdoBtnEFSCopyRaw.Location = New System.Drawing.Point(44, 88)
        Me.RdoBtnEFSCopyRaw.Name = "RdoBtnEFSCopyRaw"
        Me.RdoBtnEFSCopyRaw.Size = New System.Drawing.Size(71, 17)
        Me.RdoBtnEFSCopyRaw.TabIndex = 8
        Me.RdoBtnEFSCopyRaw.TabStop = True
        Me.RdoBtnEFSCopyRaw.Text = "CopyRaw"
        Me.RdoBtnEFSCopyRaw.UseVisualStyleBackColor = True
        '
        'RdoBtnEFSDecrypt
        '
        Me.RdoBtnEFSDecrypt.AutoSize = True
        Me.RdoBtnEFSDecrypt.Location = New System.Drawing.Point(115, 42)
        Me.RdoBtnEFSDecrypt.Name = "RdoBtnEFSDecrypt"
        Me.RdoBtnEFSDecrypt.Size = New System.Drawing.Size(86, 17)
        Me.RdoBtnEFSDecrypt.TabIndex = 7
        Me.RdoBtnEFSDecrypt.TabStop = True
        Me.RdoBtnEFSDecrypt.Text = "DecryptCopy"
        Me.RdoBtnEFSDecrypt.UseVisualStyleBackColor = True
        '
        'RdoBtnEFSSkip
        '
        Me.RdoBtnEFSSkip.AutoSize = True
        Me.RdoBtnEFSSkip.Location = New System.Drawing.Point(44, 67)
        Me.RdoBtnEFSSkip.Name = "RdoBtnEFSSkip"
        Me.RdoBtnEFSSkip.Size = New System.Drawing.Size(46, 17)
        Me.RdoBtnEFSSkip.TabIndex = 6
        Me.RdoBtnEFSSkip.TabStop = True
        Me.RdoBtnEFSSkip.Text = "Skip"
        Me.RdoBtnEFSSkip.UseVisualStyleBackColor = True
        '
        'RdoBtnEFSAbort
        '
        Me.RdoBtnEFSAbort.AutoSize = True
        Me.RdoBtnEFSAbort.Location = New System.Drawing.Point(44, 43)
        Me.RdoBtnEFSAbort.Name = "RdoBtnEFSAbort"
        Me.RdoBtnEFSAbort.Size = New System.Drawing.Size(50, 17)
        Me.RdoBtnEFSAbort.TabIndex = 5
        Me.RdoBtnEFSAbort.TabStop = True
        Me.RdoBtnEFSAbort.Text = "Abort"
        Me.RdoBtnEFSAbort.UseVisualStyleBackColor = True
        '
        'ChkBxEFS
        '
        Me.ChkBxEFS.AutoSize = True
        Me.ChkBxEFS.Location = New System.Drawing.Point(16, 19)
        Me.ChkBxEFS.Name = "ChkBxEFS"
        Me.ChkBxEFS.Size = New System.Drawing.Size(51, 17)
        Me.ChkBxEFS.TabIndex = 4
        Me.ChkBxEFS.Text = "/EFS"
        Me.ChkBxEFS.UseVisualStyleBackColor = True
        '
        'GroupBoxFileExclusions
        '
        Me.GroupBoxFileExclusions.Location = New System.Drawing.Point(163, 10)
        Me.GroupBoxFileExclusions.Name = "GroupBoxFileExclusions"
        Me.GroupBoxFileExclusions.Size = New System.Drawing.Size(144, 184)
        Me.GroupBoxFileExclusions.TabIndex = 25
        Me.GroupBoxFileExclusions.TabStop = False
        Me.GroupBoxFileExclusions.Text = "File Exclusions"
        '
        'GroupBoxFileInclusions
        '
        Me.GroupBoxFileInclusions.Location = New System.Drawing.Point(15, 10)
        Me.GroupBoxFileInclusions.Name = "GroupBoxFileInclusions"
        Me.GroupBoxFileInclusions.Size = New System.Drawing.Size(144, 184)
        Me.GroupBoxFileInclusions.TabIndex = 24
        Me.GroupBoxFileInclusions.TabStop = False
        Me.GroupBoxFileInclusions.Text = "File Inclusions"
        '
        'GroupBoxExtraDirectoryExclusions
        '
        Me.GroupBoxExtraDirectoryExclusions.Location = New System.Drawing.Point(505, 10)
        Me.GroupBoxExtraDirectoryExclusions.Name = "GroupBoxExtraDirectoryExclusions"
        Me.GroupBoxExtraDirectoryExclusions.Size = New System.Drawing.Size(144, 184)
        Me.GroupBoxExtraDirectoryExclusions.TabIndex = 23
        Me.GroupBoxExtraDirectoryExclusions.TabStop = False
        Me.GroupBoxExtraDirectoryExclusions.Text = "Extra Dir Exclusions"
        '
        'GrpBxXMLFiles
        '
        Me.GrpBxXMLFiles.Controls.Add(Me.CheckBoxCust3XML)
        Me.GrpBxXMLFiles.Controls.Add(Me.CheckBoxCust2XML)
        Me.GrpBxXMLFiles.Controls.Add(Me.CheckBoxCust1XML)
        Me.GrpBxXMLFiles.Controls.Add(Me.CheckBoxMigDocs)
        Me.GrpBxXMLFiles.Controls.Add(Me.CheckBoxMigUser)
        Me.GrpBxXMLFiles.Controls.Add(Me.CheckBoxExcludeSysFolders)
        Me.GrpBxXMLFiles.Controls.Add(Me.ChkbxConfig)
        Me.GrpBxXMLFiles.Controls.Add(Me.ChkbxCustApps)
        Me.GrpBxXMLFiles.Controls.Add(Me.ChkBxNetworkPrn)
        Me.GrpBxXMLFiles.Controls.Add(Me.CheckBoxExcludeDrives)
        Me.GrpBxXMLFiles.Controls.Add(Me.ChkBxCustUsers)
        Me.GrpBxXMLFiles.Controls.Add(Me.ChkBxMigApp)
        Me.GrpBxXMLFiles.Location = New System.Drawing.Point(15, 200)
        Me.GrpBxXMLFiles.Name = "GrpBxXMLFiles"
        Me.GrpBxXMLFiles.Size = New System.Drawing.Size(219, 159)
        Me.GrpBxXMLFiles.TabIndex = 22
        Me.GrpBxXMLFiles.TabStop = False
        Me.GrpBxXMLFiles.Text = "XML Files"
        '
        'CheckBoxCust3XML
        '
        Me.CheckBoxCust3XML.AutoSize = True
        Me.CheckBoxCust3XML.Location = New System.Drawing.Point(16, 112)
        Me.CheckBoxCust3XML.Name = "CheckBoxCust3XML"
        Me.CheckBoxCust3XML.Size = New System.Drawing.Size(67, 17)
        Me.CheckBoxCust3XML.TabIndex = 16
        Me.CheckBoxCust3XML.Text = "Custom3"
        Me.CheckBoxCust3XML.UseVisualStyleBackColor = True
        '
        'CheckBoxCust2XML
        '
        Me.CheckBoxCust2XML.AutoSize = True
        Me.CheckBoxCust2XML.Location = New System.Drawing.Point(107, 89)
        Me.CheckBoxCust2XML.Name = "CheckBoxCust2XML"
        Me.CheckBoxCust2XML.Size = New System.Drawing.Size(67, 17)
        Me.CheckBoxCust2XML.TabIndex = 15
        Me.CheckBoxCust2XML.Text = "Custom2"
        Me.CheckBoxCust2XML.UseVisualStyleBackColor = True
        '
        'CheckBoxCust1XML
        '
        Me.CheckBoxCust1XML.AutoSize = True
        Me.CheckBoxCust1XML.Location = New System.Drawing.Point(16, 89)
        Me.CheckBoxCust1XML.Name = "CheckBoxCust1XML"
        Me.CheckBoxCust1XML.Size = New System.Drawing.Size(67, 17)
        Me.CheckBoxCust1XML.TabIndex = 14
        Me.CheckBoxCust1XML.Text = "Custom1"
        Me.CheckBoxCust1XML.UseVisualStyleBackColor = True
        '
        'CheckBoxMigDocs
        '
        Me.CheckBoxMigDocs.AutoSize = True
        Me.CheckBoxMigDocs.Location = New System.Drawing.Point(16, 44)
        Me.CheckBoxMigDocs.Name = "CheckBoxMigDocs"
        Me.CheckBoxMigDocs.Size = New System.Drawing.Size(68, 17)
        Me.CheckBoxMigDocs.TabIndex = 13
        Me.CheckBoxMigDocs.Text = "MigDocs"
        Me.CheckBoxMigDocs.UseVisualStyleBackColor = True
        '
        'CheckBoxMigUser
        '
        Me.CheckBoxMigUser.AutoSize = True
        Me.CheckBoxMigUser.Location = New System.Drawing.Point(16, 67)
        Me.CheckBoxMigUser.Name = "CheckBoxMigUser"
        Me.CheckBoxMigUser.Size = New System.Drawing.Size(65, 17)
        Me.CheckBoxMigUser.TabIndex = 12
        Me.CheckBoxMigUser.Text = "MigUser"
        Me.CheckBoxMigUser.UseVisualStyleBackColor = True
        '
        'CheckBoxExcludeSysFolders
        '
        Me.CheckBoxExcludeSysFolders.AutoSize = True
        Me.CheckBoxExcludeSysFolders.Location = New System.Drawing.Point(107, 135)
        Me.CheckBoxExcludeSysFolders.Name = "CheckBoxExcludeSysFolders"
        Me.CheckBoxExcludeSysFolders.Size = New System.Drawing.Size(103, 17)
        Me.CheckBoxExcludeSysFolders.TabIndex = 11
        Me.CheckBoxExcludeSysFolders.Text = "Excl Sys Folders"
        Me.CheckBoxExcludeSysFolders.UseVisualStyleBackColor = True
        '
        'ChkbxConfig
        '
        Me.ChkbxConfig.AutoSize = True
        Me.ChkbxConfig.Location = New System.Drawing.Point(108, 112)
        Me.ChkbxConfig.Name = "ChkbxConfig"
        Me.ChkbxConfig.Size = New System.Drawing.Size(56, 17)
        Me.ChkbxConfig.TabIndex = 8
        Me.ChkbxConfig.Text = "Config"
        Me.ChkbxConfig.UseVisualStyleBackColor = True
        '
        'ChkbxCustApps
        '
        Me.ChkbxCustApps.AutoSize = True
        Me.ChkbxCustApps.Location = New System.Drawing.Point(108, 23)
        Me.ChkbxCustApps.Name = "ChkbxCustApps"
        Me.ChkbxCustApps.Size = New System.Drawing.Size(71, 17)
        Me.ChkbxCustApps.TabIndex = 6
        Me.ChkbxCustApps.Text = "CustApps"
        Me.ChkbxCustApps.UseVisualStyleBackColor = True
        '
        'ChkBxNetworkPrn
        '
        Me.ChkBxNetworkPrn.AutoSize = True
        Me.ChkBxNetworkPrn.Location = New System.Drawing.Point(107, 44)
        Me.ChkBxNetworkPrn.Name = "ChkBxNetworkPrn"
        Me.ChkBxNetworkPrn.Size = New System.Drawing.Size(82, 17)
        Me.ChkBxNetworkPrn.TabIndex = 5
        Me.ChkBxNetworkPrn.Text = "NetworkPrn"
        Me.ChkBxNetworkPrn.UseVisualStyleBackColor = True
        '
        'CheckBoxExcludeDrives
        '
        Me.CheckBoxExcludeDrives.AutoSize = True
        Me.CheckBoxExcludeDrives.Location = New System.Drawing.Point(16, 135)
        Me.CheckBoxExcludeDrives.Name = "CheckBoxExcludeDrives"
        Me.CheckBoxExcludeDrives.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoxExcludeDrives.TabIndex = 4
        Me.CheckBoxExcludeDrives.Text = "Excl Drives"
        Me.CheckBoxExcludeDrives.UseVisualStyleBackColor = True
        '
        'ChkBxCustUsers
        '
        Me.ChkBxCustUsers.AutoSize = True
        Me.ChkBxCustUsers.Location = New System.Drawing.Point(108, 67)
        Me.ChkBxCustUsers.Name = "ChkBxCustUsers"
        Me.ChkBxCustUsers.Size = New System.Drawing.Size(69, 17)
        Me.ChkBxCustUsers.TabIndex = 3
        Me.ChkBxCustUsers.Text = "CustUser"
        Me.ChkBxCustUsers.UseVisualStyleBackColor = True
        '
        'ChkBxMigApp
        '
        Me.ChkBxMigApp.AutoSize = True
        Me.ChkBxMigApp.Location = New System.Drawing.Point(16, 23)
        Me.ChkBxMigApp.Name = "ChkBxMigApp"
        Me.ChkBxMigApp.Size = New System.Drawing.Size(62, 17)
        Me.ChkBxMigApp.TabIndex = 0
        Me.ChkBxMigApp.Text = "MigApp"
        Me.ChkBxMigApp.UseVisualStyleBackColor = True
        '
        'GroupBoxExtraDirectoriesInclusion
        '
        Me.GroupBoxExtraDirectoriesInclusion.Controls.Add(Me.DataGridViewExtraDirInclude)
        Me.GroupBoxExtraDirectoriesInclusion.Location = New System.Drawing.Point(349, 11)
        Me.GroupBoxExtraDirectoriesInclusion.Name = "GroupBoxExtraDirectoriesInclusion"
        Me.GroupBoxExtraDirectoriesInclusion.Size = New System.Drawing.Size(144, 184)
        Me.GroupBoxExtraDirectoriesInclusion.TabIndex = 21
        Me.GroupBoxExtraDirectoriesInclusion.TabStop = False
        Me.GroupBoxExtraDirectoriesInclusion.Text = "Extra Dir Inclusions"
        '
        'DataGridViewExtraDirInclude
        '
        Me.DataGridViewExtraDirInclude.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewExtraDirInclude.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewExtraDirInclude.Name = "DataGridViewExtraDirInclude"
        Me.DataGridViewExtraDirInclude.Size = New System.Drawing.Size(132, 153)
        Me.DataGridViewExtraDirInclude.TabIndex = 18
        '
        'GrpBxEFSRestore
        '
        Me.GrpBxEFSRestore.Controls.Add(Me.ComboBoxDecryptStrength)
        Me.GrpBxEFSRestore.Controls.Add(Me.lblDecryptKeystring)
        Me.GrpBxEFSRestore.Controls.Add(Me.TxtBxEFSRestoreKey)
        Me.GrpBxEFSRestore.Controls.Add(Me.ChkBxEFSRestoreKey)
        Me.GrpBxEFSRestore.Location = New System.Drawing.Point(240, 415)
        Me.GrpBxEFSRestore.Name = "GrpBxEFSRestore"
        Me.GrpBxEFSRestore.Size = New System.Drawing.Size(210, 85)
        Me.GrpBxEFSRestore.TabIndex = 15
        Me.GrpBxEFSRestore.TabStop = False
        Me.GrpBxEFSRestore.Text = "EFS Restore Options"
        '
        'ComboBoxDecryptStrength
        '
        Me.ComboBoxDecryptStrength.FormattingEnabled = True
        Me.ComboBoxDecryptStrength.Items.AddRange(New Object() {"AES", "AES_128", "AES_192", "AES_256", "3DES", "3DES_112"})
        Me.ComboBoxDecryptStrength.Location = New System.Drawing.Point(130, 19)
        Me.ComboBoxDecryptStrength.Name = "ComboBoxDecryptStrength"
        Me.ComboBoxDecryptStrength.Size = New System.Drawing.Size(69, 21)
        Me.ComboBoxDecryptStrength.TabIndex = 3
        '
        'lblDecryptKeystring
        '
        Me.lblDecryptKeystring.AutoSize = True
        Me.lblDecryptKeystring.Location = New System.Drawing.Point(11, 39)
        Me.lblDecryptKeystring.Name = "lblDecryptKeystring"
        Me.lblDecryptKeystring.Size = New System.Drawing.Size(50, 13)
        Me.lblDecryptKeystring.TabIndex = 2
        Me.lblDecryptKeystring.Text = "Keystring"
        '
        'TxtBxEFSRestoreKey
        '
        Me.TxtBxEFSRestoreKey.Location = New System.Drawing.Point(9, 56)
        Me.TxtBxEFSRestoreKey.Name = "TxtBxEFSRestoreKey"
        Me.TxtBxEFSRestoreKey.Size = New System.Drawing.Size(190, 20)
        Me.TxtBxEFSRestoreKey.TabIndex = 1
        '
        'ChkBxEFSRestoreKey
        '
        Me.ChkBxEFSRestoreKey.AutoSize = True
        Me.ChkBxEFSRestoreKey.Location = New System.Drawing.Point(14, 19)
        Me.ChkBxEFSRestoreKey.Name = "ChkBxEFSRestoreKey"
        Me.ChkBxEFSRestoreKey.Size = New System.Drawing.Size(94, 17)
        Me.ChkBxEFSRestoreKey.TabIndex = 0
        Me.ChkBxEFSRestoreKey.Text = "/Decrypt /Key"
        Me.ChkBxEFSRestoreKey.UseVisualStyleBackColor = True
        '
        'GrpBxEFSBackup
        '
        Me.GrpBxEFSBackup.Controls.Add(Me.ComboBoxEncryptStrength)
        Me.GrpBxEFSBackup.Controls.Add(Me.lblEncryptKey)
        Me.GrpBxEFSBackup.Controls.Add(Me.TxtBxEfsBackupKey)
        Me.GrpBxEFSBackup.Controls.Add(Me.ChkBxEFSBackupKey)
        Me.GrpBxEFSBackup.Location = New System.Drawing.Point(239, 324)
        Me.GrpBxEFSBackup.Name = "GrpBxEFSBackup"
        Me.GrpBxEFSBackup.Size = New System.Drawing.Size(210, 85)
        Me.GrpBxEFSBackup.TabIndex = 14
        Me.GrpBxEFSBackup.TabStop = False
        Me.GrpBxEFSBackup.Text = "EFS Backup Options"
        '
        'ComboBoxEncryptStrength
        '
        Me.ComboBoxEncryptStrength.FormattingEnabled = True
        Me.ComboBoxEncryptStrength.Items.AddRange(New Object() {"AES", "AES_128", "AES_192", "AES_256", "3DES", "3DES_112"})
        Me.ComboBoxEncryptStrength.Location = New System.Drawing.Point(130, 18)
        Me.ComboBoxEncryptStrength.Name = "ComboBoxEncryptStrength"
        Me.ComboBoxEncryptStrength.Size = New System.Drawing.Size(69, 21)
        Me.ComboBoxEncryptStrength.TabIndex = 3
        '
        'lblEncryptKey
        '
        Me.lblEncryptKey.AutoSize = True
        Me.lblEncryptKey.Location = New System.Drawing.Point(14, 42)
        Me.lblEncryptKey.Name = "lblEncryptKey"
        Me.lblEncryptKey.Size = New System.Drawing.Size(50, 13)
        Me.lblEncryptKey.TabIndex = 2
        Me.lblEncryptKey.Text = "Keystring"
        '
        'TxtBxEfsBackupKey
        '
        Me.TxtBxEfsBackupKey.Location = New System.Drawing.Point(9, 58)
        Me.TxtBxEfsBackupKey.Name = "TxtBxEfsBackupKey"
        Me.TxtBxEfsBackupKey.Size = New System.Drawing.Size(190, 20)
        Me.TxtBxEfsBackupKey.TabIndex = 1
        '
        'ChkBxEFSBackupKey
        '
        Me.ChkBxEFSBackupKey.AutoSize = True
        Me.ChkBxEFSBackupKey.Location = New System.Drawing.Point(19, 22)
        Me.ChkBxEFSBackupKey.Name = "ChkBxEFSBackupKey"
        Me.ChkBxEFSBackupKey.Size = New System.Drawing.Size(93, 17)
        Me.ChkBxEFSBackupKey.TabIndex = 0
        Me.ChkBxEFSBackupKey.Text = "/Encrypt /Key"
        Me.ChkBxEFSBackupKey.UseVisualStyleBackColor = True
        '
        'GrpBxMonitoring
        '
        Me.GrpBxMonitoring.Controls.Add(Me.ChkBxListFiles)
        Me.GrpBxMonitoring.Controls.Add(Me.CmboBxWait)
        Me.GrpBxMonitoring.Controls.Add(Me.CmboBxRetrys)
        Me.GrpBxMonitoring.Controls.Add(Me.ChkBxSpaceEst)
        Me.GrpBxMonitoring.Controls.Add(Me.ChkBxContinue)
        Me.GrpBxMonitoring.Controls.Add(Me.ChkBxWait)
        Me.GrpBxMonitoring.Controls.Add(Me.ChkBxRetry)
        Me.GrpBxMonitoring.Location = New System.Drawing.Point(455, 325)
        Me.GrpBxMonitoring.Name = "GrpBxMonitoring"
        Me.GrpBxMonitoring.Size = New System.Drawing.Size(194, 175)
        Me.GrpBxMonitoring.TabIndex = 12
        Me.GrpBxMonitoring.TabStop = False
        Me.GrpBxMonitoring.Text = "Monitoring Options"
        '
        'ChkBxListFiles
        '
        Me.ChkBxListFiles.AutoSize = True
        Me.ChkBxListFiles.Location = New System.Drawing.Point(13, 148)
        Me.ChkBxListFiles.Name = "ChkBxListFiles"
        Me.ChkBxListFiles.Size = New System.Drawing.Size(68, 17)
        Me.ChkBxListFiles.TabIndex = 8
        Me.ChkBxListFiles.Text = "/ListFiles"
        Me.ChkBxListFiles.UseVisualStyleBackColor = True
        '
        'CmboBxWait
        '
        Me.CmboBxWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmboBxWait.FormattingEnabled = True
        Me.CmboBxWait.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CmboBxWait.Location = New System.Drawing.Point(129, 90)
        Me.CmboBxWait.Name = "CmboBxWait"
        Me.CmboBxWait.Size = New System.Drawing.Size(52, 28)
        Me.CmboBxWait.TabIndex = 7
        '
        'CmboBxRetrys
        '
        Me.CmboBxRetrys.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmboBxRetrys.FormattingEnabled = True
        Me.CmboBxRetrys.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CmboBxRetrys.Location = New System.Drawing.Point(129, 38)
        Me.CmboBxRetrys.Name = "CmboBxRetrys"
        Me.CmboBxRetrys.Size = New System.Drawing.Size(52, 28)
        Me.CmboBxRetrys.TabIndex = 6
        '
        'ChkBxSpaceEst
        '
        Me.ChkBxSpaceEst.AutoSize = True
        Me.ChkBxSpaceEst.Location = New System.Drawing.Point(13, 125)
        Me.ChkBxSpaceEst.Name = "ChkBxSpaceEst"
        Me.ChkBxSpaceEst.Size = New System.Drawing.Size(83, 17)
        Me.ChkBxSpaceEst.TabIndex = 5
        Me.ChkBxSpaceEst.Text = "/Space Est."
        Me.ChkBxSpaceEst.UseVisualStyleBackColor = True
        '
        'ChkBxContinue
        '
        Me.ChkBxContinue.AutoSize = True
        Me.ChkBxContinue.Location = New System.Drawing.Point(13, 22)
        Me.ChkBxContinue.Name = "ChkBxContinue"
        Me.ChkBxContinue.Size = New System.Drawing.Size(115, 17)
        Me.ChkBxContinue.TabIndex = 4
        Me.ChkBxContinue.Text = "/Continue On Error"
        Me.ChkBxContinue.UseVisualStyleBackColor = True
        '
        'ChkBxWait
        '
        Me.ChkBxWait.AutoSize = True
        Me.ChkBxWait.Location = New System.Drawing.Point(13, 102)
        Me.ChkBxWait.Name = "ChkBxWait"
        Me.ChkBxWait.Size = New System.Drawing.Size(76, 17)
        Me.ChkBxWait.TabIndex = 3
        Me.ChkBxWait.Text = "/Wait sec."
        Me.ChkBxWait.UseVisualStyleBackColor = True
        '
        'ChkBxRetry
        '
        Me.ChkBxRetry.AutoSize = True
        Me.ChkBxRetry.Location = New System.Drawing.Point(13, 49)
        Me.ChkBxRetry.Name = "ChkBxRetry"
        Me.ChkBxRetry.Size = New System.Drawing.Size(94, 17)
        Me.ChkBxRetry.TabIndex = 2
        Me.ChkBxRetry.Text = "/Time to Retry"
        Me.ChkBxRetry.UseVisualStyleBackColor = True
        '
        'GrpBxLogOptions
        '
        Me.GrpBxLogOptions.Controls.Add(Me.ChkbxEnabeBareTail)
        Me.GrpBxLogOptions.Controls.Add(Me.ChkbxProgressLog)
        Me.GrpBxLogOptions.Controls.Add(Me.ChkbxNetworkLog)
        Me.GrpBxLogOptions.Controls.Add(Me.CmboBxVerbosityLevel)
        Me.GrpBxLogOptions.Controls.Add(Me.ChkBxVerbosity)
        Me.GrpBxLogOptions.Location = New System.Drawing.Point(456, 200)
        Me.GrpBxLogOptions.Name = "GrpBxLogOptions"
        Me.GrpBxLogOptions.Size = New System.Drawing.Size(194, 118)
        Me.GrpBxLogOptions.TabIndex = 11
        Me.GrpBxLogOptions.TabStop = False
        Me.GrpBxLogOptions.Text = "Log Options"
        '
        'ChkbxEnabeBareTail
        '
        Me.ChkbxEnabeBareTail.AutoSize = True
        Me.ChkbxEnabeBareTail.Location = New System.Drawing.Point(13, 90)
        Me.ChkbxEnabeBareTail.Name = "ChkbxEnabeBareTail"
        Me.ChkbxEnabeBareTail.Size = New System.Drawing.Size(142, 17)
        Me.ChkbxEnabeBareTail.TabIndex = 4
        Me.ChkbxEnabeBareTail.Text = "View Logs With BareTail"
        Me.ChkbxEnabeBareTail.UseVisualStyleBackColor = True
        '
        'ChkbxProgressLog
        '
        Me.ChkbxProgressLog.AutoSize = True
        Me.ChkbxProgressLog.Location = New System.Drawing.Point(13, 42)
        Me.ChkbxProgressLog.Name = "ChkbxProgressLog"
        Me.ChkbxProgressLog.Size = New System.Drawing.Size(90, 17)
        Me.ChkbxProgressLog.TabIndex = 3
        Me.ChkbxProgressLog.Text = "/Progess Log"
        Me.ChkbxProgressLog.UseVisualStyleBackColor = True
        '
        'ChkbxNetworkLog
        '
        Me.ChkbxNetworkLog.AutoSize = True
        Me.ChkbxNetworkLog.Location = New System.Drawing.Point(13, 19)
        Me.ChkbxNetworkLog.Name = "ChkbxNetworkLog"
        Me.ChkbxNetworkLog.Size = New System.Drawing.Size(92, 17)
        Me.ChkbxNetworkLog.TabIndex = 2
        Me.ChkbxNetworkLog.Text = "/Network Log"
        Me.ChkbxNetworkLog.UseVisualStyleBackColor = True
        '
        'CmboBxVerbosityLevel
        '
        Me.CmboBxVerbosityLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmboBxVerbosityLevel.FormattingEnabled = True
        Me.CmboBxVerbosityLevel.Items.AddRange(New Object() {"0", "1", "4", "5", "8", "9", "12", "13"})
        Me.CmboBxVerbosityLevel.Location = New System.Drawing.Point(128, 58)
        Me.CmboBxVerbosityLevel.Name = "CmboBxVerbosityLevel"
        Me.CmboBxVerbosityLevel.Size = New System.Drawing.Size(52, 28)
        Me.CmboBxVerbosityLevel.TabIndex = 1
        '
        'ChkBxVerbosity
        '
        Me.ChkBxVerbosity.AutoSize = True
        Me.ChkBxVerbosity.Location = New System.Drawing.Point(13, 67)
        Me.ChkBxVerbosity.Name = "ChkBxVerbosity"
        Me.ChkBxVerbosity.Size = New System.Drawing.Size(69, 17)
        Me.ChkBxVerbosity.TabIndex = 0
        Me.ChkBxVerbosity.Text = "Verbosity"
        Me.ChkBxVerbosity.UseVisualStyleBackColor = True
        '
        'GrpBxStorage
        '
        Me.GrpBxStorage.Controls.Add(Me.CheckBoxHardlink)
        Me.GrpBxStorage.Controls.Add(Me.CheckBoxPpkg)
        Me.GrpBxStorage.Controls.Add(Me.CheckBoxApps)
        Me.GrpBxStorage.Controls.Add(Me.ChkbxTargetWin8)
        Me.GrpBxStorage.Controls.Add(Me.ChkBxVsc)
        Me.GrpBxStorage.Controls.Add(Me.ChkbxTargetWin7)
        Me.GrpBxStorage.Controls.Add(Me.ChkBxLocalOnly)
        Me.GrpBxStorage.Controls.Add(Me.ChkBxNoCompress)
        Me.GrpBxStorage.Controls.Add(Me.ChkBxOverwrite)
        Me.GrpBxStorage.Location = New System.Drawing.Point(15, 358)
        Me.GrpBxStorage.Name = "GrpBxStorage"
        Me.GrpBxStorage.Size = New System.Drawing.Size(219, 142)
        Me.GrpBxStorage.TabIndex = 6
        Me.GrpBxStorage.TabStop = False
        Me.GrpBxStorage.Text = "Storage Options"
        '
        'CheckBoxHardlink
        '
        Me.CheckBoxHardlink.AutoSize = True
        Me.CheckBoxHardlink.Location = New System.Drawing.Point(13, 116)
        Me.CheckBoxHardlink.Name = "CheckBoxHardlink"
        Me.CheckBoxHardlink.Size = New System.Drawing.Size(70, 17)
        Me.CheckBoxHardlink.TabIndex = 7
        Me.CheckBoxHardlink.Text = "/Hardlink"
        Me.CheckBoxHardlink.UseVisualStyleBackColor = True
        '
        'CheckBoxPpkg
        '
        Me.CheckBoxPpkg.AutoSize = True
        Me.CheckBoxPpkg.Location = New System.Drawing.Point(13, 93)
        Me.CheckBoxPpkg.Name = "CheckBoxPpkg"
        Me.CheckBoxPpkg.Size = New System.Drawing.Size(56, 17)
        Me.CheckBoxPpkg.TabIndex = 6
        Me.CheckBoxPpkg.Text = "/Ppkg"
        Me.CheckBoxPpkg.UseVisualStyleBackColor = True
        '
        'CheckBoxApps
        '
        Me.CheckBoxApps.AutoSize = True
        Me.CheckBoxApps.Location = New System.Drawing.Point(14, 70)
        Me.CheckBoxApps.Name = "CheckBoxApps"
        Me.CheckBoxApps.Size = New System.Drawing.Size(55, 17)
        Me.CheckBoxApps.TabIndex = 5
        Me.CheckBoxApps.Text = "/Apps"
        Me.CheckBoxApps.UseVisualStyleBackColor = True
        '
        'ChkbxTargetWin8
        '
        Me.ChkbxTargetWin8.AutoSize = True
        Me.ChkbxTargetWin8.Location = New System.Drawing.Point(107, 70)
        Me.ChkbxTargetWin8.Name = "ChkbxTargetWin8"
        Me.ChkbxTargetWin8.Size = New System.Drawing.Size(87, 17)
        Me.ChkbxTargetWin8.TabIndex = 4
        Me.ChkbxTargetWin8.Text = "/TargetWin8"
        Me.ChkbxTargetWin8.UseVisualStyleBackColor = True
        '
        'ChkBxVsc
        '
        Me.ChkBxVsc.AutoSize = True
        Me.ChkBxVsc.Location = New System.Drawing.Point(107, 23)
        Me.ChkBxVsc.Name = "ChkBxVsc"
        Me.ChkBxVsc.Size = New System.Drawing.Size(52, 17)
        Me.ChkBxVsc.TabIndex = 3
        Me.ChkBxVsc.Text = "/VSC"
        Me.ChkBxVsc.UseVisualStyleBackColor = True
        '
        'ChkbxTargetWin7
        '
        Me.ChkbxTargetWin7.AutoSize = True
        Me.ChkbxTargetWin7.Location = New System.Drawing.Point(107, 47)
        Me.ChkbxTargetWin7.Name = "ChkbxTargetWin7"
        Me.ChkbxTargetWin7.Size = New System.Drawing.Size(87, 17)
        Me.ChkbxTargetWin7.TabIndex = 2
        Me.ChkbxTargetWin7.Text = "/TargetWin7"
        Me.ChkbxTargetWin7.UseVisualStyleBackColor = True
        '
        'ChkBxLocalOnly
        '
        Me.ChkBxLocalOnly.AutoSize = True
        Me.ChkBxLocalOnly.Location = New System.Drawing.Point(14, 47)
        Me.ChkBxLocalOnly.Name = "ChkBxLocalOnly"
        Me.ChkBxLocalOnly.Size = New System.Drawing.Size(78, 17)
        Me.ChkBxLocalOnly.TabIndex = 1
        Me.ChkBxLocalOnly.Text = "/LocalOnly"
        Me.ChkBxLocalOnly.UseVisualStyleBackColor = True
        '
        'ChkBxNoCompress
        '
        Me.ChkBxNoCompress.AutoSize = True
        Me.ChkBxNoCompress.Location = New System.Drawing.Point(108, 116)
        Me.ChkBxNoCompress.Name = "ChkBxNoCompress"
        Me.ChkBxNoCompress.Size = New System.Drawing.Size(91, 17)
        Me.ChkBxNoCompress.TabIndex = 1
        Me.ChkBxNoCompress.Text = "/NoCompress"
        Me.ChkBxNoCompress.UseVisualStyleBackColor = True
        '
        'ChkBxOverwrite
        '
        Me.ChkBxOverwrite.AutoSize = True
        Me.ChkBxOverwrite.Location = New System.Drawing.Point(14, 23)
        Me.ChkBxOverwrite.Name = "ChkBxOverwrite"
        Me.ChkBxOverwrite.Size = New System.Drawing.Size(76, 17)
        Me.ChkBxOverwrite.TabIndex = 0
        Me.ChkBxOverwrite.Text = "/Overwrite"
        Me.ChkBxOverwrite.UseVisualStyleBackColor = True
        '
        'TabPageDrives
        '
        Me.TabPageDrives.Controls.Add(Me.ComputerInfo)
        Me.TabPageDrives.Controls.Add(Me.computerInfoPropertyGrid)
        Me.TabPageDrives.Controls.Add(Me.GroupBoxMyComputer)
        Me.TabPageDrives.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDrives.Name = "TabPageDrives"
        Me.TabPageDrives.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDrives.Size = New System.Drawing.Size(661, 510)
        Me.TabPageDrives.TabIndex = 0
        Me.TabPageDrives.Text = "Drive Info"
        Me.TabPageDrives.UseVisualStyleBackColor = True
        '
        'ComputerInfo
        '
        Me.ComputerInfo.AutoSize = True
        Me.ComputerInfo.Location = New System.Drawing.Point(23, 296)
        Me.ComputerInfo.Name = "ComputerInfo"
        Me.ComputerInfo.Size = New System.Drawing.Size(76, 13)
        Me.ComputerInfo.TabIndex = 12
        Me.ComputerInfo.Text = "Computer Info:"
        '
        'computerInfoPropertyGrid
        '
        Me.computerInfoPropertyGrid.HelpVisible = False
        Me.computerInfoPropertyGrid.Location = New System.Drawing.Point(15, 322)
        Me.computerInfoPropertyGrid.Name = "computerInfoPropertyGrid"
        Me.computerInfoPropertyGrid.Size = New System.Drawing.Size(634, 182)
        Me.computerInfoPropertyGrid.TabIndex = 11
        '
        'TabPagePSTFiles
        '
        Me.TabPagePSTFiles.Controls.Add(Me.ListBoxPstFiles)
        Me.TabPagePSTFiles.Controls.Add(Me.CmdBtnFindPST)
        Me.TabPagePSTFiles.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePSTFiles.Name = "TabPagePSTFiles"
        Me.TabPagePSTFiles.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePSTFiles.Size = New System.Drawing.Size(661, 510)
        Me.TabPagePSTFiles.TabIndex = 11
        Me.TabPagePSTFiles.Text = "PST Files"
        Me.TabPagePSTFiles.UseVisualStyleBackColor = True
        '
        'ListBoxPstFiles
        '
        Me.ListBoxPstFiles.FormattingEnabled = True
        Me.ListBoxPstFiles.Location = New System.Drawing.Point(15, 10)
        Me.ListBoxPstFiles.Name = "ListBoxPstFiles"
        Me.ListBoxPstFiles.Size = New System.Drawing.Size(635, 459)
        Me.ListBoxPstFiles.TabIndex = 0
        '
        'CmdBtnFindPST
        '
        Me.CmdBtnFindPST.Location = New System.Drawing.Point(565, 475)
        Me.CmdBtnFindPST.Name = "CmdBtnFindPST"
        Me.CmdBtnFindPST.Size = New System.Drawing.Size(75, 23)
        Me.CmdBtnFindPST.TabIndex = 6
        Me.CmdBtnFindPST.Text = "Find PST"
        Me.CmdBtnFindPST.UseVisualStyleBackColor = True
        '
        'TabPageSysInfo
        '
        Me.TabPageSysInfo.Controls.Add(Me.ListBoxPostScripts)
        Me.TabPageSysInfo.Controls.Add(Me.ListBoxPreScripts)
        Me.TabPageSysInfo.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSysInfo.Name = "TabPageSysInfo"
        Me.TabPageSysInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSysInfo.Size = New System.Drawing.Size(661, 510)
        Me.TabPageSysInfo.TabIndex = 6
        Me.TabPageSysInfo.Text = "Scripts"
        Me.TabPageSysInfo.UseVisualStyleBackColor = True
        '
        'ListBoxPostScripts
        '
        Me.ListBoxPostScripts.FormattingEnabled = True
        Me.ListBoxPostScripts.Location = New System.Drawing.Point(15, 279)
        Me.ListBoxPostScripts.Name = "ListBoxPostScripts"
        Me.ListBoxPostScripts.Size = New System.Drawing.Size(634, 225)
        Me.ListBoxPostScripts.TabIndex = 1
        '
        'ListBoxPreScripts
        '
        Me.ListBoxPreScripts.FormattingEnabled = True
        Me.ListBoxPreScripts.Location = New System.Drawing.Point(15, 10)
        Me.ListBoxPreScripts.Name = "ListBoxPreScripts"
        Me.ListBoxPreScripts.Size = New System.Drawing.Size(634, 225)
        Me.ListBoxPreScripts.TabIndex = 0
        '
        'ButtonXML
        '
        Me.ButtonXML.Location = New System.Drawing.Point(71, 552)
        Me.ButtonXML.Name = "ButtonXML"
        Me.ButtonXML.Size = New System.Drawing.Size(53, 48)
        Me.ButtonXML.TabIndex = 45
        Me.ButtonXML.Text = "XML"
        Me.ButtonXML.UseVisualStyleBackColor = True
        '
        'CmdBtnRunUsmt
        '
        Me.CmdBtnRunUsmt.Location = New System.Drawing.Point(492, 552)
        Me.CmdBtnRunUsmt.Name = "CmdBtnRunUsmt"
        Me.CmdBtnRunUsmt.Size = New System.Drawing.Size(75, 48)
        Me.CmdBtnRunUsmt.TabIndex = 52
        Me.CmdBtnRunUsmt.Text = "Run USMT"
        Me.CmdBtnRunUsmt.UseVisualStyleBackColor = True
        '
        'CmdBtnExit
        '
        Me.CmdBtnExit.Location = New System.Drawing.Point(578, 585)
        Me.CmdBtnExit.Name = "CmdBtnExit"
        Me.CmdBtnExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdBtnExit.TabIndex = 53
        Me.CmdBtnExit.Text = "Exit"
        Me.CmdBtnExit.UseVisualStyleBackColor = True
        '
        'CmdBtnAbout
        '
        Me.CmdBtnAbout.Location = New System.Drawing.Point(397, 585)
        Me.CmdBtnAbout.Name = "CmdBtnAbout"
        Me.CmdBtnAbout.Size = New System.Drawing.Size(75, 23)
        Me.CmdBtnAbout.TabIndex = 51
        Me.CmdBtnAbout.Text = "About"
        Me.CmdBtnAbout.UseVisualStyleBackColor = True
        '
        'ButtonMonitor
        '
        Me.ButtonMonitor.Location = New System.Drawing.Point(129, 552)
        Me.ButtonMonitor.Name = "ButtonMonitor"
        Me.ButtonMonitor.Size = New System.Drawing.Size(53, 48)
        Me.ButtonMonitor.TabIndex = 46
        Me.ButtonMonitor.Text = "Monitor"
        Me.ButtonMonitor.UseVisualStyleBackColor = True
        '
        'ButtonAccts
        '
        Me.ButtonAccts.Location = New System.Drawing.Point(12, 552)
        Me.ButtonAccts.Name = "ButtonAccts"
        Me.ButtonAccts.Size = New System.Drawing.Size(53, 48)
        Me.ButtonAccts.TabIndex = 44
        Me.ButtonAccts.Text = "Accts"
        Me.ButtonAccts.UseVisualStyleBackColor = True
        '
        'ButtonStorage
        '
        Me.ButtonStorage.Location = New System.Drawing.Point(188, 552)
        Me.ButtonStorage.Name = "ButtonStorage"
        Me.ButtonStorage.Size = New System.Drawing.Size(53, 48)
        Me.ButtonStorage.TabIndex = 47
        Me.ButtonStorage.Text = "Storage"
        Me.ButtonStorage.UseVisualStyleBackColor = True
        '
        'ButtonCMD
        '
        Me.ButtonCMD.Location = New System.Drawing.Point(316, 552)
        Me.ButtonCMD.Name = "ButtonCMD"
        Me.ButtonCMD.Size = New System.Drawing.Size(53, 48)
        Me.ButtonCMD.TabIndex = 49
        Me.ButtonCMD.Text = "CMD"
        Me.ButtonCMD.UseVisualStyleBackColor = True
        '
        'ButtonGenConfig
        '
        Me.ButtonGenConfig.Location = New System.Drawing.Point(245, 552)
        Me.ButtonGenConfig.Name = "ButtonGenConfig"
        Me.ButtonGenConfig.Size = New System.Drawing.Size(65, 48)
        Me.ButtonGenConfig.TabIndex = 48
        Me.ButtonGenConfig.Text = "GenConfig"
        Me.ButtonGenConfig.UseVisualStyleBackColor = True
        '
        'CheckBoxShowBtns
        '
        Me.CheckBoxShowBtns.AutoSize = True
        Me.CheckBoxShowBtns.Location = New System.Drawing.Point(383, 551)
        Me.CheckBoxShowBtns.Name = "CheckBoxShowBtns"
        Me.CheckBoxShowBtns.Size = New System.Drawing.Size(74, 17)
        Me.CheckBoxShowBtns.TabIndex = 50
        Me.CheckBoxShowBtns.Text = "ShowBtns"
        Me.CheckBoxShowBtns.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(578, 548)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxNetworkLogDataDrive)
        Me.GroupBox1.Controls.Add(Me.CheckBoxLocalLogDataDrive)
        Me.GroupBox1.Controls.Add(Me.CmboBoxUsmtDriveLetter)
        Me.GroupBox1.Controls.Add(Me.LblMappedDriveLetterUsmt)
        Me.GroupBox1.Controls.Add(Me.txtBoxUsmtDrivePath)
        Me.GroupBox1.Controls.Add(Me.LblUncUSMTSharePath)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 399)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 101)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usmt Exe and Log Data Share"
        '
        'CheckBoxLocalLogDataDrive
        '
        Me.CheckBoxLocalLogDataDrive.AutoSize = True
        Me.CheckBoxLocalLogDataDrive.Location = New System.Drawing.Point(183, 20)
        Me.CheckBoxLocalLogDataDrive.Name = "CheckBoxLocalLogDataDrive"
        Me.CheckBoxLocalLogDataDrive.Size = New System.Drawing.Size(127, 17)
        Me.CheckBoxLocalLogDataDrive.TabIndex = 44
        Me.CheckBoxLocalLogDataDrive.Text = "Local Log Data Drive"
        Me.CheckBoxLocalLogDataDrive.UseVisualStyleBackColor = True
        '
        'CheckBoxNetworkLogDataDrive
        '
        Me.CheckBoxNetworkLogDataDrive.AutoSize = True
        Me.CheckBoxNetworkLogDataDrive.Location = New System.Drawing.Point(182, 78)
        Me.CheckBoxNetworkLogDataDrive.Name = "CheckBoxNetworkLogDataDrive"
        Me.CheckBoxNetworkLogDataDrive.Size = New System.Drawing.Size(141, 17)
        Me.CheckBoxNetworkLogDataDrive.TabIndex = 45
        Me.CheckBoxNetworkLogDataDrive.Text = "Network Log Data Drive"
        Me.CheckBoxNetworkLogDataDrive.UseVisualStyleBackColor = True
        '
        'USMTGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 647)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBoxShowBtns)
        Me.Controls.Add(Me.ButtonGenConfig)
        Me.Controls.Add(Me.ButtonCMD)
        Me.Controls.Add(Me.ButtonStorage)
        Me.Controls.Add(Me.ButtonAccts)
        Me.Controls.Add(Me.ButtonMonitor)
        Me.Controls.Add(Me.ButtonXML)
        Me.Controls.Add(Me.TbCtrlMain)
        Me.Controls.Add(Me.StatusStripInfo)
        Me.Controls.Add(Me.CmdBtnRunUsmt)
        Me.Controls.Add(Me.CmdBtnAbout)
        Me.Controls.Add(Me.CmdBtnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "USMTGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USMT GUI 10.0"
        Me.StatusStripInfo.ResumeLayout(False)
        Me.StatusStripInfo.PerformLayout()
        Me.GroupBoxMyComputer.ResumeLayout(False)
        Me.GroupBoxMyComputer.PerformLayout()
        CType(Me.drivesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbCtrlMain.ResumeLayout(False)
        Me.TabPageBackup.ResumeLayout(False)
        Me.GroupBoxBuildXML.ResumeLayout(False)
        Me.GroupBoxBuildXML.PerformLayout()
        Me.GrpBoxSourceOS.ResumeLayout(False)
        Me.GrpBoxSourceOS.PerformLayout()
        Me.GrpBoxTargetOS.ResumeLayout(False)
        Me.GrpBoxTargetOS.PerformLayout()
        Me.GrpBoxCpuType.ResumeLayout(False)
        Me.GrpBoxCpuType.PerformLayout()
        Me.GroupBoxComputerInfo.ResumeLayout(False)
        Me.GroupBoxComputerInfo.PerformLayout()
        Me.GrpBoxDriveData.ResumeLayout(False)
        Me.GrpBoxDriveData.PerformLayout()
        Me.GrpBoxBackupRestore.ResumeLayout(False)
        Me.GrpBoxBackupRestore.PerformLayout()
        Me.TabPageUserSettings.ResumeLayout(False)
        Me.TabPageUserSettings.PerformLayout()
        Me.GroupBoxDomainRedirection.ResumeLayout(False)
        Me.GroupBoxDomainRedirection.PerformLayout()
        Me.GrpBoxExcludeAccts.ResumeLayout(False)
        Me.GrpBoxExcludeAccts.PerformLayout()
        Me.GrpBoxIncludeAccts.ResumeLayout(False)
        Me.GrpBoxIncludeAccts.PerformLayout()
        Me.TabPageConfigO.ResumeLayout(False)
        Me.GrpBxEFSOptions.ResumeLayout(False)
        Me.GrpBxEFSOptions.PerformLayout()
        Me.GrpBxXMLFiles.ResumeLayout(False)
        Me.GrpBxXMLFiles.PerformLayout()
        Me.GroupBoxExtraDirectoriesInclusion.ResumeLayout(False)
        CType(Me.DataGridViewExtraDirInclude, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBxEFSRestore.ResumeLayout(False)
        Me.GrpBxEFSRestore.PerformLayout()
        Me.GrpBxEFSBackup.ResumeLayout(False)
        Me.GrpBxEFSBackup.PerformLayout()
        Me.GrpBxMonitoring.ResumeLayout(False)
        Me.GrpBxMonitoring.PerformLayout()
        Me.GrpBxLogOptions.ResumeLayout(False)
        Me.GrpBxLogOptions.PerformLayout()
        Me.GrpBxStorage.ResumeLayout(False)
        Me.GrpBxStorage.PerformLayout()
        Me.TabPageDrives.ResumeLayout(False)
        Me.TabPageDrives.PerformLayout()
        Me.TabPagePSTFiles.ResumeLayout(False)
        Me.TabPageSysInfo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStripInfo As System.Windows.Forms.StatusStrip
    Friend WithEvents lbluserName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblComputerName2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblclock As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblblankSpacer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DirectorySearcherGui As System.DirectoryServices.DirectorySearcher
    Friend WithEvents GroupBoxMyComputer As System.Windows.Forms.GroupBox
    Friend WithEvents currentDirTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LabelDrives As System.Windows.Forms.Label
    Friend WithEvents drivesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LabelCurrentDirectory As System.Windows.Forms.Label
    Friend WithEvents TbCtrlMain As System.Windows.Forms.TabControl
    Friend WithEvents TabPageDrives As System.Windows.Forms.TabPage
    Friend WithEvents TabPageBackup As System.Windows.Forms.TabPage
    Friend WithEvents CmdBtnAbout As System.Windows.Forms.Button
    Friend WithEvents CmdBtnExit As System.Windows.Forms.Button
    Friend WithEvents CmdBtnRunUsmt As System.Windows.Forms.Button
    Friend WithEvents CmdBtnFindPST As System.Windows.Forms.Button
    Friend WithEvents TabPageSysInfo As System.Windows.Forms.TabPage
    Friend WithEvents TabPageConfigO As System.Windows.Forms.TabPage
    Friend WithEvents TxtBoxOldComputer As System.Windows.Forms.TextBox
    Friend WithEvents GrpBoxBackupRestore As System.Windows.Forms.GroupBox
    Friend WithEvents RdBtnRestore As System.Windows.Forms.RadioButton
    Friend WithEvents RdBtnBackup As System.Windows.Forms.RadioButton
    Friend WithEvents TabPagePSTFiles As System.Windows.Forms.TabPage
    Friend WithEvents ListBoxPstFiles As System.Windows.Forms.ListBox
    Friend WithEvents GrpBxEFSRestore As GroupBox
    Friend WithEvents lblDecryptKeystring As Label
    Friend WithEvents TxtBxEFSRestoreKey As TextBox
    Friend WithEvents ChkBxEFSRestoreKey As CheckBox
    Friend WithEvents GrpBxEFSBackup As GroupBox
    Friend WithEvents lblEncryptKey As Label
    Friend WithEvents TxtBxEfsBackupKey As TextBox
    Friend WithEvents ChkBxEFSBackupKey As CheckBox
    Friend WithEvents GrpBxMonitoring As GroupBox
    Friend WithEvents ChkBxListFiles As CheckBox
    Friend WithEvents CmboBxWait As ComboBox
    Friend WithEvents CmboBxRetrys As ComboBox
    Friend WithEvents ChkBxSpaceEst As CheckBox
    Friend WithEvents ChkBxContinue As CheckBox
    Friend WithEvents ChkBxWait As CheckBox
    Friend WithEvents ChkBxRetry As CheckBox
    Friend WithEvents GrpBxLogOptions As GroupBox
    Friend WithEvents ChkbxEnabeBareTail As CheckBox
    Friend WithEvents ChkbxProgressLog As CheckBox
    Friend WithEvents ChkbxNetworkLog As CheckBox
    Friend WithEvents CmboBxVerbosityLevel As ComboBox
    Friend WithEvents ChkBxVerbosity As CheckBox
    Friend WithEvents GrpBoxDriveData As GroupBox
    Friend WithEvents ChkBxLocalDataDrive As CheckBox
    Friend WithEvents CmboBoxLocalDataDriveLetter As ComboBox
    Friend WithEvents LblLocalDataShareDriveLetter As Label
    Friend WithEvents CmboBoxUsmtDriveLetter As ComboBox
    Friend WithEvents txtBoxUsmtDrivePath As TextBox
    Friend WithEvents LblUncUSMTSharePath As Label
    Friend WithEvents LblMappedDriveLetterUsmt As Label
    Friend WithEvents ComputerInfo As Label
    Friend WithEvents computerInfoPropertyGrid As PropertyGrid
    Friend WithEvents GroupBoxComputerInfo As GroupBox
    Friend WithEvents BtnTestConnection As Button
    Friend WithEvents LblIPAddress As Label
    Friend WithEvents LblCompName As Label
    Friend WithEvents LblNewComputer As Label
    Friend WithEvents LblOldComputer As Label
    Friend WithEvents TxtBoxNewIPAddress As TextBox
    Friend WithEvents TxtBoxOldIPAddress As TextBox
    Friend WithEvents TxtBoxNewComputer As TextBox
    Friend WithEvents ListBoxPostScripts As ListBox
    Friend WithEvents ListBoxPreScripts As ListBox
    Friend WithEvents GrpBxStorage As GroupBox
    Friend WithEvents ChkbxTargetWin8 As CheckBox
    Friend WithEvents ChkBxVsc As CheckBox
    Friend WithEvents ChkbxTargetWin7 As CheckBox
    Friend WithEvents ChkBxLocalOnly As CheckBox
    Friend WithEvents ChkBxNoCompress As CheckBox
    Friend WithEvents ChkBxOverwrite As CheckBox
    Friend WithEvents GrpBxEFSOptions As GroupBox
    Friend WithEvents RdoBtnEFSCopyRaw As RadioButton
    Friend WithEvents RdoBtnEFSDecrypt As RadioButton
    Friend WithEvents RdoBtnEFSSkip As RadioButton
    Friend WithEvents RdoBtnEFSAbort As RadioButton
    Friend WithEvents ChkBxEFS As CheckBox
    Friend WithEvents TabPageUserSettings As TabPage
    Friend WithEvents GroupBoxExtraDirectoriesInclusion As GroupBox
    Friend WithEvents ChklstbxUsersID As CheckedListBox
    Friend WithEvents GrpBoxExcludeAccts As GroupBox
    Friend WithEvents TxtboxBackupDate As TextBox
    Friend WithEvents RdBtnBackupDate As RadioButton
    Friend WithEvents RdBtnExcludeDomainAccts As RadioButton
    Friend WithEvents RdBtnExcludeAllAccts As RadioButton
    Friend WithEvents RdBtnExcludeLocalAccts As RadioButton
    Friend WithEvents txtBoxBackupDays As TextBox
    Friend WithEvents RdBtnBackupDays As RadioButton
    Friend WithEvents GrpBoxIncludeAccts As GroupBox
    Friend WithEvents RdBtnIncludeSelectedlocalAccts As RadioButton
    Friend WithEvents lblIncludeAccts As Label
    Friend WithEvents rdbtnIncludeSelectedDomainAccts As RadioButton
    Friend WithEvents rdbtnIncludeDomainAccts As RadioButton
    Friend WithEvents rdbtnIncludeLocalAccts As RadioButton
    Friend WithEvents RdbtnIncludeAllAccts As RadioButton
    Friend WithEvents GrpBxXMLFiles As GroupBox
    Friend WithEvents ChkbxConfig As CheckBox
    Friend WithEvents ChkbxCustApps As CheckBox
    Friend WithEvents ChkBxNetworkPrn As CheckBox
    Friend WithEvents CheckBoxExcludeDrives As CheckBox
    Friend WithEvents ChkBxCustUsers As CheckBox
    Friend WithEvents ChkBxMigApp As CheckBox
    Friend WithEvents CheckBoxPpkg As CheckBox
    Friend WithEvents CheckBoxApps As CheckBox
    Friend WithEvents ListBoxExcludeFilter As ListBox
    Friend WithEvents ListBoxIncludeFilter As ListBox
    Friend WithEvents GroupBoxDomainRedirection As GroupBox
    Friend WithEvents GrpBoxSourceOS As GroupBox
    Friend WithEvents RdBtnSourceWin8 As RadioButton
    Friend WithEvents RdBtnSourceWin7 As RadioButton
    Friend WithEvents RdBtnSourceWin10 As RadioButton
    Friend WithEvents GrpBoxTargetOS As GroupBox
    Friend WithEvents RdbtnTargetWin8 As RadioButton
    Friend WithEvents RdBtnTargetWin7 As RadioButton
    Friend WithEvents RdBtnTargetWin10 As RadioButton
    Friend WithEvents GrpBoxCpuType As GroupBox
    Friend WithEvents RdBtnx86 As RadioButton
    Friend WithEvents RdBtnAmd64 As RadioButton
    Friend WithEvents GroupBoxFileExclusions As GroupBox
    Friend WithEvents GroupBoxFileInclusions As GroupBox
    Friend WithEvents GroupBoxExtraDirectoryExclusions As GroupBox
    Friend WithEvents DataGridViewExtraDirInclude As DataGridView
    Friend WithEvents GroupBoxBuildXML As GroupBox
    Friend WithEvents CheckBoxSharedFavorites As CheckBox
    Friend WithEvents CheckBoxSharedDesktop As CheckBox
    Friend WithEvents CheckBoxSharedVideo As CheckBox
    Friend WithEvents CheckBoxSharedMusic As CheckBox
    Friend WithEvents CheckBoxSharedPictures As CheckBox
    Friend WithEvents CheckBoxSharedDocuments As CheckBox
    Friend WithEvents CheckBoxFavorites As CheckBox
    Friend WithEvents CheckBoxMyDesktop As CheckBox
    Friend WithEvents CheckBoxMyVideo As CheckBox
    Friend WithEvents CheckBoxMyMusic As CheckBox
    Friend WithEvents CheckBoxMyPictures As CheckBox
    Friend WithEvents CheckBoxMyDocuments As CheckBox
    Friend WithEvents CheckBoxDownloads As CheckBox
    Friend WithEvents CheckBoxWallpapers As CheckBox
    Friend WithEvents CheckBoxRecycleBin As CheckBox
    Friend WithEvents CheckBoxPrinters As CheckBox
    Friend WithEvents CheckBoxLocalAppData As CheckBox
    Friend WithEvents CheckBoxAppData As CheckBox
    Friend WithEvents CheckBoxConnected As CheckBox
    Friend WithEvents CheckBoxExcludeSysFolders As CheckBox
    Friend WithEvents CheckBoxMigDocs As CheckBox
    Friend WithEvents CheckBoxMigUser As CheckBox
    Friend WithEvents ButtonXML As Button
    Friend WithEvents LblExcludeAccts As Label
    Friend WithEvents ButtonMonitor As Button
    Friend WithEvents ButtonAccts As Button
    Friend WithEvents ButtonStorage As Button
    Friend WithEvents ButtonCMD As Button
    Friend WithEvents RdBtnIncludeCurrentUser As RadioButton
    Friend WithEvents CheckBoxCust3XML As CheckBox
    Friend WithEvents CheckBoxCust2XML As CheckBox
    Friend WithEvents CheckBoxCust1XML As CheckBox
    Friend WithEvents ButtonGenConfig As Button
    Friend WithEvents CheckBoxShowBtns As CheckBox
    Friend WithEvents CheckBoxNetworkDataDrive As CheckBox
    Friend WithEvents TextBoxDataDrivePath As TextBox
    Friend WithEvents LabelNewDomain As Label
    Friend WithEvents LabelOldDomain As Label
    Friend WithEvents TextBoxNewDomain As TextBox
    Friend WithEvents TextBoxOldDomain As TextBox
    Friend WithEvents CheckBoxMoveUser As CheckBox
    Friend WithEvents CheckBoxMoveDomain As CheckBox
    Friend WithEvents CheckBoxHardlink As CheckBox
    Friend WithEvents CheckBoxLae As CheckBox
    Friend WithEvents CheckBoxLac As CheckBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxLacPassword As TextBox
    Friend WithEvents ComboBoxDecryptStrength As ComboBox
    Friend WithEvents ComboBoxEncryptStrength As ComboBox
    Friend WithEvents RadioButtonEFSHardlink As RadioButton
    Friend WithEvents CheckedListBoxLocalUsers As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxNetworkLogDataDrive As CheckBox
    Friend WithEvents CheckBoxLocalLogDataDrive As CheckBox
End Class
