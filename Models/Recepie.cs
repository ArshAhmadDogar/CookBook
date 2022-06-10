using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace CookBook.Models{
    public class Recepie{
        
        [Key]
        public int RecepieId{get;set;}
        [Column(TypeName="varchar(100)")]
        public string name{get;set;}
         [Column(TypeName ="int")]
        public decimal price {get;set;}
        [Column(TypeName ="varchar(50)")]
        public string Category {get;set;}

        [Column(TypeName="varchar(1000)")]
        public string Description{get;set;}
         [Column(TypeName="varchar(1000)")]
        public string Ingredients {get;set;}

        public int UserId {get;set;}
        [ForeignKey("UserId")]
        public virtual User Users {get;set;}
        
        [NotMapped]
        [DisplayName("Upload Image")]
        public IFormFile Image{get;set;}
    }
}