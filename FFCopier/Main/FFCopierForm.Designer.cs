using FFCopier.Data;

namespace FFCopier
{
    partial class FFCopierForm
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
            FromPanel = new Panel();
            FromFolderLabel = new Label();
            FromDropdown = new ComboBox();
            FromLabel = new Label();
            TitleLabel = new Label();
            ToPanel = new Panel();
            ToFolderLabel = new Label();
            ToDropdown = new ComboBox();
            ToLabel = new Label();
            ArrowPanel = new Panel();
            CopyPanel = new Panel();
            ACQCheckBox = new ConfigCheckBox();
            UICacheCheckBox = new ConfigCheckBox();
            MacrosCheckBox = new ConfigCheckBox();
            ChatLogCheckBox = new ConfigCheckBox();
            KeybindCheckBox = new ConfigCheckBox();
            InventoryCheckBox = new ConfigCheckBox();
            HotBarCheckBox = new ConfigCheckBox();
            TripleTriadCheckBox = new ConfigCheckBox();
            GearsetsCheckBox = new ConfigCheckBox();
            ControlsCheckBox = new ConfigCheckBox();
            CharSettingsCheckBox = new ConfigCheckBox();
            UICheckBox = new ConfigCheckBox();
            SelectAllButton = new Button();
            UnselectAllButton = new Button();
            CopyPanelLabel = new Label();
            DescriptionPanel = new Panel();
            DescriptionTextLabel = new Label();
            SubmitButton = new Button();
            DebugTextBox = new TextBox();
            ClearButton = new Button();
            FromPanel.SuspendLayout();
            ToPanel.SuspendLayout();
            CopyPanel.SuspendLayout();
            DescriptionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FromPanel
            // 
            FromPanel.BorderStyle = BorderStyle.FixedSingle;
            FromPanel.Controls.Add(FromFolderLabel);
            FromPanel.Controls.Add(FromDropdown);
            FromPanel.Controls.Add(FromLabel);
            FromPanel.Location = new Point(12, 59);
            FromPanel.Name = "FromPanel";
            FromPanel.Size = new Size(257, 76);
            FromPanel.TabIndex = 0;
            // 
            // FromFolderLabel
            // 
            FromFolderLabel.AutoSize = true;
            FromFolderLabel.Location = new Point(8, 51);
            FromFolderLabel.Name = "FromFolderLabel";
            FromFolderLabel.Size = new Size(94, 15);
            FromFolderLabel.TabIndex = 2;
            FromFolderLabel.Text = "fromFolderLabel";
            // 
            // FromDropdown
            // 
            FromDropdown.FormattingEnabled = true;
            FromDropdown.Location = new Point(9, 24);
            FromDropdown.Name = "FromDropdown";
            FromDropdown.Size = new Size(229, 23);
            FromDropdown.TabIndex = 1;
            FromDropdown.SelectedIndexChanged += FromDropdown_SelectedIndexChanged;
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(6, 5);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(176, 15);
            FromLabel.TabIndex = 0;
            FromLabel.Text = "Character Config to copy FROM";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.Location = new Point(115, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(344, 32);
            TitleLabel.TabIndex = 2;
            TitleLabel.Text = "FFXIV Character Config Copier";
            // 
            // ToPanel
            // 
            ToPanel.BorderStyle = BorderStyle.FixedSingle;
            ToPanel.Controls.Add(ToFolderLabel);
            ToPanel.Controls.Add(ToDropdown);
            ToPanel.Controls.Add(ToLabel);
            ToPanel.Location = new Point(352, 59);
            ToPanel.Name = "ToPanel";
            ToPanel.Size = new Size(257, 76);
            ToPanel.TabIndex = 4;
            // 
            // ToFolderLabel
            // 
            ToFolderLabel.AutoSize = true;
            ToFolderLabel.Location = new Point(8, 51);
            ToFolderLabel.Name = "ToFolderLabel";
            ToFolderLabel.Size = new Size(79, 15);
            ToFolderLabel.TabIndex = 3;
            ToFolderLabel.Text = "toFolderLabel";
            // 
            // ToDropdown
            // 
            ToDropdown.FormattingEnabled = true;
            ToDropdown.Location = new Point(9, 24);
            ToDropdown.Name = "ToDropdown";
            ToDropdown.Size = new Size(229, 23);
            ToDropdown.TabIndex = 2;
            ToDropdown.SelectedIndexChanged += ToDropdown_SelectedIndexChanged;
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Location = new Point(6, 5);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(158, 15);
            ToLabel.TabIndex = 0;
            ToLabel.Text = "Character Config to copy TO";
            // 
            // ArrowPanel
            // 
            ArrowPanel.Location = new Point(275, 59);
            ArrowPanel.Name = "ArrowPanel";
            ArrowPanel.Size = new Size(71, 76);
            ArrowPanel.TabIndex = 5;
            ArrowPanel.Paint += ArrowPanel_Paint;
            // 
            // CopyPanel
            // 
            CopyPanel.BackColor = SystemColors.ControlLight;
            CopyPanel.BorderStyle = BorderStyle.FixedSingle;
            CopyPanel.Controls.Add(ACQCheckBox);
            CopyPanel.Controls.Add(UICacheCheckBox);
            CopyPanel.Controls.Add(MacrosCheckBox);
            CopyPanel.Controls.Add(ChatLogCheckBox);
            CopyPanel.Controls.Add(KeybindCheckBox);
            CopyPanel.Controls.Add(InventoryCheckBox);
            CopyPanel.Controls.Add(HotBarCheckBox);
            CopyPanel.Controls.Add(TripleTriadCheckBox);
            CopyPanel.Controls.Add(GearsetsCheckBox);
            CopyPanel.Controls.Add(ControlsCheckBox);
            CopyPanel.Controls.Add(CharSettingsCheckBox);
            CopyPanel.Controls.Add(UICheckBox);
            CopyPanel.Controls.Add(SelectAllButton);
            CopyPanel.Controls.Add(UnselectAllButton);
            CopyPanel.Controls.Add(CopyPanelLabel);
            CopyPanel.Controls.Add(DescriptionPanel);
            CopyPanel.Location = new Point(11, 141);
            CopyPanel.Name = "CopyPanel";
            CopyPanel.Size = new Size(598, 251);
            CopyPanel.TabIndex = 6;
            // 
            // ACQCheckBox
            // 
            ACQCheckBox.AutoSize = true;
            ACQCheckBox.Description = "List of recent players in /tell conversations.";
            ACQCheckBox.DisplayName = "Recent /tell conversations";
            ACQCheckBox.Enabled = false;
            ACQCheckBox.FileNames = new string[] { "ACQ.DAT" };
            ACQCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ACQCheckBox.Location = new Point(263, 170);
            ACQCheckBox.Name = "ACQCheckBox";
            ACQCheckBox.Size = new Size(176, 21);
            ACQCheckBox.TabIndex = 22;
            ACQCheckBox.Text = "Recent /tell conversations";
            ACQCheckBox.UseVisualStyleBackColor = true;
            ACQCheckBox.MouseEnter += ConfigCheckbox_MouseEnter;
            ACQCheckBox.MouseLeave += ConfigCheckbox_MouseLeave;
            // 
            // UICacheCheckBox
            // 
            UICacheCheckBox.AutoSize = true;
            UICacheCheckBox.Description = "All UI Cache, including things like retainer venture timers.";
            UICacheCheckBox.DisplayName = "Cached UI Content";
            UICacheCheckBox.Enabled = false;
            UICacheCheckBox.FileNames = new string[] { "UISAVE.DAT" };
            UICacheCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UICacheCheckBox.Location = new Point(263, 143);
            UICacheCheckBox.Name = "UICacheCheckBox";
            UICacheCheckBox.Size = new Size(135, 21);
            UICacheCheckBox.TabIndex = 21;
            UICacheCheckBox.Text = "Cached UI Content";
            UICacheCheckBox.UseVisualStyleBackColor = true;
            UICacheCheckBox.MouseEnter += ConfigCheckbox_MouseEnter;
            UICacheCheckBox.MouseLeave += ConfigCheckbox_MouseLeave;
            // 
            // MacrosCheckBox
            // 
            MacrosCheckBox.AutoSize = true;
            MacrosCheckBox.Description = "All custom macro configurations.";
            MacrosCheckBox.DisplayName = "Macros";
            MacrosCheckBox.Enabled = false;
            MacrosCheckBox.FileNames = new string[] { "MACRO.DAT" };
            MacrosCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            MacrosCheckBox.Location = new Point(263, 116);
            MacrosCheckBox.Name = "MacrosCheckBox";
            MacrosCheckBox.Size = new Size(71, 21);
            MacrosCheckBox.TabIndex = 20;
            MacrosCheckBox.Text = "Macros";
            MacrosCheckBox.UseVisualStyleBackColor = true;
            MacrosCheckBox.MouseEnter += ConfigCheckbox_MouseEnter;
            MacrosCheckBox.MouseLeave += ConfigCheckbox_MouseLeave;
            // 
            // ChatLogCheckBox
            // 
            ChatLogCheckBox.AutoSize = true;
            ChatLogCheckBox.Description = "Chat log filter settings.";
            ChatLogCheckBox.DisplayName = "Chat Log";
            ChatLogCheckBox.Enabled = false;
            ChatLogCheckBox.FileNames = new string[] { "LOGFLTR.DAT" };
            ChatLogCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ChatLogCheckBox.Location = new Point(263, 89);
            ChatLogCheckBox.Name = "ChatLogCheckBox";
            ChatLogCheckBox.Size = new Size(79, 21);
            ChatLogCheckBox.TabIndex = 19;
            ChatLogCheckBox.Text = "Chat Log";
            ChatLogCheckBox.UseVisualStyleBackColor = true;
            ChatLogCheckBox.MouseEnter += ConfigCheckbox_MouseEnter;
            ChatLogCheckBox.MouseLeave += ConfigCheckbox_MouseLeave;
            // 
            // KeybindCheckBox
            // 
            KeybindCheckBox.AutoSize = true;
            KeybindCheckBox.Description = "All keybinds configuration.";
            KeybindCheckBox.DisplayName = "Keybinds";
            KeybindCheckBox.Enabled = false;
            KeybindCheckBox.FileNames = new string[] { "KEYBIND.DAT" };
            KeybindCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            KeybindCheckBox.Location = new Point(263, 62);
            KeybindCheckBox.Name = "KeybindCheckBox";
            KeybindCheckBox.Size = new Size(80, 21);
            KeybindCheckBox.TabIndex = 18;
            KeybindCheckBox.Text = "Keybinds";
            KeybindCheckBox.UseVisualStyleBackColor = true;
            KeybindCheckBox.MouseEnter += ConfigCheckbox_MouseEnter;
            KeybindCheckBox.MouseLeave += ConfigCheckbox_MouseLeave;
            // 
            // InventoryCheckBox
            // 
            InventoryCheckBox.AutoSize = true;
            InventoryCheckBox.Description = "Inventory and retainers item sort order/positions. Includes /isearch indexes?";
            InventoryCheckBox.DisplayName = "Inventory Item Positions";
            InventoryCheckBox.Enabled = false;
            InventoryCheckBox.FileNames = new string[] { "ITEMFDR.DAT", "ITEMODR.DAT" };
            InventoryCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            InventoryCheckBox.Location = new Point(263, 35);
            InventoryCheckBox.Name = "InventoryCheckBox";
            InventoryCheckBox.Size = new Size(165, 21);
            InventoryCheckBox.TabIndex = 17;
            InventoryCheckBox.Text = "Inventory Item Positions";
            InventoryCheckBox.UseVisualStyleBackColor = true;
            InventoryCheckBox.MouseEnter += ConfigCheckbox_MouseEnter;
            InventoryCheckBox.MouseLeave += ConfigCheckbox_MouseLeave;
            // 
            // HotBarCheckBox
            // 
            HotBarCheckBox.AutoSize = true;
            HotBarCheckBox.Description = "All hotbar configurations.";
            HotBarCheckBox.DisplayName = "Hotbars";
            HotBarCheckBox.Enabled = false;
            HotBarCheckBox.FileNames = new string[] { "HOTBAR.DAT" };
            HotBarCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            HotBarCheckBox.Location = new Point(6, 143);
            HotBarCheckBox.Name = "HotBarCheckBox";
            HotBarCheckBox.Size = new Size(74, 21);
            HotBarCheckBox.TabIndex = 16;
            HotBarCheckBox.Text = "Hotbars";
            HotBarCheckBox.UseVisualStyleBackColor = true;
            HotBarCheckBox.MouseEnter += ConfigCheckbox_MouseEnter;
            HotBarCheckBox.MouseLeave += ConfigCheckbox_MouseLeave;
            // 
            // TripleTriadCheckBox
            // 
            TripleTriadCheckBox.AutoSize = true;
            TripleTriadCheckBox.Description = "I.. actually don't know why they have this.";
            TripleTriadCheckBox.DisplayName = "Triple Triad Decks";
            TripleTriadCheckBox.Enabled = false;
            TripleTriadCheckBox.FileNames = new string[] { "GS.DAT" };
            TripleTriadCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TripleTriadCheckBox.Location = new Point(6, 170);
            TripleTriadCheckBox.Name = "TripleTriadCheckBox";
            TripleTriadCheckBox.Size = new Size(130, 21);
            TripleTriadCheckBox.TabIndex = 15;
            TripleTriadCheckBox.Text = "Triple Triad Decks";
            TripleTriadCheckBox.UseVisualStyleBackColor = true;
            TripleTriadCheckBox.MouseEnter += ConfigCheckbox_MouseEnter;
            TripleTriadCheckBox.MouseLeave += ConfigCheckbox_MouseLeave;
            // 
            // GearsetsCheckBox
            // 
            GearsetsCheckBox.AutoSize = true;
            GearsetsCheckBox.Description = "All gearset configurations.";
            GearsetsCheckBox.DisplayName = "Gearsets";
            GearsetsCheckBox.Enabled = false;
            GearsetsCheckBox.FileNames = new string[] { "GEARSET.DAT" };
            GearsetsCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            GearsetsCheckBox.Location = new Point(6, 116);
            GearsetsCheckBox.Name = "GearsetsCheckBox";
            GearsetsCheckBox.Size = new Size(78, 21);
            GearsetsCheckBox.TabIndex = 14;
            GearsetsCheckBox.Text = "Gearsets";
            GearsetsCheckBox.UseVisualStyleBackColor = true;
            GearsetsCheckBox.MouseEnter += ConfigCheckbox_MouseEnter;
            GearsetsCheckBox.MouseLeave += ConfigCheckbox_MouseLeave;
            // 
            // ControlsCheckBox
            // 
            ControlsCheckBox.AutoSize = true;
            ControlsCheckBox.Description = "Keyboard/Mouse + Gamepad settings.";
            ControlsCheckBox.DisplayName = "Controls (Keyboard/Controller)";
            ControlsCheckBox.Enabled = false;
            ControlsCheckBox.FileNames = new string[] { "CONTROL0.DAT", "CONTROL1.DAT" };
            ControlsCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ControlsCheckBox.Location = new Point(6, 89);
            ControlsCheckBox.Name = "ControlsCheckBox";
            ControlsCheckBox.Size = new Size(208, 21);
            ControlsCheckBox.TabIndex = 13;
            ControlsCheckBox.Text = "Controls (Keyboard/Controller)";
            ControlsCheckBox.UseVisualStyleBackColor = true;
            ControlsCheckBox.MouseEnter += ConfigCheckbox_MouseEnter;
            ControlsCheckBox.MouseLeave += ConfigCheckbox_MouseLeave;
            // 
            // CharSettingsCheckBox
            // 
            CharSettingsCheckBox.AutoSize = true;
            CharSettingsCheckBox.Description = "All settings in the \"Character Settings\" window.";
            CharSettingsCheckBox.DisplayName = "Character Settings";
            CharSettingsCheckBox.Enabled = false;
            CharSettingsCheckBox.FileNames = new string[] { "COMMON.DAT" };
            CharSettingsCheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CharSettingsCheckBox.Location = new Point(6, 62);
            CharSettingsCheckBox.Name = "CharSettingsCheckBox";
            CharSettingsCheckBox.Size = new Size(133, 21);
            CharSettingsCheckBox.TabIndex = 12;
            CharSettingsCheckBox.Text = "Character Settings";
            CharSettingsCheckBox.UseVisualStyleBackColor = true;
            CharSettingsCheckBox.MouseEnter += ConfigCheckbox_MouseEnter;
            CharSettingsCheckBox.MouseLeave += ConfigCheckbox_MouseLeave;
            // 
            // UICheckBox
            // 
            UICheckBox.AutoSize = true;
            UICheckBox.Description = "UI Settings such as HUD and window layouts.";
            UICheckBox.DisplayName = "User Interface";
            UICheckBox.Enabled = false;
            UICheckBox.FileNames = new string[] { "ADDON.DAT" };
            UICheckBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UICheckBox.Location = new Point(7, 35);
            UICheckBox.Name = "UICheckBox";
            UICheckBox.Size = new Size(108, 21);
            UICheckBox.TabIndex = 11;
            UICheckBox.Text = "User Interface";
            UICheckBox.UseVisualStyleBackColor = true;
            UICheckBox.MouseEnter += ConfigCheckbox_MouseEnter;
            UICheckBox.MouseLeave += ConfigCheckbox_MouseLeave;
            // 
            // SelectAllButton
            // 
            SelectAllButton.Enabled = false;
            SelectAllButton.Location = new Point(490, 3);
            SelectAllButton.Name = "SelectAllButton";
            SelectAllButton.Size = new Size(89, 23);
            SelectAllButton.TabIndex = 4;
            SelectAllButton.Text = "Select All";
            SelectAllButton.UseVisualStyleBackColor = true;
            SelectAllButton.Click += SelectAllButton_Click;
            // 
            // UnselectAllButton
            // 
            UnselectAllButton.Enabled = false;
            UnselectAllButton.Location = new Point(395, 3);
            UnselectAllButton.Name = "UnselectAllButton";
            UnselectAllButton.Size = new Size(89, 23);
            UnselectAllButton.TabIndex = 3;
            UnselectAllButton.Text = "Unselect All";
            UnselectAllButton.UseVisualStyleBackColor = true;
            UnselectAllButton.Click += UnselectAllButton_Click;
            // 
            // CopyPanelLabel
            // 
            CopyPanelLabel.AutoSize = true;
            CopyPanelLabel.Location = new Point(6, 6);
            CopyPanelLabel.Name = "CopyPanelLabel";
            CopyPanelLabel.Size = new Size(288, 15);
            CopyPanelLabel.TabIndex = 10;
            CopyPanelLabel.Text = "Please select any options that you would like to copy:";
            // 
            // DescriptionPanel
            // 
            DescriptionPanel.BackColor = SystemColors.ScrollBar;
            DescriptionPanel.BorderStyle = BorderStyle.FixedSingle;
            DescriptionPanel.Controls.Add(DescriptionTextLabel);
            DescriptionPanel.Location = new Point(3, 206);
            DescriptionPanel.Name = "DescriptionPanel";
            DescriptionPanel.Size = new Size(590, 40);
            DescriptionPanel.TabIndex = 1;
            // 
            // DescriptionTextLabel
            // 
            DescriptionTextLabel.AutoSize = true;
            DescriptionTextLabel.Enabled = false;
            DescriptionTextLabel.Location = new Point(3, 3);
            DescriptionTextLabel.Name = "DescriptionTextLabel";
            DescriptionTextLabel.Size = new Size(459, 15);
            DescriptionTextLabel.TabIndex = 0;
            DescriptionTextLabel.Text = "This is a test description of what the user is going to see when they hover a check box.";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(503, 504);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(106, 32);
            SubmitButton.TabIndex = 18;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // DebugTextBox
            // 
            DebugTextBox.BackColor = SystemColors.ButtonHighlight;
            DebugTextBox.BorderStyle = BorderStyle.FixedSingle;
            DebugTextBox.Location = new Point(11, 398);
            DebugTextBox.MinimumSize = new Size(0, 100);
            DebugTextBox.Multiline = true;
            DebugTextBox.Name = "DebugTextBox";
            DebugTextBox.ReadOnly = true;
            DebugTextBox.ScrollBars = ScrollBars.Vertical;
            DebugTextBox.Size = new Size(598, 100);
            DebugTextBox.TabIndex = 9;
            // 
            // ClearButton
            // 
            ClearButton.Enabled = false;
            ClearButton.Location = new Point(11, 504);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(106, 32);
            ClearButton.TabIndex = 19;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // FFCopierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 550);
            Controls.Add(ClearButton);
            Controls.Add(DebugTextBox);
            Controls.Add(SubmitButton);
            Controls.Add(CopyPanel);
            Controls.Add(ArrowPanel);
            Controls.Add(ToPanel);
            Controls.Add(TitleLabel);
            Controls.Add(FromPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FFCopierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FFCopier";
            FromPanel.ResumeLayout(false);
            FromPanel.PerformLayout();
            ToPanel.ResumeLayout(false);
            ToPanel.PerformLayout();
            CopyPanel.ResumeLayout(false);
            CopyPanel.PerformLayout();
            DescriptionPanel.ResumeLayout(false);
            DescriptionPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel FromPanel;
        private Label FromLabel;
        private ComboBox FromDropdown;
        private Label TitleLabel;
        private Panel ToPanel;
        private ComboBox ToDropdown;
        private Label ToLabel;
        private Panel ArrowPanel;
        private Panel CopyPanel;
        private Button SubmitButton;
        private TextBox DebugTextBox;
        private Label DescriptionTextLabel;
        private Panel DescriptionPanel;
        private Button SelectAllButton;
        private Button UnselectAllButton;
        private Label CopyPanelLabel;
        private ConfigCheckBox UICheckBox;
        private ConfigCheckBox CharSettingsCheckBox;
        private ConfigCheckBox UICacheCheckBox;
        private ConfigCheckBox MacrosCheckBox;
        private ConfigCheckBox ChatLogCheckBox;
        private ConfigCheckBox KeybindCheckBox;
        private ConfigCheckBox InventoryCheckBox;
        private ConfigCheckBox HotBarCheckBox;
        private ConfigCheckBox TripleTriadCheckBox;
        private ConfigCheckBox GearsetsCheckBox;
        private ConfigCheckBox ControlsCheckBox;
        private ConfigCheckBox ACQCheckBox;
        private Label FromFolderLabel;
        private Label ToFolderLabel;
        private Button ClearButton;
    }
}