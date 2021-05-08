namespace WindowsFormsApp6
{
    partial class adm
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
            this.center = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // center
            // 
            this.center.BackColor = System.Drawing.Color.Transparent;
            this.center.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center.ForeColor = System.Drawing.Color.White;
            this.center.Location = new System.Drawing.Point(263, 4);
            this.center.Margin = new System.Windows.Forms.Padding(10);
            this.center.Name = "center";
            this.center.Padding = new System.Windows.Forms.Padding(20);
            this.center.Size = new System.Drawing.Size(444, 91);
            this.center.TabIndex = 2;
            this.center.Text = "Welcome";
            this.center.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(559, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.BackColor = System.Drawing.Color.DarkBlue;
            this.loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.Color.White;
            this.loginlabel.Location = new System.Drawing.Point(51, 123);
            this.loginlabel.Margin = new System.Windows.Forms.Padding(100);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(168, 39);
            this.loginlabel.TabIndex = 4;
            this.loginlabel.Text = "Add Data";
            this.loginlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginlabel.Click += new System.EventHandler(this.loginlabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Update Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delete Data";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 389);
            this.label4.Margin = new System.Windows.Forms.Padding(100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "See Requests";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.daria_nepriakhina_twE_bTk0BnM_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.center);
            this.Name = "adm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label center;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}