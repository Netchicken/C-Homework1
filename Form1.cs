using System.Linq.Expressions;

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

            int CountOfBrands = 0;

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

                if (int.TryParse(txtGoldQuantity.Text, out number))
                {
                    goldTotal = number * goldProteinCost;
                    CountOfBrands++;
                }
                else
                {
                    MessageBox.Show("Include a quantity for Gold Standard Whey Protein");
                }

            }

            if (cbxVegan.Checked)
            {
                int number;

                if (int.TryParse(txtVeganQuatity.Text, out number))
                {
                    veganTotal = number * veganCost;
                    CountOfBrands++;
                }
                else
                {
                    MessageBox.Show("Include a quantity for Vegan Protein Powder ");
                }
            }

            if (cbxMuscle.Checked)
            {
                int number;

                if (int.TryParse(txtMuscleQuantity.Text, out number))
                {
                    muscleTotal = number * muscleCost;
                    CountOfBrands++;
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

            //discount for multiple brands
            switch (CountOfBrands)
            {
                case 2:
                    grandTotal = grandTotal - (float)((grandTotal * 0.03));
                    break;
                case 3:
                    grandTotal = grandTotal - (float)((grandTotal * 0.05));
                    break;
                default:
                    // code block
                    break;
            }

            //final without discount for multiple brands or 8% tax
            grandTotal = (float)((grandTotal * 0.08) + grandTotal);

            lblTotalPrice.Text = "$" + grandTotal.ToString();


        }
    }
}