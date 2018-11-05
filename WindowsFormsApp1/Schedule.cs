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
            combFrequencyUnit.DataSource = Common.RepeatUnit();
            rbtnOnlyOnce.Checked = true;
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
            int times = 0; int cyclenum = 0;string cycleunit = string.Empty;
            var type= getFrequencyInfo(ref times,ref cyclenum, ref cycleunit);
            var model = new Model.Schedule();
            model.Name = txtName.Text;
            model.Note = txtNote.Text;
            model.FrequencyType = type;
            model.StartDate = Convert.ToDateTime(dtpickStart.Text);
            //model.EndDate = Convert.ToDateTime("1900-01-01 00:00:00");
            model.FrequencyTimes = times;
            model.FrequencyCycleNum = cyclenum;
            model.FrequencyCycleUnit = cycleunit;
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

        private string getFrequencyInfo(ref int times,ref int cyclenum, ref string cycleunit)
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
                                cyclenum = Convert.ToInt32(txtFrequencyNum.Text);
                                cycleunit = combFrequencyUnit.Text;
                                str = txtTimes.Text + " Times " + txtFrequencyNum.Text + " " + combFrequencyUnit.Text;
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
    }
}
