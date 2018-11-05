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
            this.rbtnCustom = new System.Windows.Forms.RadioButton();
            this.panelCustom = new System.Windows.Forms.Panel();
            this.txtFrequencyNum = new System.Windows.Forms.TextBox();
            this.combFrequencyUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimes = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtnOnlyOnce = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpickStart = new System.Windows.Forms.DateTimePicker();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.panelCustom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Circle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 21);
            this.txtName.TabIndex = 3;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(58, 59);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(198, 49);
            this.txtNote.TabIndex = 4;
            // 
            // rbtnCustom
            // 
            this.rbtnCustom.AutoSize = true;
            this.rbtnCustom.Location = new System.Drawing.Point(58, 200);
            this.rbtnCustom.Name = "rbtnCustom";
            this.rbtnCustom.Size = new System.Drawing.Size(59, 16);
            this.rbtnCustom.TabIndex = 10;
            this.rbtnCustom.TabStop = true;
            this.rbtnCustom.Text = "Custom";
            this.rbtnCustom.UseVisualStyleBackColor = true;
            this.rbtnCustom.CheckedChanged += new System.EventHandler(this.rbtnCustom_CheckedChanged);
            // 
            // panelCustom
            // 
            this.panelCustom.Controls.Add(this.txtFrequencyNum);
            this.panelCustom.Controls.Add(this.combFrequencyUnit);
            this.panelCustom.Controls.Add(this.label6);
            this.panelCustom.Controls.Add(this.txtTimes);
            this.panelCustom.Location = new System.Drawing.Point(58, 222);
            this.panelCustom.Name = "panelCustom";
            this.panelCustom.Size = new System.Drawing.Size(198, 31);
            this.panelCustom.TabIndex = 11;
            this.panelCustom.Visible = false;
            // 
            // txtFrequencyNum
            // 
            this.txtFrequencyNum.Location = new System.Drawing.Point(82, 3);
            this.txtFrequencyNum.Name = "txtFrequencyNum";
            this.txtFrequencyNum.Size = new System.Drawing.Size(20, 21);
            this.txtFrequencyNum.TabIndex = 17;
            this.txtFrequencyNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // combFrequencyUnit
            // 
            this.combFrequencyUnit.BackColor = System.Drawing.Color.White;
            this.combFrequencyUnit.FormattingEnabled = true;
            this.combFrequencyUnit.Location = new System.Drawing.Point(108, 3);
            this.combFrequencyUnit.Name = "combFrequencyUnit";
            this.combFrequencyUnit.Size = new System.Drawing.Size(87, 20);
            this.combFrequencyUnit.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "Times";
            // 
            // txtTimes
            // 
            this.txtTimes.Location = new System.Drawing.Point(17, 3);
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.Size = new System.Drawing.Size(20, 21);
            this.txtTimes.TabIndex = 14;
            this.txtTimes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(243, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add New Schedule";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnOnlyOnce
            // 
            this.rbtnOnlyOnce.AutoSize = true;
            this.rbtnOnlyOnce.Location = new System.Drawing.Point(58, 156);
            this.rbtnOnlyOnce.Name = "rbtnOnlyOnce";
            this.rbtnOnlyOnce.Size = new System.Drawing.Size(77, 16);
            this.rbtnOnlyOnce.TabIndex = 13;
            this.rbtnOnlyOnce.TabStop = true;
            this.rbtnOnlyOnce.Text = "Only Once";
            this.rbtnOnlyOnce.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "Start";
            // 
            // dtpickStart
            // 
            this.dtpickStart.CustomFormat = "yyyy-MM-dd";
            this.dtpickStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickStart.Location = new System.Drawing.Point(58, 123);
            this.dtpickStart.Name = "dtpickStart";
            this.dtpickStart.Size = new System.Drawing.Size(198, 21);
            this.dtpickStart.TabIndex = 15;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Location = new System.Drawing.Point(58, 178);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(77, 16);
            this.rbtnDay.TabIndex = 6;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "Every Day";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 330);
            this.Controls.Add(this.dtpickStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtnOnlyOnce);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelCustom);
            this.Controls.Add(this.rbtnCustom);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.RadioButton rbtnCustom;
        private System.Windows.Forms.Panel panelCustom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbtnOnlyOnce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpickStart;
        private System.Windows.Forms.ComboBox combFrequencyUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimes;
        private System.Windows.Forms.TextBox txtFrequencyNum;
        private System.Windows.Forms.RadioButton rbtnDay;
    }
}