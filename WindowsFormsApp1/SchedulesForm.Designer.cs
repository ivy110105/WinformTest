namespace WindowsFormsApp1
{
    partial class SchedulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulesForm));
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabWork = new System.Windows.Forms.TabPage();
            this.rbtnWorkPriorityUrgent = new System.Windows.Forms.RadioButton();
            this.rbtnWorkPriorityHigh = new System.Windows.Forms.RadioButton();
            this.rbtnWorkPriorityNormal = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpickWorkTime = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpickWorkDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnWorkSave = new System.Windows.Forms.Button();
            this.btnWorkReset = new System.Windows.Forms.Button();
            this.listboxWorkSub = new System.Windows.Forms.ListBox();
            this.txtWorkSubName = new System.Windows.Forms.TextBox();
            this.picWorkSub = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWorkNote = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWorkName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabGym = new System.Windows.Forms.TabPage();
            this.dgvGym = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckbGymIgnorePeriod = new System.Windows.Forms.CheckBox();
            this.dtpickGymStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGymSave = new System.Windows.Forms.Button();
            this.btnGymReset = new System.Windows.Forms.Button();
            this.listboxGymSub = new System.Windows.Forms.ListBox();
            this.txtGymSubName = new System.Windows.Forms.TextBox();
            this.panelGymCustom = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGymTimes = new System.Windows.Forms.TextBox();
            this.txtGymFrequencyNum = new System.Windows.Forms.TextBox();
            this.combGymFrequencyUnit = new System.Windows.Forms.ComboBox();
            this.rbtnGymCustom = new System.Windows.Forms.RadioButton();
            this.rbtnGymEveryDay = new System.Windows.Forms.RadioButton();
            this.rbtnGymOnlyOnce = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.picGymSub = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGymNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGymName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabReading = new System.Windows.Forms.TabPage();
            this.dgvReading = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReadingType = new System.Windows.Forms.Label();
            this.comboxReadingType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpickReadingStart = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.btnReadingSave = new System.Windows.Forms.Button();
            this.btnReadingReset = new System.Windows.Forms.Button();
            this.listboxReadingSub = new System.Windows.Forms.ListBox();
            this.txtReadingSubName = new System.Windows.Forms.TextBox();
            this.picReadingSub = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtReadingNote = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtReadingName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabs.SuspendLayout();
            this.tabWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkSub)).BeginInit();
            this.tabGym.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGym)).BeginInit();
            this.panelGymCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGymSub)).BeginInit();
            this.tabReading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadingSub)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabWork);
            this.tabs.Controls.Add(this.tabGym);
            this.tabs.Controls.Add(this.tabReading);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Location = new System.Drawing.Point(12, 11);
            this.tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(603, 690);
            this.tabs.TabIndex = 2;
            // 
            // tabWork
            // 
            this.tabWork.Controls.Add(this.panel1);
            this.tabWork.Controls.Add(this.rbtnWorkPriorityUrgent);
            this.tabWork.Controls.Add(this.rbtnWorkPriorityHigh);
            this.tabWork.Controls.Add(this.rbtnWorkPriorityNormal);
            this.tabWork.Controls.Add(this.label11);
            this.tabWork.Controls.Add(this.dtpickWorkTime);
            this.tabWork.Controls.Add(this.label10);
            this.tabWork.Controls.Add(this.dtpickWorkDate);
            this.tabWork.Controls.Add(this.label9);
            this.tabWork.Controls.Add(this.btnWorkSave);
            this.tabWork.Controls.Add(this.btnWorkReset);
            this.tabWork.Controls.Add(this.listboxWorkSub);
            this.tabWork.Controls.Add(this.txtWorkSubName);
            this.tabWork.Controls.Add(this.picWorkSub);
            this.tabWork.Controls.Add(this.label13);
            this.tabWork.Controls.Add(this.txtWorkNote);
            this.tabWork.Controls.Add(this.label14);
            this.tabWork.Controls.Add(this.txtWorkName);
            this.tabWork.Controls.Add(this.label15);
            this.tabWork.Location = new System.Drawing.Point(4, 25);
            this.tabWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabWork.Name = "tabWork";
            this.tabWork.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabWork.Size = new System.Drawing.Size(595, 661);
            this.tabWork.TabIndex = 0;
            this.tabWork.Text = "工作";
            this.tabWork.UseVisualStyleBackColor = true;
            // 
            // rbtnWorkPriorityUrgent
            // 
            this.rbtnWorkPriorityUrgent.AutoSize = true;
            this.rbtnWorkPriorityUrgent.Location = new System.Drawing.Point(127, 227);
            this.rbtnWorkPriorityUrgent.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnWorkPriorityUrgent.Name = "rbtnWorkPriorityUrgent";
            this.rbtnWorkPriorityUrgent.Size = new System.Drawing.Size(58, 19);
            this.rbtnWorkPriorityUrgent.TabIndex = 39;
            this.rbtnWorkPriorityUrgent.TabStop = true;
            this.rbtnWorkPriorityUrgent.Text = "紧急";
            this.rbtnWorkPriorityUrgent.UseVisualStyleBackColor = true;
            // 
            // rbtnWorkPriorityHigh
            // 
            this.rbtnWorkPriorityHigh.AutoSize = true;
            this.rbtnWorkPriorityHigh.Location = new System.Drawing.Point(127, 199);
            this.rbtnWorkPriorityHigh.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnWorkPriorityHigh.Name = "rbtnWorkPriorityHigh";
            this.rbtnWorkPriorityHigh.Size = new System.Drawing.Size(58, 19);
            this.rbtnWorkPriorityHigh.TabIndex = 38;
            this.rbtnWorkPriorityHigh.TabStop = true;
            this.rbtnWorkPriorityHigh.Text = "优先";
            this.rbtnWorkPriorityHigh.UseVisualStyleBackColor = true;
            // 
            // rbtnWorkPriorityNormal
            // 
            this.rbtnWorkPriorityNormal.AutoSize = true;
            this.rbtnWorkPriorityNormal.Location = new System.Drawing.Point(127, 172);
            this.rbtnWorkPriorityNormal.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnWorkPriorityNormal.Name = "rbtnWorkPriorityNormal";
            this.rbtnWorkPriorityNormal.Size = new System.Drawing.Size(58, 19);
            this.rbtnWorkPriorityNormal.TabIndex = 37;
            this.rbtnWorkPriorityNormal.TabStop = true;
            this.rbtnWorkPriorityNormal.Text = "一般";
            this.rbtnWorkPriorityNormal.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 36;
            this.label11.Text = "优先级：";
            // 
            // dtpickWorkTime
            // 
            this.dtpickWorkTime.CustomFormat = "HH:mm:ss";
            this.dtpickWorkTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickWorkTime.Location = new System.Drawing.Point(391, 130);
            this.dtpickWorkTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpickWorkTime.Name = "dtpickWorkTime";
            this.dtpickWorkTime.Size = new System.Drawing.Size(141, 25);
            this.dtpickWorkTime.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "时间：";
            // 
            // dtpickWorkDate
            // 
            this.dtpickWorkDate.Location = new System.Drawing.Point(127, 130);
            this.dtpickWorkDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpickWorkDate.Name = "dtpickWorkDate";
            this.dtpickWorkDate.Size = new System.Drawing.Size(183, 25);
            this.dtpickWorkDate.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "工作日期：";
            // 
            // btnWorkSave
            // 
            this.btnWorkSave.Location = new System.Drawing.Point(300, 410);
            this.btnWorkSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWorkSave.Name = "btnWorkSave";
            this.btnWorkSave.Size = new System.Drawing.Size(73, 25);
            this.btnWorkSave.TabIndex = 31;
            this.btnWorkSave.Text = "保存";
            this.btnWorkSave.UseVisualStyleBackColor = true;
            this.btnWorkSave.Click += new System.EventHandler(this.btnWorkSave_Click);
            // 
            // btnWorkReset
            // 
            this.btnWorkReset.Location = new System.Drawing.Point(220, 410);
            this.btnWorkReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWorkReset.Name = "btnWorkReset";
            this.btnWorkReset.Size = new System.Drawing.Size(73, 25);
            this.btnWorkReset.TabIndex = 30;
            this.btnWorkReset.Text = "重置";
            this.btnWorkReset.UseVisualStyleBackColor = true;
            this.btnWorkReset.Click += new System.EventHandler(this.btnWorkReset_Click);
            // 
            // listboxWorkSub
            // 
            this.listboxWorkSub.FormattingEnabled = true;
            this.listboxWorkSub.ItemHeight = 15;
            this.listboxWorkSub.Location = new System.Drawing.Point(127, 300);
            this.listboxWorkSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxWorkSub.Name = "listboxWorkSub";
            this.listboxWorkSub.Size = new System.Drawing.Size(407, 94);
            this.listboxWorkSub.TabIndex = 29;
            // 
            // txtWorkSubName
            // 
            this.txtWorkSubName.Location = new System.Drawing.Point(127, 259);
            this.txtWorkSubName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWorkSubName.Name = "txtWorkSubName";
            this.txtWorkSubName.Size = new System.Drawing.Size(380, 25);
            this.txtWorkSubName.TabIndex = 28;
            // 
            // picWorkSub
            // 
            this.picWorkSub.Image = ((System.Drawing.Image)(resources.GetObject("picWorkSub.Image")));
            this.picWorkSub.Location = new System.Drawing.Point(515, 262);
            this.picWorkSub.Margin = new System.Windows.Forms.Padding(4);
            this.picWorkSub.Name = "picWorkSub";
            this.picWorkSub.Size = new System.Drawing.Size(19, 15);
            this.picWorkSub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWorkSub.TabIndex = 21;
            this.picWorkSub.TabStop = false;
            this.picWorkSub.Click += new System.EventHandler(this.picWorkSub_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "工作分支：";
            // 
            // txtWorkNote
            // 
            this.txtWorkNote.Location = new System.Drawing.Point(127, 74);
            this.txtWorkNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWorkNote.Multiline = true;
            this.txtWorkNote.Name = "txtWorkNote";
            this.txtWorkNote.Size = new System.Drawing.Size(407, 50);
            this.txtWorkNote.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 19;
            this.label14.Text = "工作说明：";
            // 
            // txtWorkName
            // 
            this.txtWorkName.Location = new System.Drawing.Point(127, 36);
            this.txtWorkName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWorkName.Name = "txtWorkName";
            this.txtWorkName.Size = new System.Drawing.Size(407, 25);
            this.txtWorkName.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 15);
            this.label15.TabIndex = 17;
            this.label15.Text = "工作名称：";
            // 
            // tabGym
            // 
            this.tabGym.Controls.Add(this.dgvGym);
            this.tabGym.Controls.Add(this.ckbGymIgnorePeriod);
            this.tabGym.Controls.Add(this.dtpickGymStart);
            this.tabGym.Controls.Add(this.label8);
            this.tabGym.Controls.Add(this.btnGymSave);
            this.tabGym.Controls.Add(this.btnGymReset);
            this.tabGym.Controls.Add(this.listboxGymSub);
            this.tabGym.Controls.Add(this.txtGymSubName);
            this.tabGym.Controls.Add(this.panelGymCustom);
            this.tabGym.Controls.Add(this.rbtnGymCustom);
            this.tabGym.Controls.Add(this.rbtnGymEveryDay);
            this.tabGym.Controls.Add(this.rbtnGymOnlyOnce);
            this.tabGym.Controls.Add(this.label5);
            this.tabGym.Controls.Add(this.picGymSub);
            this.tabGym.Controls.Add(this.label4);
            this.tabGym.Controls.Add(this.txtGymNote);
            this.tabGym.Controls.Add(this.label3);
            this.tabGym.Controls.Add(this.txtGymName);
            this.tabGym.Controls.Add(this.label2);
            this.tabGym.Location = new System.Drawing.Point(4, 25);
            this.tabGym.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGym.Name = "tabGym";
            this.tabGym.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGym.Size = new System.Drawing.Size(595, 661);
            this.tabGym.TabIndex = 1;
            this.tabGym.Text = "健身";
            this.tabGym.UseVisualStyleBackColor = true;
            // 
            // dgvGym
            // 
            this.dgvGym.AllowUserToAddRows = false;
            this.dgvGym.AllowUserToDeleteRows = false;
            this.dgvGym.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGym.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGym.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGym.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvGym.Location = new System.Drawing.Point(6, 450);
            this.dgvGym.Name = "dgvGym";
            this.dgvGym.ReadOnly = true;
            this.dgvGym.RowHeadersWidth = 75;
            this.dgvGym.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGym.RowTemplate.Height = 27;
            this.dgvGym.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGym.Size = new System.Drawing.Size(583, 206);
            this.dgvGym.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "序号";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "名称";
            this.dataGridViewTextBoxColumn2.HeaderText = "名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 370;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "优先级";
            this.dataGridViewTextBoxColumn3.HeaderText = "优先级";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ckbGymIgnorePeriod
            // 
            this.ckbGymIgnorePeriod.AutoSize = true;
            this.ckbGymIgnorePeriod.Location = new System.Drawing.Point(399, 225);
            this.ckbGymIgnorePeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbGymIgnorePeriod.Name = "ckbGymIgnorePeriod";
            this.ckbGymIgnorePeriod.Size = new System.Drawing.Size(134, 19);
            this.ckbGymIgnorePeriod.TabIndex = 16;
            this.ckbGymIgnorePeriod.Text = "自动忽略生理期";
            this.ckbGymIgnorePeriod.UseVisualStyleBackColor = true;
            // 
            // dtpickGymStart
            // 
            this.dtpickGymStart.Location = new System.Drawing.Point(127, 219);
            this.dtpickGymStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpickGymStart.Name = "dtpickGymStart";
            this.dtpickGymStart.Size = new System.Drawing.Size(167, 25);
            this.dtpickGymStart.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "开始日期：";
            // 
            // btnGymSave
            // 
            this.btnGymSave.Location = new System.Drawing.Point(300, 410);
            this.btnGymSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGymSave.Name = "btnGymSave";
            this.btnGymSave.Size = new System.Drawing.Size(73, 25);
            this.btnGymSave.TabIndex = 13;
            this.btnGymSave.Text = "保存";
            this.btnGymSave.UseVisualStyleBackColor = true;
            this.btnGymSave.Click += new System.EventHandler(this.btnGymSave_Click);
            // 
            // btnGymReset
            // 
            this.btnGymReset.Location = new System.Drawing.Point(220, 410);
            this.btnGymReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGymReset.Name = "btnGymReset";
            this.btnGymReset.Size = new System.Drawing.Size(73, 25);
            this.btnGymReset.TabIndex = 12;
            this.btnGymReset.Text = "重置";
            this.btnGymReset.UseVisualStyleBackColor = true;
            this.btnGymReset.Click += new System.EventHandler(this.btnGymReset_Click);
            // 
            // listboxGymSub
            // 
            this.listboxGymSub.FormattingEnabled = true;
            this.listboxGymSub.ItemHeight = 15;
            this.listboxGymSub.Location = new System.Drawing.Point(127, 300);
            this.listboxGymSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxGymSub.Name = "listboxGymSub";
            this.listboxGymSub.Size = new System.Drawing.Size(407, 94);
            this.listboxGymSub.TabIndex = 11;
            // 
            // txtGymSubName
            // 
            this.txtGymSubName.Location = new System.Drawing.Point(127, 259);
            this.txtGymSubName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGymSubName.Name = "txtGymSubName";
            this.txtGymSubName.Size = new System.Drawing.Size(380, 25);
            this.txtGymSubName.TabIndex = 10;
            // 
            // panelGymCustom
            // 
            this.panelGymCustom.Controls.Add(this.label7);
            this.panelGymCustom.Controls.Add(this.label6);
            this.panelGymCustom.Controls.Add(this.txtGymTimes);
            this.panelGymCustom.Controls.Add(this.txtGymFrequencyNum);
            this.panelGymCustom.Controls.Add(this.combGymFrequencyUnit);
            this.panelGymCustom.Location = new System.Drawing.Point(205, 175);
            this.panelGymCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGymCustom.Name = "panelGymCustom";
            this.panelGymCustom.Size = new System.Drawing.Size(327, 39);
            this.panelGymCustom.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(157, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "（例如： 1 周 2 次）";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "次";
            // 
            // txtGymTimes
            // 
            this.txtGymTimes.Location = new System.Drawing.Point(95, 8);
            this.txtGymTimes.Margin = new System.Windows.Forms.Padding(4);
            this.txtGymTimes.Name = "txtGymTimes";
            this.txtGymTimes.Size = new System.Drawing.Size(25, 25);
            this.txtGymTimes.TabIndex = 22;
            // 
            // txtGymFrequencyNum
            // 
            this.txtGymFrequencyNum.Location = new System.Drawing.Point(4, 8);
            this.txtGymFrequencyNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtGymFrequencyNum.Name = "txtGymFrequencyNum";
            this.txtGymFrequencyNum.Size = new System.Drawing.Size(25, 25);
            this.txtGymFrequencyNum.TabIndex = 21;
            // 
            // combGymFrequencyUnit
            // 
            this.combGymFrequencyUnit.BackColor = System.Drawing.Color.White;
            this.combGymFrequencyUnit.FormattingEnabled = true;
            this.combGymFrequencyUnit.Location = new System.Drawing.Point(37, 8);
            this.combGymFrequencyUnit.Margin = new System.Windows.Forms.Padding(4);
            this.combGymFrequencyUnit.Name = "combGymFrequencyUnit";
            this.combGymFrequencyUnit.Size = new System.Drawing.Size(49, 23);
            this.combGymFrequencyUnit.TabIndex = 20;
            // 
            // rbtnGymCustom
            // 
            this.rbtnGymCustom.AutoSize = true;
            this.rbtnGymCustom.Location = new System.Drawing.Point(127, 184);
            this.rbtnGymCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnGymCustom.Name = "rbtnGymCustom";
            this.rbtnGymCustom.Size = new System.Drawing.Size(73, 19);
            this.rbtnGymCustom.TabIndex = 8;
            this.rbtnGymCustom.TabStop = true;
            this.rbtnGymCustom.Text = "自定义";
            this.rbtnGymCustom.UseVisualStyleBackColor = true;
            this.rbtnGymCustom.CheckedChanged += new System.EventHandler(this.rbtnGym_CheckedChanged);
            // 
            // rbtnGymEveryDay
            // 
            this.rbtnGymEveryDay.AutoSize = true;
            this.rbtnGymEveryDay.Location = new System.Drawing.Point(127, 159);
            this.rbtnGymEveryDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnGymEveryDay.Name = "rbtnGymEveryDay";
            this.rbtnGymEveryDay.Size = new System.Drawing.Size(58, 19);
            this.rbtnGymEveryDay.TabIndex = 7;
            this.rbtnGymEveryDay.TabStop = true;
            this.rbtnGymEveryDay.Text = "每天";
            this.rbtnGymEveryDay.UseVisualStyleBackColor = true;
            this.rbtnGymEveryDay.CheckedChanged += new System.EventHandler(this.rbtnGym_CheckedChanged);
            // 
            // rbtnGymOnlyOnce
            // 
            this.rbtnGymOnlyOnce.AutoSize = true;
            this.rbtnGymOnlyOnce.Location = new System.Drawing.Point(127, 134);
            this.rbtnGymOnlyOnce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnGymOnlyOnce.Name = "rbtnGymOnlyOnce";
            this.rbtnGymOnlyOnce.Size = new System.Drawing.Size(73, 19);
            this.rbtnGymOnlyOnce.TabIndex = 6;
            this.rbtnGymOnlyOnce.TabStop = true;
            this.rbtnGymOnlyOnce.Text = "只一次";
            this.rbtnGymOnlyOnce.UseVisualStyleBackColor = true;
            this.rbtnGymOnlyOnce.CheckedChanged += new System.EventHandler(this.rbtnGym_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "计划频次：";
            // 
            // picGymSub
            // 
            this.picGymSub.Image = ((System.Drawing.Image)(resources.GetObject("picGymSub.Image")));
            this.picGymSub.Location = new System.Drawing.Point(515, 262);
            this.picGymSub.Margin = new System.Windows.Forms.Padding(4);
            this.picGymSub.Name = "picGymSub";
            this.picGymSub.Size = new System.Drawing.Size(19, 15);
            this.picGymSub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGymSub.TabIndex = 3;
            this.picGymSub.TabStop = false;
            this.picGymSub.Click += new System.EventHandler(this.picGymSub_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "计划分支：";
            // 
            // txtGymNote
            // 
            this.txtGymNote.Location = new System.Drawing.Point(127, 74);
            this.txtGymNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGymNote.Multiline = true;
            this.txtGymNote.Name = "txtGymNote";
            this.txtGymNote.Size = new System.Drawing.Size(407, 50);
            this.txtGymNote.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "计划说明：";
            // 
            // txtGymName
            // 
            this.txtGymName.Location = new System.Drawing.Point(127, 36);
            this.txtGymName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGymName.Name = "txtGymName";
            this.txtGymName.Size = new System.Drawing.Size(407, 25);
            this.txtGymName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "计划名称：";
            // 
            // tabReading
            // 
            this.tabReading.Controls.Add(this.dgvReading);
            this.tabReading.Controls.Add(this.lblReadingType);
            this.tabReading.Controls.Add(this.comboxReadingType);
            this.tabReading.Controls.Add(this.label12);
            this.tabReading.Controls.Add(this.dtpickReadingStart);
            this.tabReading.Controls.Add(this.label17);
            this.tabReading.Controls.Add(this.btnReadingSave);
            this.tabReading.Controls.Add(this.btnReadingReset);
            this.tabReading.Controls.Add(this.listboxReadingSub);
            this.tabReading.Controls.Add(this.txtReadingSubName);
            this.tabReading.Controls.Add(this.picReadingSub);
            this.tabReading.Controls.Add(this.label18);
            this.tabReading.Controls.Add(this.txtReadingNote);
            this.tabReading.Controls.Add(this.label19);
            this.tabReading.Controls.Add(this.txtReadingName);
            this.tabReading.Controls.Add(this.label20);
            this.tabReading.Location = new System.Drawing.Point(4, 25);
            this.tabReading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabReading.Name = "tabReading";
            this.tabReading.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabReading.Size = new System.Drawing.Size(595, 661);
            this.tabReading.TabIndex = 2;
            this.tabReading.Text = "阅读";
            this.tabReading.UseVisualStyleBackColor = true;
            // 
            // dgvReading
            // 
            this.dgvReading.AllowUserToAddRows = false;
            this.dgvReading.AllowUserToDeleteRows = false;
            this.dgvReading.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvReading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReading.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvReading.Location = new System.Drawing.Point(6, 450);
            this.dgvReading.Name = "dgvReading";
            this.dgvReading.ReadOnly = true;
            this.dgvReading.RowHeadersWidth = 75;
            this.dgvReading.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReading.RowTemplate.Height = 27;
            this.dgvReading.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReading.Size = new System.Drawing.Size(583, 206);
            this.dgvReading.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "序号";
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "序号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "名称";
            this.dataGridViewTextBoxColumn5.HeaderText = "名称";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 370;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "优先级";
            this.dataGridViewTextBoxColumn6.HeaderText = "优先级";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblReadingType
            // 
            this.lblReadingType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReadingType.ForeColor = System.Drawing.Color.Blue;
            this.lblReadingType.Location = new System.Drawing.Point(127, 206);
            this.lblReadingType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReadingType.Name = "lblReadingType";
            this.lblReadingType.Size = new System.Drawing.Size(407, 39);
            this.lblReadingType.TabIndex = 54;
            this.lblReadingType.Text = "lblReadingTypeMsg";
            // 
            // comboxReadingType
            // 
            this.comboxReadingType.FormattingEnabled = true;
            this.comboxReadingType.Location = new System.Drawing.Point(127, 172);
            this.comboxReadingType.Margin = new System.Windows.Forms.Padding(4);
            this.comboxReadingType.Name = "comboxReadingType";
            this.comboxReadingType.Size = new System.Drawing.Size(183, 23);
            this.comboxReadingType.TabIndex = 53;
            this.comboxReadingType.SelectedIndexChanged += new System.EventHandler(this.comboxReadingType_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 52;
            this.label12.Text = "阅读类型：";
            // 
            // dtpickReadingStart
            // 
            this.dtpickReadingStart.AccessibleDescription = "";
            this.dtpickReadingStart.Location = new System.Drawing.Point(127, 129);
            this.dtpickReadingStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpickReadingStart.Name = "dtpickReadingStart";
            this.dtpickReadingStart.Size = new System.Drawing.Size(183, 25);
            this.dtpickReadingStart.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 15);
            this.label17.TabIndex = 50;
            this.label17.Text = "开始日期：";
            // 
            // btnReadingSave
            // 
            this.btnReadingSave.Location = new System.Drawing.Point(300, 410);
            this.btnReadingSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadingSave.Name = "btnReadingSave";
            this.btnReadingSave.Size = new System.Drawing.Size(73, 25);
            this.btnReadingSave.TabIndex = 49;
            this.btnReadingSave.Text = "保存";
            this.btnReadingSave.UseVisualStyleBackColor = true;
            this.btnReadingSave.Click += new System.EventHandler(this.btnReadingSave_Click);
            // 
            // btnReadingReset
            // 
            this.btnReadingReset.Location = new System.Drawing.Point(220, 410);
            this.btnReadingReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadingReset.Name = "btnReadingReset";
            this.btnReadingReset.Size = new System.Drawing.Size(73, 25);
            this.btnReadingReset.TabIndex = 48;
            this.btnReadingReset.Text = "重置";
            this.btnReadingReset.UseVisualStyleBackColor = true;
            this.btnReadingReset.Click += new System.EventHandler(this.btnReadingReset_Click);
            // 
            // listboxReadingSub
            // 
            this.listboxReadingSub.FormattingEnabled = true;
            this.listboxReadingSub.ItemHeight = 15;
            this.listboxReadingSub.Location = new System.Drawing.Point(127, 300);
            this.listboxReadingSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listboxReadingSub.Name = "listboxReadingSub";
            this.listboxReadingSub.Size = new System.Drawing.Size(407, 94);
            this.listboxReadingSub.TabIndex = 47;
            // 
            // txtReadingSubName
            // 
            this.txtReadingSubName.Location = new System.Drawing.Point(127, 259);
            this.txtReadingSubName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReadingSubName.Name = "txtReadingSubName";
            this.txtReadingSubName.Size = new System.Drawing.Size(380, 25);
            this.txtReadingSubName.TabIndex = 46;
            // 
            // picReadingSub
            // 
            this.picReadingSub.Image = ((System.Drawing.Image)(resources.GetObject("picReadingSub.Image")));
            this.picReadingSub.Location = new System.Drawing.Point(515, 262);
            this.picReadingSub.Margin = new System.Windows.Forms.Padding(4);
            this.picReadingSub.Name = "picReadingSub";
            this.picReadingSub.Size = new System.Drawing.Size(19, 15);
            this.picReadingSub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReadingSub.TabIndex = 44;
            this.picReadingSub.TabStop = false;
            this.picReadingSub.Click += new System.EventHandler(this.picReadingSub_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 262);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 15);
            this.label18.TabIndex = 45;
            this.label18.Text = "阅读书目：";
            // 
            // txtReadingNote
            // 
            this.txtReadingNote.Location = new System.Drawing.Point(127, 74);
            this.txtReadingNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReadingNote.Multiline = true;
            this.txtReadingNote.Name = "txtReadingNote";
            this.txtReadingNote.Size = new System.Drawing.Size(407, 50);
            this.txtReadingNote.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(39, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 15);
            this.label19.TabIndex = 42;
            this.label19.Text = "阅读说明：";
            // 
            // txtReadingName
            // 
            this.txtReadingName.Location = new System.Drawing.Point(127, 36);
            this.txtReadingName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReadingName.Name = "txtReadingName";
            this.txtReadingName.Size = new System.Drawing.Size(407, 25);
            this.txtReadingName.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 15);
            this.label20.TabIndex = 40;
            this.label20.Text = "阅读计划：";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(595, 661);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "饮食";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(595, 661);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "作息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(7, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 205);
            this.panel1.TabIndex = 40;
            // 
            // SchedulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 712);
            this.Controls.Add(this.tabs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SchedulesForm";
            this.Text = "SchedulesForm";
            this.Load += new System.EventHandler(this.SchedulesForm_Load);
            this.tabs.ResumeLayout(false);
            this.tabWork.ResumeLayout(false);
            this.tabWork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkSub)).EndInit();
            this.tabGym.ResumeLayout(false);
            this.tabGym.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGym)).EndInit();
            this.panelGymCustom.ResumeLayout(false);
            this.panelGymCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGymSub)).EndInit();
            this.tabReading.ResumeLayout(false);
            this.tabReading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReadingSub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabWork;
        private System.Windows.Forms.TabPage tabGym;
        private System.Windows.Forms.TabPage tabReading;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtGymName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGymNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picGymSub;
        private System.Windows.Forms.RadioButton rbtnGymCustom;
        private System.Windows.Forms.RadioButton rbtnGymEveryDay;
        private System.Windows.Forms.RadioButton rbtnGymOnlyOnce;
        private System.Windows.Forms.Panel panelGymCustom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGymTimes;
        private System.Windows.Forms.TextBox txtGymFrequencyNum;
        private System.Windows.Forms.ComboBox combGymFrequencyUnit;
        private System.Windows.Forms.Button btnGymReset;
        private System.Windows.Forms.ListBox listboxGymSub;
        private System.Windows.Forms.TextBox txtGymSubName;
        private System.Windows.Forms.Button btnGymSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpickGymStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckbGymIgnorePeriod;
        private System.Windows.Forms.DateTimePicker dtpickWorkDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnWorkSave;
        private System.Windows.Forms.Button btnWorkReset;
        private System.Windows.Forms.ListBox listboxWorkSub;
        private System.Windows.Forms.TextBox txtWorkSubName;
        private System.Windows.Forms.PictureBox picWorkSub;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtWorkNote;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtWorkName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpickWorkTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbtnWorkPriorityUrgent;
        private System.Windows.Forms.RadioButton rbtnWorkPriorityHigh;
        private System.Windows.Forms.RadioButton rbtnWorkPriorityNormal;
        private System.Windows.Forms.DateTimePicker dtpickReadingStart;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnReadingSave;
        private System.Windows.Forms.Button btnReadingReset;
        private System.Windows.Forms.ListBox listboxReadingSub;
        private System.Windows.Forms.TextBox txtReadingSubName;
        private System.Windows.Forms.PictureBox picReadingSub;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtReadingNote;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtReadingName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboxReadingType;
        private System.Windows.Forms.Label lblReadingType;
        private System.Windows.Forms.DataGridView dgvGym;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgvReading;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel1;
    }
}