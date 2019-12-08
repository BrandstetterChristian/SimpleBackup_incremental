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
    /// yes / no / cancel dialog in dark mode
    /// use ShowDialog
    /// </summary>
    public partial class DialogBoxDark : Form
    {
        public DialogBoxDark()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Simple yes / no / cancel dialog
        /// usage: ShowDialog(...) == DialogResult.Yes
        /// </summary>
        /// <param name="message">text for richtextbox</param>
        /// <param name="title">title of the dialog</param>
        /// <returns>result yes, no, cancel</returns>
        public static DialogResult ShowDialog(string message, string title = "Dialog")
        {
            using (DialogBoxDark dialog = new DialogBoxDark())
            {
                dialog.Text = title;
                dialog.rtbMessage.Text = message;
                dialog.ShowDialog();
                return dialog.DialogResult;
            }
        }

        private void CmsCopy(object sender, EventArgs e)
        {
            try
            {
                // copies label text
                Clipboard.SetText(rtbMessage.Text);
            }
            catch
            {
                return;
            }
        }

    }
}
