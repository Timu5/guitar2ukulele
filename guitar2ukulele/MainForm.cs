using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guitar2ukulele
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /*  E4 = 12 * 4 + 5
            B3 = 12 * 3 + 12
            G3 = 12 * 3 + 8
            D3 = 12 * 3 + 3
            A2 = 12 * 2 + 10
            E2 = 12 * 2 + 5 */
        int[] guitarStrings = { 12 * 4 + 5, 12 * 3 + 12, 12 * 3 + 8, 12 * 3 + 3, 12 * 2 + 10, 12 * 2 + 5 };
        /*  A4 = 12 * 4 + 10
            E4 = 12 * 4 + 5
            C4 = 12 * 4 + 1
            G4 = 12 * 4 + 8 */
        int[] ukuleleStrings = { 12 * 4 + 10, 12 * 4 + 5, 12 * 4 + 1, 12 * 4 + 8 };

        private void convertButton_Click(object sender, EventArgs e)
        {
            string[] input = guitarTextBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            if (input.Length < 6)
            {
                MessageBox.Show("Wrong number of strings!");
                return;
            }

            int transpose = 0;
            int.TryParse(transTextBox.Text, out transpose);

            List<int>[] notes = new List<int>[6];

            for (int i = 0; i < 6; i++)
            {
                notes[i] = new List<int>();
                for (int j = 0; j < input[i].Length; j++)
                {
                    int note = -1;
                    if (char.IsNumber(input[i][j]))
                    {
                        note = int.Parse(input[i][j].ToString());
                        if (j < input[i].Length - 1 && char.IsNumber(input[i][j + 1]))
                        {
                            note = note * 10 + int.Parse(input[i][++j].ToString());
                        }
                        note += guitarStrings[i] + transpose;
                    }
                    notes[i].Add(note);
                }
            }

            int[,] ukuNotes = new int[4, notes[0].Count];

            for (int i = 0; i < 6; i++)
            {
                for (int n = 0; n < notes[i].Count; n++)
                {
                    if (notes[i][n] != -1)
                    {
                        bool flag = false;
                        int strNum = 0;
                        for (int u = 0; u < 4; u++)
                        {
                            if (notes[i][n] > ukuleleStrings[u])
                            {
                                strNum = u;
                                flag = true;
                                break;
                            }
                        }
                        if (!flag)
                        {
                            MessageBox.Show("Cannot convert note");
                        }
                        else
                        {
                            ukuNotes[strNum, n] = notes[i][n] - ukuleleStrings[strNum];
                        }
                    }
                }
            }
            ukuleleTextBox.Text = "";
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < ukuNotes.GetLength(1); y++)
                {
                    if (ukuNotes[x, y] == 0)
                        ukuleleTextBox.Text += "-";
                    else
                        ukuleleTextBox.Text += ukuNotes[x, y].ToString();
                }

                ukuleleTextBox.Text += Environment.NewLine;

            }
        }
    }
}
