namespace EMDRGatherer
{
    partial class frmEMDRGatherer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartCapture = new System.Windows.Forms.Button();
            this.btnStopCapture = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsCaptureState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTrimState = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbStatistics = new System.Windows.Forms.GroupBox();
            this.tbOrdRowCnt = new System.Windows.Forms.TextBox();
            this.tbHistRowCnt = new System.Windows.Forms.TextBox();
            this.lblOrdRowsProced = new System.Windows.Forms.Label();
            this.lblhistRecProced = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llblzeromq = new System.Windows.Forms.LinkLabel();
            this.llblEMDR = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Enabled = false;
            this.btnStartCapture.Location = new System.Drawing.Point(13, 28);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(75, 23);
            this.btnStartCapture.TabIndex = 1;
            this.btnStartCapture.Text = "Start Capture";
            this.btnStartCapture.UseVisualStyleBackColor = true;
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
            // 
            // btnStopCapture
            // 
            this.btnStopCapture.Enabled = false;
            this.btnStopCapture.Location = new System.Drawing.Point(13, 57);
            this.btnStopCapture.Name = "btnStopCapture";
            this.btnStopCapture.Size = new System.Drawing.Size(75, 23);
            this.btnStopCapture.TabIndex = 3;
            this.btnStopCapture.Text = "Stop Capture";
            this.btnStopCapture.UseVisualStyleBackColor = true;
            this.btnStopCapture.Click += new System.EventHandler(this.btnStopCapture_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCaptureState,
            this.tsTrimState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 151);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(373, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsCaptureState
            // 
            this.tsCaptureState.Name = "tsCaptureState";
            this.tsCaptureState.Size = new System.Drawing.Size(158, 17);
            this.tsCaptureState.Text = "Capture Status: Not Running";
            // 
            // tsTrimState
            // 
            this.tsTrimState.Name = "tsTrimState";
            this.tsTrimState.Size = new System.Drawing.Size(114, 17);
            this.tsTrimState.Text = "Trim Status: Inactive";
            // 
            // gbStatistics
            // 
            this.gbStatistics.Controls.Add(this.tbOrdRowCnt);
            this.gbStatistics.Controls.Add(this.tbHistRowCnt);
            this.gbStatistics.Controls.Add(this.lblOrdRowsProced);
            this.gbStatistics.Controls.Add(this.lblhistRecProced);
            this.gbStatistics.Location = new System.Drawing.Point(95, 28);
            this.gbStatistics.Name = "gbStatistics";
            this.gbStatistics.Size = new System.Drawing.Size(266, 71);
            this.gbStatistics.TabIndex = 5;
            this.gbStatistics.TabStop = false;
            this.gbStatistics.Text = "Statistics";
            // 
            // tbOrdRowCnt
            // 
            this.tbOrdRowCnt.Location = new System.Drawing.Point(139, 40);
            this.tbOrdRowCnt.Name = "tbOrdRowCnt";
            this.tbOrdRowCnt.Size = new System.Drawing.Size(121, 20);
            this.tbOrdRowCnt.TabIndex = 3;
            this.tbOrdRowCnt.Text = "0";
            this.tbOrdRowCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbHistRowCnt
            // 
            this.tbHistRowCnt.Location = new System.Drawing.Point(139, 13);
            this.tbHistRowCnt.Name = "tbHistRowCnt";
            this.tbHistRowCnt.Size = new System.Drawing.Size(121, 20);
            this.tbHistRowCnt.TabIndex = 2;
            this.tbHistRowCnt.Text = "0";
            this.tbHistRowCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOrdRowsProced
            // 
            this.lblOrdRowsProced.AutoSize = true;
            this.lblOrdRowsProced.Location = new System.Drawing.Point(6, 43);
            this.lblOrdRowsProced.Name = "lblOrdRowsProced";
            this.lblOrdRowsProced.Size = new System.Drawing.Size(119, 13);
            this.lblOrdRowsProced.TabIndex = 1;
            this.lblOrdRowsProced.Text = "Order Rows Processed:";
            // 
            // lblhistRecProced
            // 
            this.lblhistRecProced.AutoSize = true;
            this.lblhistRecProced.Location = new System.Drawing.Point(6, 16);
            this.lblhistRecProced.Name = "lblhistRecProced";
            this.lblhistRecProced.Size = new System.Drawing.Size(125, 13);
            this.lblhistRecProced.TabIndex = 0;
            this.lblhistRecProced.Text = "History Rows Processed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Made possible by ZeroMQ and the EMDR Team.";
            // 
            // llblzeromq
            // 
            this.llblzeromq.AutoSize = true;
            this.llblzeromq.Location = new System.Drawing.Point(14, 135);
            this.llblzeromq.Name = "llblzeromq";
            this.llblzeromq.Size = new System.Drawing.Size(103, 13);
            this.llblzeromq.TabIndex = 7;
            this.llblzeromq.TabStop = true;
            this.llblzeromq.Text = "http://zeroMQ.com/";
            this.llblzeromq.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblzeromq_LinkClicked);
            // 
            // llblEMDR
            // 
            this.llblEMDR.AutoSize = true;
            this.llblEMDR.Location = new System.Drawing.Point(14, 119);
            this.llblEMDR.Name = "llblEMDR";
            this.llblEMDR.Size = new System.Drawing.Size(225, 13);
            this.llblEMDR.TabIndex = 8;
            this.llblEMDR.TabStop = true;
            this.llblEMDR.Text = "http://eve-market-data-relay.readthedocs.org/";
            this.llblEMDR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblEMDR_LinkClicked);
            // 
            // frmEMDRGatherer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 173);
            this.Controls.Add(this.llblEMDR);
            this.Controls.Add(this.llblzeromq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbStatistics);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnStopCapture);
            this.Controls.Add(this.btnStartCapture);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEMDRGatherer";
            this.Text = "EMDR Gatherer";
            this.Load += new System.EventHandler(this.frmEMDRGatherer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbStatistics.ResumeLayout(false);
            this.gbStatistics.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnStartCapture;
        private System.Windows.Forms.Button btnStopCapture;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsCaptureState;
        private System.Windows.Forms.GroupBox gbStatistics;
        private System.Windows.Forms.TextBox tbOrdRowCnt;
        private System.Windows.Forms.TextBox tbHistRowCnt;
        private System.Windows.Forms.Label lblOrdRowsProced;
        private System.Windows.Forms.Label lblhistRecProced;
        private System.Windows.Forms.ToolStripStatusLabel tsTrimState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llblzeromq;
        private System.Windows.Forms.LinkLabel llblEMDR;
    }
}

