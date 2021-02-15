using System;
using System.Windows.Forms;

namespace JiraApiControl
{
    public partial class frmIniSetting : Form
    {
        string section;
        string key;
        string fileName;

        public frmIniSetting(string section, string key, string fileName)
        {
            this.section = section;
            this.key = key;
            this.fileName = fileName;

            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Utils.SetValue(section, key, txtValue.Text, fileName);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmIniSetting_Load(object sender, EventArgs e)
        {
            this.txtValue.Text = Utils.GetValueString(section, key, fileName);
        }
    }
}
