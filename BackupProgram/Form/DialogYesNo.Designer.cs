namespace DarkDialog
{
    partial class DialogBoxDark
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
            this.cmdYes = new System.Windows.Forms.Button();
            this.cmdNo = new System.Windows.Forms.Button();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.cmsRightclick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableButtons = new System.Windows.Forms.TableLayoutPanel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmsRightclick.SuspendLayout();
            this.tableButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdYes
            // 
            this.cmdYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmdYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.cmdYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdYes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdYes.ForeColor = System.Drawing.Color.White;
            this.cmdYes.Location = new System.Drawing.Point(197, 2);
            this.cmdYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdYes.Name = "cmdYes";
            this.cmdYes.Size = new System.Drawing.Size(128, 48);
            this.cmdYes.TabIndex = 0;
            this.cmdYes.Text = "Yes";
            this.cmdYes.UseVisualStyleBackColor = false;
            // 
            // cmdNo
            // 
            this.cmdNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmdNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cmdNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdNo.Font = new System.Drawing.Font("Courier New", 12F);
            this.cmdNo.ForeColor = System.Drawing.Color.White;
            this.cmdNo.Location = new System.Drawing.Point(67, 2);
            this.cmdNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdNo.Name = "cmdNo";
            this.cmdNo.Size = new System.Drawing.Size(126, 48);
            this.cmdNo.TabIndex = 1;
            this.cmdNo.Text = "No";
            this.cmdNo.UseVisualStyleBackColor = false;
            // 
            // rtbMessage
            // 
            this.rtbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rtbMessage.ContextMenuStrip = this.cmsRightclick;
            this.rtbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMessage.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessage.ForeColor = System.Drawing.Color.White;
            this.rtbMessage.Location = new System.Drawing.Point(0, 0);
            this.rtbMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.Size = new System.Drawing.Size(327, 192);
            this.rtbMessage.TabIndex = 2;
            this.rtbMessage.Text = "";
            // 
            // cmsRightclick
            // 
            this.cmsRightclick.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsRightclick.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsRightclick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.cmsRightclick.Name = "cmsRightclick";
            this.cmsRightclick.Size = new System.Drawing.Size(117, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CmsCopy);
            // 
            // tableButtons
            // 
            this.tableButtons.ColumnCount = 3;
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableButtons.Controls.Add(this.cmdCancel, 0, 0);
            this.tableButtons.Controls.Add(this.cmdYes, 2, 0);
            this.tableButtons.Controls.Add(this.cmdNo, 1, 0);
            this.tableButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableButtons.Location = new System.Drawing.Point(0, 192);
            this.tableButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableButtons.Name = "tableButtons";
            this.tableButtons.RowCount = 1;
            this.tableButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableButtons.Size = new System.Drawing.Size(327, 52);
            this.tableButtons.TabIndex = 3;
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdCancel.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.cmdCancel.ForeColor = System.Drawing.Color.White;
            this.cmdCancel.Location = new System.Drawing.Point(2, 2);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(61, 48);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "r";
            this.cmdCancel.UseVisualStyleBackColor = false;
            // 
            // DialogBoxDark
            // 
            this.AcceptButton = this.cmdYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(327, 244);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.tableButtons);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "DialogBoxDark";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogBoxDark";
            this.cmsRightclick.ResumeLayout(false);
            this.tableButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdYes;
        private System.Windows.Forms.Button cmdNo;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.ContextMenuStrip cmsRightclick;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableButtons;
        private System.Windows.Forms.Button cmdCancel;
    }
}