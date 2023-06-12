namespace RockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.rockpicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.computerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rockpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nameLabel.Location = new System.Drawing.Point(101, 39);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(174, 24);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Rock Paper $izzahz";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionsLabel.ForeColor = System.Drawing.Color.Aqua;
            this.instructionsLabel.Location = new System.Drawing.Point(33, 74);
            this.instructionsLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(302, 78);
            this.instructionsLabel.TabIndex = 1;
            this.instructionsLabel.Text = resources.GetString("instructionsLabel.Text");
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rockButton
            // 
            this.rockButton.Location = new System.Drawing.Point(36, 304);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(75, 23);
            this.rockButton.TabIndex = 2;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Location = new System.Drawing.Point(149, 304);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(75, 23);
            this.paperButton.TabIndex = 3;
            this.paperButton.Text = "Paper $$$";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorButton
            // 
            this.scissorButton.Location = new System.Drawing.Point(260, 304);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(75, 23);
            this.scissorButton.TabIndex = 4;
            this.scissorButton.Text = "Scissors";
            this.scissorButton.UseVisualStyleBackColor = true;
            this.scissorButton.Click += new System.EventHandler(this.scissorButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.ForeColor = System.Drawing.Color.Aqua;
            this.resultLabel.Location = new System.Drawing.Point(146, 407);
            this.resultLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultLabel.Size = new System.Drawing.Size(52, 13);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "You Lose";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resultLabel.Visible = false;
            // 
            // rockpicture
            // 
            this.rockpicture.Image = ((System.Drawing.Image)(resources.GetObject("rockpicture.Image")));
            this.rockpicture.Location = new System.Drawing.Point(25, 194);
            this.rockpicture.Name = "rockpicture";
            this.rockpicture.Size = new System.Drawing.Size(104, 104);
            this.rockpicture.TabIndex = 6;
            this.rockpicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 104);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(241, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 104);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.BackColor = System.Drawing.Color.Transparent;
            this.computerLabel.ForeColor = System.Drawing.Color.Aqua;
            this.computerLabel.Location = new System.Drawing.Point(119, 382);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(135, 13);
            this.computerLabel.TabIndex = 9;
            this.computerLabel.Text = "Computer chose ................";
            this.computerLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(374, 460);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rockpicture);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Rock Paper $izzahz";
            ((System.ComponentModel.ISupportInitialize)(this.rockpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.PictureBox rockpicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label computerLabel;
    }
}

