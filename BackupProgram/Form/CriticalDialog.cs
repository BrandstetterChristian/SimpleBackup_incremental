using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDialog
{
    /// <summary>
    /// Dialoge for critical operations
    /// like accept license or delete permanent
    /// </summary>
    public partial class CriticalDialog : Form
    {
        public CriticalDialog()
        {
            InitializeComponent();
            cmdYes.Enabled = false;
            cmdYes.BackColor = Color.DarkGray;
            chbConfirm.Checked = false;
        }

        public string CheckBoxMessage { set { chbConfirm.Text = value; } }

        /// <summary>
        /// display critical message
        /// </summary>
        /// <param name="message">text to show</param>
        /// <param name="title">title of the form</param>
        /// <param name="checkboxmessage">message of the confirm checkbox</param>
        /// <returns></returns>
        public static DialogResult ShowDialog(string message, string title = "Warning", string checkboxmessage = "Accept")
        {
            using (CriticalDialog dialog = new CriticalDialog())
            {
                dialog.Text = title;
                dialog.CheckBoxMessage = checkboxmessage;
                dialog.rtbMessage.Text = message;

                dialog.ShowDialog();

                return dialog.DialogResult;
            }
        }

        private void cmdYes_Click(object sender, EventArgs e)
        {
            if (cmdYes.Enabled)
            {
                DialogResult = DialogResult.Yes;
            }
        }

        private void chbConfirm_CheckedChanged(object sender, EventArgs e)
        {
            cmdYes.Enabled = chbConfirm.Checked;
            cmdYes.BackColor = chbConfirm.Checked ? Color.Black : Color.DarkGray;
        }
    }
}
