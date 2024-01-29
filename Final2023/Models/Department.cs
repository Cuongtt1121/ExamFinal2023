namespace Final2023.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public int NumberOfPersonals { get; set; }

        // Navigation Property
        public List<Employee>? Employees { get; set; }
    }
}
