using FFCopier.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFCopier.Main
{
    public partial class AddCharacterForm : Form
    {
        private readonly FFCopierForm ffCopierForm;
        private readonly bool isFrom;

        public AddCharacterForm(FFCopierForm ffCopierForm, bool isFrom)
        {
            this.ffCopierForm = ffCopierForm;
            this.isFrom = isFrom;
            InitializeComponent();
            CharFolderLabel.Text = string.Empty;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new()
            {
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };
            string ffxivPath = folderBrowserDialog.SelectedPath + "\\My Games\\FINAL FANTASY XIV - A Realm Reborn\\";
            if (Directory.Exists(ffxivPath))
            {
                folderBrowserDialog.SelectedPath = ffxivPath;
            }
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                try
                {
                    string[] filePaths = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*" + ".DAT",
                        SearchOption.TopDirectoryOnly);
                    string[] files = new string[filePaths.Length];
                    for (int i = 0; i < filePaths.Length; i++)
                    {
                        files[i] = Path.GetFileName(filePaths[i]);
                    }
                    if (HasErrors(files))
                    {
                        return;
                    }
                    // Success!
                    CharFilePathTextBox.Text = folderBrowserDialog.SelectedPath;
                    CharFolderLabel.Text = folderBrowserDialog.SelectedPath.Split('\\').Last();
                    CharFolderDescLabel.Enabled = true;
                    CharNameDescLabel.Enabled = true;
                    CharNameTextBox.Enabled = true;
                    AddCharacterButton.Enabled = true;
                }
                catch (Exception exception)
                {
                    System.Windows.Forms.MessageBox.Show("An unknown error occurred. Please try again.\n\nException: " + exception.ToString());
                }
            }
        }

        private static bool HasErrors(string[] files)
        {
            List<string> requiredFiles = CoreData.requiredFiles;
            string missingFiles = string.Empty;
            int checkSuccessLength = CoreData.requiredFiles.Count;
            foreach (string filePath in requiredFiles)
            {
                string file = Path.GetFileName(filePath);
                if (files.Contains(file))
                {
                    checkSuccessLength--;
                    continue;
                }
                else
                {
                    missingFiles += file + "\n";
                }
            }
            if (checkSuccessLength > 0)
            {
                string errorString = "Error, please make sure all .DAT files exist!\n\n" +
                    "If this is a continuing issue, just log in with your character and they should be created.\n\n" +
                    "Files missing:\n" + missingFiles;
                System.Windows.Forms.MessageBox.Show(errorString);
                return true;
            }

            return false;
        }

        private void AddCharacterButton_Click(object sender, EventArgs e)
        {
            if (CharNameTextBox.Text.Length > 0)
            {
                if (ffCopierForm.CharacterNameExists(CharNameTextBox.Text))
                {
                    System.Windows.Forms.MessageBox.Show("Name already exists.\nPlease choose another.");
                    return;
                }
                if (ffCopierForm.CharacterFolderExists(CharFolderLabel.Text))
                {
                    Character? character = ffCopierForm.GetCharacterFromFolderName(CharFolderLabel.Text);
                    if (character != null)
                    {
                        System.Windows.Forms.MessageBox.Show("Character folder is already associated with "
                            + character.Name + ".\nPlease choose another.");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Character folder is already associated. " +
                            "\nPlease choose another.");
                    }
                    return;
                }
                var confirmResult = MessageBox.Show("This will assign the folder:" + "\n" +
                    CharFolderLabel.Text + "\n\n" +
                    "To the following character:\n" + CharNameTextBox.Text + "\n\n" +
                    "Is this correct?",
                                         "Confirm Add Character",
                                         MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    ffCopierForm.AddCharacter(new Character(CharNameTextBox.Text, CharFilePathTextBox.Text), isFrom);
                    ffCopierForm.PrintDebugLog("Successfully added " + CharFolderLabel.Text + " as " + CharNameTextBox.Text + "!");
                    Close();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please enter a name!");
            }
        }
    }
}
