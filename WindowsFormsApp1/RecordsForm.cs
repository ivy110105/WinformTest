using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1
{
    public partial class RecordsForm : Form
    {
        public RecordsForm()
        {
            InitializeComponent();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            Record form = new Record();
            Common.OpenNewForm(form);
        }

        private void lnklblToDoList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToDoList form = new ToDoList();
            Common.OpenNewForm(form);
        }

        private void RecordsForm_Load(object sender, EventArgs e)
        {
            bind();
        }

        private void bind()
        {
            // All Schedules
            var scheduleList = ScheduleAdapter.Query("AND FrequencyType<>'Only Once'");
            // All Records
            var recordList =new List<Model.Record>();

            #region ToDoList bind
            scheduleList.ForEach(x =>
            {
                var status = recordList.Exists(y => y.ScheduleID != null && y.ScheduleID == x.ID)
                ? (recordList.FirstOrDefault(y => y.ScheduleID == x.ID).Status)
                : 0;

                var statusname = status == 1 ? "Done" : (status == 2 ? "Fail":"");

                var frequenctytype = string.Empty;
                switch (x.FrequencyType)
                {
                    case "Custom":
                        frequenctytype = x.FrequencyTimes.ToString() + " Times " + x.FrequencyCycleNum.ToString() + " " + x.FrequencyCycleUnit;
                        break;
                    default:
                        frequenctytype = x.FrequencyType;
                        break;
                }

                ListViewItem lvitem = new ListViewItem();
                lvitem.Name = x.Name;
                lvitem.SubItems.Add(frequenctytype);
                lvitem.SubItems.Add(statusname);

                lvToDoList.Items.Add(lvitem);
            });
            #endregion

            #region OtherRecord bind
            // 获取当天的所有记录
            #endregion

        }
    }
}
