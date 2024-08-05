namespace C__Homework1
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
            gbxProducts = new GroupBox();
            cbxGold = new CheckBox();
            cbxVegan = new CheckBox();
            cbxMuscle = new CheckBox();
            label1 = new Label();
            txtGoldQuantity = new TextBox();
            txtVeganQuatity = new TextBox();
            txtMuscleQuantity = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            gbxMembership = new GroupBox();
            rbBronze = new RadioButton();
            rbxSilver = new RadioButton();
            rbxGold = new RadioButton();
            label7 = new Label();
            lblTotalPrice = new Label();
            btnCalculate = new Button();
            gbxProducts.SuspendLayout();
            gbxMembership.SuspendLayout();
            SuspendLayout();
            // 
            // gbxProducts
            // 
            gbxProducts.Controls.Add(cbxMuscle);
            gbxProducts.Controls.Add(cbxVegan);
            gbxProducts.Controls.Add(cbxGold);
            gbxProducts.Location = new Point(78, 97);
            gbxProducts.Name = "gbxProducts";
            gbxProducts.Size = new Size(201, 92);
            gbxProducts.TabIndex = 0;
            gbxProducts.TabStop = false;
            gbxProducts.Text = "Products";
            // 
            // cbxGold
            // 
            cbxGold.AutoSize = true;
            cbxGold.Location = new Point(3, 19);
            cbxGold.Name = "cbxGold";
            cbxGold.Size = new Size(178, 19);
            cbxGold.TabIndex = 0;
            cbxGold.Text = "Gold Standard Whey Protein ";
            cbxGold.UseVisualStyleBackColor = true;
            // 
            // cbxVegan
            // 
            cbxVegan.AutoSize = true;
            cbxVegan.Location = new Point(3, 42);
            cbxVegan.Name = "cbxVegan";
            cbxVegan.Size = new Size(145, 19);
            cbxVegan.TabIndex = 1;
            cbxVegan.Text = "Vegan Protein Powder ";
            cbxVegan.UseVisualStyleBackColor = true;
            // 
            // cbxMuscle
            // 
            cbxMuscle.AutoSize = true;
            cbxMuscle.Location = new Point(3, 67);
            cbxMuscle.Name = "cbxMuscle";
            cbxMuscle.Size = new Size(93, 19);
            cbxMuscle.TabIndex = 2;
            cbxMuscle.Text = "Muscle Milk ";
            cbxMuscle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 14);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Fitzone";
            // 
            // txtGoldQuantity
            // 
            txtGoldQuantity.Location = new Point(403, 97);
            txtGoldQuantity.Name = "txtGoldQuantity";
            txtGoldQuantity.Size = new Size(79, 23);
            txtGoldQuantity.TabIndex = 2;
            // 
            // txtVeganQuatity
            // 
            txtVeganQuatity.Location = new Point(403, 126);
            txtVeganQuatity.Name = "txtVeganQuatity";
            txtVeganQuatity.Size = new Size(79, 23);
            txtVeganQuatity.TabIndex = 3;
            // 
            // txtMuscleQuantity
            // 
            txtMuscleQuantity.Location = new Point(403, 158);
            txtMuscleQuantity.Name = "txtMuscleQuantity";
            txtMuscleQuantity.Size = new Size(79, 23);
            txtMuscleQuantity.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 79);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 5;
            label2.Text = "Amount Ordered";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(298, 105);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 6;
            label3.Text = "$60";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 79);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Unit Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(298, 166);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 8;
            label5.Text = "$75";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(298, 134);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 9;
            label6.Text = "$80";
            // 
            // gbxMembership
            // 
            gbxMembership.Controls.Add(rbxGold);
            gbxMembership.Controls.Add(rbxSilver);
            gbxMembership.Controls.Add(rbBronze);
            gbxMembership.Location = new Point(78, 195);
            gbxMembership.Name = "gbxMembership";
            gbxMembership.Size = new Size(112, 114);
            gbxMembership.TabIndex = 10;
            gbxMembership.TabStop = false;
            gbxMembership.Text = "Membership";
            // 
            // rbBronze
            // 
            rbBronze.AutoSize = true;
            rbBronze.Location = new Point(8, 22);
            rbBronze.Name = "rbBronze";
            rbBronze.Size = new Size(61, 19);
            rbBronze.TabIndex = 11;
            rbBronze.TabStop = true;
            rbBronze.Text = "Bronze";
            rbBronze.UseVisualStyleBackColor = true;
            // 
            // rbxSilver
            // 
            rbxSilver.AutoSize = true;
            rbxSilver.Location = new Point(8, 43);
            rbxSilver.Name = "rbxSilver";
            rbxSilver.Size = new Size(53, 19);
            rbxSilver.TabIndex = 12;
            rbxSilver.TabStop = true;
            rbxSilver.Text = "Silver";
            rbxSilver.UseVisualStyleBackColor = true;
            // 
            // rbxGold
            // 
            rbxGold.AutoSize = true;
            rbxGold.Location = new Point(7, 68);
            rbxGold.Name = "rbxGold";
            rbxGold.Size = new Size(50, 19);
            rbxGold.TabIndex = 13;
            rbxGold.TabStop = true;
            rbxGold.Text = "Gold";
            rbxGold.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.PowderBlue;
            label7.Location = new Point(298, 211);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 11;
            label7.Text = "Total Price";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.BackColor = Color.AliceBlue;
            lblTotalPrice.Location = new Point(377, 209);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(69, 19);
            lblTotalPrice.TabIndex = 12;
            lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(514, 79);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(111, 103);
            btnCalculate.TabIndex = 13;
            btnCalculate.Text = "Calculate Price";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotalPrice);
            Controls.Add(label7);
            Controls.Add(gbxMembership);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMuscleQuantity);
            Controls.Add(txtVeganQuatity);
            Controls.Add(txtGoldQuantity);
            Controls.Add(label1);
            Controls.Add(gbxProducts);
            Name = "Form1";
            Text = "Form1";
            gbxProducts.ResumeLayout(false);
            gbxProducts.PerformLayout();
            gbxMembership.ResumeLayout(false);
            gbxMembership.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxProducts;
        private CheckBox cbxMuscle;
        private CheckBox cbxVegan;
        private CheckBox cbxGold;
        private Label label1;
        private TextBox txtGoldQuantity;
        private TextBox txtVeganQuatity;
        private TextBox txtMuscleQuantity;
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
    }
}
