using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp12
{
    
    
        public static class GlobalVariables
        {
            public static int Result { get; set; }
        }

        public partial class Main : Form
        {
            public Main()
            {
                InitializeComponent();
            }

            private void детсвоМолодостьToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.Hide();
                Detstvo ua1 = new Detstvo(1,1); // Provide row and column values
                ua1.ShowDialog();
            }

            private void взрослаяЖизньСтаростьToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.Hide();
                Vzros ua = new Vzros();
                ua.ShowDialog();
            }

            private void менюToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.Hide();
                Main ua = new Main();
                ua.ShowDialog();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                // Parse the input from the TextBox
                if (int.TryParse(textBox1.Text, out int number))
                {
                    // Perform the calculation
                    int result = (number * 365) / 7;

                    // Set the result in the GlobalVariables class
                    GlobalVariables.Result = result;

                    // Display the result in the output TextBox
                    textBox2.Text = result.ToString();
                }
                else
                {
                    // Display an error message if the input is not a valid number
                    MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    

}