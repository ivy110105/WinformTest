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
    }
}
