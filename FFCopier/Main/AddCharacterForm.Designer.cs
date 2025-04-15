namespace FFCopier.Main
{
    partial class AddCharacterForm
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
            CharFilePathTextBox = new TextBox();
            BrowseButton = new Button();
            AddCharacterButton = new Button();
            CharFolderDescLabel = new Label();
            CharFolderLabel = new Label();
            CharNameTextBox = new TextBox();
            CharNameDescLabel = new Label();
            LocateCharacterLabel = new Label();
            SuspendLayout();
            // 
            // CharFilePathTextBox
            // 
            CharFilePathTextBox.Location = new Point(12, 36);
            CharFilePathTextBox.Name = "CharFilePathTextBox";
            CharFilePathTextBox.Size = new Size(440, 23);
            CharFilePathTextBox.TabIndex = 0;
            // 
            // BrowseButton
            // 
            BrowseButton.Location = new Point(458, 35);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(84, 24);
            BrowseButton.TabIndex = 1;
            BrowseButton.Text = "Browse...";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // AddCharacterButton
            // 
            AddCharacterButton.Enabled = false;
            AddCharacterButton.Location = new Point(435, 114);
            AddCharacterButton.Name = "AddCharacterButton";
            AddCharacterButton.Size = new Size(107, 27);
            AddCharacterButton.TabIndex = 2;
            AddCharacterButton.Text = "Add Character";
            AddCharacterButton.UseVisualStyleBackColor = true;
            AddCharacterButton.Click += AddCharacterButton_Click;
            // 
            // CharFolderDescLabel
            // 
            CharFolderDescLabel.AutoSize = true;
            CharFolderDescLabel.Enabled = false;
            CharFolderDescLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CharFolderDescLabel.Location = new Point(12, 67);
            CharFolderDescLabel.Name = "CharFolderDescLabel";
            CharFolderDescLabel.Size = new Size(108, 17);
            CharFolderDescLabel.TabIndex = 3;
            CharFolderDescLabel.Text = "Character Folder:";
            // 
            // CharFolderLabel
            // 
            CharFolderLabel.AutoSize = true;
            CharFolderLabel.Location = new Point(119, 69);
            CharFolderLabel.Name = "CharFolderLabel";
            CharFolderLabel.Size = new Size(91, 15);
            CharFolderLabel.TabIndex = 4;
            CharFolderLabel.Text = "CharacterFolder";
            // 
            // CharNameTextBox
            // 
            CharNameTextBox.Enabled = false;
            CharNameTextBox.Location = new Point(12, 114);
            CharNameTextBox.Name = "CharNameTextBox";
            CharNameTextBox.Size = new Size(318, 23);
            CharNameTextBox.TabIndex = 5;
            // 
            // CharNameDescLabel
            // 
            CharNameDescLabel.AutoSize = true;
            CharNameDescLabel.Enabled = false;
            CharNameDescLabel.Location = new Point(12, 96);
            CharNameDescLabel.Name = "CharNameDescLabel";
            CharNameDescLabel.Size = new Size(93, 15);
            CharNameDescLabel.TabIndex = 6;
            CharNameDescLabel.Text = "Character Name";
            // 
            // LocateCharacterLabel
            // 
            LocateCharacterLabel.AutoSize = true;
            LocateCharacterLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LocateCharacterLabel.Location = new Point(12, 9);
            LocateCharacterLabel.Name = "LocateCharacterLabel";
            LocateCharacterLabel.Size = new Size(396, 17);
            LocateCharacterLabel.TabIndex = 7;
            LocateCharacterLabel.Text = "Please locate character folder (i.e. FFXIV_CHR004000174BXXXXXX) ";
            // 
            // AddCharacterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 149);
            Controls.Add(LocateCharacterLabel);
            Controls.Add(CharNameDescLabel);
            Controls.Add(CharNameTextBox);
            Controls.Add(CharFolderLabel);
            Controls.Add(CharFolderDescLabel);
            Controls.Add(AddCharacterButton);
            Controls.Add(BrowseButton);
            Controls.Add(CharFilePathTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddCharacterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Character";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CharFilePathTextBox;
        private Button BrowseButton;
        private Button AddCharacterButton;
        private Label CharFolderDescLabel;
        private Label CharFolderLabel;
        private TextBox CharNameTextBox;
        private Label CharNameDescLabel;
        private Label LocateCharacterLabel;
    }
}