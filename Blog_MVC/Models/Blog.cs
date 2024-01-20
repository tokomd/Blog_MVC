using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace Blog_MVC.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Blog_Question { get; set; }
        public string Blog_Repence { get; set; }
        public string User_Name { get; set; }
        public Blog()
        {
            
        }

    }
}
