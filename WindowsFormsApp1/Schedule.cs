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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
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

        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            combUnit.DataSource = Common.RepeatUnit();
            combFrequencyUnit.DataSource = Common.RepeatUnit();
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
    }
}
