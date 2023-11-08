namespace ImageDownsizer
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
            this.chooseImgBtn = new System.Windows.Forms.Button();
            this.downscaleBtn = new System.Windows.Forms.Button();
            this.consequentialRbtn = new System.Windows.Forms.RadioButton();
            this.parallelBtn = new System.Windows.Forms.RadioButton();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseImgBtn
            // 
            this.chooseImgBtn.Location = new System.Drawing.Point(496, 413);
            this.chooseImgBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chooseImgBtn.Name = "chooseImgBtn";
            this.chooseImgBtn.Size = new System.Drawing.Size(137, 28);
            this.chooseImgBtn.TabIndex = 1;
            this.chooseImgBtn.Text = "Choose image";
            this.chooseImgBtn.UseVisualStyleBackColor = true;
            this.chooseImgBtn.Click += new System.EventHandler(this.chooseImgBtn_Click);
            // 
            // downscaleBtn
            // 
            this.downscaleBtn.Location = new System.Drawing.Point(16, 469);
            this.downscaleBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.downscaleBtn.Name = "downscaleBtn";
            this.downscaleBtn.Size = new System.Drawing.Size(133, 28);
            this.downscaleBtn.TabIndex = 2;
            this.downscaleBtn.Text = "Downscale";
            this.downscaleBtn.UseVisualStyleBackColor = true;
            this.downscaleBtn.Click += new System.EventHandler(this.downscaleBtn_Click);
            // 
            // consequentialRbtn
            // 
            this.consequentialRbtn.AutoSize = true;
            this.consequentialRbtn.Location = new System.Drawing.Point(496, 477);
            this.consequentialRbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consequentialRbtn.Name = "consequentialRbtn";
            this.consequentialRbtn.Size = new System.Drawing.Size(114, 20);
            this.consequentialRbtn.TabIndex = 3;
            this.consequentialRbtn.TabStop = true;
            this.consequentialRbtn.Text = "Consequential";
            this.consequentialRbtn.UseVisualStyleBackColor = true;
            // 
            // parallelBtn
            // 
            this.parallelBtn.AutoSize = true;
            this.parallelBtn.Location = new System.Drawing.Point(496, 449);
            this.parallelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parallelBtn.Name = "parallelBtn";
            this.parallelBtn.Size = new System.Drawing.Size(74, 20);
            this.parallelBtn.TabIndex = 4;
            this.parallelBtn.TabStop = true;
            this.parallelBtn.Text = "Parallel";
            this.parallelBtn.UseVisualStyleBackColor = true;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(157, 475);
            this.txtPercentage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(132, 22);
            this.txtPercentage.TabIndex = 5;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(16, 15);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(641, 390);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 512);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.parallelBtn);
            this.Controls.Add(this.consequentialRbtn);
            this.Controls.Add(this.downscaleBtn);
            this.Controls.Add(this.chooseImgBtn);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Image Downsizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button chooseImgBtn;
        private System.Windows.Forms.Button downscaleBtn;
        private System.Windows.Forms.RadioButton consequentialRbtn;
        private System.Windows.Forms.RadioButton parallelBtn;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

