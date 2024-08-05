using static System.Runtime.InteropServices.JavaScript.JSType;

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
            float bronze = 0.1f, silver = 0.05f;
            Single goldTotal = 0, veganTotal = 0, muscleTotal = 0, grandTotal = 0;

            //check for no brand selected
            if (!cbxGold.Checked && !cbxMuscle.Checked && !cbxVegan.Checked)
            {
                MessageBox.Show("Select at least one Product");
                return;
            }
            // checked for no membership selected
            if (!rbBronze.Checked && !rbxSilver.Checked && !rbxGold.Checked)
            {
                MessageBox.Show("Select at least one membership type");
                return;
            }


            if (cbxGold.Checked)
            {
                int number;
                bool success = int.TryParse(txtGoldQuantity.Text, out number);
                if (success)
                {
                    goldTotal = number * goldProteinCost;
                }
                else
                {
                    MessageBox.Show("Include a quantity for Gold Standard Whey Protein");
                }

            }

            if (cbxVegan.Checked)
            {
                int number;
                bool success = int.TryParse(txtVeganQuatity.Text, out number);
                if (success)
                {
                    veganTotal = number * veganCost;
                }
                else
                {
                    MessageBox.Show("Include a quantity for Vegan Protein Powder ");
                }
            }

            if (cbxMuscle.Checked)
            {
                int number;
                bool success = int.TryParse(txtMuscleQuantity.Text, out number);
                if (success)
                {
                    muscleTotal = number * muscleCost;
                }
                else
                {
                    MessageBox.Show("Include a quantity for Muscle Milk ");
                }

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

            //final without discount for multiple brands or 8% tax
            lblTotalPrice.Text = "$" + grandTotal.ToString();


        }
    }
}