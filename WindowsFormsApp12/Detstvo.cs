using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
    {
        public partial class Detstvo : Form
        {
            private int row, col;

            public Detstvo(int row, int column)
            {
                this.row = row;
                this.col = column;
                InitializeComponent();
                CreateTableLayoutPanel();
            }

            private void Detstvo_Load(object sender, EventArgs e)
            {
                // You can use GlobalVariables.Result here if needed.
            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.Hide();
                Main ua = new Main();
                ua.ShowDialog();
            }

            private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
            {
                // Ensure this method is subscribed to the Paint event of tableLayoutPanel1
            }

            private void CreateTableLayoutPanel()
            {
                // Create TableLayoutPanel
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.AutoSize = true;
                tableLayoutPanel.AutoScroll = true;
                tableLayoutPanel.Dock = DockStyle.Fill;
                tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                tableLayoutPanel.RowCount = 1;
                tableLayoutPanel.ColumnCount = 1; // 64 columns with every fifth column skipped

                // Add TableLayoutPanel to Form
                this.Controls.Add(tableLayoutPanel);

                // Paint numbers from 1 to 52 over cells
                int number = 1;
                for (int row = 0; row < tableLayoutPanel.RowCount; row++)
                {
                    for (int col = 0; col < tableLayoutPanel.ColumnCount; col++)
                    {
                        Label label = new Label();
                        label.Text = number.ToString();
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        label.Dock = DockStyle.Fill;
                        label.BackColor = Color.LightGray; // Background color
                        tableLayoutPanel.Controls.Add(label, col, row);

                        number++;
                    }
                }
            }
        }
    }
