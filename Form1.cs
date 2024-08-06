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
            Single twoPersonMeal = 15, fourPersonMeal = 20, sixPersonMeal = 30;
            float bronze = 0.1f, silver = 0.05f;
            Single twoPersonMealTotal = 0, fourPersonMealTotal = 0, sixPersonMealTotal = 0, grandTotal = 0;

            int countOfMeals = 0;

            //check for no brand selected
            if (!cbxTwoPerson.Checked && !cbxSixPerson.Checked && !cbxFourPerson.Checked)
            {
                MessageBox.Show("Select at least one meal");
                return;
            }
            // checked for no membership selected
            if (!rbBronze.Checked && !rbxSilver.Checked && !rbxGold.Checked)
            {
                MessageBox.Show("Select at least one membership type");
                return;
            }


            if (cbxTwoPerson.Checked)
            {
                int number;

                if (int.TryParse(txtGoldQuantity.Text, out number))
                {
                    twoPersonMealTotal = number * twoPersonMeal;
                    countOfMeals++;
                }
                else
                {
                    MessageBox.Show("Include a quantity of two person meals");
                }

            }

            if (cbxFourPerson.Checked)
            {
                int number;

                if (int.TryParse(txtVeganQuatity.Text, out number))
                {
                    fourPersonMealTotal = number * fourPersonMeal;
                    countOfMeals++;
                }
                else
                {
                    MessageBox.Show("Include a quantity of four person meals");
                }
            }

            if (cbxSixPerson.Checked)
            {
                int number;
                if (int.TryParse(txtMuscleQuantity.Text, out number))
                {
                    sixPersonMealTotal = number * sixPersonMeal;
                    countOfMeals++;
                }
                else
                {
                    MessageBox.Show("Include a quantity of six persn meals ");
                }

            }


            grandTotal = twoPersonMealTotal + fourPersonMealTotal + sixPersonMealTotal;

            if (rbBronze.Checked)
            {
                grandTotal = (grandTotal * bronze) + grandTotal;
            }
            else if (rbxSilver.Checked)
            {
                grandTotal = (grandTotal * silver) + grandTotal;
            }

            //discount for multiple brands
            switch (countOfMeals)
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

            //tax added on
            grandTotal = (float)((grandTotal * 0.08) + grandTotal);

            lblTotalPrice.Text = "$" + grandTotal.ToString();


        }
    }
}