using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using VTC.Data.Entities;
using VTC.Data.Repositories.Interfaces;

namespace VTC.Data.Repositories
{
    public class LessonRepository : ILessonRepository
    {
        private readonly VTCDataContext _context;
        public LessonRepository(VTCDataContext context)
        {
            _context=context;   
        }
        public void Add(Lesson model)
        {
           _context.Lessons.Add(model);
        }

        public void Update(Lesson model)
        {
            var data=_context.Lessons.FirstOrDefault(l=>l.Id == model.Id); 
            
        }
    }
}
