﻿namespace C__Homework1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxMeals = new GroupBox();
            cbxSixPerson = new CheckBox();
            cbxFourPerson = new CheckBox();
            cbxTwoPerson = new CheckBox();
            txtTwoPersonQuantity = new TextBox();
            txtfourPersonQuantity = new TextBox();
            txtSixPersonQuantity = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            gbxMembership = new GroupBox();
            rbxGold = new RadioButton();
            rbxSilver = new RadioButton();
            rbBronze = new RadioButton();
            label7 = new Label();
            lblTotalPrice = new Label();
            btnCalculate = new Button();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            label1 = new Label();
            label8 = new Label();
            lblTaxAmount = new Label();
            lblDiscountAmount = new Label();
            btnPlaceOrder = new Button();
            gbxMeals.SuspendLayout();
            gbxMembership.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gbxMeals
            // 
            gbxMeals.BackColor = Color.Silver;
            gbxMeals.Controls.Add(cbxSixPerson);
            gbxMeals.Controls.Add(cbxFourPerson);
            gbxMeals.Controls.Add(cbxTwoPerson);
            gbxMeals.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxMeals.ForeColor = Color.Azure;
            gbxMeals.Location = new Point(290, 20);
            gbxMeals.Margin = new Padding(4, 5, 4, 5);
            gbxMeals.Name = "gbxMeals";
            gbxMeals.Padding = new Padding(4, 5, 4, 5);
            gbxMeals.Size = new Size(331, 153);
            gbxMeals.TabIndex = 0;
            gbxMeals.TabStop = false;
            gbxMeals.Text = "Meals";
            // 
            // cbxSixPerson
            // 
            cbxSixPerson.AutoSize = true;
            cbxSixPerson.Location = new Point(4, 112);
            cbxSixPerson.Margin = new Padding(4, 5, 4, 5);
            cbxSixPerson.Name = "cbxSixPerson";
            cbxSixPerson.Size = new Size(148, 36);
            cbxSixPerson.TabIndex = 2;
            cbxSixPerson.Text = "Six Person";
            cbxSixPerson.UseVisualStyleBackColor = true;
            // 
            // cbxFourPerson
            // 
            cbxFourPerson.AutoSize = true;
            cbxFourPerson.Location = new Point(4, 70);
            cbxFourPerson.Margin = new Padding(4, 5, 4, 5);
            cbxFourPerson.Name = "cbxFourPerson";
            cbxFourPerson.Size = new Size(166, 36);
            cbxFourPerson.TabIndex = 1;
            cbxFourPerson.Text = "Four Person";
            cbxFourPerson.UseVisualStyleBackColor = true;
            // 
            // cbxTwoPerson
            // 
            cbxTwoPerson.AutoSize = true;
            cbxTwoPerson.Location = new Point(4, 32);
            cbxTwoPerson.Margin = new Padding(4, 5, 4, 5);
            cbxTwoPerson.Name = "cbxTwoPerson";
            cbxTwoPerson.Size = new Size(161, 36);
            cbxTwoPerson.TabIndex = 0;
            cbxTwoPerson.Text = "Two Person";
            cbxTwoPerson.UseVisualStyleBackColor = true;
            // 
            // txtTwoPersonQuantity
            // 
            txtTwoPersonQuantity.Location = new Point(774, 42);
            txtTwoPersonQuantity.Margin = new Padding(4, 5, 4, 5);
            txtTwoPersonQuantity.Name = "txtTwoPersonQuantity";
            txtTwoPersonQuantity.Size = new Size(111, 31);
            txtTwoPersonQuantity.TabIndex = 2;
            // 
            // txtfourPersonQuantity
            // 
            txtfourPersonQuantity.Location = new Point(774, 90);
            txtfourPersonQuantity.Margin = new Padding(4, 5, 4, 5);
            txtfourPersonQuantity.Name = "txtfourPersonQuantity";
            txtfourPersonQuantity.Size = new Size(111, 31);
            txtfourPersonQuantity.TabIndex = 3;
            // 
            // txtSixPersonQuantity
            // 
            txtSixPersonQuantity.Location = new Point(774, 143);
            txtSixPersonQuantity.Margin = new Padding(4, 5, 4, 5);
            txtSixPersonQuantity.Name = "txtSixPersonQuantity";
            txtSixPersonQuantity.Size = new Size(111, 31);
            txtSixPersonQuantity.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.SeaShell;
            label2.Location = new Point(741, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 32);
            label2.TabIndex = 5;
            label2.Text = "Amount Ordered";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(643, 57);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 32);
            label3.TabIndex = 6;
            label3.Text = "$15";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.SeaShell;
            label4.Location = new Point(630, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 7;
            label4.Text = "Unit Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(643, 140);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 32);
            label5.TabIndex = 8;
            label5.Text = "$30";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(643, 97);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(53, 32);
            label6.TabIndex = 9;
            label6.Text = "$20";
            // 
            // gbxMembership
            // 
            gbxMembership.BackColor = Color.Silver;
            gbxMembership.Controls.Add(rbxGold);
            gbxMembership.Controls.Add(rbxSilver);
            gbxMembership.Controls.Add(rbBronze);
            gbxMembership.Font = new Font("Segoe UI", 12F);
            gbxMembership.ForeColor = Color.Linen;
            gbxMembership.Location = new Point(290, 183);
            gbxMembership.Margin = new Padding(4, 5, 4, 5);
            gbxMembership.Name = "gbxMembership";
            gbxMembership.Padding = new Padding(4, 5, 4, 5);
            gbxMembership.Size = new Size(170, 172);
            gbxMembership.TabIndex = 10;
            gbxMembership.TabStop = false;
            gbxMembership.Text = "Membership";
            // 
            // rbxGold
            // 
            rbxGold.AutoSize = true;
            rbxGold.Location = new Point(10, 113);
            rbxGold.Margin = new Padding(4, 5, 4, 5);
            rbxGold.Name = "rbxGold";
            rbxGold.Size = new Size(89, 36);
            rbxGold.TabIndex = 13;
            rbxGold.TabStop = true;
            rbxGold.Text = "Gold";
            rbxGold.UseVisualStyleBackColor = true;
            // 
            // rbxSilver
            // 
            rbxSilver.AutoSize = true;
            rbxSilver.Location = new Point(11, 72);
            rbxSilver.Margin = new Padding(4, 5, 4, 5);
            rbxSilver.Name = "rbxSilver";
            rbxSilver.Size = new Size(97, 36);
            rbxSilver.TabIndex = 12;
            rbxSilver.TabStop = true;
            rbxSilver.Text = "Silver";
            rbxSilver.UseVisualStyleBackColor = true;
            // 
            // rbBronze
            // 
            rbBronze.AutoSize = true;
            rbBronze.Location = new Point(11, 37);
            rbBronze.Margin = new Padding(4, 5, 4, 5);
            rbBronze.Name = "rbBronze";
            rbBronze.Size = new Size(113, 36);
            rbBronze.TabIndex = 11;
            rbBronze.TabStop = true;
            rbBronze.Text = "Bronze";
            rbBronze.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSeaGreen;
            label7.Location = new Point(638, 277);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 11;
            label7.Text = "Total Price";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.BackColor = Color.AliceBlue;
            lblTotalPrice.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotalPrice.Location = new Point(764, 274);
            lblTotalPrice.Margin = new Padding(4, 0, 4, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(139, 58);
            lblTotalPrice.TabIndex = 12;
            lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(910, 83);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(159, 79);
            btnCalculate.TabIndex = 13;
            btnCalculate.Text = "Calculate Price";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.foodbag;
            pictureBox1.Location = new Point(1, -13);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(910, 261);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(159, 71);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSeaGreen;
            label1.Location = new Point(577, 199);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 16;
            label1.Text = "Discount Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightSeaGreen;
            label8.Location = new Point(623, 231);
            label8.Name = "label8";
            label8.Size = new Size(106, 25);
            label8.TabIndex = 17;
            label8.Text = "Tax Amount";
            // 
            // lblTaxAmount
            // 
            lblTaxAmount.BackColor = Color.Azure;
            lblTaxAmount.Location = new Point(764, 242);
            lblTaxAmount.Name = "lblTaxAmount";
            lblTaxAmount.Size = new Size(140, 25);
            lblTaxAmount.TabIndex = 18;
            // 
            // lblDiscountAmount
            // 
            lblDiscountAmount.BackColor = Color.Azure;
            lblDiscountAmount.Location = new Point(763, 199);
            lblDiscountAmount.Name = "lblDiscountAmount";
            lblDiscountAmount.Size = new Size(140, 32);
            lblDiscountAmount.TabIndex = 19;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(910, 172);
            btnPlaceOrder.Margin = new Padding(4, 5, 4, 5);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(159, 79);
            btnPlaceOrder.TabIndex = 20;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1086, 377);
            Controls.Add(btnPlaceOrder);
            Controls.Add(lblDiscountAmount);
            Controls.Add(lblTaxAmount);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotalPrice);
            Controls.Add(label7);
            Controls.Add(gbxMembership);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSixPersonQuantity);
            Controls.Add(txtfourPersonQuantity);
            Controls.Add(txtTwoPersonQuantity);
            Controls.Add(gbxMeals);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            gbxMeals.ResumeLayout(false);
            gbxMeals.PerformLayout();
            gbxMembership.ResumeLayout(false);
            gbxMembership.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxMeals;
        private CheckBox cbxSixPerson;
        private CheckBox cbxFourPerson;
        private CheckBox cbxTwoPerson;
        private TextBox txtTwoPersonQuantity;
        private TextBox txtfourPersonQuantity;
        private TextBox txtSixPersonQuantity;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox gbxMembership;
        private RadioButton rbxGold;
        private RadioButton rbxSilver;
        private RadioButton rbBronze;
        private Label label7;
        private Label lblTotalPrice;
        private Button btnCalculate;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Label label1;
        private Label label8;
        private Label lblTaxAmount;
        private Label lblDiscountAmount;
        private Button btnPlaceOrder;
    }
}
