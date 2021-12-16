namespace Pharmacy_Management_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PowerTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.MedNameTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.AddMedButton = new System.Windows.Forms.Button();
            this.SellMedIdTextBox = new System.Windows.Forms.TextBox();
            this.SellMedButton = new System.Windows.Forms.Button();
            this.ShowStockButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.ShowBalanceButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ShowMedNameLabel = new System.Windows.Forms.Label();
            this.ShowMedPowerLabel = new System.Windows.Forms.Label();
            this.ShowQuantityLabel = new System.Windows.Forms.Label();
            this.MedIdStockTextBox = new System.Windows.Forms.TextBox();
            this.AccBalanceLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SellQuantityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Power";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medicine ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Medicine ID";
            // 
            // PowerTextBox
            // 
            this.PowerTextBox.Location = new System.Drawing.Point(155, 152);
            this.PowerTextBox.Name = "PowerTextBox";
            this.PowerTextBox.Size = new System.Drawing.Size(247, 22);
            this.PowerTextBox.TabIndex = 8;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(155, 203);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(247, 22);
            this.IdTextBox.TabIndex = 9;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(155, 259);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(247, 22);
            this.PriceTextBox.TabIndex = 10;
            // 
            // MedNameTextBox
            // 
            this.MedNameTextBox.Location = new System.Drawing.Point(155, 105);
            this.MedNameTextBox.Name = "MedNameTextBox";
            this.MedNameTextBox.Size = new System.Drawing.Size(247, 22);
            this.MedNameTextBox.TabIndex = 11;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(155, 312);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(247, 22);
            this.QuantityTextBox.TabIndex = 12;
            // 
            // AddMedButton
            // 
            this.AddMedButton.Location = new System.Drawing.Point(155, 378);
            this.AddMedButton.Name = "AddMedButton";
            this.AddMedButton.Size = new System.Drawing.Size(138, 41);
            this.AddMedButton.TabIndex = 13;
            this.AddMedButton.Text = "Add Medicine";
            this.AddMedButton.UseVisualStyleBackColor = true;
            this.AddMedButton.Click += new System.EventHandler(this.AddMedButton_Click);
            // 
            // SellMedIdTextBox
            // 
            this.SellMedIdTextBox.Location = new System.Drawing.Point(625, 102);
            this.SellMedIdTextBox.Name = "SellMedIdTextBox";
            this.SellMedIdTextBox.Size = new System.Drawing.Size(247, 22);
            this.SellMedIdTextBox.TabIndex = 14;
            // 
            // SellMedButton
            // 
            this.SellMedButton.Location = new System.Drawing.Point(625, 215);
            this.SellMedButton.Name = "SellMedButton";
            this.SellMedButton.Size = new System.Drawing.Size(138, 40);
            this.SellMedButton.TabIndex = 16;
            this.SellMedButton.Text = "Sell Medicine";
            this.SellMedButton.UseVisualStyleBackColor = true;
            this.SellMedButton.Click += new System.EventHandler(this.SellMedButton_Click);
            // 
            // ShowStockButton
            // 
            this.ShowStockButton.Location = new System.Drawing.Point(520, 555);
            this.ShowStockButton.Name = "ShowStockButton";
            this.ShowStockButton.Size = new System.Drawing.Size(424, 27);
            this.ShowStockButton.TabIndex = 18;
            this.ShowStockButton.Text = "Show Current Stock";
            this.ShowStockButton.UseVisualStyleBackColor = true;
            this.ShowStockButton.Click += new System.EventHandler(this.ShowStockButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Current Acoount Balance:";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(681, 395);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(118, 16);
            this.BalanceLabel.TabIndex = 20;
            this.BalanceLabel.Text = "                                     ";
            // 
            // ShowBalanceButton
            // 
            this.ShowBalanceButton.Location = new System.Drawing.Point(870, 311);
            this.ShowBalanceButton.Name = "ShowBalanceButton";
            this.ShowBalanceButton.Size = new System.Drawing.Size(75, 23);
            this.ShowBalanceButton.TabIndex = 21;
            this.ShowBalanceButton.Text = "Show";
            this.ShowBalanceButton.UseVisualStyleBackColor = true;
            this.ShowBalanceButton.Click += new System.EventHandler(this.ShowBalanceButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(46, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 20);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add Medicine";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(517, 50);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(122, 20);
            this.linkLabel2.TabIndex = 23;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Sell Medicine";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Med ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(518, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Med Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(518, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Power:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(518, 511);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Quantity:";
            // 
            // ShowMedNameLabel
            // 
            this.ShowMedNameLabel.AutoSize = true;
            this.ShowMedNameLabel.Location = new System.Drawing.Point(601, 425);
            this.ShowMedNameLabel.Name = "ShowMedNameLabel";
            this.ShowMedNameLabel.Size = new System.Drawing.Size(97, 16);
            this.ShowMedNameLabel.TabIndex = 28;
            this.ShowMedNameLabel.Text = "                              ";
            // 
            // ShowMedPowerLabel
            // 
            this.ShowMedPowerLabel.AutoSize = true;
            this.ShowMedPowerLabel.Location = new System.Drawing.Point(601, 466);
            this.ShowMedPowerLabel.Name = "ShowMedPowerLabel";
            this.ShowMedPowerLabel.Size = new System.Drawing.Size(67, 16);
            this.ShowMedPowerLabel.TabIndex = 29;
            this.ShowMedPowerLabel.Text = "                    ";
            // 
            // ShowQuantityLabel
            // 
            this.ShowQuantityLabel.AutoSize = true;
            this.ShowQuantityLabel.Location = new System.Drawing.Point(601, 511);
            this.ShowQuantityLabel.Name = "ShowQuantityLabel";
            this.ShowQuantityLabel.Size = new System.Drawing.Size(76, 16);
            this.ShowQuantityLabel.TabIndex = 30;
            this.ShowQuantityLabel.Text = "                       ";
            // 
            // MedIdStockTextBox
            // 
            this.MedIdStockTextBox.Location = new System.Drawing.Point(604, 375);
            this.MedIdStockTextBox.Name = "MedIdStockTextBox";
            this.MedIdStockTextBox.Size = new System.Drawing.Size(268, 22);
            this.MedIdStockTextBox.TabIndex = 31;
            // 
            // AccBalanceLabel
            // 
            this.AccBalanceLabel.AutoSize = true;
            this.AccBalanceLabel.Location = new System.Drawing.Point(681, 318);
            this.AccBalanceLabel.Name = "AccBalanceLabel";
            this.AccBalanceLabel.Size = new System.Drawing.Size(67, 16);
            this.AccBalanceLabel.TabIndex = 32;
            this.AccBalanceLabel.Text = "                    ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Quantity";
            // 
            // SellQuantityTextBox
            // 
            this.SellQuantityTextBox.Location = new System.Drawing.Point(624, 155);
            this.SellQuantityTextBox.Name = "SellQuantityTextBox";
            this.SellQuantityTextBox.Size = new System.Drawing.Size(247, 22);
            this.SellQuantityTextBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 636);
            this.Controls.Add(this.AccBalanceLabel);
            this.Controls.Add(this.MedIdStockTextBox);
            this.Controls.Add(this.ShowQuantityLabel);
            this.Controls.Add(this.ShowMedPowerLabel);
            this.Controls.Add(this.ShowMedNameLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ShowBalanceButton);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ShowStockButton);
            this.Controls.Add(this.SellMedButton);
            this.Controls.Add(this.SellQuantityTextBox);
            this.Controls.Add(this.SellMedIdTextBox);
            this.Controls.Add(this.AddMedButton);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.MedNameTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.PowerTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PowerTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox MedNameTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Button AddMedButton;
        private System.Windows.Forms.TextBox SellMedIdTextBox;
        private System.Windows.Forms.Button SellMedButton;
        private System.Windows.Forms.Button ShowStockButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Button ShowBalanceButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ShowMedNameLabel;
        private System.Windows.Forms.Label ShowMedPowerLabel;
        private System.Windows.Forms.Label ShowQuantityLabel;
        private System.Windows.Forms.TextBox MedIdStockTextBox;
        private System.Windows.Forms.Label AccBalanceLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SellQuantityTextBox;
    }
}

