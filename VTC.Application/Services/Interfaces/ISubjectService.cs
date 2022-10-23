using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.ViewModels;
using VTC.Data.Enums;
namespace VTC.Application.Services.Interfaces
{
    public interface ISubjectService
    {
        public List<SubjectVM> GetAllSubject(int? level);
        public SubjectInfoVM GetById(int id);
        public void Add(SubjectAddEditVM subjectVM );
        public void Update(SubjectAddEditVM subjectVM );
        public void UpdateStatus(int id, EntityStatus status);
        public SubjectAddEditVM GetForEdit(int id);
    }
}
