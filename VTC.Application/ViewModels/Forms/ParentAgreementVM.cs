using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VTC.Application.ViewModels
{
    public class ParentAgreementVM
    { public int Id { get; set; }
        [Required]
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
        [Required]
        public DateTime CreatedDate { get; set; }
        
       
        
        public ParentAgreementVM()
        {
          const int a = 6;
        }
}
    
}
