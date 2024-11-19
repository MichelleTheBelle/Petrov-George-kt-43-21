namespace PetrovGeorgeKt_43_21.Models
{
	public class Department
	{
		public int DepartmentId { get; set; }
		public string? Name { get; set; }
		public int HeadId { get; set; }
		public Teacher? Head { get; set; }
	}
}