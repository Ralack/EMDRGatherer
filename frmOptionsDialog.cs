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
        public frmOptionsDialog()
        {

            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbDiskBufferSize_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch("[^0-9]", tbDiskBufferSize.Text))
            {
                MessageBox.Show(@"Valid values are 0 to 1000000 MB.", "Invalid Input", MessageBoxButtons.OK);
                tbDiskBufferSize.Text.Remove(tbDiskBufferSize.Text.Length - 1);

                return;
            }
            else if (int.Parse(tbDiskBufferSize.Text) < 1 || int.Parse(tbDiskBufferSize.Text) > 1000000)
            {
                MessageBox.Show(@"Valid values are 0 to 1000000 MB.", "Invalid Input", MessageBoxButtons.OK);

                if (Int64.Parse(tbDiskBufferSize.Text) < 1)
                    tbDiskBufferSize.Text = @"0";
                else
                    tbDiskBufferSize.Text = @"1000000";
            }
        }

        private void tbHighWaterMark_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch("[^0-9]", tbHighWaterMark.Text))
            {
                MessageBox.Show(@"Valid values are 1 to 1000000 Messages.", "Invalid Input", MessageBoxButtons.OK);
                tbHighWaterMark.Text.Remove(tbHighWaterMark.Text.Length - 1);

                return;
            }
            else if (int.Parse(tbHighWaterMark.Text) < 0 || int.Parse(tbHighWaterMark.Text) > 1000000)
            {
                MessageBox.Show(@"Valid values are 0 to 1000000 Messages.", "Invalid Input", MessageBoxButtons.OK);

                if (Int64.Parse(tbHighWaterMark.Text) < 0)
                    tbHighWaterMark.Text = @"0";
                else
                    tbHighWaterMark.Text = @"1000000";
            }
        }

        private void cbMessageBufferSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMessageBufferSettings.Checked == true)
            {
                
                tbDiskBufferSize.Enabled = true;
                //tbHighWaterMark.Enabled = true;
            }
            else
            {
                
                tbDiskBufferSize.Enabled = false;
                //tbHighWaterMark.Enabled = false;
            }
        }

        

        private void cbMergeDuplicates_CheckedChanged(object sender, EventArgs e)
        {

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
            DataConnectionDialog dcd = new DataConnectionDialog();
            //ToDo: Load the existing configuration if present
            DataConnectionConfiguration dcs = new DataConnectionConfiguration(null);
            dcs.LoadConfiguration(dcd);

            if (DataConnectionDialog.Show(dcd) == DialogResult.OK)
            {
                tbDataBaseConnName.Text = dcd.ConnectionString;
                
            }
        }

        private void frmOptionsDialog_Load(object sender, EventArgs e)
        {

        }

        private void clbEMDRServers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
