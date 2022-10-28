using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.Services.Interfaces;
using VTC.Application.ViewModels;
using VTC.Data.Repositories.Interfaces;
using VTC.Data.Entities;
using VTC.Data;
using VTC.Application.Queries;

namespace VTC.Application.Services
{
    public class FormService : IFormService
    {
        private readonly IFormRepository _formRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly VTCDataContext _context;

        public FormService(IFormRepository formRepository, IUnitOfWork unitOfWork,VTCDataContext context)
        {
            _formRepository = formRepository;
            _unitOfWork = unitOfWork;
            _context = context;
        }
        public void AddParentAgreement(ParentAgreementVM model)
        {
            var parentAgreement = new ParentAgreement()
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
            _formRepository.Add(parentAgreement);
            _unitOfWork.Save();
        }

        public ParentAgreementVM GetById(int id)
        {
            return _context.ParentAgreements.GetById(id);
        }

        public List<ParentListVM> GetParentAgreementList()
        {
            return _context.ParentAgreements.GetParentList();
        }
    }
}
