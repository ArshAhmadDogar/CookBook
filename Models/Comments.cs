using System.ComponentModel.DataAnnotations;
namespace CookBook.Models{
    public class Comments{
        [Key]
        public int CommentId{get;set;}
        public string Comment{get; set;}
        public string name{get;set;}
        public string email {get;set;}
    }
}