namespace Cipher
{
    partial class FormLoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonCaeser = new System.Windows.Forms.Button();
            this.buttonSubstitution = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCaeser
            // 
            this.ButtonCaeser.BackColor = System.Drawing.Color.White;
            this.ButtonCaeser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCaeser.Location = new System.Drawing.Point(168, 225);
            this.ButtonCaeser.Name = "ButtonCaeser";
            this.ButtonCaeser.Size = new System.Drawing.Size(112, 23);
            this.ButtonCaeser.TabIndex = 2;
            this.ButtonCaeser.Text = "Caeser Cipher...";
            this.ButtonCaeser.UseVisualStyleBackColor = false;
            this.ButtonCaeser.Click += new System.EventHandler(this.ButtonCaeser_Click);
            // 
            // buttonSubstitution
            // 
            this.buttonSubstitution.BackColor = System.Drawing.Color.White;
            this.buttonSubstitution.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSubstitution.Location = new System.Drawing.Point(333, 225);
            this.buttonSubstitution.Name = "buttonSubstitution";
            this.buttonSubstitution.Size = new System.Drawing.Size(120, 23);
            this.buttonSubstitution.TabIndex = 3;
            this.buttonSubstitution.Text = "Substitution  Cipher...";
            this.buttonSubstitution.UseVisualStyleBackColor = false;
            this.buttonSubstitution.Click += new System.EventHandler(this.buttonSubstitution_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(234, 185);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(159, 24);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Choose an option";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonSubstitution);
            this.Controls.Add(this.ButtonCaeser);
            this.Name = "FormLoad";
            this.Text = "Cipher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoad_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonCaeser;
        internal System.Windows.Forms.Button buttonSubstitution;
        internal System.Windows.Forms.Label Label1;
    }
}

