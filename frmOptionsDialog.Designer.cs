namespace EMDRGatherer
{
    partial class frmOptionsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptionsDialog));
            this.lblHighWatermark = new System.Windows.Forms.Label();
            this.lblDiskBufferSize = new System.Windows.Forms.Label();
            this.tbHighWaterMark = new System.Windows.Forms.TextBox();
            this.tbDiskBufferSize = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEMDRServers = new System.Windows.Forms.Label();
            this.cbMessageBufferSettings = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbHistTrimDays = new System.Windows.Forms.TextBox();
            this.cbMergeDuplicates = new System.Windows.Forms.CheckBox();
            this.lblTrimOrderAge = new System.Windows.Forms.Label();
            this.lblHistAge = new System.Windows.Forms.Label();
            this.tbOrdTrimDays = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.btnSqlConnection = new System.Windows.Forms.Button();
            this.tbDataBaseConnName = new System.Windows.Forms.TextBox();
            this.tabEMDRServers = new System.Windows.Forms.TabPage();
            this.cbEmdrServer = new System.Windows.Forms.ComboBox();
            this.tabMessageBuffer = new System.Windows.Forms.TabPage();
            this.ttOptionDialog = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabDatabase.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabEMDRServers.SuspendLayout();
            this.tabMessageBuffer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHighWatermark
            // 
            this.lblHighWatermark.AutoSize = true;
            this.lblHighWatermark.Location = new System.Drawing.Point(9, 39);
            this.lblHighWatermark.Name = "lblHighWatermark";
            this.lblHighWatermark.Size = new System.Drawing.Size(126, 13);
            this.lblHighWatermark.TabIndex = 0;
            this.lblHighWatermark.Text = "Queue High Water Mark:";
            // 
            // lblDiskBufferSize
            // 
            this.lblDiskBufferSize.AutoSize = true;
            this.lblDiskBufferSize.Location = new System.Drawing.Point(9, 63);
            this.lblDiskBufferSize.Name = "lblDiskBufferSize";
            this.lblDiskBufferSize.Size = new System.Drawing.Size(85, 13);
            this.lblDiskBufferSize.TabIndex = 1;
            this.lblDiskBufferSize.Text = "Disk Buffer Size:";
            // 
            // tbHighWaterMark
            // 
            this.tbHighWaterMark.Enabled = false;
            this.tbHighWaterMark.Location = new System.Drawing.Point(136, 36);
            this.tbHighWaterMark.Name = "tbHighWaterMark";
            this.tbHighWaterMark.Size = new System.Drawing.Size(118, 20);
            this.tbHighWaterMark.TabIndex = 2;
            this.tbHighWaterMark.Text = "0";
            this.ttOptionDialog.SetToolTip(this.tbHighWaterMark, resources.GetString("tbHighWaterMark.ToolTip"));
            this.tbHighWaterMark.TextChanged += new System.EventHandler(this.tbHighWaterMark_TextChanged);
            // 
            // tbDiskBufferSize
            // 
            this.tbDiskBufferSize.Enabled = false;
            this.tbDiskBufferSize.Location = new System.Drawing.Point(136, 60);
            this.tbDiskBufferSize.Name = "tbDiskBufferSize";
            this.tbDiskBufferSize.Size = new System.Drawing.Size(118, 20);
            this.tbDiskBufferSize.TabIndex = 3;
            this.tbDiskBufferSize.Text = "0";
            this.ttOptionDialog.SetToolTip(this.tbDiskBufferSize, resources.GetString("tbDiskBufferSize.ToolTip"));
            this.tbDiskBufferSize.TextChanged += new System.EventHandler(this.tbDiskBufferSize_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(89, 253);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(222, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblEMDRServers
            // 
            this.lblEMDRServers.AutoSize = true;
            this.lblEMDRServers.Location = new System.Drawing.Point(3, 10);
            this.lblEMDRServers.Name = "lblEMDRServers";
            this.lblEMDRServers.Size = new System.Drawing.Size(100, 13);
            this.lblEMDRServers.TabIndex = 7;
            this.lblEMDRServers.Text = "EVE EMDR Server:";
            // 
            // cbMessageBufferSettings
            // 
            this.cbMessageBufferSettings.AutoSize = true;
            this.cbMessageBufferSettings.Location = new System.Drawing.Point(12, 13);
            this.cbMessageBufferSettings.Name = "cbMessageBufferSettings";
            this.cbMessageBufferSettings.Size = new System.Drawing.Size(229, 17);
            this.cbMessageBufferSettings.TabIndex = 4;
            this.cbMessageBufferSettings.Text = "Enable Advanced Message Buffer Settings";
            this.cbMessageBufferSettings.UseVisualStyleBackColor = true;
            this.cbMessageBufferSettings.CheckedChanged += new System.EventHandler(this.cbMessageBufferSettings_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDatabase);
            this.tabControl1.Controls.Add(this.tabEMDRServers);
            this.tabControl1.Controls.Add(this.tabMessageBuffer);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 234);
            this.tabControl1.TabIndex = 10;
            // 
            // tabDatabase
            // 
            this.tabDatabase.Controls.Add(this.groupBox2);
            this.tabDatabase.Controls.Add(this.groupBox1);
            this.tabDatabase.Location = new System.Drawing.Point(4, 22);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatabase.Size = new System.Drawing.Size(364, 208);
            this.tabDatabase.TabIndex = 0;
            this.tabDatabase.Text = "Database";
            this.tabDatabase.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbHistTrimDays);
            this.groupBox2.Controls.Add(this.cbMergeDuplicates);
            this.groupBox2.Controls.Add(this.lblTrimOrderAge);
            this.groupBox2.Controls.Add(this.lblHistAge);
            this.groupBox2.Controls.Add(this.tbOrdTrimDays);
            this.groupBox2.Location = new System.Drawing.Point(6, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 99);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Management Settings";
            // 
            // tbHistTrimDays
            // 
            this.tbHistTrimDays.Location = new System.Drawing.Point(174, 65);
            this.tbHistTrimDays.Name = "tbHistTrimDays";
            this.tbHistTrimDays.Size = new System.Drawing.Size(169, 20);
            this.tbHistTrimDays.TabIndex = 7;
            this.tbHistTrimDays.Text = "0";
            this.ttOptionDialog.SetToolTip(this.tbHistTrimDays, "The age in days at which the trim function \r\nremoves an order from the database. " +
        " \r\n(Valid values: 0-10000, 0 = disable)");
            this.tbHistTrimDays.TextChanged += new System.EventHandler(this.tbHistTrimDays_TextChanged);
            // 
            // cbMergeDuplicates
            // 
            this.cbMergeDuplicates.AutoSize = true;
            this.cbMergeDuplicates.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbMergeDuplicates.Location = new System.Drawing.Point(5, 19);
            this.cbMergeDuplicates.Name = "cbMergeDuplicates";
            this.cbMergeDuplicates.Size = new System.Drawing.Size(110, 17);
            this.cbMergeDuplicates.TabIndex = 2;
            this.cbMergeDuplicates.Text = "Merge duplicates:";
            this.ttOptionDialog.SetToolTip(this.cbMergeDuplicates, resources.GetString("cbMergeDuplicates.ToolTip"));
            this.cbMergeDuplicates.UseVisualStyleBackColor = true;
            this.cbMergeDuplicates.CheckedChanged += new System.EventHandler(this.cbMergeDuplicates_CheckedChanged);
            // 
            // lblTrimOrderAge
            // 
            this.lblTrimOrderAge.AutoSize = true;
            this.lblTrimOrderAge.Location = new System.Drawing.Point(5, 42);
            this.lblTrimOrderAge.Name = "lblTrimOrderAge";
            this.lblTrimOrderAge.Size = new System.Drawing.Size(167, 13);
            this.lblTrimOrderAge.TabIndex = 3;
            this.lblTrimOrderAge.Text = "Trim orders x days after expiration:";
            this.ttOptionDialog.SetToolTip(this.lblTrimOrderAge, "The number of days after the order expires\r\nbefore the trim function removes an o" +
        "rder\r\nfrom the database.  (Valid values: 1-10000)");
            // 
            // lblHistAge
            // 
            this.lblHistAge.AutoSize = true;
            this.lblHistAge.Location = new System.Drawing.Point(5, 68);
            this.lblHistAge.Name = "lblHistAge";
            this.lblHistAge.Size = new System.Drawing.Size(161, 13);
            this.lblHistAge.TabIndex = 6;
            this.lblHistAge.Text = "Trim History x days after capture:";
            // 
            // tbOrdTrimDays
            // 
            this.tbOrdTrimDays.Location = new System.Drawing.Point(174, 39);
            this.tbOrdTrimDays.Name = "tbOrdTrimDays";
            this.tbOrdTrimDays.Size = new System.Drawing.Size(169, 20);
            this.tbOrdTrimDays.TabIndex = 4;
            this.tbOrdTrimDays.Text = "0";
            this.ttOptionDialog.SetToolTip(this.tbOrdTrimDays, "The number of days after the order expires\r\nbefore the trim function removes an o" +
        "rder\r\nfrom the database.  (Valid values: 0-10000, 0 = disable)\r\n\r\n");
            this.tbOrdTrimDays.TextChanged += new System.EventHandler(this.tbOrdTrimDays_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDataSource);
            this.groupBox1.Controls.Add(this.btnSqlConnection);
            this.groupBox1.Controls.Add(this.tbDataBaseConnName);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 88);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Connection Settings";
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Location = new System.Drawing.Point(8, 16);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(70, 13);
            this.lblDataSource.TabIndex = 2;
            this.lblDataSource.Text = "Data Source:";
            // 
            // btnSqlConnection
            // 
            this.btnSqlConnection.Location = new System.Drawing.Point(11, 59);
            this.btnSqlConnection.Name = "btnSqlConnection";
            this.btnSqlConnection.Size = new System.Drawing.Size(104, 23);
            this.btnSqlConnection.TabIndex = 1;
            this.btnSqlConnection.Text = "SQL Connection";
            this.btnSqlConnection.UseVisualStyleBackColor = true;
            this.btnSqlConnection.Click += new System.EventHandler(this.btnSqlConnection_Click);
            // 
            // tbDataBaseConnName
            // 
            this.tbDataBaseConnName.Location = new System.Drawing.Point(11, 33);
            this.tbDataBaseConnName.Name = "tbDataBaseConnName";
            this.tbDataBaseConnName.Size = new System.Drawing.Size(341, 20);
            this.tbDataBaseConnName.TabIndex = 0;
            // 
            // tabEMDRServers
            // 
            this.tabEMDRServers.Controls.Add(this.cbEmdrServer);
            this.tabEMDRServers.Controls.Add(this.lblEMDRServers);
            this.tabEMDRServers.Location = new System.Drawing.Point(4, 22);
            this.tabEMDRServers.Name = "tabEMDRServers";
            this.tabEMDRServers.Padding = new System.Windows.Forms.Padding(3);
            this.tabEMDRServers.Size = new System.Drawing.Size(364, 208);
            this.tabEMDRServers.TabIndex = 1;
            this.tabEMDRServers.Text = "EMDR Servers";
            this.tabEMDRServers.UseVisualStyleBackColor = true;
            // 
            // cbEmdrServer
            // 
            this.cbEmdrServer.FormattingEnabled = true;
            this.cbEmdrServer.Items.AddRange(new object[] {
            "tcp://relay-us-west-1.eve-emdr.com:8050",
            "tcp://relay-us-central-1.eve-emdr.com:8050",
            "tcp://relay-us-east-1.eve-emdr.com:8050",
            "tcp://relay-ca-east-1.eve-emdr.com:8050",
            "tcp://relay-eu-sweden-1.eve-emdr.com:8050",
            "tcp://relay-eu-germany-1.eve-emdr.com:8050",
            "tcp://relay-eu-france-2.eve-emdr.com:8050",
            "tcp://relay-eu-denmark-1.eve-emdr.com:8050"});
            this.cbEmdrServer.Location = new System.Drawing.Point(7, 27);
            this.cbEmdrServer.Name = "cbEmdrServer";
            this.cbEmdrServer.Size = new System.Drawing.Size(322, 21);
            this.cbEmdrServer.TabIndex = 8;
            // 
            // tabMessageBuffer
            // 
            this.tabMessageBuffer.Controls.Add(this.label1);
            this.tabMessageBuffer.Controls.Add(this.tbDiskBufferSize);
            this.tabMessageBuffer.Controls.Add(this.cbMessageBufferSettings);
            this.tabMessageBuffer.Controls.Add(this.lblHighWatermark);
            this.tabMessageBuffer.Controls.Add(this.tbHighWaterMark);
            this.tabMessageBuffer.Controls.Add(this.lblDiskBufferSize);
            this.tabMessageBuffer.Location = new System.Drawing.Point(4, 22);
            this.tabMessageBuffer.Name = "tabMessageBuffer";
            this.tabMessageBuffer.Size = new System.Drawing.Size(364, 208);
            this.tabMessageBuffer.TabIndex = 2;
            this.tabMessageBuffer.Text = "Message Buffer";
            this.tabMessageBuffer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(260, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "(not implemented)";
            // 
            // frmOptionsDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(396, 285);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptionsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptionsDialog_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDatabase.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabEMDRServers.ResumeLayout(false);
            this.tabEMDRServers.PerformLayout();
            this.tabMessageBuffer.ResumeLayout(false);
            this.tabMessageBuffer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHighWatermark;
        private System.Windows.Forms.Label lblDiskBufferSize;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEMDRServers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDatabase;
        private System.Windows.Forms.ToolTip ttOptionDialog;
        private System.Windows.Forms.Label lblTrimOrderAge;
        private System.Windows.Forms.TabPage tabEMDRServers;
        private System.Windows.Forms.TabPage tabMessageBuffer;
        private System.Windows.Forms.Label lblHistAge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSqlConnection;
        private System.Windows.Forms.Label lblDataSource;
        public System.Windows.Forms.TextBox tbDataBaseConnName;
        public System.Windows.Forms.TextBox tbHighWaterMark;
        public System.Windows.Forms.TextBox tbDiskBufferSize;
        public System.Windows.Forms.CheckBox cbMessageBufferSettings;
        public System.Windows.Forms.TextBox tbOrdTrimDays;
        public System.Windows.Forms.CheckBox cbMergeDuplicates;
        public System.Windows.Forms.TextBox tbHistTrimDays;
        public System.Windows.Forms.ComboBox cbEmdrServer;
        private System.Windows.Forms.Label label1;
    }
}