using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace JiraApiControl
{
    public partial class frmMain : Form
    {
        List<Issue> ListDoing = new List<Issue>();
        List<Issue> ListDone = new List<Issue>();

        string jiraUri = string.Empty;
        string id = string.Empty;
        string password = string.Empty;
        string assignee = string.Empty;
        string fixversion = string.Empty;
        string jiraServer = string.Empty;
        string jiraInfoFile = Application.StartupPath + @"\" + "SettingInfo.ini";

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="jiraServer"></param>
        /// <param name="jiraUri"></param>
        /// <param name="id"></param>
        /// <param name="password"></param>
        public frmMain(string jiraServer, string jiraUri, string id, string password)
        {
            this.jiraServer = jiraServer;
            this.jiraUri = jiraUri;
            this.id = id;
            this.password = password;

            InitializeComponent();
        }

        private void SetMemberList(string targetMember)
        {
            string[] iniMemberList = targetMember.Split(',');
            memberList.Items.Clear();
            foreach (string _InMember in iniMemberList)
            {
                memberList.Items.Add(_InMember.Trim());
            }
        }

        private void SetSprintList(string targetSprint)
        {
            string[] iniSprintList = targetSprint.Split(',');
            sprintList.Items.Clear();
            foreach (string _InSprint in iniSprintList)
            {
                sprintList.Items.Add(_InSprint.Trim());
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetMemberList(InfoSetting_Member());
            SetSprintList(InfoSetting_Sprint());
        }

        private string InfoSetting_Member()
        {
            return Utils.GetValueString("MemberInfo", "Member", jiraInfoFile);
        }

        private string InfoSetting_Sprint()
        {
            return Utils.GetValueString("SprintInfo", "Sprint", jiraInfoFile);
        }

        private string setLabels()
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(txtLabels1.Text))
            {
                result += txtLabels1.Text;
                if (!string.IsNullOrEmpty(txtLabels2.Text))
                {
                    result += "," + txtLabels2.Text;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txtLabels2.Text))
                {
                    result += txtLabels2.Text;
                }
            }
            return result;
        }

        /// <summary>
        /// 作業中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            // Grid初期化
            dgDoing.Rows.Clear();

            // 件数カウンター
            lblCount1.Text = 0.ToString();

            // ①．JIRA認証を行う
            Jira jira = new Jira();
            if (await jira.Login(jiraServer, id, password) == false)
            {
                Console.WriteLine("Auth failed: " + id);
                return;
            }

            // ②．アサインを整理する
            assignee = SetAssignMember();

            // ③．fixversionを整理する
            fixversion = SetFixVersion();

            // ③．検索を実施する
            SearchResult resultDoing = await jira.GetIssuesByAssignee(txtDate.Text, fixversion, assignee, setLabels(), 0, true);

            // チケット設定
            ListDoing = resultDoing.issues;

            // ◆◆◆◆◆ DOINGリスト ◆◆◆◆◆
            lblCount1.Text = 0.ToString();
            if (ListDoing != null)
            {
                ListDoing.Sort((a, b) => string.Compare(a.fields.assignee.displayName, b.fields.assignee.displayName));
                ListDoing = resultDoing.issues;
                int count = 1;

                foreach (var issue in ListDoing)
                {
                    dgDoing.Rows.Add(count++, issue.fields.assignee.displayName, jiraUri + issue.key, issue.fields.summary, issue.fields.status.name, issue.fields.updated, issue.fields.duedate);
                }

                if (ListDoing.Count == 51)
                {
                    resultDoing = await jira.GetIssuesByAssignee(txtDate.Text, fixversion, assignee, setLabels(), count, true);
                    ListDoing = resultDoing.issues;
                    ListDoing.Sort((a, b) => string.Compare(a.fields.assignee.displayName, b.fields.assignee.displayName));

                    count = 51;
                    foreach (var issue in ListDoing)
                    {
                        dgDoing.Rows.Add(count++, issue.fields.assignee.displayName, jiraUri + issue.key, issue.fields.summary, issue.fields.status.name, issue.fields.updated, issue.fields.duedate);
                    }
                }

                if (ListDoing.Count == 101)
                {
                    resultDoing = await jira.GetIssuesByAssignee(txtDate.Text, fixversion, assignee, setLabels(), count, true);
                    ListDoing = resultDoing.issues;
                    ListDoing.Sort((a, b) => string.Compare(a.fields.assignee.displayName, b.fields.assignee.displayName));

                    count = 51;
                    foreach (var issue in ListDoing)
                    {
                        dgDoing.Rows.Add(count++, issue.fields.assignee.displayName, jiraUri + issue.key, issue.fields.summary, issue.fields.status.name, issue.fields.updated, issue.fields.duedate);
                    }
                }

                if (ListDoing.Count == 151)
                {
                    resultDoing = await jira.GetIssuesByAssignee(txtDate.Text, fixversion, assignee, setLabels(), count, true);
                    ListDoing = resultDoing.issues;
                    ListDoing.Sort((a, b) => string.Compare(a.fields.assignee.displayName, b.fields.assignee.displayName));

                    count = 51;
                    foreach (var issue in ListDoing)
                    {
                        dgDoing.Rows.Add(count++, issue.fields.assignee.displayName, jiraUri + issue.key, issue.fields.summary, issue.fields.status.name, issue.fields.updated, issue.fields.duedate);
                    }
                }

                // 件数カウンター
                lblCount1.Text = (count - 1).ToString();
            }
        }


        /// <summary>
        /// 作業完了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnSearchDone_Click(object sender, EventArgs e)
        {
            // Grid初期化
            dgDone.Rows.Clear();

            // 件数カウンター
            lblCount2.Text = 0.ToString();

            // ①．JIRA認証を行う
            Jira jira = new Jira();
            if (await jira.Login(jiraServer, id, password) == false)
            {
                Console.WriteLine("Auth failed: " + id);
                return;
            }

            // ②．アサインを整理する
            assignee = SetAssignMember();

            // ③．fixversionを整理する
            fixversion = SetFixVersion();

            // ③．検索を実施する
            SearchResult resultDone = await jira.GetIssuesByAssignee(txtDate.Text, fixversion, assignee, setLabels(), 0, false);

            // チケット設定
            ListDone = resultDone.issues;

            // ◆◆◆◆◆ DONEリスト ◆◆◆◆◆
            lblCount2.Text = 0.ToString();
            if (ListDone != null)
            {
                ListDone.Sort((a, b) => string.Compare(a.fields.assignee.displayName, b.fields.assignee.displayName));

                int count = 1;
                foreach (var issue in ListDone)
                {
                    dgDone.Rows.Add(count++, issue.fields.assignee.displayName, jiraUri + issue.key, issue.fields.summary, issue.fields.status.name, issue.fields.updated, issue.fields.duedate);
                }

                if (count == 51)
                {
                    resultDone = await jira.GetIssuesByAssignee(txtDate.Text, fixversion, assignee, setLabels(), count, true);
                    ListDone = resultDone.issues;
                    ListDone.Sort((a, b) => string.Compare(a.fields.assignee.displayName, b.fields.assignee.displayName));

                    foreach (var issue in ListDone)
                    {
                        dgDone.Rows.Add(count++, issue.fields.assignee.displayName, jiraUri + issue.key, issue.fields.summary, issue.fields.status.name, issue.fields.updated, issue.fields.duedate);
                    }
                }

                if (count == 101)
                {
                    resultDone = await jira.GetIssuesByAssignee(txtDate.Text, fixversion, assignee, setLabels(), count, true);
                    ListDone = resultDone.issues;
                    ListDone.Sort((a, b) => string.Compare(a.fields.assignee.displayName, b.fields.assignee.displayName));

                    foreach (var issue in ListDone)
                    {
                        dgDone.Rows.Add(count++, issue.fields.assignee.displayName, jiraUri + issue.key, issue.fields.summary, issue.fields.status.name, issue.fields.updated, issue.fields.duedate);
                    }
                }

                if (count == 151)
                {
                    resultDone = await jira.GetIssuesByAssignee(txtDate.Text, fixversion, assignee, setLabels(), count, true);
                    ListDone = resultDone.issues;
                    ListDone.Sort((a, b) => string.Compare(a.fields.assignee.displayName, b.fields.assignee.displayName));

                    foreach (var issue in ListDone)
                    {
                        dgDone.Rows.Add(count++, issue.fields.assignee.displayName, jiraUri + issue.key, issue.fields.summary, issue.fields.status.name, issue.fields.updated, issue.fields.duedate);
                    }
                }

                // 件数カウンター
                lblCount2.Text = (count - 1).ToString();
            }
        }

        private string SetAssignMember()
        {
            string resultStr = string.Empty;

            for (int i = 0; i <= memberList.Items.Count - 1; i++)
            {
                if (memberList.GetItemCheckState(i) == CheckState.Checked)
                {
                    if (string.IsNullOrEmpty(resultStr))
                    {
                        resultStr += memberList.Items[i];
                    }
                    else
                    {
                        resultStr += "," + memberList.Items[i];
                    }
                }
            }
            return resultStr;
        }

        private string SetFixVersion()
        {
            string resultStr = string.Empty;
            for (int i = 0; i <= sprintList.Items.Count - 1; i++)
            {
                if (sprintList.GetItemCheckState(i) == CheckState.Checked)
                {
                    if (string.IsNullOrEmpty(resultStr))
                    {
                        resultStr += sprintList.Items[i];
                    }
                    else
                    {
                        resultStr += "," + sprintList.Items[i];
                    }
                }
            }
            return resultStr;
        }


        private void CreatTicker(string SummaryTitle, int TicketType)
        {
            var data = new Utils.IssueRest();
            data.fields.project.key = txtProjectName.Text;
            data.fields.summary = SummaryTitle;
            data.fields.description = SummaryTitle;
            data.fields.issuetype.name = "Story";
            data.fields.labels = new string[2];
            data.fields.labels[0] = txtLabels1.Text;
            data.fields.labels[1] = txtLabels2.Text;

            string postUrl = "https://domain.com/jira/rest/api/2/issue";

            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

            client.BaseAddress = new System.Uri(postUrl);
            byte[] cred = UTF8Encoding.UTF8.GetBytes(id + ":" + password);
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(cred));
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            System.Net.Http.Formatting.MediaTypeFormatter jsonFormatter = new System.Net.Http.Formatting.JsonMediaTypeFormatter();

            //System.Net.Http.HttpContent content = new System.Net.Http.ObjectContent<string>(data, jsonFormatter);
            System.Net.Http.HttpContent content = new System.Net.Http.ObjectContent<Utils.IssueRest>(data, jsonFormatter);
            System.Net.Http.HttpResponseMessage response = client.PostAsync("issue", content).Result;

            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                string[] splitStr = result.Split(',');

                lblResult.Text = "作成完了 " + splitStr[1];
                string targetTicketNumber = splitStr[1].Remove(0, 7).Replace(@"\", string.Empty).Replace("\"", string.Empty);

                switch (TicketType)
                {
                    case 1:
                        break;

                    case 2:
                        string postUrl2 = "https://domain/jira/rest/api/2/issue";
                        byte[] cred2 = UTF8Encoding.UTF8.GetBytes(id + ":" + password);
                        ArrayList ar = new ArrayList();
                        ar.Add(txtSubTicket1.Text);
                        ar.Add(txtSubTicket2.Text);
                        ar.Add(txtSubTicket3.Text);
                        ar.Add(txtSubTicket4.Text);
                        ar.Add(txtSubTicket5.Text);
                        ar.Add(txtSubTicket6.Text);
                        ar.Add(txtSubTicket7.Text);

                        foreach (var target in ar)
                        {
                            var data2 = new Utils.IssueRest();
                            data2.fields.project.key = txtProjectName.Text;
                            data2.fields.summary = target.ToString();
                            data2.fields.description = target.ToString();
                            data2.fields.parent.key = targetTicketNumber;
                            data2.fields.issuetype.id = "5";
                            data2.fields.labels = new string[2];
                            data2.fields.labels[0] = txtLabels1.Text;
                            data2.fields.labels[1] = txtLabels2.Text;

                            System.Net.Http.HttpClient client2 = new System.Net.Http.HttpClient();
                            client2.BaseAddress = new Uri(postUrl2);
                            client2.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(cred2));
                            client2.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                            System.Net.Http.Formatting.MediaTypeFormatter jsonFormatter2 = new System.Net.Http.Formatting.JsonMediaTypeFormatter();

                            System.Net.Http.HttpContent content2 = new System.Net.Http.ObjectContent<Utils.IssueRest>(data2, jsonFormatter);
                            System.Net.Http.HttpResponseMessage response2 = client.PostAsync("issue", content2).Result;
                        }
                        break;
                }
            }
            else
            {
                lblResult.Text = "作成失敗";
            }
        }

        private void btnCreate1_Click(object sender, EventArgs e)
        {
            CreatTicker(txtStory.Text, 1);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            CreatTicker(txtStory.Text, 2);
        }

        /// <summary>
        /// Assignee編集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditAssignee_Click(object sender, EventArgs e)
        {
            frmIniSetting fis = new frmIniSetting("MemberInfo", "Member", jiraInfoFile);
            if (DialogResult.OK == fis.ShowDialog())
            {
                SetMemberList(InfoSetting_Member());
            }
        }

        /// <summary>
        /// Fixversion編集
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditFixversion_Click(object sender, EventArgs e)
        {
            frmIniSetting fis = new frmIniSetting("SprintInfo", "Sprint", jiraInfoFile);
            if (DialogResult.OK == fis.ShowDialog())
            {
                SetSprintList(InfoSetting_Sprint());
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgDoing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && !string.IsNullOrEmpty(dgDoing[e.ColumnIndex, e.RowIndex].Value.ToString()))
                Process.Start("IExplore.exe", dgDoing[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        private void dgDone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && !string.IsNullOrEmpty(dgDone[e.ColumnIndex, e.RowIndex].Value.ToString()))
                Process.Start("IExplore.exe", dgDone[e.ColumnIndex, e.RowIndex].Value.ToString());
        }

        private void btnCreateSubTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStoryTicket.Text))
            {
                string postUrl = "https://domain/jira/rest/api/2/issue";
                byte[] cred = UTF8Encoding.UTF8.GetBytes(id + ":" + password);
                System.Net.Http.Formatting.MediaTypeFormatter jsonFormatter = new System.Net.Http.Formatting.JsonMediaTypeFormatter();

                System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
                client.BaseAddress = new Uri(postUrl);
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(cred));
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                ArrayList ar = new ArrayList();
                ar.Add(txtSubTicket1.Text);
                ar.Add(txtSubTicket2.Text);
                ar.Add(txtSubTicket3.Text);
                ar.Add(txtSubTicket4.Text);
                ar.Add(txtSubTicket5.Text);
                ar.Add(txtSubTicket6.Text);
                ar.Add(txtSubTicket7.Text);

                foreach (var target in ar)
                {
                    var data = new Utils.IssueRest();
                    data.fields.project.key = txtProjectName.Text;
                    data.fields.summary = target.ToString();
                    data.fields.description = target.ToString();
                    data.fields.parent.key = txtStoryTicket.Text;
                    data.fields.issuetype.id = "5";
                    data.fields.labels = new string[2];
                    data.fields.labels[0] = txtLabels1.Text;
                    data.fields.labels[1] = txtLabels2.Text;

                    System.Net.Http.HttpContent content = new System.Net.Http.ObjectContent<Utils.IssueRest>(data, jsonFormatter);
                    System.Net.Http.HttpResponseMessage response = client.PostAsync("issue", content).Result;
                }
            }
        }
    }
}
