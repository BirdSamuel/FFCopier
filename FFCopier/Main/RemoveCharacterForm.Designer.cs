namespace FFCopier.Main
{
    partial class RemoveCharacterForm
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
            RemoveCharacterComboBox = new ComboBox();
            RemoveCharacterLabel = new Label();
            CharFolderLabel = new Label();
            CharFolderDescLabel = new Label();
            RemoveCharacterButton = new Button();
            SuspendLayout();
            // 
            // RemoveCharacterComboBox
            // 
            RemoveCharacterComboBox.FormattingEnabled = true;
            RemoveCharacterComboBox.Location = new Point(12, 31);
            RemoveCharacterComboBox.Name = "RemoveCharacterComboBox";
            RemoveCharacterComboBox.Size = new Size(293, 23);
            RemoveCharacterComboBox.TabIndex = 0;
            RemoveCharacterComboBox.SelectedIndexChanged += RemoveCharacterComboBox_SelectedIndexChanged;
            // 
            // RemoveCharacterLabel
            // 
            RemoveCharacterLabel.AutoSize = true;
            RemoveCharacterLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveCharacterLabel.Location = new Point(10, 9);
            RemoveCharacterLabel.Name = "RemoveCharacterLabel";
            RemoveCharacterLabel.Size = new Size(207, 17);
            RemoveCharacterLabel.TabIndex = 1;
            RemoveCharacterLabel.Text = "Please select character to remove:";
            // 
            // CharFolderLabel
            // 
            CharFolderLabel.AutoSize = true;
            CharFolderLabel.Location = new Point(119, 59);
            CharFolderLabel.Name = "CharFolderLabel";
            CharFolderLabel.Size = new Size(91, 15);
            CharFolderLabel.TabIndex = 6;
            CharFolderLabel.Text = "CharacterFolder";
            // 
            // CharFolderDescLabel
            // 
            CharFolderDescLabel.AutoSize = true;
            CharFolderDescLabel.Enabled = false;
            CharFolderDescLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CharFolderDescLabel.Location = new Point(12, 57);
            CharFolderDescLabel.Name = "CharFolderDescLabel";
            CharFolderDescLabel.Size = new Size(108, 17);
            CharFolderDescLabel.TabIndex = 5;
            CharFolderDescLabel.Text = "Character Folder:";
            // 
            // RemoveCharacterButton
            // 
            RemoveCharacterButton.Enabled = false;
            RemoveCharacterButton.Location = new Point(221, 79);
            RemoveCharacterButton.Name = "RemoveCharacterButton";
            RemoveCharacterButton.Size = new Size(96, 29);
            RemoveCharacterButton.TabIndex = 7;
            RemoveCharacterButton.Text = "Remove";
            RemoveCharacterButton.UseVisualStyleBackColor = true;
            RemoveCharacterButton.Click += RemoveCharacterButton_Click;
            // 
            // RemoveCharacterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 113);
            Controls.Add(RemoveCharacterButton);
            Controls.Add(CharFolderLabel);
            Controls.Add(CharFolderDescLabel);
            Controls.Add(RemoveCharacterLabel);
            Controls.Add(RemoveCharacterComboBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RemoveCharacterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Remove Character";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox RemoveCharacterComboBox;
        private Label RemoveCharacterLabel;
        private Label CharFolderLabel;
        private Label CharFolderDescLabel;
        private Button RemoveCharacterButton;
    }
}