namespace WindowsFormsApp1
{
    partial class IndexForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCharts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(34, 56);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(247, 47);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "Schedules";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.Location = new System.Drawing.Point(34, 143);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(247, 47);
            this.btnRecords.TabIndex = 1;
            this.btnRecords.Text = "Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(34, 229);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(247, 47);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCharts
            // 
            this.btnCharts.Location = new System.Drawing.Point(34, 322);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(247, 47);
            this.btnCharts.TabIndex = 3;
            this.btnCharts.Text = "Charts";
            this.btnCharts.UseVisualStyleBackColor = true;
            this.btnCharts.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCharts);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.btnSchedule);
            this.Name = "IndexForm";
            this.Text = "IndexForm";
            this.Load += new System.EventHandler(this.IndexForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCharts;
        private System.Windows.Forms.Label label1;
    }
}

