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
    public partial class SchedulesForm : Form
    {
        public SchedulesForm()
        {
            InitializeComponent();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            Schedule form = new Schedule();
            Common.OpenNewForm(form);
        }
    }
}
