using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kincsvadász_rács
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public class liststyle
        {
            public int positionX;
            public int positionY;
            public string type;
            public bool clicked;

            public liststyle(int positionX, int positionY, string type, bool clicked)
            {
                this.positionX = positionX;
                this.positionY = positionY;
                this.type = type;
                this.clicked = clicked;
            }
        }
        public class pontok
        {
            public string nev;
            public int pont;
            public int ido;
            public DateTime datum;
            public pontok(string line)
            {
                string[] oneline = line.Split(';');
                this.nev = oneline[0];
                this.pont = int.Parse(oneline[1]);
                this.ido = int.Parse(oneline[2]);
                this.datum = DateTime.Parse(oneline[3]);
            }
        }
        public List<liststyle> buttonlist = new List<liststyle>();
        public string[] buttonTypes = { "Empty", "Treasure", "Trap" };
        public Random random = new Random();
        private class ButtonTag
        {
            public int Row { get; set; }
            public int Column { get; set; }
            public string Type { get; set; }
            public bool IsClicked { get; set; }

            public ButtonTag(int row, int column, string type, bool isClicked)
            {
                Row = row;
                Column = column;
                Type = type;
                IsClicked = isClicked;
            }
        }

        public int Counter = 0;
        public int foundTreasure;
        public int id = 0;  
        public int cimke;


        public void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null && button.Tag is ButtonTag tag)
            {
                switch (tag.Type)
                {
                    case "Empty":
                        button.BackColor = Color.LightGray;
                        button.Text = "";
                        Counter += 0;
                        break;
                    case "Treasure":
                        button.BackColor = Color.Green;
                        button.Text = "";
                        Counter += 2;                        
                        foundTreasure++;
                        break;
                    case "Trap":
                        button.BackColor = Color.Red;
                        button.Text = "";
                        Counter -= 2;
                        break;
                }
                button.Enabled = false;
                lbl_pontszam.Text = "Pontszám: " + Counter.ToString(); //itt frissül a pontszám és a label
            }
        }

        Form form3; //Form címke létrhozása itt.
        System.Windows.Forms.Label lbl_pontszam; //címke inicializálása itt.             
        private void button1_Click(object sender, EventArgs e)
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
            form2.Controls.Add(numericUpDown1);

            NumericUpDown numericUpDown2 = new NumericUpDown();
            numericUpDown2.Location = new Point(10, 90);
            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 10;
            numericUpDown2.Width = 100;
            numericUpDown2.Height = 100;
            form2.Controls.Add(numericUpDown2);

            TextBox textBox1 = new TextBox();
            textBox1.Location = new Point(40, 125);
            textBox1.Width = 100;
            textBox1.Height = 20;
            form2.Controls.Add(textBox1);


            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
            label1.Location = new Point(10, 25);
            label1.Left = 10;
            label1.Text = "Sorok száma";
            form2.Controls.Add(label1);


            System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
            label2.Location = new Point(10, 75);
            label2.Text = "Oszlopok száma";
            form2.Controls.Add(label2);


            System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
            label3.Location = new Point(10, 130);
            label3.Text = "Név:";
            form2.Controls.Add(label3);

            Button buttonStart = new Button();
            buttonStart.Location = new Point(120, 55);
            buttonStart.Text = "START";
            buttonStart.Width = 100;
            buttonStart.Height = 45;
            form2.Controls.Add(buttonStart);

            int rows = (int)numericUpDown1.Value;
            int cols = (int)numericUpDown2.Value;
            int spacing = 10;
            int treasurecount = 0;

            buttonStart.Click += (s, ev) =>
            {
                rows = (int)numericUpDown1.Value;
                cols = (int)numericUpDown2.Value;
                spacing = 10;
                treasurecount = 0;
                id = 0;
                buttonlist.Clear();
                foundTreasure = 0;
                Counter = 0;

                form3 = new Form();
                form3.Show();

                // Compute form size
                int formWidth = spacing + cols * (50 + spacing) + 15;
                int formHeight = spacing + rows * (50 + spacing) + 120;
                form3.Width = formWidth;
                form3.Height = formHeight;

                System.IO.StreamWriter sw2 = new System.IO.StreamWriter("test.txt", true);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        string typeForList = buttonTypes[random.Next(0, buttonTypes.Length)];
                        buttonlist.Add(new liststyle(i, j, typeForList, false));
                        sw2.WriteLine($"{i + 1},{j + 1},{buttonlist[id].type},{buttonlist[id].clicked}");
                        id++;

                        Button gridButton = new Button();
                        gridButton.Width = 50;
                        gridButton.Height = 50;
                        gridButton.Left = spacing + j * (50 + spacing);
                        gridButton.Top = spacing + i * (50 + spacing);

                        int prop = random.Next(0, buttonTypes.Length);
                        gridButton.Tag = new ButtonTag(i, j, buttonTypes[prop], false);
                        gridButton.Click += ButtonClick;
                        gridButton.Text = buttonTypes[prop] == "Treasure" ? "Kincs" : buttonTypes[prop] == "Trap" ? "Csapda" : "Üres";
                        gridButton.ForeColor = Color.White;
                        gridButton.BackColor = Color.White;

                        if (buttonTypes[prop] == "Treasure") { treasurecount++; }
                        form3.Controls.Add(gridButton);
                        gridButton.Visible = false;
                    }
                }
                sw2.Close();

                // Pontszám label
                lbl_pontszam = new System.Windows.Forms.Label();
                lbl_pontszam.Location = new Point(10, spacing + rows * (50 + spacing) + 50);
                lbl_pontszam.Text = "Pontszám: " + Counter.ToString();
                form3.Controls.Add(lbl_pontszam);

                form3.Text = "Kincsek: " + treasurecount.ToString();

                // Timer label
                System.Windows.Forms.Label lbl_timer = new System.Windows.Forms.Label();
                lbl_timer.Location = new Point(form3.Width - 120, spacing + rows * (50 + spacing) + 50);
                lbl_timer.AutoSize = true;
                lbl_timer.Text = "Idő: 0s";
                form3.Controls.Add(lbl_timer);

                // Indítás button 
                Button startbutton = new Button();
                startbutton.Width = (cols * 50) + (cols - 1) * spacing;
                startbutton.Height = 30;
                startbutton.Text = "Indítás";
                startbutton.Location = new Point(10, spacing + rows * (50 + spacing) + 10);
                form3.Controls.Add(startbutton);

                // Game timer
                System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
                gameTimer.Interval = 1000; // 1 second
                int elapsedSeconds = 0;

                gameTimer.Tick += (ts, te) =>
                {
                    elapsedSeconds++;
                    lbl_timer.Text = $"Idő: {elapsedSeconds}s";

                    // Feltételek:
                    // a) megvan az összes kincs    
                    bool allTreasuresFound = (foundTreasure >= treasurecount);
                    // b) minde gomb le volt nyomva kivéve az indítás gombot
                    var gridButtons = form3.Controls.OfType<Button>().Where(x => x != startbutton);
                    bool allButtonsClicked = gridButtons.All(x => !x.Enabled);

                    if (allTreasuresFound || allButtonsClicked)
                    {
                        gameTimer.Stop();
                        using (var sw = new System.IO.StreamWriter("pontok.txt", true))// minden adat fájlba írása
                        {
                            if (allTreasuresFound)
                            {
                                sw.WriteLine($"{textBox1.Text};{Counter.ToString()};{elapsedSeconds};{DateTime.Now}");
                            }
                            else
                            {
                                sw.WriteLine($"{textBox1.Text};{Counter};{elapsedSeconds};{DateTime.Now}");
                            }
                        }

                        // a játék vége üzenet
                        string message = allTreasuresFound ? "Gratulálunk! Megtaláltad az összes kincset!" : "Játék vége. Minden gombot megnyomtak / nincs több művelet.";
                        DialogResult result = MessageBox.Show(message + $" Pontszám: {Counter} Idő: {elapsedSeconds}s Arány: {(rows * cols) / Counter}", "Játék vége", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            form3.Hide();
                            form2.Hide();
                            Form form4 = new Form();
                            form4.Show();
                            form4.Width = 350;
                            form4.Height = 500;

                            ComboBox filter = new ComboBox();
                            filter.Items.Add("Összes eredmény");
                            filter.Items.Add("Név szerint");
                            filter.Items.Add("Pontszám szerint");
                            filter.Items.Add("Idő szerint");
                            filter.Width = 300;
                            filter.Height = 20;
                            filter.Location = new Point(10, 300);
                            form4.Controls.Add(filter);

                            List<pontok> pontokLista = new List<pontok>();
                            System.IO.File.ReadAllLines("pontok.txt").ToList().ForEach(line => pontokLista.Add(new pontok(line)));
                            ListBox eredmények = new ListBox();
                            eredmények.Width = 300;
                            eredmények.Height = 280;
                            eredmények.Location = new Point(10, 10);
                            filter.SelectedIndexChanged += (sFilter,fFilter) => 
                            {
                                if (filter.SelectedItem.ToString() == "Összes eredmény")
                                {
                                    eredmények.Items.Clear();
                                    pontokLista.ForEach(line => eredmények.Items.Add($"Név: {line.nev} Pontok: {line.pont} Idő: {line.ido} Dátum: {line.datum.Year}.{line.datum.Month}.{line.datum.Day}"));
                                }
                                else if (filter.SelectedItem.ToString() == "Név szerint")
                                {
                                    eredmények.Items.Clear();
                                    pontokLista.OrderBy(x => x.nev).ToList().ForEach(line => eredmények.Items.Add($"Név: {line.nev} Pontok: {line.pont} Idő: {line.ido} Dátum: {line.datum.Year}.{line.datum.Month}.{line.datum.Day}"));
                                }
                                else if (filter.SelectedItem.ToString() == "Pontszám szerint")
                                {
                                    eredmények.Items.Clear();
                                    pontokLista.OrderByDescending(x => x.pont).ToList().ForEach(line => eredmények.Items.Add($"Pontok: {line.pont} Név: {line.nev} Idő: {line.ido} Dátum: {line.datum.Year}.{line.datum.Month}.{line.datum.Day}"));
                                }
                                else if (filter.SelectedItem.ToString() == "Idő szerint")
                                {
                                    eredmények.Items.Clear();
                                    pontokLista.OrderByDescending(x => x.ido).ToList().ForEach(line => eredmények.Items.Add($"Idő: {line.ido} Pontok: {line.pont} Név: {line.nev} Dátum: {line.datum.Year}.{line.datum.Month}.{line.datum.Day}"));
                                }  
                            };
                            form4.Controls.Add(eredmények);

                            Button kilépés = new Button();
                            kilépés.Text = "Kilépés";
                            kilépés.Width = 100;
                            kilépés.Height = 20;
                            kilépés.Location = new Point(10,370);
                            kilépés.Click += (sExit, eExit) => CloseAllAndExit();
                            form4.Controls.Add(kilépés);

                            Button újJáték = new Button();
                            újJáték.Text = "Új játék";
                            újJáték.Width = 100;
                            újJáték.Height = 20;
                            újJáték.Location = new Point(110, 370);
                            újJáték.Click += (sNew, eNew) => ShowStartingPage();
                            form4.Controls.Add(újJáték);
                        }
                    }

                    // Pontszám label frissítése
                    lbl_pontszam.Text = "Pontszám: " + Counter.ToString();
                };
                startbutton.Click += (se, evv) =>
                {
                    // gombok megjelenítése
                    foreach (Control ctrl in form3.Controls)
                    {
                        if (ctrl is Button btn && btn != startbutton)
                        {
                            btn.Visible = true;
                            btn.Enabled = true;
                        }
                    }
                    startbutton.Enabled = false;
                    // timer reset és elindítás
                    elapsedSeconds = 0;
                    lbl_timer.Text = "Idő: 0s";
                    gameTimer.Start();
                };
            };
        }

        private void CloseAllAndExit()
        {
            // Make a copy of the open forms collection to avoid modifying the collection while iterating
            var openForms = Application.OpenForms.Cast<Form>().ToList(); // copy list of open forms
            foreach (var open in openForms)
            {
                // Only attempt to close forms that are not already disposed
                if (!open.IsDisposed)
                {
                    open.Close(); // close this form (will trigger Form.Closing / Form.Closed events)
                }
            }
            Application.Exit(); // ensure the message loop ends and the process exits
        }
        private void ShowStartingPage()
        {
            var openForms = Application.OpenForms.Cast<Form>().ToList();
            foreach (var open in openForms)
            {
                if (open == this) continue; // keep the starting page
                if (!open.IsDisposed) {open.Close();} //close everything else
            }

            // Also explicitly close any stored secondary form reference
            if (form3 != null && !form3.IsDisposed)
            {
                form3.Close();
                form3 = null;
            }

            // Show and restore the starting form
            if (this.IsDisposed)
            {
                // If this instance was disposed for some reason, create and show a new one.
                var starter = new Form1();
                starter.Show();
                return;
            }

            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();

            // Reset game state so the user can start a new game

            buttonlist.Clear();
            Counter = 0;
            foundTreasure = 0;
            id = 0;
            cimke = 0;
            lbl_pontszam = null;
        }

    }
}
