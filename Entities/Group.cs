namespace Entities
{
    public class Group : DbEntity
    {
        [Column("name")]
        [MaxLength(32)]
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        [Column("facultyId")]
        public Guid FacultyId { get; set; }
        public Faculty Faculty { get; set; }
    }
}