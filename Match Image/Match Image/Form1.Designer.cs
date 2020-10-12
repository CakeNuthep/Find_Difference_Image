namespace Match_Image
{
    partial class Form1
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
            this.pictureBox_snip2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_snip1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_notMatch = new System.Windows.Forms.Button();
            this.button_snipImage2 = new System.Windows.Forms.Button();
            this.button_snipImage1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_snip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_snip1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_snip2
            // 
            this.pictureBox_snip2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_snip2.Location = new System.Drawing.Point(449, 20);
            this.pictureBox_snip2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_snip2.Name = "pictureBox_snip2";
            this.pictureBox_snip2.Size = new System.Drawing.Size(330, 225);
            this.pictureBox_snip2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_snip2.TabIndex = 0;
            this.pictureBox_snip2.TabStop = false;
            // 
            // pictureBox_snip1
            // 
            this.pictureBox_snip1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_snip1.Location = new System.Drawing.Point(50, 20);
            this.pictureBox_snip1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_snip1.Name = "pictureBox_snip1";
            this.pictureBox_snip1.Size = new System.Drawing.Size(330, 225);
            this.pictureBox_snip1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_snip1.TabIndex = 1;
            this.pictureBox_snip1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.button_notMatch);
            this.panel1.Controls.Add(this.button_snipImage2);
            this.panel1.Controls.Add(this.button_snipImage1);
            this.panel1.Controls.Add(this.pictureBox_snip1);
            this.panel1.Controls.Add(this.pictureBox_snip2);
            this.panel1.Location = new System.Drawing.Point(40, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 476);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox3.Location = new System.Drawing.Point(415, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(3, 254);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // button_notMatch
            // 
            this.button_notMatch.BackColor = System.Drawing.Color.White;
            this.button_notMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_notMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button_notMatch.ForeColor = System.Drawing.Color.Black;
            this.button_notMatch.Location = new System.Drawing.Point(359, 298);
            this.button_notMatch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_notMatch.Name = "button_notMatch";
            this.button_notMatch.Size = new System.Drawing.Size(105, 26);
            this.button_notMatch.TabIndex = 3;
            this.button_notMatch.Text = "Find not Match";
            this.button_notMatch.UseVisualStyleBackColor = false;
            this.button_notMatch.Click += new System.EventHandler(this.button_notMatch_Click);
            // 
            // button_snipImage2
            // 
            this.button_snipImage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_snipImage2.Location = new System.Drawing.Point(579, 249);
            this.button_snipImage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_snipImage2.Name = "button_snipImage2";
            this.button_snipImage2.Size = new System.Drawing.Size(82, 24);
            this.button_snipImage2.TabIndex = 2;
            this.button_snipImage2.Text = "Snip image2";
            this.button_snipImage2.UseVisualStyleBackColor = true;
            this.button_snipImage2.Click += new System.EventHandler(this.button_snipImage2_Click);
            // 
            // button_snipImage1
            // 
            this.button_snipImage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_snipImage1.Location = new System.Drawing.Point(164, 249);
            this.button_snipImage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_snipImage1.Name = "button_snipImage1";
            this.button_snipImage1.Size = new System.Drawing.Size(85, 24);
            this.button_snipImage1.TabIndex = 2;
            this.button_snipImage1.Text = "Snip image1";
            this.button_snipImage1.UseVisualStyleBackColor = true;
            this.button_snipImage1.Click += new System.EventHandler(this.button_snipImage1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(898, 358);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Match Image Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_snip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_snip1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_snip2;
        private System.Windows.Forms.PictureBox pictureBox_snip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_notMatch;
        private System.Windows.Forms.Button button_snipImage2;
        private System.Windows.Forms.Button button_snipImage1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

