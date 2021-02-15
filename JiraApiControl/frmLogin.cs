using System;
using System.Windows.Forms;

namespace JiraApiControl
{
    public partial class frmLogin : Form
    {
        string id = string.Empty;
        string password = string.Empty;
        string jiraServer = string.Empty;
        string jiraUri = string.Empty;

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Jira jira = new Jira();
            if (await jira.Login(txtServer.Text, txtID.Text, txtPW.Text) == false)
            {
                lblResult.Text = "AuthFailed：" + txtID.Text;
                btnRun.Visible = false;
                return;
            }
            else
            {
                jiraServer = txtServer.Text;
                jiraUri = txtURL.Text;
                id = txtID.Text;
                password = txtPW.Text;
                btnRun.Visible = true;

                lblResult.Text = string.Empty;
            }
        }

        /// <summary>
        /// 確認ボタンイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmMain frmMain = new frmMain(jiraServer, jiraUri, id, password);
            frmMain.Show();
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
