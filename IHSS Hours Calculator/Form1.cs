using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHSS_Hours_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numHours = Convert.ToInt32(hoursTextBox.Text);
                int numDays = Convert.ToInt32(daysTextBox.Text);

                if (numHours > 200)
                {
                    numHours = numHours / 2;
                }

                int numOfHours1 = numHours / numDays;
                int numCheck = numOfHours1 * numDays;
                int numOfDays2 = numHours - numCheck;
                int numOfDays1 = numDays - numOfDays2;
                int numOfHours2 = numOfHours1 + 1;

                sevenHoursTextBox.Text = numOfDays1.ToString() + " days with " + numOfHours1.ToString() + " hours each.";
                eightHoursTextBox.Text = numOfDays2.ToString() + " days with " + numOfHours2.ToString() + " hours each.";
            }
            catch
            {

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
