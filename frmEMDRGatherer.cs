using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMDRGatherer
{
    public partial class frmEMDRGatherer : Form
    {

    #region Class Variables
        emdrDl edl;
        BackgroundWorker bw;
        BackgroundWorker trimBw;
        bwWorkerArgs bwArgs;
        EmdrConfig config;

    #endregion

    #region Constructor
        public frmEMDRGatherer()
        {
            edl = new emdrDl();
            bw = new BackgroundWorker();
            trimBw = new BackgroundWorker();

            InitializeComponent();

            config = new EmdrConfig();

            if (config.CfgState != ConfigState.ConfigLoaded)
            {
                DialogResult res;
                while (OpenOptionDialog() != ConfigState.ConfigLoaded)
                {
                    res = MessageBox.Show(this, "Configuation is Invalid. Please complete the configuration to continue. Press OK to try again or cancel to close the program" 
                        , "Invalid Configuration", 
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                    if (res == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                }
                btnStartCapture.Enabled = true;
            }
            else
            {
                btnStartCapture.Enabled = true;
            }

            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler(edl.getMarketData);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);

            trimBw.WorkerSupportsCancellation = true;
            trimBw.DoWork += new DoWorkEventHandler(edl.trimOrderData);

            
        }
    #endregion

    #region Control Event Handlers

        private void frmEMDRGatherer_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStartCapture_Click(object sender, EventArgs e)
        {
            if (bw.IsBusy != true)
            {
                bwArgs = new bwWorkerArgs(config.Attr.EMDRServer, config.Attr.DataSource, config.Attr.MergeDuplicates, 
                    config.Attr.CaptureHistory, config.Attr.CaptureOrders);

                bw.RunWorkerAsync(bwArgs);

                if (trimBw.IsBusy != true)
                {
                    trimBw.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show(@"The Background Workers did not start because they are in a busy state",
                        "Error: BackgroundWorker Busy", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            tsCaptureState.Text = @"Capture Status: Running";
            tsTrimState.Text = @"Trim Status: Active";
            btnStopCapture.Enabled = true;
            btnStartCapture.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bw.IsBusy)
            {
                bw.CancelAsync();
            }
            this.Close();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenOptionDialog();            
        }

        private void llblzeromq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llblzeromq.LinkVisited = true;
            System.Diagnostics.Process.Start("http://zeroMQ.com/");
        }

        private void llblEMDR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llblEMDR.LinkVisited = true;
            System.Diagnostics.Process.Start("http://eve-market-data-relay.readthedocs.org/");
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            bwResponse ba = (bwResponse)e.UserState;

            tbHistRowCnt.Text = String.Format("{0:N0}", ba.HistCnt);
            tbOrdRowCnt.Text = String.Format("{0:N0}", ba.OrdCnt);
        }

        private void btnStopCapture_Click(object sender, EventArgs e)
        {
            if (bw.WorkerSupportsCancellation == true)
            {
                bw.CancelAsync();

                if (trimBw.WorkerSupportsCancellation == true)
                {
                    trimBw.CancelAsync();
                }
            }            
        }
    #endregion

    #region Background Worker Handlers

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                tsCaptureState.Text = @"Capture Status: Stopped";
            }
            else if (!(e.Error == null))
            {
                tsCaptureState.Text = @"Capture Status: Error Received";
                MessageBox.Show(e.Error.Message.ToString(), @"Error in BackgroundWorker!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                tsCaptureState.Text = @"Capture Status: Stopped";
            }

            btnStopCapture.Enabled = false;
            btnStartCapture.Enabled = true;
        }

        private void trimBw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                tsTrimState.Text = @"Trim Status: Inactive";
            }

            else if (!(e.Error == null))
            {
                tsTrimState.Text = @"Capture Status: Error Received";
                MessageBox.Show(e.Error.Message.ToString(), @"Error in BackgroundWorker!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else
            {
                tsTrimState.Text = @"Trim Status: Inactive";
            }
        }

    #endregion

    #region Dialog Handlers
        private ConfigState OpenOptionDialog()
        {
            DialogResult result;
            frmOptionsDialog optionsDlg = new frmOptionsDialog(config);

            result = optionsDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                config.Attr.DataSource = optionsDlg.tbDataBaseConnName.Text;
                config.Attr.MergeDuplicates = optionsDlg.cbMergeDuplicates.Checked;               
                config.Attr.TrimOrdersDays = int.Parse(optionsDlg.tbOrdTrimDays.Text);
                config.Attr.TrimHistDays = int.Parse(optionsDlg.tbHistTrimDays.Text);
                config.Attr.EMDRServer = optionsDlg.cbEmdrServer.Text;
                config.Attr.CaptureHistory = optionsDlg.cbCaptureHistory.Checked;
                config.Attr.CaptureOrders = optionsDlg.cbCaptureOrders.Checked;
                

                //Write out the new config options
                if (config.WriteConfig() == ConfigState.ConfigSaved)
                {
                    return ConfigState.ConfigLoaded;
                }
                else
                {
                    return ConfigState.ConfigNotLoaded;
                }
            }
            else if (result != DialogResult.OK && config.CfgState == ConfigState.ConfigLoaded)
            {
                //In case everything was already loaded and we close with out changing
                return ConfigState.ConfigLoaded;
            }

            return ConfigState.ConfigNotLoaded;
            
        }

        
    #endregion
       
    }
}
