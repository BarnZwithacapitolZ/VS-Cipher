namespace Cipher
{
    partial class CaeserCipher
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
            this.tableLayoutPanelTextBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOuput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelControls = new System.Windows.Forms.TableLayoutPanel();
            this.LabelInputKey = new System.Windows.Forms.Label();
            this.TextBoxInputKey = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxInputOutput = new System.Windows.Forms.ComboBox();
            this.ButtonConvert = new System.Windows.Forms.Button();
            this.comboBoxCipher = new System.Windows.Forms.ComboBox();
            this.labelCipher = new System.Windows.Forms.Label();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDecryptedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDecryptedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substitutionCipherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelTextBoxes.SuspendLayout();
            this.tableLayoutPanelControls.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTextBoxes
            // 
            this.tableLayoutPanelTextBoxes.ColumnCount = 1;
            this.tableLayoutPanelTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTextBoxes.Controls.Add(this.textBoxInput, 0, 0);
            this.tableLayoutPanelTextBoxes.Controls.Add(this.textBoxOuput, 0, 1);
            this.tableLayoutPanelTextBoxes.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelTextBoxes.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanelTextBoxes.Name = "tableLayoutPanelTextBoxes";
            this.tableLayoutPanelTextBoxes.RowCount = 2;
            this.tableLayoutPanelTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTextBoxes.Size = new System.Drawing.Size(400, 436);
            this.tableLayoutPanelTextBoxes.TabIndex = 0;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(3, 3);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInput.Size = new System.Drawing.Size(394, 212);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.Text = "Input...";
            // 
            // textBoxOuput
            // 
            this.textBoxOuput.Location = new System.Drawing.Point(3, 221);
            this.textBoxOuput.Multiline = true;
            this.textBoxOuput.Name = "textBoxOuput";
            this.textBoxOuput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOuput.Size = new System.Drawing.Size(394, 212);
            this.textBoxOuput.TabIndex = 1;
            this.textBoxOuput.Text = "Output...";
            // 
            // tableLayoutPanelControls
            // 
            this.tableLayoutPanelControls.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelControls.ColumnCount = 2;
            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanelControls.Controls.Add(this.LabelInputKey, 0, 0);
            this.tableLayoutPanelControls.Controls.Add(this.TextBoxInputKey, 1, 0);
            this.tableLayoutPanelControls.Controls.Add(this.buttonClear, 1, 4);
            this.tableLayoutPanelControls.Controls.Add(this.comboBoxInputOutput, 0, 4);
            this.tableLayoutPanelControls.Controls.Add(this.ButtonConvert, 1, 3);
            this.tableLayoutPanelControls.Controls.Add(this.comboBoxCipher, 1, 2);
            this.tableLayoutPanelControls.Controls.Add(this.labelCipher, 0, 2);
            this.tableLayoutPanelControls.Controls.Add(this.buttonPlus, 1, 1);
            this.tableLayoutPanelControls.Controls.Add(this.buttonMinus, 0, 1);
            this.tableLayoutPanelControls.Controls.Add(this.buttonSwitch, 0, 5);
            this.tableLayoutPanelControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanelControls.Location = new System.Drawing.Point(403, 25);
            this.tableLayoutPanelControls.Name = "tableLayoutPanelControls";
            this.tableLayoutPanelControls.RowCount = 7;
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanelControls.Size = new System.Drawing.Size(231, 436);
            this.tableLayoutPanelControls.TabIndex = 1;
            // 
            // LabelInputKey
            // 
            this.LabelInputKey.BackColor = System.Drawing.Color.Transparent;
            this.LabelInputKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInputKey.ForeColor = System.Drawing.Color.White;
            this.LabelInputKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelInputKey.Location = new System.Drawing.Point(4, 1);
            this.LabelInputKey.Name = "LabelInputKey";
            this.LabelInputKey.Size = new System.Drawing.Size(96, 25);
            this.LabelInputKey.TabIndex = 10;
            this.LabelInputKey.Text = "Input Key:";
            this.LabelInputKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBoxInputKey
            // 
            this.TextBoxInputKey.BackColor = System.Drawing.Color.Silver;
            this.TextBoxInputKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxInputKey.Location = new System.Drawing.Point(107, 4);
            this.TextBoxInputKey.Multiline = true;
            this.TextBoxInputKey.Name = "TextBoxInputKey";
            this.TextBoxInputKey.Size = new System.Drawing.Size(120, 19);
            this.TextBoxInputKey.TabIndex = 11;
            this.TextBoxInputKey.Text = "0";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(107, 108);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 19);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "Clear...";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBoxInputOutput
            // 
            this.comboBoxInputOutput.BackColor = System.Drawing.Color.Silver;
            this.comboBoxInputOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInputOutput.FormattingEnabled = true;
            this.comboBoxInputOutput.Items.AddRange(new object[] {
            "Both",
            "Input",
            "Output"});
            this.comboBoxInputOutput.Location = new System.Drawing.Point(4, 108);
            this.comboBoxInputOutput.Name = "comboBoxInputOutput";
            this.comboBoxInputOutput.Size = new System.Drawing.Size(96, 21);
            this.comboBoxInputOutput.TabIndex = 19;
            // 
            // ButtonConvert
            // 
            this.ButtonConvert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConvert.Location = new System.Drawing.Point(107, 82);
            this.ButtonConvert.Name = "ButtonConvert";
            this.ButtonConvert.Size = new System.Drawing.Size(94, 19);
            this.ButtonConvert.TabIndex = 18;
            this.ButtonConvert.Text = "Convert...";
            this.ButtonConvert.UseVisualStyleBackColor = false;
            this.ButtonConvert.Click += new System.EventHandler(this.ButtonConvert_Click);
            // 
            // comboBoxCipher
            // 
            this.comboBoxCipher.BackColor = System.Drawing.Color.Silver;
            this.comboBoxCipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCipher.FormattingEnabled = true;
            this.comboBoxCipher.Items.AddRange(new object[] {
            "Decrypt",
            "Encrypt"});
            this.comboBoxCipher.Location = new System.Drawing.Point(107, 56);
            this.comboBoxCipher.Name = "comboBoxCipher";
            this.comboBoxCipher.Size = new System.Drawing.Size(120, 21);
            this.comboBoxCipher.TabIndex = 13;
            // 
            // labelCipher
            // 
            this.labelCipher.BackColor = System.Drawing.Color.Transparent;
            this.labelCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCipher.ForeColor = System.Drawing.Color.White;
            this.labelCipher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCipher.Location = new System.Drawing.Point(4, 53);
            this.labelCipher.Name = "labelCipher";
            this.labelCipher.Size = new System.Drawing.Size(96, 21);
            this.labelCipher.TabIndex = 12;
            this.labelCipher.Text = "Cipher:";
            this.labelCipher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(107, 30);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(29, 19);
            this.buttonPlus.TabIndex = 21;
            this.buttonPlus.Text = "+1";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(4, 30);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(29, 19);
            this.buttonMinus.TabIndex = 22;
            this.buttonMinus.Text = "-1";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwitch.Location = new System.Drawing.Point(4, 134);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(94, 19);
            this.buttonSwitch.TabIndex = 23;
            this.buttonSwitch.Text = "Switch...";
            this.buttonSwitch.UseVisualStyleBackColor = false;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.saveDecryptedFileToolStripMenuItem});
            this.loadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.loadToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDecryptedFileToolStripMenuItem});
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loadFileToolStripMenuItem.Text = "Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // loadDecryptedFileToolStripMenuItem
            // 
            this.loadDecryptedFileToolStripMenuItem.Name = "loadDecryptedFileToolStripMenuItem";
            this.loadDecryptedFileToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.loadDecryptedFileToolStripMenuItem.Text = "Load Decrypted File";
            this.loadDecryptedFileToolStripMenuItem.Click += new System.EventHandler(this.loadDecryptedFileToolStripMenuItem_Click);
            // 
            // saveDecryptedFileToolStripMenuItem
            // 
            this.saveDecryptedFileToolStripMenuItem.Name = "saveDecryptedFileToolStripMenuItem";
            this.saveDecryptedFileToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveDecryptedFileToolStripMenuItem.Text = "Save Output";
            this.saveDecryptedFileToolStripMenuItem.Click += new System.EventHandler(this.saveDecryptedFileToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.substitutionCipherToolStripMenuItem,
            this.loadMenuToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // substitutionCipherToolStripMenuItem
            // 
            this.substitutionCipherToolStripMenuItem.Name = "substitutionCipherToolStripMenuItem";
            this.substitutionCipherToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.substitutionCipherToolStripMenuItem.Text = "Substitution Cipher";
            this.substitutionCipherToolStripMenuItem.Click += new System.EventHandler(this.substitutionCipherToolStripMenuItem_Click);
            // 
            // loadMenuToolStripMenuItem
            // 
            this.loadMenuToolStripMenuItem.Name = "loadMenuToolStripMenuItem";
            this.loadMenuToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.loadMenuToolStripMenuItem.Text = "Load Menu";
            this.loadMenuToolStripMenuItem.Click += new System.EventHandler(this.loadMenuToolStripMenuItem_Click);
            // 
            // CaeserCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.tableLayoutPanelControls);
            this.Controls.Add(this.tableLayoutPanelTextBoxes);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CaeserCipher";
            this.Text = "CaeserCipher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CaeserCipher_FormClosing);
            this.Load += new System.EventHandler(this.CaeserCipher_Load);
            this.tableLayoutPanelTextBoxes.ResumeLayout(false);
            this.tableLayoutPanelTextBoxes.PerformLayout();
            this.tableLayoutPanelControls.ResumeLayout(false);
            this.tableLayoutPanelControls.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTextBoxes;
        private System.Windows.Forms.TextBox textBoxOuput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelControls;
        private System.Windows.Forms.MenuStrip menuStrip1;
        internal System.Windows.Forms.Label LabelInputKey;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        internal System.Windows.Forms.TextBox TextBoxInputKey;
        internal System.Windows.Forms.Label labelCipher;
        private System.Windows.Forms.ComboBox comboBoxCipher;
        internal System.Windows.Forms.Button ButtonConvert;
        private System.Windows.Forms.ComboBox comboBoxInputOutput;
        internal System.Windows.Forms.Button buttonClear;
        internal System.Windows.Forms.Button buttonPlus;
        internal System.Windows.Forms.Button buttonMinus;
        internal System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDecryptedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDecryptedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substitutionCipherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMenuToolStripMenuItem;
    }
}