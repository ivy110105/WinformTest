using System;

namespace WindowsFormsApp1.Model
{
    [Serializable]
    public  class BaseModel
    {
        [DataFieldAttribute("ID", "primary key")]
        public Guid ID { get; set; }
        [DataFieldAttribute("CreatedBy", "50")]
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        [DataFieldAttribute("ModifiedBy", "50")]
        public string ModifiedBy { get; set; }
        public DateTime ModifedOn { get; set; }
        public bool Deleted { get; set; }
    }

    public class DataFieldAttribute : Attribute
    {
        private string _FieldName;
        private string _FieldType;
        public DataFieldAttribute(string fieldname, string fieldtype)
        {
            this._FieldName = fieldname;
            this._FieldType = fieldtype;
        }
        public string FieldName
        {
            get { return this._FieldName; }
            set { this._FieldName = value; }
        }
        public string FieldType
        {
            get { return this._FieldType; }
            set { this._FieldType = value; }
        }
    }
}
