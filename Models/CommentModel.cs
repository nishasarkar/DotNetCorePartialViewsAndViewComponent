namespace WebApplication1.Models
{
    public class Comment_Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
        public int PostID { get; set; }
    }
}
