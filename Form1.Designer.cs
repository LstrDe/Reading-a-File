namespace Reading_a_File
{
    partial class FrmOpenTextFile
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
            this.btnRegister1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lvShowText = new System.Windows.Forms.ListBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.bntUpload = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegister1
            // 
            this.btnRegister1.Location = new System.Drawing.Point(396, 26);
            this.btnRegister1.Name = "btnRegister1";
            this.btnRegister1.Size = new System.Drawing.Size(118, 31);
            this.btnRegister1.TabIndex = 2;
            this.btnRegister1.Text = "Register";
            this.btnRegister1.UseVisualStyleBackColor = true;
            this.btnRegister1.Click += new System.EventHandler(this.bntFind_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lvShowText
            // 
            this.lvShowText.FormattingEnabled = true;
            this.lvShowText.Location = new System.Drawing.Point(12, 14);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(365, 160);
            this.lvShowText.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(396, 63);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(118, 31);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // bntUpload
            // 
            this.bntUpload.Location = new System.Drawing.Point(396, 100);
            this.bntUpload.Name = "bntUpload";
            this.bntUpload.Size = new System.Drawing.Size(118, 31);
            this.bntUpload.TabIndex = 5;
            this.bntUpload.Text = "Upload";
            this.bntUpload.UseVisualStyleBackColor = true;
            this.bntUpload.Click += new System.EventHandler(this.bntUpload_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(396, 26);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(118, 31);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FrmOpenTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(526, 190);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.bntUpload);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lvShowText);
            this.Controls.Add(this.btnRegister1);
            this.Name = "FrmOpenTextFile";
            this.Text = "FrmStdentRecord";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegister1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lvShowText;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button bntUpload;
        private System.Windows.Forms.Button btnRegister;
    }
}

