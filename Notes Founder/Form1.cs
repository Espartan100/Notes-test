using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes_Founder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

            string message = "Are you sure you want to clear the notes?";
            string title = "Clear Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                EmailTB.Text = "";
                VerificationCB.SelectedIndex = -1;
                ReasonTB.Text = "";
                ActionTB.Text = "";
                ResolutionTB.Text = "";
                ExpectationTB.Text = "";
                AInfoTB.Text = "";
            }
            else
            {
                // Do something  
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            //Format of the Complete Note
            string CombineText = string.Join("",
                "**FOUNDEVER NOTES**",Environment.NewLine,
                "Email: ", EmailTB.Text, Environment.NewLine,
                "Verification Type: ", VerificationCB.Text, Environment.NewLine,
                "Call Reason:",Environment.NewLine,
                ReasonTB.Text, Environment.NewLine,
                "***RESOLUTION DETAILS***", Environment.NewLine,
                "Actions Takens:", Environment.NewLine,
                ActionTB.Text, Environment.NewLine,
                "Resolution:", Environment.NewLine,
                ResolutionTB.Text, Environment.NewLine,
                "Set Expectations:", Environment.NewLine,
                ExpectationTB.Text, Environment.NewLine,
                "Additional Info:", Environment.NewLine,
                AInfoTB.Text);
            
            /* This is to test the complete Text
            MessageBox.Show(CombineText);
            */

            //This is to Clipboard(Ctrl + C) the complete text
            Clipboard.SetText(CombineText);
        }
    }
}
