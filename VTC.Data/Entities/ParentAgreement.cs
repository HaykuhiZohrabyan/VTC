using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VTC.Data.Entities
{
    public class ParentAgreement : Entity
    {

        public int Id { get; set; }
        [Required (ErrorMessage = "Please enter Parent Name")]
        public string ParentFirstName { get; set; }
        [Required]
        public string ParentSecondName { get; set; }
        [Required]
        public DateTime ParentDob { get; set; }
        [Required]
        public string ParentIdNumber { get; set; }
        [Required]
        public string ParentIdFrom { get; set; }
        [Required]
        public string ParentSocialCard { get; set; }
        [Required]
        public DateTime ParentIdIssueddate { get; set; }
        [Required]
        public string ChildFirstName { get; set; }
        [Required]
        public string ChildSecondName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string ChildBirthCertificate { get; set; }
        public DateTime CreatedDate { get; set; }
        public ParentAgreement()
        {
            CreatedDate = DateTime.Now;
        }
       

    }
}
