namespace eazy_HASH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog = new OpenFileDialog();
            inputFileButton = new Button();
            inputPathLabel = new Label();
            outputFileButton = new Button();
            outputFileLabel = new Label();
            hashDropDown = new ComboBox();
            hashButton = new Button();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // inputFileButton
            // 
            inputFileButton.Location = new Point(12, 73);
            inputFileButton.Name = "inputFileButton";
            inputFileButton.Size = new Size(182, 29);
            inputFileButton.TabIndex = 0;
            inputFileButton.Text = "SELECT INPUT FILE";
            inputFileButton.UseVisualStyleBackColor = true;
            inputFileButton.Click += inputFileButton_Click;
            // 
            // inputPathLabel
            // 
            inputPathLabel.BackColor = SystemColors.Highlight;
            inputPathLabel.ForeColor = Color.White;
            inputPathLabel.Location = new Point(228, 73);
            inputPathLabel.Name = "inputPathLabel";
            inputPathLabel.Padding = new Padding(3);
            inputPathLabel.Size = new Size(560, 29);
            inputPathLabel.TabIndex = 1;
            inputPathLabel.Text = "[ input file path will be shown here ]";
            inputPathLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // outputFileButton
            // 
            outputFileButton.Location = new Point(12, 128);
            outputFileButton.Name = "outputFileButton";
            outputFileButton.Size = new Size(182, 29);
            outputFileButton.TabIndex = 2;
            outputFileButton.Text = "SELECT OUTPUT FILE";
            outputFileButton.UseVisualStyleBackColor = true;
            outputFileButton.Click += outputFileButton_Click;
            // 
            // outputFileLabel
            // 
            outputFileLabel.BackColor = SystemColors.Highlight;
            outputFileLabel.ForeColor = SystemColors.ButtonHighlight;
            outputFileLabel.Location = new Point(228, 128);
            outputFileLabel.Name = "outputFileLabel";
            outputFileLabel.Padding = new Padding(3);
            outputFileLabel.Size = new Size(560, 29);
            outputFileLabel.TabIndex = 3;
            outputFileLabel.Text = "[ output file path will be shown here ]";
            outputFileLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // hashDropDown
            // 
            hashDropDown.FormattingEnabled = true;
            hashDropDown.Items.AddRange(new object[] { "MD5", "RIPEMD160", "SHA1", "SHA512", "SHA384", "SHA256", "SHA3_384", "SHA3_512", "SHA3_256" });
            hashDropDown.Location = new Point(12, 194);
            hashDropDown.Name = "hashDropDown";
            hashDropDown.Size = new Size(210, 28);
            hashDropDown.TabIndex = 4;
            hashDropDown.Text = "SELECT HASH ALGORITHM";
            hashDropDown.SelectedIndexChanged += hashDropDown_SelectedIndexChanged;
            // 
            // hashButton
            // 
            hashButton.Location = new Point(265, 194);
            hashButton.Name = "hashButton";
            hashButton.Size = new Size(135, 29);
            hashButton.TabIndex = 5;
            hashButton.Text = "HASH";
            hashButton.UseVisualStyleBackColor = true;
            hashButton.Click += hashButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hashButton);
            Controls.Add(hashDropDown);
            Controls.Add(outputFileLabel);
            Controls.Add(outputFileButton);
            Controls.Add(inputPathLabel);
            Controls.Add(inputFileButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog;
        private Button inputFileButton;
        private Label inputPathLabel;
        private Button outputFileButton;
        private Label outputFileLabel;
        private ComboBox hashDropDown;
        private Button hashButton;
    }
}
