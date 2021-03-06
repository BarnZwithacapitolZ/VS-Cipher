﻿using System;
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
    public partial class CaeserCipher : Form
    {
        public CaeserCipher()
        {
            InitializeComponent();
        }

        private void CaeserCipher_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void CaeserCipher_Load(object sender, EventArgs e)
        {
            comboBoxCipher.SelectedIndex = 1;
            comboBoxInputOutput.SelectedIndex = 0;
        }

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


        private int encrypt(char character, int key, int minAscii, int maxAscii)
        {
            int value = (char)character;
            int newValue = 0;
            if (value > minAscii - 1 && value < maxAscii + 1)
            {
                newValue = value + key;
                do // For if new value goes past maxAscii
                {
                    if (newValue > maxAscii)
                    {
                        newValue -= 26;
                    } 
                } while (newValue > maxAscii);
            }
            else
            {
                newValue = value;
            }
            return newValue;
        }

        private int decrypt(char character, int key, int minAscii, int maxAscii)
        {
            int value = (char)character;
            int newValue = 0;
            if (value > minAscii - 1 && value < maxAscii + 1)
            {
                newValue = value - key;
                do
                    if (newValue < minAscii)
                    {
                        newValue += 26;
                    }
                while (newValue < minAscii);
            }
            else
            {
                newValue = value;
            }
            return newValue;
        }


        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            string plainText = textBoxInput.Text;
            string cipherText = "";           
            int asciiValue = 0;
            int newAsciiValue = 0;
            int shiftKey;

            try
            {
                shiftKey = int.Parse(TextBoxInputKey.Text);
                if (shiftKey == 0)
                {
                    MessageBox.Show("Please note, the key 0 will not convert to any encryption.");
                }
            }
            catch (Exception) { // Don't let key be used if not an integer
                MessageBox.Show("Please enter a valid key.");             
                return;
            }

            if (comboBoxCipher.SelectedIndex == 1)
            {             
                foreach (char letter in plainText)
                {
                    if (char.IsUpper(letter))
                    {
                        cipherText = cipherText + char.ConvertFromUtf32(encrypt(letter, shiftKey, 65, 90));
                    }
                    else
                    {
                        cipherText = cipherText + char.ConvertFromUtf32(encrypt(letter, shiftKey, 97, 122));
                    }
                }
                textBoxOuput.Text = cipherText;
            }
            else
            {
                foreach (char letter in plainText)
                {
                    if (char.IsUpper(letter))
                    {
                        cipherText = cipherText + char.ConvertFromUtf32(decrypt(letter, shiftKey, 65, 90));
                    }
                    else
                    {
                        cipherText = cipherText + char.ConvertFromUtf32(decrypt(letter, shiftKey, 97, 122));
                    }
                }
                textBoxOuput.Text = cipherText;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (comboBoxInputOutput.SelectedIndex == 0)
            {
                textBoxInput.Text = textBoxOuput.Text = "";
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


        private void changeInputKey(int newValue)
        {
            try // Only if the value is an integer
            {
                int currentText = int.Parse(TextBoxInputKey.Text);
                currentText += newValue;
                TextBoxInputKey.Text = Convert.ToString(currentText);
            }
            catch (Exception) // Else
            {
                MessageBox.Show("You cannot change a value that isn't an integer!");
            }
        }


        private void buttonPlus_Click(object sender, EventArgs e)
        {
            changeInputKey(1);         
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            changeInputKey(-1);         
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text;
            string outputText = textBoxOuput.Text;
            textBoxInput.Text = outputText;
            textBoxOuput.Text = inputText;
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

        private void loadMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoad form_load = new FormLoad();
            form_load.Show();
            form_load.Location = this.Location;
            this.Hide();
        }

        private void substitutionCipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubstitutionCipher sub_cipher = new SubstitutionCipher();
            sub_cipher.Show();
            sub_cipher.Location = this.Location;
            this.Hide();
        }
    }
}
