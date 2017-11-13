namespace PrintCG_24062016
{
    partial class FrmTracking
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btntracking = new System.Windows.Forms.Button();
            this.txtmailer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(892, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btntracking
            // 
            this.btntracking.Location = new System.Drawing.Point(154, 5);
            this.btntracking.Name = "btntracking";
            this.btntracking.Size = new System.Drawing.Size(75, 23);
            this.btntracking.TabIndex = 1;
            this.btntracking.Text = "Tra cứu";
            this.btntracking.UseVisualStyleBackColor = true;
            this.btntracking.Click += new System.EventHandler(this.btntracking_Click);
            // 
            // txtmailer
            // 
            this.txtmailer.Location = new System.Drawing.Point(7, 7);
            this.txtmailer.Name = "txtmailer";
            this.txtmailer.Size = new System.Drawing.Size(141, 20);
            this.txtmailer.TabIndex = 2;
            this.txtmailer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmailer_KeyDown);
            // 
            // FrmTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 191);
            this.Controls.Add(this.txtmailer);
            this.Controls.Add(this.btntracking);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmTracking";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntracking;
        private System.Windows.Forms.TextBox txtmailer;
    }
}