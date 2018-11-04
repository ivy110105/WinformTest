namespace WindowsFormsApp1
{
    partial class Schedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.rbtnWeek = new System.Windows.Forms.RadioButton();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.rbtnCustom = new System.Windows.Forms.RadioButton();
            this.panelCustom = new System.Windows.Forms.Panel();
            this.rbtnCustomFrequency = new System.Windows.Forms.RadioButton();
            this.rbtnCustomRepeat = new System.Windows.Forms.RadioButton();
            this.txtFrequencyNum = new System.Windows.Forms.TextBox();
            this.combFrequencyUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimes = new System.Windows.Forms.TextBox();
            this.combUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtnNeverRepeat = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpickStart = new System.Windows.Forms.DateTimePicker();
            this.panelCustom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Repeat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 30);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 25);
            this.txtName.TabIndex = 3;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(77, 74);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(263, 60);
            this.txtNote.TabIndex = 4;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Location = new System.Drawing.Point(77, 225);
            this.rbtnDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(100, 19);
            this.rbtnDay.TabIndex = 6;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Every Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // rbtnWeek
            // 
            this.rbtnWeek.AutoSize = true;
            this.rbtnWeek.Location = new System.Drawing.Point(77, 252);
            this.rbtnWeek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnWeek.Name = "rbtnWeek";
            this.rbtnWeek.Size = new System.Drawing.Size(108, 19);
            this.rbtnWeek.TabIndex = 7;
            this.rbtnWeek.TabStop = true;
            this.rbtnWeek.Text = "Every Week";
            this.rbtnWeek.UseVisualStyleBackColor = true;
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Location = new System.Drawing.Point(77, 280);
            this.rbtnMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(116, 19);
            this.rbtnMonth.TabIndex = 8;
            this.rbtnMonth.TabStop = true;
            this.rbtnMonth.Text = "Every Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Location = new System.Drawing.Point(77, 308);
            this.rbtnYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(108, 19);
            this.rbtnYear.TabIndex = 9;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Every Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            // 
            // rbtnCustom
            // 
            this.rbtnCustom.AutoSize = true;
            this.rbtnCustom.Location = new System.Drawing.Point(77, 335);
            this.rbtnCustom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnCustom.Name = "rbtnCustom";
            this.rbtnCustom.Size = new System.Drawing.Size(100, 19);
            this.rbtnCustom.TabIndex = 10;
            this.rbtnCustom.TabStop = true;
            this.rbtnCustom.Text = "Custom...";
            this.rbtnCustom.UseVisualStyleBackColor = true;
            this.rbtnCustom.CheckedChanged += new System.EventHandler(this.rbtnCustom_CheckedChanged);
            // 
            // panelCustom
            // 
            this.panelCustom.Controls.Add(this.rbtnCustomFrequency);
            this.panelCustom.Controls.Add(this.rbtnCustomRepeat);
            this.panelCustom.Controls.Add(this.txtFrequencyNum);
            this.panelCustom.Controls.Add(this.combFrequencyUnit);
            this.panelCustom.Controls.Add(this.label6);
            this.panelCustom.Controls.Add(this.txtTimes);
            this.panelCustom.Controls.Add(this.combUnit);
            this.panelCustom.Controls.Add(this.label4);
            this.panelCustom.Controls.Add(this.txtCustom);
            this.panelCustom.Location = new System.Drawing.Point(73, 354);
            this.panelCustom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCustom.Name = "panelCustom";
            this.panelCustom.Size = new System.Drawing.Size(268, 81);
            this.panelCustom.TabIndex = 11;
            this.panelCustom.Visible = false;
            // 
            // rbtnCustomFrequency
            // 
            this.rbtnCustomFrequency.AutoSize = true;
            this.rbtnCustomFrequency.Location = new System.Drawing.Point(25, 51);
            this.rbtnCustomFrequency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnCustomFrequency.Name = "rbtnCustomFrequency";
            this.rbtnCustomFrequency.Size = new System.Drawing.Size(17, 16);
            this.rbtnCustomFrequency.TabIndex = 18;
            this.rbtnCustomFrequency.TabStop = true;
            this.rbtnCustomFrequency.UseVisualStyleBackColor = true;
            // 
            // rbtnCustomRepeat
            // 
            this.rbtnCustomRepeat.AutoSize = true;
            this.rbtnCustomRepeat.Location = new System.Drawing.Point(25, 18);
            this.rbtnCustomRepeat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnCustomRepeat.Name = "rbtnCustomRepeat";
            this.rbtnCustomRepeat.Size = new System.Drawing.Size(17, 16);
            this.rbtnCustomRepeat.TabIndex = 16;
            this.rbtnCustomRepeat.TabStop = true;
            this.rbtnCustomRepeat.UseVisualStyleBackColor = true;
            // 
            // txtFrequencyNum
            // 
            this.txtFrequencyNum.Location = new System.Drawing.Point(139, 46);
            this.txtFrequencyNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFrequencyNum.Name = "txtFrequencyNum";
            this.txtFrequencyNum.Size = new System.Drawing.Size(25, 25);
            this.txtFrequencyNum.TabIndex = 17;
            this.txtFrequencyNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // combFrequencyUnit
            // 
            this.combFrequencyUnit.BackColor = System.Drawing.Color.White;
            this.combFrequencyUnit.FormattingEnabled = true;
            this.combFrequencyUnit.Location = new System.Drawing.Point(173, 46);
            this.combFrequencyUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combFrequencyUnit.Name = "combFrequencyUnit";
            this.combFrequencyUnit.Size = new System.Drawing.Size(93, 23);
            this.combFrequencyUnit.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Times";
            // 
            // txtTimes
            // 
            this.txtTimes.Location = new System.Drawing.Point(52, 46);
            this.txtTimes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.Size = new System.Drawing.Size(25, 25);
            this.txtTimes.TabIndex = 14;
            this.txtTimes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // combUnit
            // 
            this.combUnit.BackColor = System.Drawing.Color.White;
            this.combUnit.FormattingEnabled = true;
            this.combUnit.Location = new System.Drawing.Point(159, 14);
            this.combUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combUnit.Name = "combUnit";
            this.combUnit.Size = new System.Drawing.Size(108, 23);
            this.combUnit.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Every";
            // 
            // txtCustom
            // 
            this.txtCustom.Location = new System.Drawing.Point(107, 14);
            this.txtCustom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.Size = new System.Drawing.Size(43, 25);
            this.txtCustom.TabIndex = 12;
            this.txtCustom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 462);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(324, 38);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add New Schedule";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnNeverRepeat
            // 
            this.rbtnNeverRepeat.AutoSize = true;
            this.rbtnNeverRepeat.Location = new System.Drawing.Point(77, 198);
            this.rbtnNeverRepeat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnNeverRepeat.Name = "rbtnNeverRepeat";
            this.rbtnNeverRepeat.Size = new System.Drawing.Size(124, 19);
            this.rbtnNeverRepeat.TabIndex = 13;
            this.rbtnNeverRepeat.TabStop = true;
            this.rbtnNeverRepeat.Text = "Nerer Repeat";
            this.rbtnNeverRepeat.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Start";
            // 
            // dtpickStart
            // 
            this.dtpickStart.CustomFormat = "yyyy-MM-dd";
            this.dtpickStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickStart.Location = new System.Drawing.Point(77, 154);
            this.dtpickStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpickStart.Name = "dtpickStart";
            this.dtpickStart.Size = new System.Drawing.Size(263, 25);
            this.dtpickStart.TabIndex = 15;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 515);
            this.Controls.Add(this.dtpickStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtnNeverRepeat);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelCustom);
            this.Controls.Add(this.rbtnCustom);
            this.Controls.Add(this.rbtnYear);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnWeek);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.panelCustom.ResumeLayout(false);
            this.panelCustom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.RadioButton rbtnWeek;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.RadioButton rbtnCustom;
        private System.Windows.Forms.Panel panelCustom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustom;
        private System.Windows.Forms.ComboBox combUnit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbtnNeverRepeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpickStart;
        private System.Windows.Forms.ComboBox combFrequencyUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimes;
        private System.Windows.Forms.TextBox txtFrequencyNum;
        private System.Windows.Forms.RadioButton rbtnCustomFrequency;
        private System.Windows.Forms.RadioButton rbtnCustomRepeat;
    }
}