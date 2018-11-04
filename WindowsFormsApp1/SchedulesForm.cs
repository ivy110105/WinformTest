using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SchedulesForm : Form
    {
        public SchedulesForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            Schedule form = new Schedule();
            Common.OpenNewForm(form);
        }
    }
}
