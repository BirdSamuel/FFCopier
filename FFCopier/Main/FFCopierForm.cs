using FFCopier.Data;
using FFCopier.Main;
using System.Diagnostics;
using System.Text.Json;

namespace FFCopier
{
    public partial class FFCopierForm : Form
    {
        private Character? selectedFromCharacter;
        private Character? selectedToCharacter;
        internal readonly List<Character> allCharacters = new();
        internal List<ConfigCheckBox> configCheckBoxes = new();

        public FFCopierForm()
        {
            LoadData();
            InitializeComponent();
            InitializeDropdowns();
            InitializeCheckboxes();
            SubmitButton.Enabled = false;
            DescriptionTextLabel.Text = String.Empty;
            FromFolderLabel.Text = String.Empty;
            ToFolderLabel.Text = String.Empty;
        }

        private void InitializeDropdowns()
        {
            FromDropdown.Items.Clear();
            ToDropdown.Items.Clear();
            allCharacters.Sort(delegate (Character c1, Character c2) { return c1.Name.CompareTo(c2.Name); });
            foreach (Character character in allCharacters)
            {
                if (character != null)
                {
                    FromDropdown.Items.Add(character.Name);
                    ToDropdown.Items.Add(character.Name);
                }
            }
            FromDropdown.Items.Add(CoreData.addNewCharacter);
            ToDropdown.Items.Add(CoreData.addNewCharacter);
            if (allCharacters.Count > 1)
            {
                ToDropdown.Items.Add(CoreData.allCharacters);
            }
            if (allCharacters.Count > 0)
            {
                FromDropdown.Items.Add(CoreData.removeCharacter);
                ToDropdown.Items.Add(CoreData.removeCharacter);
            }
        }

        private void InitializeCheckboxes()
        {
            configCheckBoxes = new()
            {
                UICheckBox,
                CharSettingsCheckBox,
                ControlsCheckBox,
                GearsetsCheckBox,
                HotBarCheckBox,
                TripleTriadCheckBox,
                InventoryCheckBox,
                KeybindCheckBox,
                ChatLogCheckBox,
                MacrosCheckBox,
                UICacheCheckBox,
                ACQCheckBox,
            };
        }

        private void LoadData()
        {
            // Read the JSON string from the file
            if (File.Exists(CoreData.characterFileName))
            {
                string jsonString = File.ReadAllText(CoreData.characterFileName);
                var characters = JsonSerializer.Deserialize<List<Character>>(jsonString);
                if (characters != null)
                {
                    foreach (Character character in characters)
                    {
                        allCharacters.Add(character);
                    }
                }
            }
        }

        private void SaveData()
        {
            // Serialize all characters to JSON
            string jsonString = JsonSerializer.Serialize(allCharacters);
            File.WriteAllText(CoreData.characterFileName, jsonString);
        }

        internal void AddCharacter(Character character, bool isFrom)
        {
            allCharacters.Add(character);
            SaveData();
            InitializeDropdowns();
            if (isFrom)
            {
                FromDropdown.SelectedItem = character.Name;
                FromFolderLabel.Text = character.GetFolderName();
            }
            else
            {
                ToDropdown.SelectedItem = character.Name;
                ToFolderLabel.Text = character.GetFolderName();
            }
            SubmitButton.Enabled = BothCharactersAreValid();
        }

        internal void RemoveCharacter(Character character)
        {
            if (FromDropdown.SelectedItem != null)
            {
                if (((string)FromDropdown.SelectedItem).Equals(character.Name))
                {
                    FromDropdown.SelectedItem = null;
                }
            }
            if (ToDropdown.SelectedItem != null)
            {
                if (((string)ToDropdown.SelectedItem).Equals(character.Name))
                {
                    ToDropdown.SelectedItem = null;
                }
            }
            allCharacters.Remove(character);
            SaveData();
            InitializeDropdowns();
        }

        internal bool CharacterNameExists(string characterName)
        {
            foreach (Character character in allCharacters)
            {
                if (characterName.Equals(character.Name))
                {
                    return true;
                }
            }
            return false;
        }

        internal void SetFromCharacter(Character character)
        {
            selectedFromCharacter = character;
            FromFolderLabel.Text = character.GetFolderName();
            FromFolderLabel.Text = selectedFromCharacter.GetFolderName();
        }

        internal void SetToCharacter(Character character)
        {
            selectedToCharacter = character;
            ToFolderLabel.Text = character.GetFolderName();
            ToFolderLabel.Text = selectedToCharacter.GetFolderName();
        }

