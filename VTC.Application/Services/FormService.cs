using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.Services.Interfaces;
using VTC.Application.ViewModels;
using VTC.Data.Repositories.Interfaces;
using VTC.Data.Entities;

namespace VTC.Application.Services
{
    public class FormService : IFormService
    {
        private readonly IFormRepository _formRepository;
        private readonly IUnitOfWork _unitOfWork;


        public FormService(IFormRepository formRepository, IUnitOfWork unitOfWork)
        {
            _formRepository = formRepository;
            _unitOfWork = unitOfWork;
        }
        public void AddParentAgreement(ParentAgreementVM model)
        {
            var parenAgreement = new ParentAgreement()
            {
                ParentFullName = model.ParentFullName,
                ParentSocialCard = model.ParentSocialCard,
                ParentIdFrom = model.ParentIdFrom,
                Address = model.Address,
                ParentDob = model.ParentDob,
                ParentIdNumber = model.ParentIdNumber,
                ParentIdIssueddate = model.ParentIdIssueddate,
                ChildFullName = model.ChildFullName,
                ChildBirthCertificate = model.ChildBirthCertificate            
            };
        }
    }
}
