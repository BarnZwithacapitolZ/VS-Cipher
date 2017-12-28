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
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }

        private void ButtonCaeser_Click(object sender, EventArgs e) // Load Caeser Cipher
        {
            CaeserCipher caeser_cipher = new CaeserCipher();
            caeser_cipher.Show();
            caeser_cipher.Location = this.Location;
            this.Hide();
        }

        private void FormLoad_FormClosing(object sender, FormClosingEventArgs e) // Quit
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonSubstitution_Click(object sender, EventArgs e) // Load Substitution Cipher
        {
            SubstitutionCipher sub_cipher = new SubstitutionCipher();
            sub_cipher.Show();
            sub_cipher.Location = this.Location;
            this.Hide();
        }
    }
}
