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

        public FormService(IFormRepository formRepository, IUnitOfWork unitOfWork, VTCDataContext context)
        {
            _formRepository = formRepository;
            _unitOfWork = unitOfWork;
            _context = context;
        }
        public void AddParentAgreement(ParentAgreementVM model)
        {
            var parentAgreement = new ParentAgreement()
            {
                ParentFirstName = model.ParentFirstName,
                ParentSecondName = model.ParentSecondName,
                ParentSocialCard = model.ParentSocialCard,
                ParentIdFrom = model.ParentIdFrom,
                Address = model.Address,
                ParentDob = model.ParentDob,
                ParentIdNumber = model.ParentIdNumber,
                ParentIdIssueddate = model.ParentIdIssueddate,
                ChildFirstName = model.ChildFirstName,
                ChildSecondName = model.ChildSecondName,
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

        public Tuple<List<ParentListVM>, int> GetParentList(ParentListVM model, int pageSize, int pageIndex)
        {

            var query = _context.ParentAgreements.Where(p => (
            (model.ParentFirstName == null || p.ParentFirstName.ToLower().Contains(model.ParentFirstName.ToLower()))
                       && (model.ParentSecondName == null || p.ParentSecondName.ToLower().Contains(model.ParentSecondName.ToLower())))
                       && ( (model.ChildFirstName == null || p.ChildFirstName.ToLower().Contains(model.ChildFirstName.ToLower()))
                       ||( model.ChildSecondName == null || p.ChildSecondName.ToLower().Contains(model.ChildSecondName.ToLower()))));
                

            var list=query
                .Select(m=>new ParentListVM()
            {
                ParentFirstName=m.ParentFirstName,
                ParentSecondName=m.ParentSecondName,
                ChildFirstName=m.ChildFirstName,
                ChildSecondName=m.ChildSecondName,
                Id=m.Id,
                ParentIdNumber=m.ParentIdNumber,
            })
                .OrderByDescending(r => r.ParentFirstName)
               
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            var count = query.Count();
            return Tuple.Create(list, count);
        }
    }
}
