using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DateTime EndDate { get; set; }
        [DataFieldAttribute("RepeatType", "100")]
        public string RepeatType { get; set; }
        public int RepeatNum { get; set; }
        [DataFieldAttribute("RepeatUnit", "30")]
        public string RepeatUnit { get; set; }
        public int RepeatDays { get; set; }
    }
}
