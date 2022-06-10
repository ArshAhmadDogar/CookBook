using System.ComponentModel.DataAnnotations;
namespace CookBook.Models{
    public class User{
        [Key]
        public int UserId{get;set;}
        public string name{get;set;}
        public string email{get;set;}
        public string password{get;set;}
    }
}