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
            this.label1 = new System.Windows.Forms.Label();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnOnlyOnce = new System.Windows.Forms.RadioButton();
            this.rbtnEveryDay = new System.Windows.Forms.RadioButton();
            this.rbtnCustom = new System.Windows.Forms.RadioButton();
            this.panelCustom = new System.Windows.Forms.Panel();
            this.txtFrequencyNum = new System.Windows.Forms.TextBox();
            this.combFrequencyUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimes = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listboxSub = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.tabs.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCustom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedules";
            // 
            // picAdd
            // 
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(135, 24);
            this.picAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(19, 15);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdd.TabIndex = 1;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tab1);
            this.tabs.Controls.Add(this.tab2);
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Location = new System.Drawing.Point(40, 68);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(602, 615);
            this.tabs.TabIndex = 2;
            // 
            // tab1
            // 
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(890, 586);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "工作";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.checkBox1);
            this.tab2.Controls.Add(this.dateTimePicker1);
            this.tab2.Controls.Add(this.label8);
            this.tab2.Controls.Add(this.button2);
            this.tab2.Controls.Add(this.button1);
            this.tab2.Controls.Add(this.listboxSub);
            this.tab2.Controls.Add(this.textBox3);
            this.tab2.Controls.Add(this.panelCustom);
            this.tab2.Controls.Add(this.rbtnCustom);
            this.tab2.Controls.Add(this.rbtnEveryDay);
            this.tab2.Controls.Add(this.rbtnOnlyOnce);
            this.tab2.Controls.Add(this.label5);
            this.tab2.Controls.Add(this.pictureBox1);
            this.tab2.Controls.Add(this.label4);
            this.tab2.Controls.Add(this.textBox2);
            this.tab2.Controls.Add(this.label3);
            this.tab2.Controls.Add(this.textBox1);
            this.tab2.Controls.Add(this.label2);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(594, 586);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "健身";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(877, 584);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "阅读";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(877, 584);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "饮食";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(877, 584);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "作息";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "计划说明：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 74);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(406, 66);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "计划分支：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(514, 284);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "计划频次：";
            // 
            // rbtnOnlyOnce
            // 
            this.rbtnOnlyOnce.AutoSize = true;
            this.rbtnOnlyOnce.Location = new System.Drawing.Point(127, 155);
            this.rbtnOnlyOnce.Name = "rbtnOnlyOnce";
            this.rbtnOnlyOnce.Size = new System.Drawing.Size(73, 19);
            this.rbtnOnlyOnce.TabIndex = 6;
            this.rbtnOnlyOnce.TabStop = true;
            this.rbtnOnlyOnce.Text = "只一次";
            this.rbtnOnlyOnce.UseVisualStyleBackColor = true;
            this.rbtnOnlyOnce.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnEveryDay
            // 
            this.rbtnEveryDay.AutoSize = true;
            this.rbtnEveryDay.Location = new System.Drawing.Point(127, 180);
            this.rbtnEveryDay.Name = "rbtnEveryDay";
            this.rbtnEveryDay.Size = new System.Drawing.Size(58, 19);
            this.rbtnEveryDay.TabIndex = 7;
            this.rbtnEveryDay.TabStop = true;
            this.rbtnEveryDay.Text = "每天";
            this.rbtnEveryDay.UseVisualStyleBackColor = true;
            this.rbtnEveryDay.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnCustom
            // 
            this.rbtnCustom.AutoSize = true;
            this.rbtnCustom.Location = new System.Drawing.Point(127, 205);
            this.rbtnCustom.Name = "rbtnCustom";
            this.rbtnCustom.Size = new System.Drawing.Size(73, 19);
            this.rbtnCustom.TabIndex = 8;
            this.rbtnCustom.TabStop = true;
            this.rbtnCustom.Text = "自定义";
            this.rbtnCustom.UseVisualStyleBackColor = true;
            this.rbtnCustom.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // panelCustom
            // 
            this.panelCustom.Controls.Add(this.label7);
            this.panelCustom.Controls.Add(this.label6);
            this.panelCustom.Controls.Add(this.txtTimes);
            this.panelCustom.Controls.Add(this.txtFrequencyNum);
            this.panelCustom.Controls.Add(this.combFrequencyUnit);
            this.panelCustom.Location = new System.Drawing.Point(206, 196);
            this.panelCustom.Name = "panelCustom";
            this.panelCustom.Size = new System.Drawing.Size(327, 39);
            this.panelCustom.TabIndex = 9;
            // 
            // txtFrequencyNum
            // 
            this.txtFrequencyNum.Location = new System.Drawing.Point(4, 8);
            this.txtFrequencyNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrequencyNum.Name = "txtFrequencyNum";
            this.txtFrequencyNum.Size = new System.Drawing.Size(25, 25);
            this.txtFrequencyNum.TabIndex = 21;
            // 
            // combFrequencyUnit
            // 
            this.combFrequencyUnit.BackColor = System.Drawing.Color.White;
            this.combFrequencyUnit.FormattingEnabled = true;
            this.combFrequencyUnit.Location = new System.Drawing.Point(37, 8);
            this.combFrequencyUnit.Margin = new System.Windows.Forms.Padding(4);
            this.combFrequencyUnit.Name = "combFrequencyUnit";
            this.combFrequencyUnit.Size = new System.Drawing.Size(50, 23);
            this.combFrequencyUnit.TabIndex = 20;
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
            // txtTimes
            // 
            this.txtTimes.Location = new System.Drawing.Point(95, 8);
            this.txtTimes.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.Size = new System.Drawing.Size(25, 25);
            this.txtTimes.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 281);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(380, 25);
            this.textBox3.TabIndex = 10;
            // 
            // listboxSub
            // 
            this.listboxSub.FormattingEnabled = true;
            this.listboxSub.ItemHeight = 15;
            this.listboxSub.Location = new System.Drawing.Point(127, 324);
            this.listboxSub.Name = "listboxSub";
            this.listboxSub.Size = new System.Drawing.Size(406, 184);
            this.listboxSub.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "重置";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "开始日期：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 25);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(399, 246);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 19);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "自动忽略生理期";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SchedulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 719);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SchedulesForm";
            this.Text = "SchedulesForm";
            this.Load += new System.EventHandler(this.SchedulesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCustom.ResumeLayout(false);
            this.panelCustom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtnCustom;
        private System.Windows.Forms.RadioButton rbtnEveryDay;
        private System.Windows.Forms.RadioButton rbtnOnlyOnce;
        private System.Windows.Forms.Panel panelCustom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimes;
        private System.Windows.Forms.TextBox txtFrequencyNum;
        private System.Windows.Forms.ComboBox combFrequencyUnit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listboxSub;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}