        internal bool CharacterFolderExists(string folderName)
        {
            if (allCharacters.Count <= 0) return false;
            try
            {
                Character? character = allCharacters.Where((character, _) => character.GetFolderName().Equals(folderName)).First();
                if (character == null) return false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal Character? GetCharacterFromFolderName(string folderName)
        {
            if (allCharacters.Count <= 0) return null;
            return allCharacters.Where((character, _) => character.GetFolderName().Equals(folderName)).First();
        }

        internal Character? GetCharacterFromName(String name)
        {
            if (allCharacters.Count <= 0) return null;
            return allCharacters.Where((character, _) => character.Name.Equals(name)).First();
        }

        private void FromDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem != null)
            {
                string? selectedCharacterName = comboBox.SelectedItem.ToString();
                if (string.IsNullOrEmpty(selectedCharacterName)) return;
                if (!HandleDropdownSelection(comboBox, selectedCharacterName, true))
                {
                    return;
                }
                selectedFromCharacter = GetCharacterFromName(selectedCharacterName);
                if (selectedFromCharacter != null)
                {
                    FromFolderLabel.Text = selectedFromCharacter.GetFolderName();
                }
                SubmitButton.Enabled = BothCharactersAreValid();
            }
        }
        private void ToDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem != null)
            {
                string? selectedCharacterName = comboBox.SelectedItem.ToString();
                if (string.IsNullOrEmpty(selectedCharacterName)) return;
                if (!HandleDropdownSelection(comboBox, selectedCharacterName, false))
                {
                    return;
                }
                selectedToCharacter = GetCharacterFromName(selectedCharacterName);
                if (selectedToCharacter != null)
                {
                    ToFolderLabel.Text = selectedToCharacter.GetFolderName();
                }
                SubmitButton.Enabled = BothCharactersAreValid();
            }
        }
        private bool HandleDropdownSelection(ComboBox comboBox, string selectedCharacterName, bool isFrom)
        {
            if (selectedCharacterName.Equals(CoreData.addNewCharacter))
            {
                AddCharacterForm addCharacterForm = new(this, isFrom);
                comboBox.SelectedItem = null;
                if (isFrom)
                {
                    FromFolderLabel.Text = String.Empty;
                }
                else
                {
                    ToFolderLabel.Text = String.Empty;
                }
                SetCheckBoxesEnabled(false);
                _ = addCharacterForm.ShowDialog();
                return false;
            }
            else if (selectedCharacterName.Equals(CoreData.removeCharacter))
            {
                RemoveCharacterForm removeCharacterForm = new(this);
                comboBox.SelectedItem = null;
                if (isFrom)
                {
                    FromFolderLabel.Text = String.Empty;
                }
                else
                {
                    ToFolderLabel.Text = String.Empty;
                }
                SetCheckBoxesEnabled(false);
                _ = removeCharacterForm.ShowDialog();
                return false;
            }
            else if (selectedCharacterName.Equals(CoreData.allCharacters))
            {
                selectedToCharacter = null;
                if (isFrom)
                {
                    FromFolderLabel.Text = String.Empty;
                }
                else
                {
                    ToFolderLabel.Text = String.Empty;
                }
                SetCheckBoxesEnabled(true);
                return false;
            }
            SetCheckBoxesEnabled(true);
            return true;
        }

#pragma warning disable IDE0150 // Prefer 'null' check over type check
        private bool BothCharactersAreValid() => selectedFromCharacter is not null && selectedFromCharacter is Character
                && ((selectedToCharacter != null && selectedToCharacter is Character) || AllCharactersIsSelected());
