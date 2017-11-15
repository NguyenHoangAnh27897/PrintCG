namespace PrintCG_24062016
{
    partial class FrmCOD
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
            this.lblfile = new System.Windows.Forms.Label();
            this.btnchonfile = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblfile
            // 
            this.lblfile.AutoSize = true;
            this.lblfile.Location = new System.Drawing.Point(93, 17);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(96, 13);
            this.lblfile.TabIndex = 10;
            this.lblfile.Text = "Bạn chưa chọn file";
            // 
            // btnchonfile
            // 
            this.btnchonfile.Location = new System.Drawing.Point(12, 12);
            this.btnchonfile.Name = "btnchonfile";
            this.btnchonfile.Size = new System.Drawing.Size(75, 23);
            this.btnchonfile.TabIndex = 11;
            this.btnchonfile.Text = "Chọn file";
            this.btnchonfile.UseVisualStyleBackColor = true;
            this.btnchonfile.Click += new System.EventHandler(this.btnchonfile_Click);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(130, 57);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(128, 52);
            this.btnin.TabIndex = 12;
            this.btnin.Text = "In phiếu gửi";
            this.btnin.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FrmCOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 121);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.lblfile);
            this.Controls.Add(this.btnchonfile);
            this.Name = "FrmCOD";
            this.Text = "FrmCOD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.Button btnchonfile;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}