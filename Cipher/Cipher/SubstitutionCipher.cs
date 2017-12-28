using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Made by Sam Barnes

namespace Cipher
{
    public partial class SubstitutionCipher : Form
    {
        public SubstitutionCipher()
        {
            InitializeComponent();
        }

        private string[,] originalValues = new string[26, 2] { { "A", "Y" }, { "B", "Z" }, { "C", "W" }, { "D", "X" }, { "E", "U" },
        { "F", "V" }, { "G", "S" }, { "H", "T" }, { "I", "Q" }, { "J", "R" }, { "K", "O" }, { "L", "P" }, { "M", "M" }, { "N", "N" },
        { "O", "K" }, { "P", "L" }, { "Q", "I" }, { "R", "J" }, { "S", "G" }, { "T", "H" }, { "U", "E" }, { "V", "F" }, { "W", "C" },
        { "X", "D" }, { "Y", "A" }, { "Z", "B" } }; // Each letter and their relative replacement

        private void loadFile(string text, TextBox location)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = text;
            fd.InitialDirectory = ("C:\"");
            fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fd.FilterIndex = 2;
            fd.RestoreDirectory = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                location.Text = System.IO.File.ReadAllText(fd.FileName); // Write to the textbox specified  
            }
        }

        private void saveFile(string text, TextBox location)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Title = text;
            fd.InitialDirectory = ("C:\"");
            fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fd.FilterIndex = 2;
            fd.RestoreDirectory = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(fd.FileName, location.Text); // Write all the text from textbox spcified to save location
            }
        }

        private void encode(int first, int second)
        {
            string plainText = textBoxInput.Text;
            string newValue = "";
            string cipherText = "";

            foreach (char letter in plainText)
            {
                for (int x = 0; x < 26; x++)
                {
                    if (originalValues[x, first] == letter.ToString().ToUpper())
                    {
                        newValue = originalValues[x, second];
                        break;
                    }
                    else
                    {
                        newValue = Convert.ToString(letter);
                    }
                }
                cipherText = cipherText + newValue;         
            }
            textBoxOuput.Text = cipherText.ToLower();
        }

        private void SubstitutionCipher_Load(object sender, EventArgs e)
        {
            comboBoxChangeValue.SelectedIndex = 0;
            comboBoxInputOutput.SelectedIndex = 0;
            comboBoxCipher.SelectedIndex = 1;
        }

        private void SubstitutionCipher_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void comboBoxChangeValue_SelectedIndexChanged(object sender, EventArgs e)
        {          
            for (int x = 0; x < 26; x++)
            {
                if (comboBoxChangeValue.Text.Equals(comboBoxChangeValue.Items[x])) 
                {                 
                    TextBoxNewValue.Text = originalValues[x, 1];
                }
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 26; x++) // For every character
            {
                if (TextBoxNewValue.Text is string && TextBoxNewValue.Text.Length <= 1)
                {
                    if (comboBoxChangeValue.Text.Equals(comboBoxChangeValue.Items[x]))
                    {
                        originalValues[x, 1] = TextBoxNewValue.Text.ToUpper(); // Change the specified character
                    }
                }
                else // Prevent character inputs from not being characters
                {
                    MessageBox.Show("Please enter a single character");
                    break;
                }                                 
            }
            TextBoxNewValue.Text = "";
        }

        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            if (comboBoxCipher.SelectedIndex == 1)
            {
                encode(0, 1); // Encrypt the text with specified values
            }
            else
            {
                encode(1, 0); // Decrypt the text with specified values
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (comboBoxInputOutput.SelectedIndex == 0)
            {
                textBoxInput.Text = "";
                textBoxOuput.Text = "";
            }
            else if (comboBoxInputOutput.SelectedIndex == 1)
            {
                textBoxInput.Text = "";
            }
            else
            {
                textBoxOuput.Text = "";
            }
        }

        private void substitutionCipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaeserCipher ceaser_cipher = new CaeserCipher();
            ceaser_cipher.Show();
            ceaser_cipher.Location = this.Location;
            this.Hide();
        }

        private void loadMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoad form_load = new FormLoad();
            form_load.Show();
            form_load.Location = this.Location;
            this.Hide();
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadFile("Open File", textBoxInput);
        }

        private void loadDecryptedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadFile("Open File", textBoxOuput);
        }

        private void saveDecryptedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile("Save File", textBoxOuput);
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text;
            string outputText = textBoxOuput.Text;
            textBoxInput.Text = outputText;
            textBoxOuput.Text = inputText;
        }
    }
}