#pragma warning restore IDE0150 // Prefer 'null' check over type check

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (BothCharactersAreValid() && selectedFromCharacter is not null && (selectedToCharacter is not null || AllCharactersIsSelected()))
            {
                if (selectedFromCharacter == selectedToCharacter)
                {
                    System.Windows.Forms.MessageBox.Show("Copying to and from the same character is very silly.");
                    return;
                }
                string copyingFieldsString = "";
                foreach (ConfigCheckBox configCheckBox in configCheckBoxes)
                {
                    if (configCheckBox.Checked)
                    {
                        copyingFieldsString += configCheckBox.Text + Environment.NewLine;
                    }
                }
                if (copyingFieldsString.Length <= 0)
                {
                    System.Windows.Forms.MessageBox.Show("No files are selected, nothing will be copied.");
                    return;
                }
                string toName;
                if (selectedToCharacter != null)
                {
                    toName = selectedToCharacter.Name + "\n";
                }
                else
                {
                    toName = string.Empty;
                    foreach(Character character in allCharacters)
                    {
                        if (character == selectedFromCharacter) continue;
                        toName += character.Name + Environment.NewLine;
                    }
                }
                var confirmResult = MessageBox.Show("The config will be copied from:\n\n"
                    + selectedFromCharacter.Name + "\nto\n" + toName + 
                    "\nAnd the following fields will be copied:\n" + copyingFieldsString,
                                         "Confirm Copy",
                                         MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    CopyConfig();
                }
            }
        }

        private bool AllCharactersIsSelected()
        {
            if (ToDropdown.SelectedItem == null) return false;
            var toDropdownCheck = ToDropdown.SelectedItem;
            if (toDropdownCheck != null)
            {
                var allCharactersCheck = toDropdownCheck.ToString();
                if (string.IsNullOrEmpty(allCharactersCheck)) return false;
                return allCharactersCheck.Equals(CoreData.allCharacters);
            }
            return false;
        }

        private void CopyConfig()
        {
            if (selectedFromCharacter is not null && (selectedToCharacter is not null || AllCharactersIsSelected()))
            {
                try
                {
                    string selectedFromPath = selectedFromCharacter.FolderPath;
                    if (AllCharactersIsSelected())
                    {
                        foreach (Character character in allCharacters)
                        {
                            if (character == selectedFromCharacter) continue;
                            CopyFiles(selectedFromPath, character.FolderPath, selectedFromCharacter.Name, character.Name);
                        }
                    }
                    else if (selectedToCharacter != null)
                    {
                        CopyFiles(selectedFromPath, selectedToCharacter.FolderPath, selectedFromCharacter.Name, selectedToCharacter.Name);
                    }
                }
                catch (Exception ex)
                {
                    PrintDebugLog("Error:" + ex.ToString());
                }
            }
        }

        private void CopyFiles(string fromPath, string toPath, string fromCharName, string toCharName)
        {
            foreach (ConfigCheckBox configCheckBox in configCheckBoxes)
            {
                if (configCheckBox.Checked)
                {
                    foreach (string fileName in configCheckBox.FileNames)
                    {
                        PrintDebugLog("Copying " + configCheckBox.DisplayName +
                        "(" + fileName + ")"
                        + " from " + fromCharName
                        + " to " + toCharName + ".... ", hasNewLine: false);

                        string fromFile = fromPath + "\\" + fileName;
                        string toFile = toPath + "\\" + fileName;
                        try
                        {
                            File.Copy(fromFile, toFile, true);
                            PrintDebugLog("Success!");
                        }
                        catch (IOException e)
                        {
                            try
                            {
                                // Super crazy hack in case things go wrong
                                if (e.Message.Contains("process cannot access the file"))
                                {
                                    var process = new System.Diagnostics.Process();
                                    process.StartInfo.UseShellExecute = false;
                                    process.StartInfo.RedirectStandardOutput = true;
                                    process.StartInfo.FileName = "cmd.exe";
                                    process.StartInfo.Arguments = "/C copy \"" + fromFile + "\" \"" + toFile + "\"";
                                    process.Start();
                                    PrintDebugLog(process.StandardOutput.ReadToEnd());
                                    process.WaitForExit();
                                    process.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                PrintDebugLog("Error:" + ex.ToString());
                            }
                        }
                    }
                }
            }
        }

        private void ArrowPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new(Brushes.Black, 12)
            {
                StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
            };
            graphics.DrawLine(pen, 60, 40, 10, 40);
        }

        private void ConfigCheckbox_MouseEnter(object sender, System.EventArgs e)
        {
            if (sender is ConfigCheckBox config)
            {
                DescriptionTextLabel.Text = config.Description + " \nFile: ";
                List<string> allFiles = config.FileNames.ToList();
                if (allFiles.Count == 1)
                {
                    DescriptionTextLabel.Text += config.FileNames.First();
                }
                else
                {
                    for (int i = 0; i < allFiles.Count; i++)
                    {
                        DescriptionTextLabel.Text += allFiles[i];
                        if (i < allFiles.Count - 1)
                        {
                            DescriptionTextLabel.Text += ", ";
                        }
                    }
                }
            }
        }

        private void ConfigCheckbox_MouseLeave(object sender, System.EventArgs e)
        {
            if (sender is ConfigCheckBox)
            {
                DescriptionTextLabel.Text = "";
            }
        }

        public void PrintDebugLog(String text, bool hasNewLine = true)
        {
            string newText = text;
            if (hasNewLine)
            {
                newText += Environment.NewLine;
            }
            DebugTextBox.AppendText(newText);
            ClearButton.Enabled = DebugTextBox.Text.Length > 0;
        }

        private void UnselectAllButton_Click(object sender, EventArgs e)
        {
            SetCheckBoxesChecked(false);
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            SetCheckBoxesChecked(true);
        }

        private void SetCheckBoxesChecked(bool isChecked)
        {
            foreach (ConfigCheckBox checkBox in configCheckBoxes)
            {
                checkBox.Checked = isChecked;
            }
        }

        private void SetCheckBoxesEnabled(bool isEnabled)
        {
            SelectAllButton.Enabled = isEnabled;
            UnselectAllButton.Enabled = isEnabled;
            //
            foreach (ConfigCheckBox checkBox in configCheckBoxes)
            {
                checkBox.Enabled = isEnabled;
            }
            //
            SubmitButton.Enabled = isEnabled;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DebugTextBox.Text = string.Empty;
            ClearButton.Enabled = false;
        }
    }
}