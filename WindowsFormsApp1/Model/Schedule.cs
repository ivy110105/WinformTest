using System;

namespace WindowsFormsApp1.Model
{
    [Serializable]
    public class Schedule : BaseModel
    {
        [DataFieldAttribute("Name", "200")]
        public string Name { get; set; }
        [DataFieldAttribute("Note", "500")]
        public string Note { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// 频率类型
        /// </summary>
        [DataFieldAttribute("RepeatType", "100")]        
        public string FrequencyType { get; set; }
        /// <summary>
        /// 频次（次数）
        /// </summary>
        public int FrequencyTimes { get; set; }
        /// <summary>
        /// 频率周期数（eg：每三天）
        /// </summary>
        public int FrequencyCycleNum { get; set; }
        /// <summary>
        /// 频率周期单位
        /// </summary>
        [DataFieldAttribute("RepeatUnit", "30")]
        public string FrequencyCycleUnit { get; set; }
    }
}
