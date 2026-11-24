using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_App.Entities
{
    public class Membership : BaseEntity
    {

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [NotMapped]
        public String Status => DateTime.Now < StartDate ? "UpComing" 
                                : DateTime.Now < EndDate ? "Active" 
                                : "Expired";

        public int PlanId { get; set; }//Fk
        public Plan Plan { get; set; } 
        public int MemberId { get; set; }//Fk
        public Member Member { get; set; } 
    }
}
