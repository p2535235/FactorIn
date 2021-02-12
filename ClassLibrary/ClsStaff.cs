namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public System.DateTime DateAccessed { get; set; }
        public double TotalCost { get; set; }
        public bool GrantAccess { get; set; }
        public int ProductID { get; set; }
    }
}