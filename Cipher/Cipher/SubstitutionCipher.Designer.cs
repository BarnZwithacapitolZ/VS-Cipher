namespace Cipher
{
    partial class SubstitutionCipher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubstitutionCipher));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDecryptedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDecryptedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substitutionCipherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelTextBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOuput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelControls = new System.Windows.Forms.TableLayoutPanel();
            this.LabelToChange = new System.Windows.Forms.Label();
            this.TextBoxNewValue = new System.Windows.Forms.TextBox();
            this.labelToValue = new System.Windows.Forms.Label();
            this.comboBoxChangeValue = new System.Windows.Forms.ComboBox();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.comboBoxInputOutput = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.ButtonConvert = new System.Windows.Forms.Button();
            this.comboBoxCipher = new System.Windows.Forms.ComboBox();
            this.labelCipher = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanelTextBoxes.SuspendLayout();
            this.tableLayoutPanelControls.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 3;
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
            this.substitutionCipherToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.substitutionCipherToolStripMenuItem.Text = "Caeser Cipher";
            this.substitutionCipherToolStripMenuItem.Click += new System.EventHandler(this.substitutionCipherToolStripMenuItem_Click);
            // 
            // loadMenuToolStripMenuItem
            // 
            this.loadMenuToolStripMenuItem.Name = "loadMenuToolStripMenuItem";
            this.loadMenuToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.loadMenuToolStripMenuItem.Text = "Load Menu";
            this.loadMenuToolStripMenuItem.Click += new System.EventHandler(this.loadMenuToolStripMenuItem_Click);
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
            this.tableLayoutPanelTextBoxes.TabIndex = 4;
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
            this.tableLayoutPanelControls.Controls.Add(this.LabelToChange, 0, 0);
            this.tableLayoutPanelControls.Controls.Add(this.TextBoxNewValue, 1, 1);
            this.tableLayoutPanelControls.Controls.Add(this.labelToValue, 1, 0);
            this.tableLayoutPanelControls.Controls.Add(this.comboBoxChangeValue, 0, 1);
            this.tableLayoutPanelControls.Controls.Add(this.buttonSwitch, 0, 6);
            this.tableLayoutPanelControls.Controls.Add(this.comboBoxInputOutput, 0, 5);
            this.tableLayoutPanelControls.Controls.Add(this.buttonClear, 1, 5);
            this.tableLayoutPanelControls.Controls.Add(this.ButtonConvert, 1, 4);
            this.tableLayoutPanelControls.Controls.Add(this.comboBoxCipher, 1, 3);
            this.tableLayoutPanelControls.Controls.Add(this.labelCipher, 0, 3);
            this.tableLayoutPanelControls.Controls.Add(this.buttonSubmit, 1, 2);
            this.tableLayoutPanelControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanelControls.Location = new System.Drawing.Point(403, 25);
            this.tableLayoutPanelControls.Name = "tableLayoutPanelControls";
            this.tableLayoutPanelControls.RowCount = 8;
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tableLayoutPanelControls.Size = new System.Drawing.Size(231, 436);
            this.tableLayoutPanelControls.TabIndex = 5;
            // 
            // LabelToChange
            // 
            this.LabelToChange.BackColor = System.Drawing.Color.Transparent;
            this.LabelToChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelToChange.ForeColor = System.Drawing.Color.White;
            this.LabelToChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelToChange.Location = new System.Drawing.Point(4, 1);
            this.LabelToChange.Name = "LabelToChange";
            this.LabelToChange.Size = new System.Drawing.Size(96, 25);
            this.LabelToChange.TabIndex = 10;
            this.LabelToChange.Text = "To-Change:";
            this.LabelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBoxNewValue
            // 
            this.TextBoxNewValue.BackColor = System.Drawing.Color.Silver;
            this.TextBoxNewValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxNewValue.Location = new System.Drawing.Point(107, 30);
            this.TextBoxNewValue.Multiline = true;
            this.TextBoxNewValue.Name = "TextBoxNewValue";
            this.TextBoxNewValue.Size = new System.Drawing.Size(120, 19);
            this.TextBoxNewValue.TabIndex = 11;
            // 
            // labelToValue
            // 
            this.labelToValue.BackColor = System.Drawing.Color.Transparent;
            this.labelToValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToValue.ForeColor = System.Drawing.Color.White;
            this.labelToValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelToValue.Location = new System.Drawing.Point(107, 1);
            this.labelToValue.Name = "labelToValue";
            this.labelToValue.Size = new System.Drawing.Size(96, 25);
            this.labelToValue.TabIndex = 24;
            this.labelToValue.Text = "To-Value:";
            this.labelToValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxChangeValue
            // 
            this.comboBoxChangeValue.BackColor = System.Drawing.Color.Silver;
            this.comboBoxChangeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChangeValue.FormattingEnabled = true;
            this.comboBoxChangeValue.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBoxChangeValue.Location = new System.Drawing.Point(4, 30);
            this.comboBoxChangeValue.Name = "comboBoxChangeValue";
            this.comboBoxChangeValue.Size = new System.Drawing.Size(96, 21);
            this.comboBoxChangeValue.TabIndex = 25;
            this.comboBoxChangeValue.SelectedIndexChanged += new System.EventHandler(this.comboBoxChangeValue_SelectedIndexChanged);
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSwitch.Location = new System.Drawing.Point(4, 160);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(94, 19);
            this.buttonSwitch.TabIndex = 23;
            this.buttonSwitch.Text = "Switch...";
            this.buttonSwitch.UseVisualStyleBackColor = false;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
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
            this.comboBoxInputOutput.Location = new System.Drawing.Point(4, 134);
            this.comboBoxInputOutput.Name = "comboBoxInputOutput";
            this.comboBoxInputOutput.Size = new System.Drawing.Size(96, 21);
            this.comboBoxInputOutput.TabIndex = 19;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(107, 134);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 19);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "Clear...";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // ButtonConvert
            // 
            this.ButtonConvert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConvert.Location = new System.Drawing.Point(107, 108);
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
            this.comboBoxCipher.Location = new System.Drawing.Point(107, 82);
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
            this.labelCipher.Location = new System.Drawing.Point(4, 79);
            this.labelCipher.Name = "labelCipher";
            this.labelCipher.Size = new System.Drawing.Size(96, 21);
            this.labelCipher.TabIndex = 12;
            this.labelCipher.Text = "Cipher:";
            this.labelCipher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(107, 56);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(94, 19);
            this.buttonSubmit.TabIndex = 26;
            this.buttonSubmit.Text = "Submit...";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // SubstitutionCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.tableLayoutPanelControls);
            this.Controls.Add(this.tableLayoutPanelTextBoxes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SubstitutionCipher";
            this.Text = "Substitution Cipher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubstitutionCipher_FormClosing);
            this.Load += new System.EventHandler(this.SubstitutionCipher_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanelTextBoxes.ResumeLayout(false);
            this.tableLayoutPanelTextBoxes.PerformLayout();
            this.tableLayoutPanelControls.ResumeLayout(false);
            this.tableLayoutPanelControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDecryptedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDecryptedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substitutionCipherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMenuToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTextBoxes;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOuput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelControls;
        internal System.Windows.Forms.Label LabelToChange;
        internal System.Windows.Forms.TextBox TextBoxNewValue;
        internal System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxInputOutput;
        internal System.Windows.Forms.Button ButtonConvert;
        private System.Windows.Forms.ComboBox comboBoxCipher;
        internal System.Windows.Forms.Label labelCipher;
        internal System.Windows.Forms.Button buttonSwitch;
        internal System.Windows.Forms.Label labelToValue;
        private System.Windows.Forms.ComboBox comboBoxChangeValue;
        internal System.Windows.Forms.Button buttonSubmit;
    }
}