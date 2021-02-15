namespace JiraApiControl
{
    partial class frmMain
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
            this.dgDoing = new System.Windows.Forms.DataGridView();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditAssignee = new System.Windows.Forms.Button();
            this.btnEditFixversion = new System.Windows.Forms.Button();
            this.btnSearchDone = new System.Windows.Forms.Button();
            this.btnSearchDoing = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sprintList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.memberList = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCount1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgDone = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.btnCreate1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLabels1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLabels2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtStoryTicket = new System.Windows.Forms.TextBox();
            this.btnCreateSubTask = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSubTicket7 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSubTicket6 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSubTicket5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSubTicket4 = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStory = new System.Windows.Forms.TextBox();
            this.txtSubTicket1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubTicket2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSubTicket3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoing)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDone)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDoing
            // 
            this.dgDoing.AllowUserToAddRows = false;
            this.dgDoing.AllowUserToDeleteRows = false;
            this.dgDoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDoing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.Person,
            this.Ticket,
            this.Title,
            this.Status,
            this.Column1,
            this.DueDate});
            this.dgDoing.Location = new System.Drawing.Point(12, 324);
            this.dgDoing.Name = "dgDoing";
            this.dgDoing.RowHeadersVisible = false;
            this.dgDoing.Size = new System.Drawing.Size(1275, 216);
            this.dgDoing.TabIndex = 0;
            this.dgDoing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDoing_CellClick);
            // 
            // RowNum
            // 
            this.RowNum.HeaderText = "No";
            this.RowNum.Name = "RowNum";
            this.RowNum.Width = 50;
            // 
            // Person
            // 
            this.Person.HeaderText = "担当者";
            this.Person.Name = "Person";
            this.Person.Width = 200;
            // 
            // Ticket
            // 
            this.Ticket.HeaderText = "チケット";
            this.Ticket.Name = "Ticket";
            this.Ticket.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ticket.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ticket.Width = 300;
            // 
            // Title
            // 
            this.Title.HeaderText = "タイトル";
            this.Title.Name = "Title";
            this.Title.Width = 400;
            // 
            // Status
            // 
            this.Status.HeaderText = "ステータス";
            this.Status.Name = "Status";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "更新日";
            this.Column1.Name = "Column1";
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "期限日";
            this.DueDate.Name = "DueDate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditAssignee);
            this.groupBox1.Controls.Add(this.btnEditFixversion);
            this.groupBox1.Controls.Add(this.btnSearchDone);
            this.groupBox1.Controls.Add(this.btnSearchDoing);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sprintList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.memberList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 284);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Conditions";
            // 
            // btnEditAssignee
            // 
            this.btnEditAssignee.Location = new System.Drawing.Point(137, 20);
            this.btnEditAssignee.Name = "btnEditAssignee";
            this.btnEditAssignee.Size = new System.Drawing.Size(50, 23);
            this.btnEditAssignee.TabIndex = 11;
            this.btnEditAssignee.Text = "Edit";
            this.btnEditAssignee.UseVisualStyleBackColor = true;
            this.btnEditAssignee.Click += new System.EventHandler(this.btnEditAssignee_Click);
            // 
            // btnEditFixversion
            // 
            this.btnEditFixversion.Location = new System.Drawing.Point(304, 20);
            this.btnEditFixversion.Name = "btnEditFixversion";
            this.btnEditFixversion.Size = new System.Drawing.Size(50, 23);
            this.btnEditFixversion.TabIndex = 10;
            this.btnEditFixversion.Text = "Edit";
            this.btnEditFixversion.UseVisualStyleBackColor = true;
            this.btnEditFixversion.Click += new System.EventHandler(this.btnEditFixversion_Click);
            // 
            // btnSearchDone
            // 
            this.btnSearchDone.Location = new System.Drawing.Point(360, 117);
            this.btnSearchDone.Name = "btnSearchDone";
            this.btnSearchDone.Size = new System.Drawing.Size(86, 41);
            this.btnSearchDone.TabIndex = 8;
            this.btnSearchDone.Text = "Search [done]";
            this.btnSearchDone.UseVisualStyleBackColor = true;
            this.btnSearchDone.Click += new System.EventHandler(this.btnSearchDone_Click);
            // 
            // btnSearchDoing
            // 
            this.btnSearchDoing.Location = new System.Drawing.Point(360, 70);
            this.btnSearchDoing.Name = "btnSearchDoing";
            this.btnSearchDoing.Size = new System.Drawing.Size(86, 41);
            this.btnSearchDoing.TabIndex = 7;
            this.btnSearchDoing.Text = "Search [doing]";
            this.btnSearchDoing.UseVisualStyleBackColor = true;
            this.btnSearchDoing.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "days";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(360, 44);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(43, 20);
            this.txtDate.TabIndex = 5;
            this.txtDate.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DueDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FixVersion";
            // 
            // sprintList
            // 
            this.sprintList.FormattingEnabled = true;
            this.sprintList.Location = new System.Drawing.Point(193, 44);
            this.sprintList.Name = "sprintList";
            this.sprintList.Size = new System.Drawing.Size(161, 229);
            this.sprintList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assignee";
            // 
            // memberList
            // 
            this.memberList.FormattingEnabled = true;
            this.memberList.Location = new System.Drawing.Point(22, 44);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(165, 229);
            this.memberList.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "In Progress";
            // 
            // lblCount1
            // 
            this.lblCount1.AutoSize = true;
            this.lblCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCount1.Location = new System.Drawing.Point(81, 299);
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(0, 20);
            this.lblCount1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(81, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(8, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Done";
            // 
            // dgDone
            // 
            this.dgDone.AllowUserToAddRows = false;
            this.dgDone.AllowUserToDeleteRows = false;
            this.dgDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewLinkColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column2,
            this.dataGridViewTextBoxColumn5});
            this.dgDone.Location = new System.Drawing.Point(12, 576);
            this.dgDone.Name = "dgDone";
            this.dgDone.RowHeadersVisible = false;
            this.dgDone.Size = new System.Drawing.Size(1275, 216);
            this.dgDone.TabIndex = 4;
            this.dgDone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDone_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "担当者";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.HeaderText = "チケット";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "タイトル";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 400;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "ステータス";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "更新日";
            this.Column2.Name = "Column2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "期限日";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // lblCount2
            // 
            this.lblCount2.AutoSize = true;
            this.lblCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCount2.Location = new System.Drawing.Point(81, 551);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(0, 20);
            this.lblCount2.TabIndex = 7;
            // 
            // btnCreate1
            // 
            this.btnCreate1.Location = new System.Drawing.Point(351, 20);
            this.btnCreate1.Name = "btnCreate1";
            this.btnCreate1.Size = new System.Drawing.Size(88, 20);
            this.btnCreate1.TabIndex = 8;
            this.btnCreate1.Text = "Create Story";
            this.btnCreate1.UseVisualStyleBackColor = true;
            this.btnCreate1.Click += new System.EventHandler(this.btnCreate1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResult);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(480, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 282);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JIRA automation";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResult.ForeColor = System.Drawing.Color.Blue;
            this.lblResult.Location = new System.Drawing.Point(299, 16);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 25;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox4.Controls.Add(this.txtProjectName);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtLabels1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtLabels2);
            this.groupBox4.Location = new System.Drawing.Point(6, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 253);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ProjectInfo";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(63, 29);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(95, 20);
            this.txtProjectName.TabIndex = 24;
            this.txtProjectName.Text = "ProjectName";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Project";
            // 
            // txtLabels1
            // 
            this.txtLabels1.Location = new System.Drawing.Point(63, 58);
            this.txtLabels1.Name = "txtLabels1";
            this.txtLabels1.Size = new System.Drawing.Size(95, 20);
            this.txtLabels1.TabIndex = 20;
            this.txtLabels1.Text = "Label1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Labels";
            // 
            // txtLabels2
            // 
            this.txtLabels2.Location = new System.Drawing.Point(164, 58);
            this.txtLabels2.Name = "txtLabels2";
            this.txtLabels2.Size = new System.Drawing.Size(95, 20);
            this.txtLabels2.TabIndex = 22;
            this.txtLabels2.Text = "Label2";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtStoryTicket);
            this.groupBox3.Controls.Add(this.btnCreateSubTask);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtSubTicket7);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtSubTicket6);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtSubTicket5);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtSubTicket4);
            this.groupBox3.Controls.Add(this.btnAll);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnCreate1);
            this.groupBox3.Controls.Add(this.txtStory);
            this.groupBox3.Controls.Add(this.txtSubTicket1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSubTicket2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtSubTicket3);
            this.groupBox3.Location = new System.Drawing.Point(298, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 253);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create Ticket";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Parent";
            // 
            // txtStoryTicket
            // 
            this.txtStoryTicket.Location = new System.Drawing.Point(71, 45);
            this.txtStoryTicket.Name = "txtStoryTicket";
            this.txtStoryTicket.Size = new System.Drawing.Size(274, 20);
            this.txtStoryTicket.TabIndex = 30;
            this.txtStoryTicket.Text = "※Enter the parent StoryJIRA number (TEST-123)※";
            // 
            // btnCreateSubTask
            // 
            this.btnCreateSubTask.Location = new System.Drawing.Point(351, 45);
            this.btnCreateSubTask.Name = "btnCreateSubTask";
            this.btnCreateSubTask.Size = new System.Drawing.Size(88, 46);
            this.btnCreateSubTask.TabIndex = 29;
            this.btnCreateSubTask.Text = "SubTask group creation";
            this.btnCreateSubTask.UseVisualStyleBackColor = true;
            this.btnCreateSubTask.Click += new System.EventHandler(this.btnCreateSubTask_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(58, 230);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Sub-Task";
            // 
            // txtSubTicket7
            // 
            this.txtSubTicket7.Location = new System.Drawing.Point(114, 227);
            this.txtSubTicket7.Name = "txtSubTicket7";
            this.txtSubTicket7.Size = new System.Drawing.Size(231, 20);
            this.txtSubTicket7.TabIndex = 27;
            this.txtSubTicket7.Text = "７．TEST7";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(58, 204);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Sub-Task";
            // 
            // txtSubTicket6
            // 
            this.txtSubTicket6.Location = new System.Drawing.Point(114, 201);
            this.txtSubTicket6.Name = "txtSubTicket6";
            this.txtSubTicket6.Size = new System.Drawing.Size(231, 20);
            this.txtSubTicket6.TabIndex = 25;
            this.txtSubTicket6.Text = "６．TEST6";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(58, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Sub-Task";
            // 
            // txtSubTicket5
            // 
            this.txtSubTicket5.Location = new System.Drawing.Point(114, 175);
            this.txtSubTicket5.Name = "txtSubTicket5";
            this.txtSubTicket5.Size = new System.Drawing.Size(231, 20);
            this.txtSubTicket5.TabIndex = 23;
            this.txtSubTicket5.Text = "５．TEST5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Sub-Task";
            // 
            // txtSubTicket4
            // 
            this.txtSubTicket4.Location = new System.Drawing.Point(114, 149);
            this.txtSubTicket4.Name = "txtSubTicket4";
            this.txtSubTicket4.Size = new System.Drawing.Size(231, 20);
            this.txtSubTicket4.TabIndex = 21;
            this.txtSubTicket4.Text = "４．TEST4";
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(440, 20);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(57, 227);
            this.btnAll.TabIndex = 20;
            this.btnAll.Text = "Create All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Story";
            // 
            // txtStory
            // 
            this.txtStory.Location = new System.Drawing.Point(71, 20);
            this.txtStory.Name = "txtStory";
            this.txtStory.Size = new System.Drawing.Size(274, 20);
            this.txtStory.TabIndex = 9;
            this.txtStory.Text = "※Please enter your Story name※";
            // 
            // txtSubTicket1
            // 
            this.txtSubTicket1.Location = new System.Drawing.Point(114, 71);
            this.txtSubTicket1.Name = "txtSubTicket1";
            this.txtSubTicket1.Size = new System.Drawing.Size(231, 20);
            this.txtSubTicket1.TabIndex = 11;
            this.txtSubTicket1.Text = "１．TEST1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Sub-Task";
            // 
            // txtSubTicket2
            // 
            this.txtSubTicket2.Location = new System.Drawing.Point(114, 97);
            this.txtSubTicket2.Name = "txtSubTicket2";
            this.txtSubTicket2.Size = new System.Drawing.Size(231, 20);
            this.txtSubTicket2.TabIndex = 13;
            this.txtSubTicket2.Text = "２．TEST2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Sub-Task";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Sub-Task";
            // 
            // txtSubTicket3
            // 
            this.txtSubTicket3.Location = new System.Drawing.Point(114, 123);
            this.txtSubTicket3.Name = "txtSubTicket3";
            this.txtSubTicket3.Size = new System.Drawing.Size(231, 20);
            this.txtSubTicket3.TabIndex = 15;
            this.txtSubTicket3.Text = "３．TEST3";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 802);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblCount2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgDone);
            this.Controls.Add(this.lblCount1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgDoing);
            this.Name = "frmMain";
            this.Text = "JIRA-API REST by TOSUN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDoing)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDone)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDoing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox sprintList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox memberList;
        private System.Windows.Forms.Button btnSearchDoing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCount1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgDone;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person;
        private System.Windows.Forms.DataGridViewLinkColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnCreate1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSubTicket3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubTicket2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubTicket1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLabels1;
        private System.Windows.Forms.TextBox txtLabels2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSearchDone;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnEditAssignee;
        private System.Windows.Forms.Button btnEditFixversion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSubTicket4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSubTicket7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSubTicket6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSubTicket5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtStoryTicket;
        private System.Windows.Forms.Button btnCreateSubTask;
    }
}