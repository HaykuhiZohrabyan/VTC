using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.Queries;
using VTC.Application.Services.Interfaces;
using VTC.Application.ViewModels;
using VTC.Data;
using VTC.Data.Entities;
using VTC.Data.Repositories;
using VTC.Data.Repositories.Interfaces;

namespace VTC.Application.Services
{
    public class  LessonService:ILessonService
    {
        private readonly ILessonRepository _repository; 
        private  readonly IUnitOfWork _unitOfWork;
        private readonly VTCDataContext _context;
        public LessonService(ILessonRepository repository, IUnitOfWork unitOfWork,VTCDataContext context)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _context = context;
        }

        public void Add(LessonAddEditVM model)
        {
            Lesson lesson = new()
            {
               Title = model.Title,
               ShortDescription = model.ShortDescription,
               Content = model.Content,
               SubjectId=model.SubjectId,   


            };
            _repository.Add(lesson);
            _unitOfWork.Save();
        }

        public LessonAddEditVM GetForEdit(int? lessonId)
        {
            var data=_context.Lessons.GetForEdit(lessonId);
            return data;
        }

       
        public void Update(LessonAddEditVM model)
        {
            Lesson lesson = new()
            {
                Title = model.Title,
                ShortDescription = model.ShortDescription,
                Content = model.Content,
                SubjectId = model.SubjectId,
                Id = model.Id

            };
            _repository.Update(lesson);
            _unitOfWork.Save();
        }
    }
}
