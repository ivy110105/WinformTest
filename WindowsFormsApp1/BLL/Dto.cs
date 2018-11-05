namespace WindowsFormsApp1.BLL
{
    public class Dto
    {
        public string Name { get; set; }
        public string Frequency { get; set; }
        /// <summary>
        /// 状态
        /// 0：Initial Status 1：Done 2：Fail
        /// </summary>
        public int Status { get; set; }
    }
}
