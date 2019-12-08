namespace DarkDialog
{
    partial class CriticalDialog
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
            this.chbConfirm = new System.Windows.Forms.CheckBox();
            this.cmdYes = new System.Windows.Forms.Button();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.cmdNo = new System.Windows.Forms.Button();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbConfirm
            // 
            this.chbConfirm.AutoSize = true;
            this.tblButtons.SetColumnSpan(this.chbConfirm, 2);
            this.chbConfirm.Font = new System.Drawing.Font("Courier New", 12F);
            this.chbConfirm.Location = new System.Drawing.Point(2, 2);
            this.chbConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbConfirm.Name = "chbConfirm";
            this.chbConfirm.Size = new System.Drawing.Size(117, 22);
            this.chbConfirm.TabIndex = 1;
            this.chbConfirm.Text = "checkBox1";
            this.chbConfirm.UseVisualStyleBackColor = true;
            this.chbConfirm.CheckedChanged += new System.EventHandler(this.chbConfirm_CheckedChanged);
            // 
            // cmdYes
            // 
            this.cmdYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmdYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdYes.Font = new System.Drawing.Font("Courier New", 12F);
            this.cmdYes.ForeColor = System.Drawing.Color.White;
            this.cmdYes.Location = new System.Drawing.Point(165, 49);
            this.cmdYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdYes.Name = "cmdYes";
            this.cmdYes.Size = new System.Drawing.Size(160, 43);
            this.cmdYes.TabIndex = 3;
            this.cmdYes.Text = "Continue";
            this.cmdYes.UseVisualStyleBackColor = false;
            this.cmdYes.Click += new System.EventHandler(this.cmdYes_Click);
            // 
            // tblButtons
            // 
            this.tblButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tblButtons.ColumnCount = 2;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.Controls.Add(this.cmdNo, 0, 1);
            this.tblButtons.Controls.Add(this.chbConfirm, 0, 0);
            this.tblButtons.Controls.Add(this.cmdYes, 1, 1);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblButtons.Location = new System.Drawing.Point(0, 150);
            this.tblButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 2;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.Size = new System.Drawing.Size(327, 94);
            this.tblButtons.TabIndex = 4;
            // 
            // cmdNo
            // 
            this.cmdNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmdNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdNo.Font = new System.Drawing.Font("Courier New", 12F);
            this.cmdNo.ForeColor = System.Drawing.Color.White;
            this.cmdNo.Location = new System.Drawing.Point(2, 49);
            this.cmdNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdNo.Name = "cmdNo";
            this.cmdNo.Size = new System.Drawing.Size(159, 43);
            this.cmdNo.TabIndex = 4;
            this.cmdNo.Text = "Cancel";
            this.cmdNo.UseVisualStyleBackColor = false;
            // 
            // rtbMessage
            // 
            this.rtbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rtbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMessage.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessage.ForeColor = System.Drawing.Color.White;
            this.rtbMessage.Location = new System.Drawing.Point(0, 0);
            this.rtbMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.Size = new System.Drawing.Size(327, 150);
            this.rtbMessage.TabIndex = 5;
            this.rtbMessage.Text = "";
            // 
            // CriticalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.cmdNo;
            this.ClientSize = new System.Drawing.Size(327, 244);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.tblButtons);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CriticalDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CriticalDialog";
            this.tblButtons.ResumeLayout(false);
            this.tblButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chbConfirm;
        private System.Windows.Forms.Button cmdYes;
        private System.Windows.Forms.TableLayoutPanel tblButtons;
        private System.Windows.Forms.Button cmdNo;
        private System.Windows.Forms.RichTextBox rtbMessage;
    }
}