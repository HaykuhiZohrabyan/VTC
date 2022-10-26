using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTC.Application.ViewModels
{
    public class ParentAgreementVM
    {
        public string ParentFullName { get; set; }
        public DateTime ParentDob { get; set; }
        public string ParentIdNumber { get; set; }
        public string ParentIdFrom { get; set; }
        public string ParentSocialCard { get; set; }
        public DateTime ParentIdIssueddate { get; set; }
        public string ChildFullName { get; set; }
        public string Address { get; set; }
        public string ChildBirthCertificate { get; set; }
    }
}
