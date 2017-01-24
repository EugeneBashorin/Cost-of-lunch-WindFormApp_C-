using System;
using System.Windows.Forms;

namespace CostOfLunch
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();

              dinnerParty = new DinnerParty(25, 15M, 7.5M, 30, 50, 20, 5, 0.05M)
            {
                NumberOfPeople = (int)numberOfPeopleValue.Value,
                HealthyOption = healthyBox.Checked,
                UnusualDecorate = DecorationBox.Checked
            };
         
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty()
            {
                NumberOfPeople = (int)numberBirthday.Value,
                UnusualDecorate = decorBirthday.Checked,
                CakeWriting = cakeWriting.Text
            };

            DisplayBirthdayPartyCost();
          }
        // numericUpDown1 NumberOfPeople for DinnerParty BirthdayParty
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var numericUpDown = sender as NumericUpDown;
            if (numericUpDown == null)
                return;

            dinnerParty.NumberOfPeople = (int)numericUpDown.Value;
            DisplayDinnerPartyCost();
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            var numericUpDown = sender as NumericUpDown;
            if (numericUpDown == null)
                return;

            birthdayParty.NumberOfPeople = (int)numericUpDown.Value;
            DisplayBirthdayPartyCost();
        }

        // DecorationBox true/false for DinnerParty BirthdayParty
      
        private void DecorationBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.UnusualDecorate = DecorationBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void decorBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.UnusualDecorate = decorBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        // healthyBox true/false for DinnerParty
        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyBox.Checked;
            DisplayDinnerPartyCost();
        }

        // CakeSize true/false for DinnerParty
        private void CakeSize_CheckedChanged(object sender, EventArgs e)
        {

            DisplayDinnerPartyCost();
        }

        // cakeWriting for BirthdayParty
        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            costLabel.Text = Cost.ToString("c");
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal Cost = birthdayParty.Cost;
            birthdayCost.Text = Cost.ToString("c");
        }

       
    }
}
