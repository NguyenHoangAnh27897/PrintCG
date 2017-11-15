namespace PrintCG_24062016
{
    partial class FrmUpdate
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
            this.btndownload = new System.Windows.Forms.Button();
            this.lstfile = new System.Windows.Forms.ListBox();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.txtclient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndownload
            // 
            this.btndownload.Location = new System.Drawing.Point(194, 258);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(75, 23);
            this.btndownload.TabIndex = 0;
            this.btndownload.Text = "Download";
            this.btndownload.UseVisualStyleBackColor = true;
            // 
            // lstfile
            // 
            this.lstfile.FormattingEnabled = true;
            this.lstfile.Location = new System.Drawing.Point(12, 12);
            this.lstfile.Name = "lstfile";
            this.lstfile.Size = new System.Drawing.Size(428, 173);
            this.lstfile.TabIndex = 1;
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(60, 192);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(121, 20);
            this.txtserver.TabIndex = 2;
            // 
            // txtclient
            // 
            this.txtclient.Location = new System.Drawing.Point(319, 192);
            this.txtclient.Name = "txtclient";
            this.txtclient.Size = new System.Drawing.Size(121, 20);
            this.txtclient.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Client";
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtclient);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.lstfile);
            this.Controls.Add(this.btndownload);
            this.Name = "FrmUpdate";
            this.Text = "FrmUpdate";
            this.Load += new System.EventHandler(this.FrmUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.ListBox lstfile;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.TextBox txtclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}