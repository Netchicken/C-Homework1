namespace C__Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Single goldProteinCost = 60, veganCost = 80, muscleCost = 75;
            float bronze = 0.1f, silver = 0.5f;
            Single goldProteinQuantity, veganQuantity, muscleQuantity;
            Single goldTotal = 0, veganTotal = 0, muscleTotal = 0, grandTotal = 0;

            goldProteinQuantity = Convert.ToSingle(txtGoldQuantity.Text);
            veganQuantity = Convert.ToSingle(txtVeganQuatity.Text);
            muscleQuantity = Convert.ToSingle(txtMuscleQuantity.Text);

            if (goldProteinQuantity > 0 && cbxGold.Checked)
            {

                goldTotal = goldProteinQuantity * goldProteinCost;
            }

            if (veganQuantity > 0 && cbxVegan.Checked)
            {

                veganTotal = veganQuantity * veganCost;
            }

            if (muscleQuantity > 0 && cbxMuscle.Checked)
            {

                muscleTotal = muscleQuantity * muscleCost;
            }


            grandTotal = goldTotal + veganTotal + muscleTotal;

            if (rbBronze.Checked)
            {
                grandTotal = (grandTotal * bronze) + grandTotal;
            }
            else if (rbxSilver.Checked)
            {
                grandTotal = (grandTotal * silver) + grandTotal;

            }

            lblTotalPrice.Text = grandTotal.ToString();


        }
    }
}