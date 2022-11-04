using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.ViewModels;
using VTC.Data;
using VTC.Data.Entities;

namespace VTC.Application.Queries
{
    public static class LessonExtention
    {
        public static LessonAddEditVM GetForEdit(this DbSet<Lesson> db, int? Id)
        {
            var data = db.Where(l => l.Id == Id).Select(l => new LessonAddEditVM()
            {
                Id = l.Id,
                Title = l.Title,
                Content = l.Content,
                ShortDescription = l.ShortDescription,
                SubjectId = l.SubjectId,
            }).AsNoTracking().FirstOrDefault();
            return data;
        }

    }
}
