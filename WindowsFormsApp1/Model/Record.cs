using System;

namespace WindowsFormsApp1.Model
{
    [Serializable]
    public class Record : BaseModel
    {
        [DataFieldAttribute("ScheduleID", "50")]
        public Guid? ScheduleID { get; set; }
        [DataFieldAttribute("Name", "200")]
        public string Name { get; set; }
        [DataFieldAttribute("Note", "500")]
        public string Note { get; set; }
        /// <summary>
        /// 计划完成状态
        /// 0：Initial Status 1：Done 2：Fail
        /// </summary>
        public int Status { get; set; }
    }
}
