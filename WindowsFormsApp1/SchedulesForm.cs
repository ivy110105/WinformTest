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
            initGym();
            initReading();
        }

        #region 工作

        private void picWorkSub_Click(object sender, EventArgs e)
        {
            var index = listboxWorkSub.Items.Count + 1;
            listboxWorkSub.Items.Add(index.ToString() + ". " + txtWorkSubName.Text);
            txtWorkSubName.Text = string.Empty;
            txtWorkSubName.Focus();
        }
        private void btnWorkReset_Click(object sender, EventArgs e)
        {
            txtWorkName.Text = string.Empty;
            txtWorkNote.Text = string.Empty;
            txtWorkSubName.Text = string.Empty;
            dtpickWorkDate.Text = DateTime.Now.ToString();
            dtpickWorkTime.Text = DateTime.Now.ToString();
            listboxWorkSub.Items.Clear();
            rbtnWorkPriorityUrgent.Checked = false;
            rbtnWorkPriorityHigh.Checked = false;
            rbtnWorkPriorityNormal.Checked = false;
        }
        private void btnWorkSave_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 健身

        private void initGym()
        { panelGymCustom.Visible = false; }
        private void rbtnGym_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Text)
            {
                case "自定义":
                    panelGymCustom.Visible = true;
                    break;
                default:
                    panelGymCustom.Visible = false;
                    break;
            }
        }
        private void picGymSub_Click(object sender, EventArgs e)
        {
            var index = listboxGymSub.Items.Count + 1;
            listboxGymSub.Items.Add(index.ToString() + ". " + txtGymSubName.Text);
            txtGymSubName.Text = string.Empty;
            txtGymSubName.Focus();
        }
        private void btnGymReset_Click(object sender, EventArgs e)
        {
            txtGymName.Text = string.Empty;
            txtGymNote.Text = string.Empty;
            txtGymFrequencyNum.Text = string.Empty;
            txtGymSubName.Text = string.Empty;
            txtGymTimes.Text = string.Empty;
            ckbGymIgnorePeriod.Checked = false;
            dtpickGymStart.Text = DateTime.Now.ToString();
            listboxGymSub.Items.Clear();
            rbtnGymOnlyOnce.Checked = false;
            rbtnGymEveryDay.Checked = false;
            rbtnGymCustom.Checked = false;
            panelGymCustom.Visible = false;
        }
        private void btnGymSave_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 阅读

        private void initReading()
        {
            comboxReadingType.DataSource = Common.ReadingType();
        }
        private void comboxReadingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = ((ComboBox)sender).Text;
            switch (text)
            {
                case "工作需求":
                    lblReadingType.Text = "在职场或者在生活当中需要去学习去一直掌握的技能，这样你才有足够的力气和能量。";
                    break;
                case "陶冶情操":
                    lblReadingType.Text = "经典的名著，历史文学哲学等属于精神类的书籍，能够陶冶我们的情操，让人格得到锻炼和塑造。";
                    break;
                case "消磨时光":
                    lblReadingType.Text = "网络小说、神仙穿越、期刊杂志等，当然你也能从中获取你想要的东西，只是一般相对较少。";
                    break;
            }
            lblReadingType.Select();
        }
        private void picReadingSub_Click(object sender, EventArgs e)
        {
            var index = listboxReadingSub.Items.Count + 1;
            listboxReadingSub.Items.Add(index.ToString() + ". " + txtReadingSubName.Text);
            txtReadingSubName.Text = string.Empty;
            txtReadingSubName.Focus();
        }
        private void btnReadingReset_Click(object sender, EventArgs e)
        {
            txtReadingName.Text = string.Empty;
            txtReadingNote.Text = string.Empty;
            txtReadingSubName.Text = string.Empty;
            listboxReadingSub.Items.Clear();
            dtpickReadingStart.Text = DateTime.Now.ToString();
            comboxReadingType.SelectedIndex = 0;
        }
        private void btnReadingSave_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 饮食

        #endregion

        #region 作息

        #endregion

    }
}
