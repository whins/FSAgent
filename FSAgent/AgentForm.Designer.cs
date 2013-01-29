namespace FSAgent
{
	partial class AgentForm
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
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemProperties = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageGeneral = new System.Windows.Forms.TabPage();
			this.tabPageLog = new System.Windows.Forms.TabPage();
			this.tabPageAudio = new System.Windows.Forms.TabPage();
			this.groupBoxDevices = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxInputDevice = new System.Windows.Forms.ComboBox();
			this.comboBoxRingDevice = new System.Windows.Forms.ComboBox();
			this.comboBoxOutputDevice = new System.Windows.Forms.ComboBox();
			this.checkBoxDefaultDevices = new System.Windows.Forms.CheckBox();
			this.tabPageCustom = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.contextMenuStripNotifyIcon.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPageLog.SuspendLayout();
			this.tabPageAudio.SuspendLayout();
			this.groupBoxDevices.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(379, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "1007";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(3, 3);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(357, 244);
			this.textBox1.TabIndex = 1;
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenuStripNotifyIcon;
			this.notifyIcon.Visible = true;
			// 
			// contextMenuStripNotifyIcon
			// 
			this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemExit,
            this.ToolStripMenuItemProperties});
			this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
			this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(135, 48);
			// 
			// ToolStripMenuItemExit
			// 
			this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
			this.ToolStripMenuItemExit.Size = new System.Drawing.Size(134, 22);
			this.ToolStripMenuItemExit.Text = "Выход";
			this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
			// 
			// ToolStripMenuItemProperties
			// 
			this.ToolStripMenuItemProperties.Name = "ToolStripMenuItemProperties";
			this.ToolStripMenuItemProperties.Size = new System.Drawing.Size(134, 22);
			this.ToolStripMenuItemProperties.Text = "Настройки";
			this.ToolStripMenuItemProperties.Click += new System.EventHandler(this.ToolStripMenuItemProperties_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageLog);
			this.tabControl1.Controls.Add(this.tabPageGeneral);
			this.tabControl1.Controls.Add(this.tabPageAudio);
			this.tabControl1.Controls.Add(this.tabPageCustom);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new System.Drawing.Point(3, 3);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(371, 276);
			this.tabControl1.TabIndex = 3;
			// 
			// tabPageGeneral
			// 
			this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabPageGeneral.Name = "tabPageGeneral";
			this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGeneral.Size = new System.Drawing.Size(363, 250);
			this.tabPageGeneral.TabIndex = 0;
			this.tabPageGeneral.Text = "Общие";
			this.tabPageGeneral.UseVisualStyleBackColor = true;
			// 
			// tabPageLog
			// 
			this.tabPageLog.Controls.Add(this.textBox1);
			this.tabPageLog.Location = new System.Drawing.Point(4, 22);
			this.tabPageLog.Name = "tabPageLog";
			this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageLog.Size = new System.Drawing.Size(363, 250);
			this.tabPageLog.TabIndex = 1;
			this.tabPageLog.Text = "Лог";
			this.tabPageLog.UseVisualStyleBackColor = true;
			// 
			// tabPageAudio
			// 
			this.tabPageAudio.Controls.Add(this.groupBoxDevices);
			this.tabPageAudio.Controls.Add(this.checkBoxDefaultDevices);
			this.tabPageAudio.Location = new System.Drawing.Point(4, 22);
			this.tabPageAudio.Name = "tabPageAudio";
			this.tabPageAudio.Padding = new System.Windows.Forms.Padding(5);
			this.tabPageAudio.Size = new System.Drawing.Size(363, 250);
			this.tabPageAudio.TabIndex = 2;
			this.tabPageAudio.Text = "Аудио";
			this.tabPageAudio.UseVisualStyleBackColor = true;
			// 
			// groupBoxDevices
			// 
			this.groupBoxDevices.Controls.Add(this.label3);
			this.groupBoxDevices.Controls.Add(this.label2);
			this.groupBoxDevices.Controls.Add(this.label1);
			this.groupBoxDevices.Controls.Add(this.comboBoxInputDevice);
			this.groupBoxDevices.Controls.Add(this.comboBoxRingDevice);
			this.groupBoxDevices.Controls.Add(this.comboBoxOutputDevice);
			this.groupBoxDevices.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBoxDevices.Location = new System.Drawing.Point(5, 34);
			this.groupBoxDevices.Margin = new System.Windows.Forms.Padding(5);
			this.groupBoxDevices.Name = "groupBoxDevices";
			this.groupBoxDevices.Padding = new System.Windows.Forms.Padding(5);
			this.groupBoxDevices.Size = new System.Drawing.Size(353, 211);
			this.groupBoxDevices.TabIndex = 4;
			this.groupBoxDevices.TabStop = false;
			this.groupBoxDevices.Text = "Устройства";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Звонок";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Динамики";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Микрофон";
			// 
			// comboBoxInputDevice
			// 
			this.comboBoxInputDevice.FormattingEnabled = true;
			this.comboBoxInputDevice.Location = new System.Drawing.Point(7, 93);
			this.comboBoxInputDevice.Name = "comboBoxInputDevice";
			this.comboBoxInputDevice.Size = new System.Drawing.Size(220, 21);
			this.comboBoxInputDevice.TabIndex = 1;
			// 
			// comboBoxRingDevice
			// 
			this.comboBoxRingDevice.FormattingEnabled = true;
			this.comboBoxRingDevice.Location = new System.Drawing.Point(7, 44);
			this.comboBoxRingDevice.Name = "comboBoxRingDevice";
			this.comboBoxRingDevice.Size = new System.Drawing.Size(220, 21);
			this.comboBoxRingDevice.TabIndex = 0;
			// 
			// comboBoxOutputDevice
			// 
			this.comboBoxOutputDevice.FormattingEnabled = true;
			this.comboBoxOutputDevice.Location = new System.Drawing.Point(7, 142);
			this.comboBoxOutputDevice.Name = "comboBoxOutputDevice";
			this.comboBoxOutputDevice.Size = new System.Drawing.Size(220, 21);
			this.comboBoxOutputDevice.TabIndex = 2;
			// 
			// checkBoxDefaultDevices
			// 
			this.checkBoxDefaultDevices.AutoSize = true;
			this.checkBoxDefaultDevices.Location = new System.Drawing.Point(13, 9);
			this.checkBoxDefaultDevices.Name = "checkBoxDefaultDevices";
			this.checkBoxDefaultDevices.Size = new System.Drawing.Size(233, 17);
			this.checkBoxDefaultDevices.TabIndex = 3;
			this.checkBoxDefaultDevices.Text = "Использовать устройства по умолчанию";
			this.checkBoxDefaultDevices.UseVisualStyleBackColor = true;
			// 
			// tabPageCustom
			// 
			this.tabPageCustom.Location = new System.Drawing.Point(4, 22);
			this.tabPageCustom.Name = "tabPageCustom";
			this.tabPageCustom.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCustom.Size = new System.Drawing.Size(363, 250);
			this.tabPageCustom.TabIndex = 3;
			this.tabPageCustom.Text = "Дополнительно";
			this.tabPageCustom.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(380, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "release";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(380, 74);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "answer";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(380, 115);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 6;
			this.button4.Text = "reg";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(380, 146);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 7;
			this.button5.Text = "unreg";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// AgentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 276);
			this.ControlBox = false;
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.button1);
			this.Name = "AgentForm";
			this.Text = "Настройки";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgentForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Agent_FormClosed);
			this.Load += new System.EventHandler(this.AgentForm_Load);
			this.contextMenuStripNotifyIcon.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPageLog.ResumeLayout(false);
			this.tabPageLog.PerformLayout();
			this.tabPageAudio.ResumeLayout(false);
			this.tabPageAudio.PerformLayout();
			this.groupBoxDevices.ResumeLayout(false);
			this.groupBoxDevices.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageGeneral;
		private System.Windows.Forms.TabPage tabPageLog;
		private System.Windows.Forms.TabPage tabPageAudio;
		private System.Windows.Forms.ComboBox comboBoxOutputDevice;
		private System.Windows.Forms.ComboBox comboBoxInputDevice;
		private System.Windows.Forms.ComboBox comboBoxRingDevice;
		private System.Windows.Forms.TabPage tabPageCustom;
		private System.Windows.Forms.GroupBox groupBoxDevices;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBoxDefaultDevices;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemProperties;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
	}
}

