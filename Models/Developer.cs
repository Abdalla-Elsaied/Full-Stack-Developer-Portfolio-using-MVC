namespace MVC_EX_1.Models
{
    public class Developer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string HSkills { get; set; }
        public string SSkills { get; set; }

        public List<Projects> DevProjects { get; set; }
    }
}
