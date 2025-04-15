using FFCopier.Data;

namespace FFCopier.Main
{
    public partial class RemoveCharacterForm : Form
    {
        private readonly FFCopierForm ffCopierForm;
        private Character? selectedCharacter;

        public RemoveCharacterForm(FFCopierForm ffCopierForm)
        {
            this.ffCopierForm = ffCopierForm;
            InitializeComponent();
            List<Character> allCharacters = ffCopierForm.allCharacters;
            if (allCharacters.Count > 0)
            {
                foreach (Character character in allCharacters)
                {
                    if (character != null)
                    {
                        RemoveCharacterComboBox.Items.Add(character.Name);
                    }
                }
            }
            CharFolderLabel.Text = string.Empty;
        }

        private void RemoveCharacterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem != null)
            {
                string? selectedCharacterName = comboBox.SelectedItem.ToString();
                if (string.IsNullOrEmpty(selectedCharacterName)) return;
                selectedCharacter = ffCopierForm.GetCharacterFromName(selectedCharacterName);
                if (selectedCharacter != null)
                {
                    CharFolderDescLabel.Enabled = true;
                    CharFolderLabel.Text = selectedCharacter.GetFolderName();
                    RemoveCharacterButton.Enabled = true;
                }
            }
        }

        private void RemoveCharacterButton_Click(object sender, EventArgs e)
        {
            if (selectedCharacter != null)
            {
                var confirmResult = MessageBox.Show("This will remove the character:" + "\n" +
                   selectedCharacter.Name + "\n\n" +
                   "Is this correct?",
                                        "Confirm Remove Character",
                                        MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    ffCopierForm.PrintDebugLog("Removed " + selectedCharacter.Name);
                    ffCopierForm.RemoveCharacter(selectedCharacter);
                    Close();
                }
            }
        }
    }
}
