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
            cbxMuscle = new CheckBox();
            cbxVegan = new CheckBox();
            cbxGold = new CheckBox();
            txtGoldQuantity = new TextBox();
            txtVeganQuatity = new TextBox();
            txtMuscleQuantity = new TextBox();
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
            gbxProducts.SuspendLayout();
            gbxMembership.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gbxProducts
            // 
            gbxProducts.Controls.Add(cbxMuscle);
            gbxProducts.Controls.Add(cbxVegan);
            gbxProducts.Controls.Add(cbxGold);
            gbxProducts.Location = new Point(203, 27);
            gbxProducts.Name = "gbxProducts";
            gbxProducts.Size = new Size(201, 92);
            gbxProducts.TabIndex = 0;
            gbxProducts.TabStop = false;
            gbxProducts.Text = "Products";
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
            // txtGoldQuantity
            // 
            txtGoldQuantity.Location = new Point(528, 27);
            txtGoldQuantity.Name = "txtGoldQuantity";
            txtGoldQuantity.Size = new Size(79, 23);
            txtGoldQuantity.TabIndex = 2;
            // 
            // txtVeganQuatity
            // 
            txtVeganQuatity.Location = new Point(528, 56);
            txtVeganQuatity.Name = "txtVeganQuatity";
            txtVeganQuatity.Size = new Size(79, 23);
            txtVeganQuatity.TabIndex = 3;
            // 
            // txtMuscleQuantity
            // 
            txtMuscleQuantity.Location = new Point(528, 88);
            txtMuscleQuantity.Name = "txtMuscleQuantity";
            txtMuscleQuantity.Size = new Size(79, 23);
            txtMuscleQuantity.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(519, 9);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 5;
            label2.Text = "Amount Ordered";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(423, 35);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 6;
            label3.Text = "$60";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 9);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Unit Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 96);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 8;
            label5.Text = "$75";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(423, 64);
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
            gbxMembership.Location = new Point(203, 125);
            gbxMembership.Name = "gbxMembership";
            gbxMembership.Size = new Size(112, 95);
            gbxMembership.TabIndex = 10;
            gbxMembership.TabStop = false;
            gbxMembership.Text = "Membership";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.PowderBlue;
            label7.Location = new Point(545, 125);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 11;
            label7.Text = "Total Price";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.BackColor = Color.AliceBlue;
            lblTotalPrice.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotalPrice.Location = new Point(639, 125);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(105, 48);
            lblTotalPrice.TabIndex = 12;
            lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(639, 9);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(111, 103);
            btnCalculate.TabIndex = 13;
            btnCalculate.Text = "Calculate Price";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fitzone;
            pictureBox1.Location = new Point(1, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 226);
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
            Controls.Add(txtMuscleQuantity);
            Controls.Add(txtVeganQuatity);
            Controls.Add(txtGoldQuantity);
            Controls.Add(gbxProducts);
            Name = "Form1";
            Text = "Form1";
            gbxProducts.ResumeLayout(false);
            gbxProducts.PerformLayout();
            gbxMembership.ResumeLayout(false);
            gbxMembership.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxProducts;
        private CheckBox cbxMuscle;
        private CheckBox cbxVegan;
        private CheckBox cbxGold;
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
        private PictureBox pictureBox1;
    }
}
