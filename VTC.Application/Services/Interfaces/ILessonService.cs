using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.ViewModels;

namespace VTC.Application.Services.Interfaces
{
   public interface ILessonService
    {
        void Add(LessonAddEditVM model);
        void Update(LessonAddEditVM model); 
        LessonAddEditVM GetForEdit(int? lessonId);
    }
}
