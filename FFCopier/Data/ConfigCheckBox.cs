using System.ComponentModel;
using System.Windows.Forms.VisualStyles;

namespace FFCopier.Data
{
    class ConfigCheckBox : CheckBox
    { 
        private string displayName = "";
        [Category("Custom Properties")]
        [Description("What this checkbox should display as its' text.")]
        public string DisplayName
        {
            get { return displayName; }
            set { 
                displayName = value;
                // Automatically update the Text when CustomData is set
                this.Text = displayName; 
            }
        }

        private string description = "";
        [Category("Custom Properties")]
        [Description("A custom description for this checkbox.")]
        public string Description
        {
            get { return description; }
            set { description = value; Invalidate(); }
        }

        private String[] fileNames = Array.Empty<string>();
        [Category("Custom Properties")]
        [Description("A list of filenames that can be associated.")]
        public String[] FileNames
        {
            get { return fileNames; }
            set { fileNames = value; Invalidate(); }
        }
    }
}
