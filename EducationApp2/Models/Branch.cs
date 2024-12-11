namespace EducationApp2.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relationship
        public ICollection<TeacherBranch> TeacherBranches { get; set; }
    }
}
