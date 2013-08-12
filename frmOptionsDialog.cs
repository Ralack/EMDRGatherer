using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;


namespace EMDRGatherer
{
    public partial class frmOptionsDialog : Form
    {
        DataConnectionDialog dcd;

        public frmOptionsDialog()
        {
            dcd = new DataConnectionDialog();

            InitializeComponent();
        }

        public frmOptionsDialog( EmdrConfig _cfg)
        {
            dcd = new DataConnectionDialog();

            InitializeComponent();

            dcd.ConnectionString = _cfg.Attr.DataSource;
            tbDataBaseConnName.Text = _cfg.Attr.DataSource;            
            tbHistTrimDays.Text = _cfg.Attr.TrimHistDays.ToString();
            tbOrdTrimDays.Text = _cfg.Attr.TrimOrdersDays.ToString();
            cbEmdrServer.Text = _cfg.Attr.EMDRServer;
            cbMergeDuplicates.Checked = _cfg.Attr.MergeDuplicates;            

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
               
                     
        private void tbOrdTrimDays_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch("[^0-9]", tbOrdTrimDays.Text))
            {
                MessageBox.Show(@"Valid values are 1 to 1000000 Days.", "Invalid Input", MessageBoxButtons.OK);
                tbOrdTrimDays.Text.Remove(tbOrdTrimDays.Text.Length - 1);

                return;
            }
            else if (int.Parse(tbOrdTrimDays.Text) < 0 || int.Parse(tbOrdTrimDays.Text) > 1000000)
            {
                MessageBox.Show(@"Valid values are 0 to 1000000 Days.", "Invalid Input", MessageBoxButtons.OK);

                if (int.Parse(tbOrdTrimDays.Text) < 0)
                    tbOrdTrimDays.Text = @"0";
                else
                    tbOrdTrimDays.Text = @"1000000";
            }
        }


        private void tbHistTrimDays_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch("[^0-9]", tbHistTrimDays.Text))
            {
                MessageBox.Show(@"Valid values are 1 to 1000000 Days.", "Invalid Input", MessageBoxButtons.OK);
                tbHistTrimDays.Text.Remove(tbHistTrimDays.Text.Length - 1);

                return;
            }
            else if (int.Parse(tbHistTrimDays.Text) < 0 || int.Parse(tbHistTrimDays.Text) > 1000000)
            {
                MessageBox.Show(@"Valid values are 0 to 1000000 Days.", "Invalid Input", MessageBoxButtons.OK);

                if (Int64.Parse(tbHistTrimDays.Text) < 0)
                    tbHistTrimDays.Text = @"0";
                else
                    tbHistTrimDays.Text = @"1000000";
            }
        }

        private void btnSqlConnection_Click(object sender, EventArgs e)
        {
            DataConnectionConfiguration dcs = new DataConnectionConfiguration(null); ;
                                   
            dcs.LoadConfiguration(dcd);

            if (DataConnectionDialog.Show(dcd) == DialogResult.OK)
            {
                tbDataBaseConnName.Text = dcd.ConnectionString;
                
            }
        }

        private void cbCaptureHistory_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCaptureHistory.Checked == false)
            {
                tbHistTrimDays.Enabled = false;
                tbHistTrimDays.Text = "0";
            }
            else
            {
                tbHistTrimDays.Enabled = true;
                
            }
        }

        private void cbCaptureOrders_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCaptureOrders.Checked == false)
            {
                tbOrdTrimDays.Enabled = false;
                tbOrdTrimDays.Text = "0";
            }
            else
            {
                tbOrdTrimDays.Enabled = true;
            }
        }
    }
}
