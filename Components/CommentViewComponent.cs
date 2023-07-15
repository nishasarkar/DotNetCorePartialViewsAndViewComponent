using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Components
{
    public class CommentViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            HttpClient client = new HttpClient();
            ICollection<Comment_Model> comments = client.GetFromJsonAsync<ICollection<Comment_Model>>("https://jsonplaceholder.typicode.com/comments?postId=" + id).Result;
            return View("~/views/components/comment.cshtml", comments);
        }
    }
}
