using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            init();
            lblInit.Select();
        }

        private void init()
        {
            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;
            var day = DateTime.Now.Day;

            combYear.DataSource = Common.Years();
            combYear.Text = year.ToString();

            combMonth.DataSource = Common.Monthes();
            combMonth.Text = month.ToString();

            combDays.DataSource = Common.Days(year, month);
            combDays.Text = day.ToString();
        }

        private void lblInit_Click(object sender, EventArgs e)
        {
            SchedulesForm form = new SchedulesForm();
            Common.OpenNewForm(form);
        }
    }
}
