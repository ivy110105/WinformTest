using System;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;

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

        private void SchedulesForm_Load(object sender, EventArgs e)
        {
            //bind();
            init();
        }

        private void bind()
        {
            var list = ScheduleAdapter.Query();

        }

        private void init()
        {
            panelCustom.Visible = false;

        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Text)
            {
                case "自定义":
                    panelCustom.Visible = true;
                    break;
                default:
                    panelCustom.Visible = false;
                    break;
            }
        }
    }
}
