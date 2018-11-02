namespace WindowsFormsApp1
{
    partial class RecordsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.lnklblToDoList = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ToDoList";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Others";
            // 
            // picAdd
            // 
            this.picAdd.Image = ((System.Drawing.Image)(resources.GetObject("picAdd.Image")));
            this.picAdd.Location = new System.Drawing.Point(90, 213);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(14, 12);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdd.TabIndex = 3;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // lnklblToDoList
            // 
            this.lnklblToDoList.AutoSize = true;
            this.lnklblToDoList.Location = new System.Drawing.Point(196, 26);
            this.lnklblToDoList.Name = "lnklblToDoList";
            this.lnklblToDoList.Size = new System.Drawing.Size(107, 12);
            this.lnklblToDoList.TabIndex = 4;
            this.lnklblToDoList.TabStop = true;
            this.lnklblToDoList.Text = "forgot to record?";
            this.lnklblToDoList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblToDoList_LinkClicked);
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 407);
            this.Controls.Add(this.lnklblToDoList);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecordsForm";
            this.Text = "RecordsForm";
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.LinkLabel lnklblToDoList;
    }
}