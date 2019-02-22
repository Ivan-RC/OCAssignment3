using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//This is my own work
//Ivan Rivas


namespace OCAssignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Display_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                    string longestWord = "";
                    string allText = sr.ReadToEnd();
                    richTextBox1.Text = allText.ToLower();
                    string[] text = allText.ToLower().Split();
                    string firstText = text[0];
                    string lastText = text[0];
                    int maxVowels = 0;
                    string mostVowels = "";

                    for (int i = 0; i < text.Length; i++)
                    {
                        //Find first and last word alphabetically
                        if (text[i].CompareTo(firstText) < 0)
                            firstText = text[i];
                        if (text[i].CompareTo(lastText) > 0)
                            lastText = text[i];

                        //Find longest word
                        if (text[i].Length > longestWord.Length)
                        {
                            longestWord = text[i];
                        }

                        //Find word with most vowels
                        int vowelCt = 0;
                        for(int j = 0; j < text[i].Length; j++)
                        {
                            if (text[i][j] == 'a' ||
                                text[i][j] == 'e' ||
                                text[i][j] == 'i' ||
                                text[i][j] == 'o' ||
                                text[i][j] == 'u')
                            {
                                vowelCt++;
                            }
                        }
                        if (vowelCt > maxVowels)
                        {
                            maxVowels = vowelCt;
                            mostVowels = text[i];
                        }
                    }

                    richTextBox1.Text += "\nThis is the last word: " + firstText + ". This is the first word: " + lastText;
                    richTextBox1.Text += "\nThis is the longest word: " + longestWord;
                    richTextBox1.Text += "\nThis is the word with the most vowels: " + mostVowels;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void btn1_Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " ";
        }
    }
}
