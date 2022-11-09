using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.Services.Interfaces;
using VTC.Application.ViewModels;
using VTC.Data.Enums;
using VTC.Data;
using VTC.Data.Repositories.Interfaces;
using VTC.Application.Queries;
using VTC.Data.Entities;

namespace VTC.Application.Services
{
    public class SubjectService : ISubjectService 
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly VTCDataContext _context;
        public SubjectService(ISubjectRepository subjectRepository, IUnitOfWork unitOfWork, VTCDataContext context)
        {
            _subjectRepository = subjectRepository;
            _unitOfWork = unitOfWork;
            _context = context;
        }

        public void Add(SubjectAddEditVM subjectVM)
        {
            Subject subject = new Subject
            {
                Description = subjectVM.Description,
                Name = subjectVM.Name,
                LogoFile = subjectVM.LogoFile,
                LevelId = subjectVM.LevelId,
            };
            
            _subjectRepository.Add(subject);
            _unitOfWork.Save();
        }

        public List<SubjectVM> GetAllSubject(int? level)
        {
            var subjects = _context.Subjects.GetAllSubjects();
            return subjects;
        }

        public SubjectInfoVM GetById(int id)
        {
            return _context.Subjects.GetById(id);
        }

        public SubjectAddEditVM GetForEdit(int id)
        {
            return _context.Subjects.GetForEdit(id);
        }

        public void Update(SubjectAddEditVM subjectVM)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatus(int id, EntityStatus status)
        {
            throw new NotImplementedException();
        }
    }
}
