namespace PayrollGUI
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.hourlypayrateLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.hourlypayrateTextBox = new System.Windows.Forms.TextBox();
            this.hoursworkedLabel = new System.Windows.Forms.Label();
            this.hoursworkedTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.summaryLabek = new System.Windows.Forms.Label();
            this.ssnSummaryLabel = new System.Windows.Forms.Label();
            this.statementLabel = new System.Windows.Forms.Label();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.stateTaxLabel = new System.Windows.Forms.Label();
            this.federalTaxLabel = new System.Windows.Forms.Label();
            this.netPayLabel = new System.Windows.Forms.Label();
            this.grossPayTextBox = new System.Windows.Forms.TextBox();
            this.federalTaxtTextBox = new System.Windows.Forms.TextBox();
            this.stateTaxTextBox = new System.Windows.Forms.TextBox();
            this.netPayTextBox = new System.Windows.Forms.TextBox();
            this.payrateLabel = new System.Windows.Forms.Label();
            this.anHourLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionsLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.instructionsLabel.Location = new System.Drawing.Point(89, 60);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(270, 18);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Please enter the follow information below.";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nameLabel.Location = new System.Drawing.Point(70, 107);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(40, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.BackColor = System.Drawing.Color.Transparent;
            this.ssnLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ssnLabel.Location = new System.Drawing.Point(70, 132);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(31, 15);
            this.ssnLabel.TabIndex = 2;
            this.ssnLabel.Text = "SSN";
            // 
            // hourlypayrateLabel
            // 
            this.hourlypayrateLabel.AutoSize = true;
            this.hourlypayrateLabel.BackColor = System.Drawing.Color.Transparent;
            this.hourlypayrateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlypayrateLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hourlypayrateLabel.Location = new System.Drawing.Point(70, 159);
            this.hourlypayrateLabel.Name = "hourlypayrateLabel";
            this.hourlypayrateLabel.Size = new System.Drawing.Size(96, 15);
            this.hourlypayrateLabel.TabIndex = 3;
            this.hourlypayrateLabel.Text = "Hourly Pay Rate";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(223, 102);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(147, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(223, 132);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(147, 20);
            this.ssnTextBox.TabIndex = 5;
            // 
            // hourlypayrateTextBox
            // 
            this.hourlypayrateTextBox.Location = new System.Drawing.Point(223, 159);
            this.hourlypayrateTextBox.Name = "hourlypayrateTextBox";
            this.hourlypayrateTextBox.Size = new System.Drawing.Size(147, 20);
            this.hourlypayrateTextBox.TabIndex = 6;
            // 
            // hoursworkedLabel
            // 
            this.hoursworkedLabel.AutoSize = true;
            this.hoursworkedLabel.BackColor = System.Drawing.Color.Transparent;
            this.hoursworkedLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursworkedLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.hoursworkedLabel.Location = new System.Drawing.Point(70, 190);
            this.hoursworkedLabel.Name = "hoursworkedLabel";
            this.hoursworkedLabel.Size = new System.Drawing.Size(89, 15);
            this.hoursworkedLabel.TabIndex = 7;
            this.hoursworkedLabel.Text = "Hours Worked";
            // 
            // hoursworkedTextBox
            // 
            this.hoursworkedTextBox.Location = new System.Drawing.Point(223, 188);
            this.hoursworkedTextBox.Name = "hoursworkedTextBox";
            this.hoursworkedTextBox.Size = new System.Drawing.Size(147, 20);
            this.hoursworkedTextBox.TabIndex = 8;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateButton.Location = new System.Drawing.Point(251, 229);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // summaryLabek
            // 
            this.summaryLabek.AutoSize = true;
            this.summaryLabek.BackColor = System.Drawing.Color.Transparent;
            this.summaryLabek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryLabek.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.summaryLabek.Location = new System.Drawing.Point(105, 270);
            this.summaryLabek.Name = "summaryLabek";
            this.summaryLabek.Size = new System.Drawing.Size(0, 15);
            this.summaryLabek.TabIndex = 10;
            // 
            // ssnSummaryLabel
            // 
            this.ssnSummaryLabel.AutoSize = true;
            this.ssnSummaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.ssnSummaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnSummaryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ssnSummaryLabel.Location = new System.Drawing.Point(220, 294);
            this.ssnSummaryLabel.Name = "ssnSummaryLabel";
            this.ssnSummaryLabel.Size = new System.Drawing.Size(0, 15);
            this.ssnSummaryLabel.TabIndex = 11;
            // 
            // statementLabel
            // 
            this.statementLabel.AutoSize = true;
            this.statementLabel.BackColor = System.Drawing.Color.Transparent;
            this.statementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statementLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statementLabel.Location = new System.Drawing.Point(89, 343);
            this.statementLabel.Name = "statementLabel";
            this.statementLabel.Size = new System.Drawing.Size(0, 15);
            this.statementLabel.TabIndex = 12;
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.AutoSize = true;
            this.grossPayLabel.BackColor = System.Drawing.Color.Transparent;
            this.grossPayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPayLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grossPayLabel.Location = new System.Drawing.Point(70, 416);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(62, 15);
            this.grossPayLabel.TabIndex = 13;
            this.grossPayLabel.Text = "Gross Pay";
            // 
            // stateTaxLabel
            // 
            this.stateTaxLabel.AutoSize = true;
            this.stateTaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.stateTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTaxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stateTaxLabel.Location = new System.Drawing.Point(68, 472);
            this.stateTaxLabel.Name = "stateTaxLabel";
            this.stateTaxLabel.Size = new System.Drawing.Size(79, 15);
            this.stateTaxLabel.TabIndex = 14;
            this.stateTaxLabel.Text = "State Tax 5%";
            // 
            // federalTaxLabel
            // 
            this.federalTaxLabel.AutoSize = true;
            this.federalTaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.federalTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.federalTaxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.federalTaxLabel.Location = new System.Drawing.Point(70, 444);
            this.federalTaxLabel.Name = "federalTaxLabel";
            this.federalTaxLabel.Size = new System.Drawing.Size(100, 15);
            this.federalTaxLabel.TabIndex = 15;
            this.federalTaxLabel.Text = "Federal Tax 15%";
            // 
            // netPayLabel
            // 
            this.netPayLabel.AutoSize = true;
            this.netPayLabel.BackColor = System.Drawing.Color.Transparent;
            this.netPayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netPayLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.netPayLabel.Location = new System.Drawing.Point(70, 522);
            this.netPayLabel.Name = "netPayLabel";
            this.netPayLabel.Size = new System.Drawing.Size(49, 15);
            this.netPayLabel.TabIndex = 16;
            this.netPayLabel.Text = "Net Pay";
            // 
            // grossPayTextBox
            // 
            this.grossPayTextBox.Location = new System.Drawing.Point(223, 410);
            this.grossPayTextBox.Name = "grossPayTextBox";
            this.grossPayTextBox.Size = new System.Drawing.Size(147, 20);
            this.grossPayTextBox.TabIndex = 17;
            // 
            // federalTaxtTextBox
            // 
            this.federalTaxtTextBox.Location = new System.Drawing.Point(223, 439);
            this.federalTaxtTextBox.Name = "federalTaxtTextBox";
            this.federalTaxtTextBox.Size = new System.Drawing.Size(147, 20);
            this.federalTaxtTextBox.TabIndex = 18;
            // 
            // stateTaxTextBox
            // 
            this.stateTaxTextBox.Location = new System.Drawing.Point(223, 466);
            this.stateTaxTextBox.Name = "stateTaxTextBox";
            this.stateTaxTextBox.Size = new System.Drawing.Size(147, 20);
            this.stateTaxTextBox.TabIndex = 19;
            // 
            // netPayTextBox
            // 
            this.netPayTextBox.Location = new System.Drawing.Point(223, 517);
            this.netPayTextBox.Name = "netPayTextBox";
            this.netPayTextBox.Size = new System.Drawing.Size(147, 20);
            this.netPayTextBox.TabIndex = 20;
            // 
            // payrateLabel
            // 
            this.payrateLabel.AutoSize = true;
            this.payrateLabel.BackColor = System.Drawing.Color.Transparent;
            this.payrateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.payrateLabel.Location = new System.Drawing.Point(192, 343);
            this.payrateLabel.Name = "payrateLabel";
            this.payrateLabel.Size = new System.Drawing.Size(0, 15);
            this.payrateLabel.TabIndex = 21;
            // 
            // anHourLabel
            // 
            this.anHourLabel.AutoSize = true;
            this.anHourLabel.BackColor = System.Drawing.Color.Transparent;
            this.anHourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anHourLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anHourLabel.Location = new System.Drawing.Point(359, 343);
            this.anHourLabel.Name = "anHourLabel";
            this.anHourLabel.Size = new System.Drawing.Size(0, 15);
            this.anHourLabel.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(470, 592);
            this.Controls.Add(this.anHourLabel);
            this.Controls.Add(this.payrateLabel);
            this.Controls.Add(this.netPayTextBox);
            this.Controls.Add(this.stateTaxTextBox);
            this.Controls.Add(this.federalTaxtTextBox);
            this.Controls.Add(this.grossPayTextBox);
            this.Controls.Add(this.netPayLabel);
            this.Controls.Add(this.federalTaxLabel);
            this.Controls.Add(this.stateTaxLabel);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.statementLabel);
            this.Controls.Add(this.ssnSummaryLabel);
            this.Controls.Add(this.summaryLabek);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.hoursworkedTextBox);
            this.Controls.Add(this.hoursworkedLabel);
            this.Controls.Add(this.hourlypayrateTextBox);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.hourlypayrateLabel);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.instructionsLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Payroll Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.Label hourlypayrateLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.TextBox hourlypayrateTextBox;
        private System.Windows.Forms.Label hoursworkedLabel;
        private System.Windows.Forms.TextBox hoursworkedTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label summaryLabek;
        private System.Windows.Forms.Label ssnSummaryLabel;
        private System.Windows.Forms.Label statementLabel;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.Label stateTaxLabel;
        private System.Windows.Forms.Label federalTaxLabel;
        private System.Windows.Forms.Label netPayLabel;
        private System.Windows.Forms.TextBox grossPayTextBox;
        private System.Windows.Forms.TextBox federalTaxtTextBox;
        private System.Windows.Forms.TextBox stateTaxTextBox;
        private System.Windows.Forms.TextBox netPayTextBox;
        private System.Windows.Forms.Label payrateLabel;
        private System.Windows.Forms.Label anHourLabel;
    }
}

