namespace WindowsFormsApp1
{
    partial class ToDoList
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
            this.combYear = new System.Windows.Forms.ComboBox();
            this.combMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combDays = new System.Windows.Forms.ComboBox();
            this.lblInit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combYear
            // 
            this.combYear.FormattingEnabled = true;
            this.combYear.Location = new System.Drawing.Point(81, 38);
            this.combYear.Name = "combYear";
            this.combYear.Size = new System.Drawing.Size(76, 23);
            this.combYear.TabIndex = 0;
            // 
            // combMonth
            // 
            this.combMonth.FormattingEnabled = true;
            this.combMonth.Location = new System.Drawing.Point(239, 38);
            this.combMonth.Name = "combMonth";
            this.combMonth.Size = new System.Drawing.Size(75, 23);
            this.combMonth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "年份：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "月份：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "日期：";
            // 
            // combDays
            // 
            this.combDays.FormattingEnabled = true;
            this.combDays.Location = new System.Drawing.Point(397, 38);
            this.combDays.Name = "combDays";
            this.combDays.Size = new System.Drawing.Size(75, 23);
            this.combDays.TabIndex = 4;
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.Location = new System.Drawing.Point(181, 322);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(142, 15);
            this.lblInit.TabIndex = 6;
            this.lblInit.Text = "还没有计划？去安排";
            this.lblInit.Click += new System.EventHandler(this.lblInit_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 691);
            this.Controls.Add(this.lblInit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combMonth);
            this.Controls.Add(this.combYear);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ToDoList";
            this.Text = "待办事项";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combYear;
        private System.Windows.Forms.ComboBox combMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combDays;
        private System.Windows.Forms.Label lblInit;
    }
}