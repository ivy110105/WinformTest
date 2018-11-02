using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            switch (((Button)sender).Text)
            {
                case "Schedules":
                    form = new SchedulesForm();                    
                    break;
                case "Records":
                    form = new RecordsForm();
                    break;
                case "Settings":
                    form = new SettingsForm();
                    break;
                case "Charts":
                    form = new ChartsForm();
                    break;
            }
           Common.OpenNewForm(form);
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("HH:mm:ss.fff");
            Timer timer1 = new Timer();
            timer1.Interval = 5000;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1EventProcessor);//添加事件
        }
        public void timer1EventProcessor(object source, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("HH:mm:ss.fff");
            Common.ClearMemory();
        }
    }
}
