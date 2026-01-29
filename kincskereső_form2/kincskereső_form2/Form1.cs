using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kincskereső_form2
{
    public partial class Form1 : Form
    {

        public int Rows = 10;
        public int Columns = 10;

        public string[] buttonTypes = { "Empty", "Treasure", "Trap" };
        public string[,] grid;

        public Random random = new Random();
        public int counter = 0;

        public class ButtonTag
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
        public void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null && button.Tag is ButtonTag tag)
            {
                MessageBox.Show($"Button at ({tag.Row}, {tag.Column}) is a {tag.Type}");
            }
        }



        public void InitializeGameBoard(int rows, int columns)
        {
            Form1 game = new Form1();
            game.Show();
            game.Width = 500;
            game.Height = 500;
            int offsetX = 10;
            int offsetY = 10;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    var button = new Button();
                    button.Width = 20;
                    button.Height = 20;
                    button.Left = offsetX;
                    button.Top = offsetY;
                    offsetX += 15;
                    button.BackColor = Color.White;
                    int prop = random.Next(0,buttonTypes.Length);
                    button.Tag = new ButtonTag(i, j, buttonTypes[prop],false);

                    
                    button.Click += ButtonClick;
                    game.Controls.Add(button);
                }
                offsetY += 15;
            }
        }
        public Form1()
        {
            InitializeComponent();
            InitializeGameBoard(Rows, Columns);
        }
    }
}
