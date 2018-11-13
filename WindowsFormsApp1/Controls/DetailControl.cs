using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controls
{
    /// <summary>
    /// 此类用来定义盛放子DataGridview的容器
    /// </summary>
    [ToolboxItem(false)]
    public partial class DetailControl : Panel
    {
        //public DetailControl()
        //{
        //    InitializeComponent();
        //}

        //public DetailControl(IContainer container)
        //{
        //    container.Add(this);

        //    InitializeComponent();
        //}

        #region 字段
        public List<DataGridView> childGrid = new List<DataGridView>();
        public DataSet _cDataset;
        #endregion

        #region 方法
        public void Add(string tableName, string strPrimaryKey, string strForeignKey)
        {
            //TabPage tPage = new TabPage() { Text = pageCaption };
            //this.Controls.Add(tPage);
            var newGrid = new MasterControl(_cDataset, controlType.middle) { Dock = DockStyle.Fill, DataSource = new DataView(_cDataset.Tables[tableName]) };
            newGrid.setParentSource(tableName, strPrimaryKey, strForeignKey);//设置主外键
            //newGrid.Name = "ChildrenMaster";
            //tPage.Controls.Add(newGrid);
            this.Controls.Add(newGrid);
            //this.BorderStyle = BorderStyle.FixedSingle;
            CellStyle.applyGridTheme(newGrid);
            CellStyle.setGridRowHeader(newGrid);
            newGrid.RowPostPaint += CellStyle.rowPostPaint_HeaderCount;
            childGrid.Add(newGrid);
        }

        public void Add2(string tableName)
        {
            //TabPage tPage = new TabPage() { Text = pageCaption };
            //this.Controls.Add(tPage);
            DataGridView newGrid = new DataGridView() { Dock = DockStyle.Fill, DataSource = new DataView(_cDataset.Tables[tableName]) };
            newGrid.AllowUserToAddRows = false;
            //tPage.Controls.Add(newGrid);
            this.Controls.Add(newGrid);
            CellStyle.applyGridTheme(newGrid);
            CellStyle.setGridRowHeader(newGrid);
            newGrid.RowPostPaint += CellStyle.rowPostPaint_HeaderCount;
            childGrid.Add(newGrid);
        }

        public void RemoveControl()
        {
            this.Controls.Remove(childGrid[0]);
            childGrid.Clear();
        }
        #endregion

    }
}
