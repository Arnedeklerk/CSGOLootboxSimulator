using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGOLootboxSimulator
{
    public partial class Form1 : Form
    {
        double milSpec, restricted, classified, covert;
        int userAmount, knifeCounter, covertCounter, classifiedCounter, restrictedCounter, milspecCounter, totalCounter;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //string userInput;

        private void OutcomeBox_Click(object sender, EventArgs e)
        {

        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            //outcomeBox.Text = ("Welcome");
            outcomeBoxTwo.ScrollBars = RichTextBoxScrollBars.Vertical;
            outcomeBoxTwo.Multiline = true;

        }

        private void UserIterations_TextChanged(object sender, EventArgs e)
        {
            
        }

        Random random = new Random();

        public Form1()
        {
           
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            
            milSpec = 79.92;
            restricted = 15.98;
            classified = 3.2;
            covert = 0.64;
            //exceedinglyRare = 0.26

            //userInput = Console.ReadLine();
            if (userIterations.Text == "")
            {
                outcomeBoxTwo.Text = "Please enter an iteration count";
                
            }
            else
            {
                userAmount = Convert.ToInt32(userIterations.Text);


                for (int j = 0; j < userAmount; j++)
                {
                    double percent = random.NextDouble() * 100;

                    totalCounter++;

                    if (percent <= milSpec)
                    {
                        //outcomeBoxTwo.SelectionColor = Color.Red;
                        outcomeBoxTwo.Text += ("Milspec -\r\n");
                        
                        milspecCounter++;
                    }

                    else if (percent <= restricted + milSpec)
                    {
                        outcomeBoxTwo.Text += ("Restricted ----\r\n");
                        restrictedCounter++;
                    }

                    else if (percent <= restricted + milSpec + classified)
                    {
                        outcomeBoxTwo.Text += ("Classified ------\r\n");
                        classifiedCounter++;
                    }

                    else if (percent <= restricted + milSpec + classified + covert)
                    {
                        outcomeBoxTwo.Text += ("Covert --------\r\n");
                        covertCounter++;
                    }
                    else
                    {
                        outcomeBoxTwo.Text += ("Knife / Gloves! ------------\r\n");
                        knifeCounter++;
                    }

                    knifeCount.Text = "Milspec: " + milspecCounter.ToString() + "\r\nRestricted: " + restrictedCounter + "\r\nClassified: " + classifiedCounter + "\r\nCovert: " + covertCounter + "\r\nKnives: " + knifeCounter + "\r\nTotal: " + totalCounter;

                    //foreach(int av in outcomeBoxTwo.Text)
                    //{
                    //    if (av = "Knife / Gloves! That's as good as it gets!")
                    //    {
                    //        int knifeCount++;
                    //    }
                    //}
                }
            }
        }
    }
}
