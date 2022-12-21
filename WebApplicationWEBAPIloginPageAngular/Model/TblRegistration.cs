using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationWEBAPIloginPageAngular.Model
{
    public class TblRegistration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; } 
        public string Name { get; set; }

        public string EmailId { get; set; } 
        public string Password { get; set; }   
        public string Gender { get; set; }  
        public DateTime Dob { get; set; } 


    }
}
