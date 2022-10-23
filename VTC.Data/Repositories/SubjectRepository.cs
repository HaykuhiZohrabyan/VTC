using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Data.Entities;
using VTC.Data.Enums;
using VTC.Data.Repositories.Interfaces;
namespace VTC.Data.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly VTCDataContext _context;
        public SubjectRepository(VTCDataContext context)
        {
            _context = context;
        }

        public void Add(Subject subject)
        {
             _context.Subjects.Add(subject);
        }

        public void Update(Subject subject)
        {
            var entity = _context.Subjects.FirstOrDefault(s => s.Id == subject.Id);
            entity.Name=subject.Name;
            entity.Description = subject.Description;
            entity.LogoFile = subject.LogoFile;
            entity.LevelId = subject.LevelId;
        }

        public void UpdateStatus(int id, EntityStatus entityStatus)
        {
            var entity = _context.Subjects.FirstOrDefault(s => s.Id == id);
            entity.EntityStatus= entityStatus ;
        }
    }
}
