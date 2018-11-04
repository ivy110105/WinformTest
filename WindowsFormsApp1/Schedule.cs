using System;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            combUnit.DataSource = Common.RepeatUnit();
            combFrequencyUnit.DataSource = Common.RepeatUnit();
            rbtnNeverRepeat.Checked = true;
        }

        private void rbtnCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCustom.Checked)
            {
                panelCustom.Visible = true;
            }
            else
            {
                panelCustom.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num = 0;string unit = string.Empty;
            var type= getRepeatType(ref num, ref unit);
            int days = getDays(num, unit);
            var model = new Model.Schedule();
            model.Name = txtName.Text;
            model.Note = txtNote.Text;
            model.RepeatType = type;
            model.StartDate = Convert.ToDateTime(dtpickStart.Text);
            model.EndDate = Convert.ToDateTime("1900-01-01 00:00:00");
            model.RepeatNum = num;
            model.RepeatUnit = unit;
            model.RepeatDays = days;
            model.CreatedOn = DateTime.Now;
            model.CreatedBy = "";
            model.ModifedOn = DateTime.Now;
            model.ModifiedBy = "";
            model.Deleted = false;
            var result = ScheduleAdapter.Insert(model);
            if (result)
                MessageBox.Show("Succeed ^_^");
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private string getRepeatType(ref int num,ref string unit)
        {
            var str = string.Empty;
            foreach (Control ctrl in this.Controls)
            {
                //判断类型
                if (ctrl is RadioButton)
                {
                    if (((RadioButton)ctrl).Checked == true)
                    {
                        switch (((RadioButton)ctrl).Text)
                        {
                            case "Custom...":
                                foreach (Control subctrl in panelCustom.Controls)
                                {
                                    if (subctrl is RadioButton)
                                    {
                                        if (((RadioButton)subctrl).Checked)
                                        {
                                            switch (((RadioButton)subctrl).Name)
                                            {
                                                case "rbtnCustomRepeat":
                                                    num = Convert.ToInt32(txtCustom.Text);
                                                    unit = combUnit.Text;
                                                    str = "Every " + num.ToString() + " " + unit;                                                    
                                                    break;
                                                case "rbtnCustomFrequency":
                                                    num = Convert.ToInt32(txtFrequencyNum.Text);
                                                    unit = combFrequencyUnit.Text;
                                                    str = txtTimes.Text + " Times " + txtFrequencyNum.Text + " " + combFrequencyUnit.Text;
                                                    break;
                                            }
                                        }
                                    }
                                }
                                break;
                            default:
                                str= ((RadioButton)ctrl).Text;
                                break;
                        }
                        break;
                    }
                }
            }
            return str;
        }

        private int getDays(int num, string unit)
        {
            int days = 0;
            switch (unit)
            {
                case "days": days = num; break;
                case "weeks": days= num * 7; break;
                case "months": days = num * 30; break;
                case "years": days = num * 365; break;
            }
            return days;
        }
    }
}
