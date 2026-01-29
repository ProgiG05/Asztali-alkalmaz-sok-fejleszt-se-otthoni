using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] buttonTypes = { "Empty", "Treasure", "Trap" };

        public Random random = new Random();
        private class ButtonTag
        {
            public int Row { get; set; }
            public int Column { get; set; }
            public string Type { get; set; }
            public bool IsClicked { get; set; }

            public ButtonTag(int row, int column, string type,bool isclicked)
            {
                Row = row;
                Column = column;
                Type = type;
                IsClicked = isclicked;
            }
        }

        public int Counter = 0;
        public int treasurecount = 0;

        public void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null && button.Tag is ButtonTag tag)
            {
                switch (tag.Type)
                {
                    case "Empty":
                        button.BackColor = Color.LightGray;
                        button.ForeColor = Color.Black;
                        button.Text = "*__*";
                        
                        Counter++;
                        break;
                    case "Treasure":
                        button.BackColor = Color.Green;
                        button.Text = "+";
                        Counter += 2;
                        treasurecount--;
                        this.Text = "Kincsvadász - Pontszám: " + treasurecount.ToString();
                        break;
                    case "Trap":
                        button.BackColor = Color.Red;
                        button.Text = "X";
                        Counter -= 2;
                        break;
                }
                button.Enabled = false;
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form2 = new Form();
            this.Hide();
            form2.Show();

            form2.Width = 250;
            form2.Height = 200;

            NumericUpDown numericUpDown1 = new NumericUpDown();
            numericUpDown1.Location = new Point(10, 40);
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 10;

            numericUpDown1.Width = 100;
            numericUpDown1.Height = 100;

            NumericUpDown numericUpDown2 = new NumericUpDown();
            numericUpDown2.Location = new Point(10, 90);
            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 10;

            numericUpDown2.Width = 100;
            numericUpDown2.Height = 100;

            TextBox textboxName = new TextBox();
            textboxName.Location = new Point(50, 125);
            textboxName.Width = 100;
            textboxName.Height = 20;

            form2.Controls.Add(numericUpDown1);
            form2.Controls.Add(numericUpDown2);
            form2.Controls.Add(textboxName);

            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
            label1.Location = new Point(10, 25);
            label1.Left = 10;
            label1.Text = "Sorok száma";


            System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
            label2.Location = new Point(10, 75);
            label2.Text = "Oszlopok száma";

            System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
            label3.Location = new Point(10, 125);
            label3.Text = "Név:";


            Button buttonStart = new Button();
            buttonStart.Location = new Point(120, 55);
            buttonStart.Text = "START";
            buttonStart.Width = 100;
            buttonStart.Height = 45;

            form2.Controls.Add(buttonStart);
            form2.Controls.Add(label1);
            form2.Controls.Add(label2);

            Form form3 = new Form();
            buttonStart.Click += (s, ev) =>
            {
                form3.Show();
                form3.Width = 800;
                form3.Height = 600;
                int rows = (int)numericUpDown1.Value;
                int cols = (int)numericUpDown2.Value;
                int buttonWidth = 50;
                int buttonHeight = 50;
                int spacing = 10;
                
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Button gridButton = new Button();
                        gridButton.Width = buttonWidth;
                        gridButton.Height = buttonHeight;
                        gridButton.Left = spacing + j * (buttonWidth + spacing);
                        gridButton.Top = spacing + i * (buttonHeight + spacing);
                        int prop = random.Next(0, buttonTypes.Length);
                        gridButton.Tag = new ButtonTag(i, j, buttonTypes[prop],false);
                        gridButton.Click += ButtonClick;
                        gridButton.Text = buttonTypes[prop] == "Treasure" ? "Kincs" : buttonTypes[prop] == "Trap" ? "Csapda" : "Üres";
                        gridButton.ForeColor = Color.White;
                        gridButton.BackColor = Color.White;

                        if (gridButton.Text == "Kincs")
                        {
                            treasurecount++;
                        }


                        form3.Controls.Add(gridButton);
                    }

                    form3.Text = "Kincsvadász - Kincsek száma: " + treasurecount.ToString();
                }

                int formWidth;
                formWidth = buttonWidth * cols + spacing * (cols + 1) + 15;
                form3.Width = formWidth;


                int formHeight;
                formHeight = buttonHeight * rows + spacing * (rows + 1) + 40;
                form3.Height = formHeight;


            };
        }
    }
}
