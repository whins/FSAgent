namespace SIPAgent
{
	partial class SettingsWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Account = new System.Windows.Forms.TabPage();
			this.labelSipPort = new System.Windows.Forms.Label();
			this.textBoxSipPort = new System.Windows.Forms.TextBox();
			this.labelAccountID = new System.Windows.Forms.Label();
			this.labelAccountDisplayName = new System.Windows.Forms.Label();
			this.labelAccountDomain = new System.Windows.Forms.Label();
			this.labelAccountPassword = new System.Windows.Forms.Label();
			this.labelAccountUsername = new System.Windows.Forms.Label();
			this.labelAccountAddress = new System.Windows.Forms.Label();
			this.labelAccountName = new System.Windows.Forms.Label();
			this.textBoxAccountID = new System.Windows.Forms.TextBox();
			this.textBoxAccountDisplayName = new System.Windows.Forms.TextBox();
			this.textBoxAccountDomain = new System.Windows.Forms.TextBox();
			this.textBoxAccountPassword = new System.Windows.Forms.TextBox();
			this.textBoxAccountUsername = new System.Windows.Forms.TextBox();
			this.textBoxAccountAddress = new System.Windows.Forms.TextBox();
			this.textBoxAccountName = new System.Windows.Forms.TextBox();
			this.checkBoxAccountEnabled = new System.Windows.Forms.CheckBox();
			this.SIP = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBoxCFUFlag = new System.Windows.Forms.CheckBox();
			this.checkBoxCFNRFlag = new System.Windows.Forms.CheckBox();
			this.checkBoxCFBFlag = new System.Windows.Forms.CheckBox();
			this.textBoxCFBNumber = new System.Windows.Forms.TextBox();
			this.textBoxCFNRNumber = new System.Windows.Forms.TextBox();
			this.textBoxCFUNumber = new System.Windows.Forms.TextBox();
			this.labelTestNumber = new System.Windows.Forms.Label();
			this.textBoxTestNumber = new System.Windows.Forms.TextBox();
			this.labelNameServer = new System.Windows.Forms.Label();
			this.labelStunServerAddress = new System.Windows.Forms.Label();
			this.textBoxNameServer = new System.Windows.Forms.TextBox();
			this.textBoxStunServerAddress = new System.Windows.Forms.TextBox();
			this.checkBoxVAD = new System.Windows.Forms.CheckBox();
			this.checkBoxSipPublishEnabled = new System.Windows.Forms.CheckBox();
			this.checkBoxAAFlag = new System.Windows.Forms.CheckBox();
			this.checkBoxDNDFlag = new System.Windows.Forms.CheckBox();
			this.Audio = new System.Windows.Forms.TabPage();
			this.groupBoxRing = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.comboBoxRingDevices = new System.Windows.Forms.ComboBox();
			this.groupBoxMicrophone = new System.Windows.Forms.GroupBox();
			this.checkBoxRecordingMute = new System.Windows.Forms.CheckBox();
			this.comboBoxRecordingDevices = new System.Windows.Forms.ComboBox();
			this.groupBoxSpeakers = new System.Windows.Forms.GroupBox();
			this.checkBoxPlaybackMute = new System.Windows.Forms.CheckBox();
			this.comboBoxPlaybackDevices = new System.Windows.Forms.ComboBox();
			this.Call = new System.Windows.Forms.TabPage();
			this.buttonSave = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.Account.SuspendLayout();
			this.SIP.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.Audio.SuspendLayout();
			this.groupBoxRing.SuspendLayout();
			this.groupBoxMicrophone.SuspendLayout();
			this.groupBoxSpeakers.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.Account);
			this.tabControl1.Controls.Add(this.SIP);
			this.tabControl1.Controls.Add(this.Audio);
			this.tabControl1.Controls.Add(this.Call);
			this.tabControl1.Location = new System.Drawing.Point(1, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(341, 220);
			this.tabControl1.TabIndex = 3;
			// 
			// Account
			// 
			this.Account.Controls.Add(this.labelSipPort);
			this.Account.Controls.Add(this.textBoxSipPort);
			this.Account.Controls.Add(this.labelAccountID);
			this.Account.Controls.Add(this.labelAccountDisplayName);
			this.Account.Controls.Add(this.labelAccountDomain);
			this.Account.Controls.Add(this.labelAccountPassword);
			this.Account.Controls.Add(this.labelAccountUsername);
			this.Account.Controls.Add(this.labelAccountAddress);
			this.Account.Controls.Add(this.labelAccountName);
			this.Account.Controls.Add(this.textBoxAccountID);
			this.Account.Controls.Add(this.textBoxAccountDisplayName);
			this.Account.Controls.Add(this.textBoxAccountDomain);
			this.Account.Controls.Add(this.textBoxAccountPassword);
			this.Account.Controls.Add(this.textBoxAccountUsername);
			this.Account.Controls.Add(this.textBoxAccountAddress);
			this.Account.Controls.Add(this.textBoxAccountName);
			this.Account.Controls.Add(this.checkBoxAccountEnabled);
			this.Account.Location = new System.Drawing.Point(4, 22);
			this.Account.Name = "Account";
			this.Account.Padding = new System.Windows.Forms.Padding(3);
			this.Account.Size = new System.Drawing.Size(333, 194);
			this.Account.TabIndex = 0;
			this.Account.Text = "Акаунт";
			this.Account.UseVisualStyleBackColor = true;
			// 
			// labelSipPort
			// 
			this.labelSipPort.AutoSize = true;
			this.labelSipPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSipPort.Location = new System.Drawing.Point(266, 35);
			this.labelSipPort.Name = "labelSipPort";
			this.labelSipPort.Size = new System.Drawing.Size(58, 13);
			this.labelSipPort.TabIndex = 19;
			this.labelSipPort.Text = "SIP порт";
			// 
			// textBoxSipPort
			// 
			this.textBoxSipPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SIPAgent.Properties.Settings.Default, "cfgSipPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxSipPort.Location = new System.Drawing.Point(223, 32);
			this.textBoxSipPort.Name = "textBoxSipPort";
			this.textBoxSipPort.Size = new System.Drawing.Size(39, 20);
			this.textBoxSipPort.TabIndex = 20;
			this.textBoxSipPort.Text = global::SIPAgent.Properties.Settings.Default.cfgSipPort;
			// 
			// labelAccountID
			// 
			this.labelAccountID.AutoSize = true;
			this.labelAccountID.Location = new System.Drawing.Point(155, 165);
			this.labelAccountID.Name = "labelAccountID";
			this.labelAccountID.Size = new System.Drawing.Size(18, 13);
			this.labelAccountID.TabIndex = 17;
			this.labelAccountID.Text = "ID";
			// 
			// labelAccountDisplayName
			// 
			this.labelAccountDisplayName.AutoSize = true;
			this.labelAccountDisplayName.Location = new System.Drawing.Point(155, 139);
			this.labelAccountDisplayName.Name = "labelAccountDisplayName";
			this.labelAccountDisplayName.Size = new System.Drawing.Size(107, 13);
			this.labelAccountDisplayName.TabIndex = 16;
			this.labelAccountDisplayName.Text = "Отображаемое имя";
			// 
			// labelAccountDomain
			// 
			this.labelAccountDomain.AutoSize = true;
			this.labelAccountDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAccountDomain.Location = new System.Drawing.Point(155, 113);
			this.labelAccountDomain.Name = "labelAccountDomain";
			this.labelAccountDomain.Size = new System.Drawing.Size(47, 13);
			this.labelAccountDomain.TabIndex = 15;
			this.labelAccountDomain.Text = "Домен";
			// 
			// labelAccountPassword
			// 
			this.labelAccountPassword.AutoSize = true;
			this.labelAccountPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAccountPassword.Location = new System.Drawing.Point(155, 87);
			this.labelAccountPassword.Name = "labelAccountPassword";
			this.labelAccountPassword.Size = new System.Drawing.Size(51, 13);
			this.labelAccountPassword.TabIndex = 10;
			this.labelAccountPassword.Text = "Пароль";
			// 
			// labelAccountUsername
			// 
			this.labelAccountUsername.AutoSize = true;
			this.labelAccountUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAccountUsername.Location = new System.Drawing.Point(155, 61);
			this.labelAccountUsername.Name = "labelAccountUsername";
			this.labelAccountUsername.Size = new System.Drawing.Size(92, 13);
			this.labelAccountUsername.TabIndex = 9;
			this.labelAccountUsername.Text = "Пользователь";
			// 
			// labelAccountAddress
			// 
			this.labelAccountAddress.AutoSize = true;
			this.labelAccountAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAccountAddress.Location = new System.Drawing.Point(155, 35);
			this.labelAccountAddress.Name = "labelAccountAddress";
			this.labelAccountAddress.Size = new System.Drawing.Size(50, 13);
			this.labelAccountAddress.TabIndex = 8;
			this.labelAccountAddress.Text = "Сервер";
			// 
			// labelAccountName
			// 
			this.labelAccountName.AutoSize = true;
			this.labelAccountName.Location = new System.Drawing.Point(155, 9);
			this.labelAccountName.Name = "labelAccountName";
			this.labelAccountName.Size = new System.Drawing.Size(88, 13);
			this.labelAccountName.TabIndex = 7;
			this.labelAccountName.Text = "Учетная запись";
			// 
			// textBoxAccountID
			// 
			this.textBoxAccountID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SIPAgent.Properties.Settings.Default, "cfgAccountID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxAccountID.Location = new System.Drawing.Point(6, 162);
			this.textBoxAccountID.Name = "textBoxAccountID";
			this.textBoxAccountID.Size = new System.Drawing.Size(143, 20);
			this.textBoxAccountID.TabIndex = 14;
			this.textBoxAccountID.Text = global::SIPAgent.Properties.Settings.Default.cfgAccountID;
			// 
			// textBoxAccountDisplayName
			// 
			this.textBoxAccountDisplayName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SIPAgent.Properties.Settings.Default, "cfgAccountDisplayName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxAccountDisplayName.Location = new System.Drawing.Point(6, 136);
			this.textBoxAccountDisplayName.Name = "textBoxAccountDisplayName";
			this.textBoxAccountDisplayName.Size = new System.Drawing.Size(143, 20);
			this.textBoxAccountDisplayName.TabIndex = 13;
			this.textBoxAccountDisplayName.Text = global::SIPAgent.Properties.Settings.Default.cfgAccountDisplayName;
			// 
			// textBoxAccountDomain
			// 
			this.textBoxAccountDomain.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SIPAgent.Properties.Settings.Default, "cfgAccountDomain", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxAccountDomain.Location = new System.Drawing.Point(6, 110);
			this.textBoxAccountDomain.Name = "textBoxAccountDomain";
			this.textBoxAccountDomain.Size = new System.Drawing.Size(143, 20);
			this.textBoxAccountDomain.TabIndex = 12;
			this.textBoxAccountDomain.Text = global::SIPAgent.Properties.Settings.Default.cfgAccountDomain;
			// 
			// textBoxAccountPassword
			// 
			this.textBoxAccountPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SIPAgent.Properties.Settings.Default, "cfgAccountPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxAccountPassword.Location = new System.Drawing.Point(6, 84);
			this.textBoxAccountPassword.Name = "textBoxAccountPassword";
			this.textBoxAccountPassword.Size = new System.Drawing.Size(143, 20);
			this.textBoxAccountPassword.TabIndex = 6;
			this.textBoxAccountPassword.Text = global::SIPAgent.Properties.Settings.Default.cfgAccountPassword;
			// 
			// textBoxAccountUsername
			// 
			this.textBoxAccountUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SIPAgent.Properties.Settings.Default, "cfgAccountUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxAccountUsername.Location = new System.Drawing.Point(6, 58);
			this.textBoxAccountUsername.Name = "textBoxAccountUsername";
			this.textBoxAccountUsername.Size = new System.Drawing.Size(143, 20);
			this.textBoxAccountUsername.TabIndex = 5;
			this.textBoxAccountUsername.Text = global::SIPAgent.Properties.Settings.Default.cfgAccountUsername;
			// 
			// textBoxAccountAddress
			// 
			this.textBoxAccountAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SIPAgent.Properties.Settings.Default, "cfgAccountAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxAccountAddress.Location = new System.Drawing.Point(6, 32);
			this.textBoxAccountAddress.Name = "textBoxAccountAddress";
			this.textBoxAccountAddress.Size = new System.Drawing.Size(143, 20);
			this.textBoxAccountAddress.TabIndex = 4;
			this.textBoxAccountAddress.Text = global::SIPAgent.Properties.Settings.Default.cfgAccountAddress;
			// 
			// textBoxAccountName
			// 
			this.textBoxAccountName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SIPAgent.Properties.Settings.Default, "cfgAccountName", true));
			this.textBoxAccountName.Location = new System.Drawing.Point(6, 6);
			this.textBoxAccountName.Name = "textBoxAccountName";
			this.textBoxAccountName.Size = new System.Drawing.Size(143, 20);
			this.textBoxAccountName.TabIndex = 3;
			this.textBoxAccountName.Text = global::SIPAgent.Properties.Settings.Default.cfgAccountName;
			// 
			// checkBoxAccountEnabled
			// 
			this.checkBoxAccountEnabled.AutoSize = true;
			this.checkBoxAccountEnabled.Checked = global::SIPAgent.Properties.Settings.Default.cfgAccountEnabled;
			this.checkBoxAccountEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxAccountEnabled.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SIPAgent.Properties.Settings.Default, "cfgAccountEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxAccountEnabled.Location = new System.Drawing.Point(240, 164);
			this.checkBoxAccountEnabled.Name = "checkBoxAccountEnabled";
			this.checkBoxAccountEnabled.Size = new System.Drawing.Size(70, 17);
			this.checkBoxAccountEnabled.TabIndex = 2;
			this.checkBoxAccountEnabled.Text = "Включен";
			this.checkBoxAccountEnabled.UseVisualStyleBackColor = true;
			// 
			// SIP
			// 
			this.SIP.Controls.Add(this.groupBox1);
			this.SIP.Controls.Add(this.labelTestNumber);
			this.SIP.Controls.Add(this.textBoxTestNumber);
			this.SIP.Controls.Add(this.labelNameServer);
			this.SIP.Controls.Add(this.labelStunServerAddress);
			this.SIP.Controls.Add(this.textBoxNameServer);
			this.SIP.Controls.Add(this.textBoxStunServerAddress);
			this.SIP.Controls.Add(this.checkBoxVAD);
			this.SIP.Controls.Add(this.checkBoxSipPublishEnabled);
			this.SIP.Controls.Add(this.checkBoxAAFlag);
			this.SIP.Controls.Add(this.checkBoxDNDFlag);
			this.SIP.Location = new System.Drawing.Point(4, 22);
			this.SIP.Name = "SIP";
			this.SIP.Padding = new System.Windows.Forms.Padding(3);
			this.SIP.Size = new System.Drawing.Size(333, 194);
			this.SIP.TabIndex = 1;
			this.SIP.Text = "SIP";
			this.SIP.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxCFUFlag);
			this.groupBox1.Controls.Add(this.checkBoxCFNRFlag);
			this.groupBox1.Controls.Add(this.checkBoxCFBFlag);
			this.groupBox1.Controls.Add(this.textBoxCFBNumber);
			this.groupBox1.Controls.Add(this.textBoxCFNRNumber);
			this.groupBox1.Controls.Add(this.textBoxCFUNumber);
			this.groupBox1.Location = new System.Drawing.Point(6, 102);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(324, 89);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Переадресация звонков";
			// 
			// checkBoxCFUFlag
			// 
			this.checkBoxCFUFlag.AutoSize = true;
			this.checkBoxCFUFlag.Checked = global::SIPAgent.Properties.Settings.Default.cfgCFUFlag;
			this.checkBoxCFUFlag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SIPAgent.Properties.Settings.Default, "cfgCFUFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxCFUFlag.Location = new System.Drawing.Point(12, 17);
			this.checkBoxCFUFlag.Name = "checkBoxCFUFlag";
			this.checkBoxCFUFlag.Size = new System.Drawing.Size(62, 17);
			this.checkBoxCFUFlag.TabIndex = 0;
			this.checkBoxCFUFlag.Text = "Всегда";
			this.checkBoxCFUFlag.UseVisualStyleBackColor = true;
			// 
			// checkBoxCFNRFlag
			// 
			this.checkBoxCFNRFlag.AutoSize = true;
			this.checkBoxCFNRFlag.Checked = global::SIPAgent.Properties.Settings.Default.cfgCFNRFlag;
			this.checkBoxCFNRFlag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SIPAgent.Properties.Settings.Default, "cfgCFNRFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxCFNRFlag.Location = new System.Drawing.Point(12, 40);
			this.checkBoxCFNRFlag.Name = "checkBoxCFNRFlag";
			this.checkBoxCFNRFlag.Size = new System.Drawing.Size(88, 17);
			this.checkBoxCFNRFlag.TabIndex = 1;
			this.checkBoxCFNRFlag.Text = "Не отвечает";
			this.checkBoxCFNRFlag.UseVisualStyleBackColor = true;
			// 
			// checkBoxCFBFlag
			// 
			this.checkBoxCFBFlag.AutoSize = true;
			this.checkBoxCFBFlag.Checked = global::SIPAgent.Properties.Settings.Default.cfgCFBFlag;
			this.checkBoxCFBFlag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SIPAgent.Properties.Settings.Default, "cfgCFBFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxCFBFlag.Location = new System.Drawing.Point(12, 63);
			this.checkBoxCFBFlag.Name = "checkBoxCFBFlag";
			this.checkBoxCFBFlag.Size = new System.Drawing.Size(56, 17);
			this.checkBoxCFBFlag.TabIndex = 4;
			this.checkBoxCFBFlag.Text = "Занят";
			this.checkBoxCFBFlag.UseVisualStyleBackColor = true;
			// 
			// textBoxCFBNumber
			// 
			this.textBoxCFBNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SIPAgent.Properties.Settings.Default, "cfgCFBNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxCFBNumber.Location = new System.Drawing.Point(186, 61);
			this.textBoxCFBNumber.Name = "textBoxCFBNumber";
			this.textBoxCFBNumber.Size = new System.Drawing.Size(132, 20);
			this.textBoxCFBNumber.TabIndex = 14;
			this.textBoxCFBNumber.Text = global::SIPAgent.Properties.Settings.Default.cfgCFBNumber;
			// 
			// textBoxCFNRNumber
			// 
			this.textBoxCFNRNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SIPAgent.Properties.Settings.Default, "cfgCFNRNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxCFNRNumber.Location = new System.Drawing.Point(186, 38);
			this.textBoxCFNRNumber.Name = "textBoxCFNRNumber";
			this.textBoxCFNRNumber.Size = new System.Drawing.Size(132, 20);
			this.textBoxCFNRNumber.TabIndex = 16;
			this.textBoxCFNRNumber.Text = global::SIPAgent.Properties.Settings.Default.cfgCFNRNumber;
			// 
			// textBoxCFUNumber
			// 
			this.textBoxCFUNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SIPAgent.Properties.Settings.Default, "cfgCFUNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxCFUNumber.Location = new System.Drawing.Point(186, 15);
			this.textBoxCFUNumber.Name = "textBoxCFUNumber";
			this.textBoxCFUNumber.Size = new System.Drawing.Size(132, 20);
			this.textBoxCFUNumber.TabIndex = 8;
			this.textBoxCFUNumber.Text = global::SIPAgent.Properties.Settings.Default.cfgCFUNumber;
			// 
			// labelTestNumber
			// 
			this.labelTestNumber.AutoSize = true;
			this.labelTestNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTestNumber.Location = new System.Drawing.Point(103, 6);
			this.labelTestNumber.Name = "labelTestNumber";
			this.labelTestNumber.Size = new System.Drawing.Size(69, 13);
			this.labelTestNumber.TabIndex = 19;
			this.labelTestNumber.Text = "Тест. номер";
			// 
			// textBoxTestNumber
			// 
			this.textBoxTestNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SIPAgent.Properties.Settings.Default, "TestNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxTestNumber.Location = new System.Drawing.Point(7, 3);
			this.textBoxTestNumber.Name = "textBoxTestNumber";
			this.textBoxTestNumber.Size = new System.Drawing.Size(90, 20);
			this.textBoxTestNumber.TabIndex = 20;
			this.textBoxTestNumber.Text = global::SIPAgent.Properties.Settings.Default.TestNumber;
			// 
			// labelNameServer
			// 
			this.labelNameServer.AutoSize = true;
			this.labelNameServer.Location = new System.Drawing.Point(103, 32);
			this.labelNameServer.Name = "labelNameServer";
			this.labelNameServer.Size = new System.Drawing.Size(66, 13);
			this.labelNameServer.TabIndex = 11;
			this.labelNameServer.Text = "NameServer";
			// 
			// labelStunServerAddress
			// 
			this.labelStunServerAddress.AutoSize = true;
			this.labelStunServerAddress.Location = new System.Drawing.Point(103, 58);
			this.labelStunServerAddress.Name = "labelStunServerAddress";
			this.labelStunServerAddress.Size = new System.Drawing.Size(98, 13);
			this.labelStunServerAddress.TabIndex = 9;
			this.labelStunServerAddress.Text = "StunServerAddress";
			// 
			// textBoxNameServer
			// 
			this.textBoxNameServer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SIPAgent.Properties.Settings.Default, "cfgNameServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxNameServer.Location = new System.Drawing.Point(7, 29);
			this.textBoxNameServer.Name = "textBoxNameServer";
			this.textBoxNameServer.Size = new System.Drawing.Size(90, 20);
			this.textBoxNameServer.TabIndex = 12;
			this.textBoxNameServer.Text = global::SIPAgent.Properties.Settings.Default.cfgNameServer;
			// 
			// textBoxStunServerAddress
			// 
			this.textBoxStunServerAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SIPAgent.Properties.Settings.Default, "cfgStunServerAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.textBoxStunServerAddress.Location = new System.Drawing.Point(7, 55);
			this.textBoxStunServerAddress.Name = "textBoxStunServerAddress";
			this.textBoxStunServerAddress.Size = new System.Drawing.Size(90, 20);
			this.textBoxStunServerAddress.TabIndex = 10;
			this.textBoxStunServerAddress.Text = global::SIPAgent.Properties.Settings.Default.cfgStunServerAddress;
			// 
			// checkBoxVAD
			// 
			this.checkBoxVAD.AutoSize = true;
			this.checkBoxVAD.Checked = global::SIPAgent.Properties.Settings.Default.cfgVAD;
			this.checkBoxVAD.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SIPAgent.Properties.Settings.Default, "cfgVAD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxVAD.Location = new System.Drawing.Point(219, 31);
			this.checkBoxVAD.Name = "checkBoxVAD";
			this.checkBoxVAD.Size = new System.Drawing.Size(48, 17);
			this.checkBoxVAD.TabIndex = 6;
			this.checkBoxVAD.Text = "VAD";
			this.checkBoxVAD.UseVisualStyleBackColor = true;
			// 
			// checkBoxSipPublishEnabled
			// 
			this.checkBoxSipPublishEnabled.AutoSize = true;
			this.checkBoxSipPublishEnabled.Checked = global::SIPAgent.Properties.Settings.Default.cfgSipPublishEnabled;
			this.checkBoxSipPublishEnabled.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SIPAgent.Properties.Settings.Default, "cfgSipPublishEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxSipPublishEnabled.Location = new System.Drawing.Point(219, 6);
			this.checkBoxSipPublishEnabled.Name = "checkBoxSipPublishEnabled";
			this.checkBoxSipPublishEnabled.Size = new System.Drawing.Size(114, 17);
			this.checkBoxSipPublishEnabled.TabIndex = 5;
			this.checkBoxSipPublishEnabled.Text = "SipPublishEnabled";
			this.checkBoxSipPublishEnabled.UseVisualStyleBackColor = true;
			// 
			// checkBoxAAFlag
			// 
			this.checkBoxAAFlag.AutoSize = true;
			this.checkBoxAAFlag.Checked = global::SIPAgent.Properties.Settings.Default.cfgAAFlag;
			this.checkBoxAAFlag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SIPAgent.Properties.Settings.Default, "cfgAAFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxAAFlag.Location = new System.Drawing.Point(7, 81);
			this.checkBoxAAFlag.Name = "checkBoxAAFlag";
			this.checkBoxAAFlag.Size = new System.Drawing.Size(78, 17);
			this.checkBoxAAFlag.TabIndex = 3;
			this.checkBoxAAFlag.Text = "Автоответ";
			this.checkBoxAAFlag.UseVisualStyleBackColor = true;
			this.checkBoxAAFlag.CheckedChanged += new System.EventHandler(this.checkBoxAAFlag_CheckedChanged);
			// 
			// checkBoxDNDFlag
			// 
			this.checkBoxDNDFlag.AutoSize = true;
			this.checkBoxDNDFlag.Checked = global::SIPAgent.Properties.Settings.Default.cfgDNDFlag;
			this.checkBoxDNDFlag.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SIPAgent.Properties.Settings.Default, "cfgDNDFlag", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxDNDFlag.Location = new System.Drawing.Point(219, 81);
			this.checkBoxDNDFlag.Name = "checkBoxDNDFlag";
			this.checkBoxDNDFlag.Size = new System.Drawing.Size(102, 17);
			this.checkBoxDNDFlag.TabIndex = 2;
			this.checkBoxDNDFlag.Text = "Не беспокоить";
			this.checkBoxDNDFlag.UseVisualStyleBackColor = true;
			this.checkBoxDNDFlag.CheckedChanged += new System.EventHandler(this.checkBoxDNDFlag_CheckedChanged);
			// 
			// Audio
			// 
			this.Audio.Controls.Add(this.groupBoxRing);
			this.Audio.Controls.Add(this.groupBoxMicrophone);
			this.Audio.Controls.Add(this.groupBoxSpeakers);
			this.Audio.Location = new System.Drawing.Point(4, 22);
			this.Audio.Name = "Audio";
			this.Audio.Size = new System.Drawing.Size(333, 194);
			this.Audio.TabIndex = 2;
			this.Audio.Text = "Аудио";
			this.Audio.UseVisualStyleBackColor = true;
			// 
			// groupBoxRing
			// 
			this.groupBoxRing.Controls.Add(this.checkBox1);
			this.groupBoxRing.Controls.Add(this.comboBoxRingDevices);
			this.groupBoxRing.Location = new System.Drawing.Point(8, 66);
			this.groupBoxRing.Name = "groupBoxRing";
			this.groupBoxRing.Size = new System.Drawing.Size(316, 54);
			this.groupBoxRing.TabIndex = 4;
			this.groupBoxRing.TabStop = false;
			this.groupBoxRing.Text = "Звонок";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(228, 20);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(80, 17);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "checkBox2";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// comboBoxRingDevices
			// 
			this.comboBoxRingDevices.FormattingEnabled = true;
			this.comboBoxRingDevices.Location = new System.Drawing.Point(7, 20);
			this.comboBoxRingDevices.Name = "comboBoxRingDevices";
			this.comboBoxRingDevices.Size = new System.Drawing.Size(195, 21);
			this.comboBoxRingDevices.TabIndex = 0;
			this.comboBoxRingDevices.SelectedIndexChanged += new System.EventHandler(this.comboBoxRingDevices_SelectedIndexChanged);
			// 
			// groupBoxMicrophone
			// 
			this.groupBoxMicrophone.Controls.Add(this.checkBoxRecordingMute);
			this.groupBoxMicrophone.Controls.Add(this.comboBoxRecordingDevices);
			this.groupBoxMicrophone.Location = new System.Drawing.Point(8, 134);
			this.groupBoxMicrophone.Name = "groupBoxMicrophone";
			this.groupBoxMicrophone.Size = new System.Drawing.Size(316, 57);
			this.groupBoxMicrophone.TabIndex = 1;
			this.groupBoxMicrophone.TabStop = false;
			this.groupBoxMicrophone.Text = "Микрофон";
			// 
			// checkBoxRecordingMute
			// 
			this.checkBoxRecordingMute.AutoSize = true;
			this.checkBoxRecordingMute.Location = new System.Drawing.Point(228, 20);
			this.checkBoxRecordingMute.Name = "checkBoxRecordingMute";
			this.checkBoxRecordingMute.Size = new System.Drawing.Size(80, 17);
			this.checkBoxRecordingMute.TabIndex = 2;
			this.checkBoxRecordingMute.Text = "checkBox2";
			this.checkBoxRecordingMute.UseVisualStyleBackColor = true;
			this.checkBoxRecordingMute.CheckedChanged += new System.EventHandler(this.checkBoxPlaybackMute_CheckedChanged);
			// 
			// comboBoxRecordingDevices
			// 
			this.comboBoxRecordingDevices.FormattingEnabled = true;
			this.comboBoxRecordingDevices.Location = new System.Drawing.Point(7, 20);
			this.comboBoxRecordingDevices.Name = "comboBoxRecordingDevices";
			this.comboBoxRecordingDevices.Size = new System.Drawing.Size(195, 21);
			this.comboBoxRecordingDevices.TabIndex = 0;
			this.comboBoxRecordingDevices.SelectedIndexChanged += new System.EventHandler(this.comboBoxRecordingDevices_SelectedIndexChanged);
			// 
			// groupBoxSpeakers
			// 
			this.groupBoxSpeakers.Controls.Add(this.checkBoxPlaybackMute);
			this.groupBoxSpeakers.Controls.Add(this.comboBoxPlaybackDevices);
			this.groupBoxSpeakers.Location = new System.Drawing.Point(8, 4);
			this.groupBoxSpeakers.Name = "groupBoxSpeakers";
			this.groupBoxSpeakers.Size = new System.Drawing.Size(316, 56);
			this.groupBoxSpeakers.TabIndex = 0;
			this.groupBoxSpeakers.TabStop = false;
			this.groupBoxSpeakers.Text = "Динамики";
			// 
			// checkBoxPlaybackMute
			// 
			this.checkBoxPlaybackMute.AutoSize = true;
			this.checkBoxPlaybackMute.Location = new System.Drawing.Point(228, 20);
			this.checkBoxPlaybackMute.Name = "checkBoxPlaybackMute";
			this.checkBoxPlaybackMute.Size = new System.Drawing.Size(80, 17);
			this.checkBoxPlaybackMute.TabIndex = 2;
			this.checkBoxPlaybackMute.Text = "checkBox1";
			this.checkBoxPlaybackMute.UseVisualStyleBackColor = true;
			this.checkBoxPlaybackMute.CheckedChanged += new System.EventHandler(this.checkBoxPlaybackMute_CheckedChanged);
			// 
			// comboBoxPlaybackDevices
			// 
			this.comboBoxPlaybackDevices.FormattingEnabled = true;
			this.comboBoxPlaybackDevices.Location = new System.Drawing.Point(7, 20);
			this.comboBoxPlaybackDevices.Name = "comboBoxPlaybackDevices";
			this.comboBoxPlaybackDevices.Size = new System.Drawing.Size(195, 21);
			this.comboBoxPlaybackDevices.TabIndex = 0;
			this.comboBoxPlaybackDevices.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlaybackDevices_SelectedIndexChanged);
			// 
			// Call
			// 
			this.Call.Location = new System.Drawing.Point(4, 22);
			this.Call.Name = "Call";
			this.Call.Size = new System.Drawing.Size(333, 194);
			this.Call.TabIndex = 3;
			this.Call.Text = "Звонок";
			this.Call.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(263, 224);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 11;
			this.buttonSave.Text = "OK";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// SettingsWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 255);
			this.ControlBox = false;
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.buttonSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsWindow";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Настройки";
			this.tabControl1.ResumeLayout(false);
			this.Account.ResumeLayout(false);
			this.Account.PerformLayout();
			this.SIP.ResumeLayout(false);
			this.SIP.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.Audio.ResumeLayout(false);
			this.groupBoxRing.ResumeLayout(false);
			this.groupBoxRing.PerformLayout();
			this.groupBoxMicrophone.ResumeLayout(false);
			this.groupBoxMicrophone.PerformLayout();
			this.groupBoxSpeakers.ResumeLayout(false);
			this.groupBoxSpeakers.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxAccountEnabled;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Account;
		private System.Windows.Forms.Label labelAccountPassword;
		private System.Windows.Forms.Label labelAccountUsername;
		private System.Windows.Forms.Label labelAccountAddress;
		private System.Windows.Forms.Label labelAccountName;
		private System.Windows.Forms.TextBox textBoxAccountPassword;
		private System.Windows.Forms.TextBox textBoxAccountUsername;
		private System.Windows.Forms.TextBox textBoxAccountAddress;
		private System.Windows.Forms.TextBox textBoxAccountName;
		private System.Windows.Forms.TabPage SIP;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label labelAccountID;
		private System.Windows.Forms.Label labelAccountDisplayName;
		private System.Windows.Forms.Label labelAccountDomain;
		private System.Windows.Forms.TextBox textBoxAccountID;
		private System.Windows.Forms.TextBox textBoxAccountDisplayName;
		private System.Windows.Forms.TextBox textBoxAccountDomain;
		private System.Windows.Forms.CheckBox checkBoxVAD;
		private System.Windows.Forms.CheckBox checkBoxSipPublishEnabled;
		private System.Windows.Forms.CheckBox checkBoxCFBFlag;
		private System.Windows.Forms.CheckBox checkBoxAAFlag;
		private System.Windows.Forms.CheckBox checkBoxDNDFlag;
		private System.Windows.Forms.CheckBox checkBoxCFNRFlag;
		private System.Windows.Forms.CheckBox checkBoxCFUFlag;
		private System.Windows.Forms.TextBox textBoxCFNRNumber;
		private System.Windows.Forms.TextBox textBoxCFBNumber;
		private System.Windows.Forms.TextBox textBoxNameServer;
		private System.Windows.Forms.Label labelNameServer;
		private System.Windows.Forms.TextBox textBoxStunServerAddress;
		private System.Windows.Forms.Label labelStunServerAddress;
		private System.Windows.Forms.TextBox textBoxCFUNumber;
		private System.Windows.Forms.TabPage Audio;
		private System.Windows.Forms.TabPage Call;
		private System.Windows.Forms.GroupBox groupBoxMicrophone;
		private System.Windows.Forms.GroupBox groupBoxSpeakers;
		private System.Windows.Forms.ComboBox comboBoxPlaybackDevices;
		private System.Windows.Forms.ComboBox comboBoxRecordingDevices;
		private System.Windows.Forms.CheckBox checkBoxRecordingMute;
		private System.Windows.Forms.CheckBox checkBoxPlaybackMute;
		private System.Windows.Forms.Label labelTestNumber;
		private System.Windows.Forms.TextBox textBoxTestNumber;
		private System.Windows.Forms.Label labelSipPort;
		private System.Windows.Forms.TextBox textBoxSipPort;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBoxRing;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ComboBox comboBoxRingDevices;
	}
}

