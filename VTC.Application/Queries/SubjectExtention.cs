using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.ViewModels;
using VTC.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace VTC.Application.Queries
{
    public static class SubjectExtention
    {
        public static List<SubjectVM> GetAllSubjects(this DbSet<Subject> db,int? LevelId = null)
        {
            var data = db.Where(s => !LevelId.HasValue || s.LevelId == LevelId)
                .Select(s => new SubjectVM
                {
                    Id = s.Id,
                    Name = s.Name,
                    LevelName = s.Level.Title,
                    LogoFile = s.LogoFile,
                    PackageName = s.Level.Package.Title,
                    LessonCount = s.Lessons.Count(),


                }).AsSplitQuery()
                .AsNoTracking().ToList();
            return data;

             
        }
        public static SubjectInfoVM GetById(this DbSet<Subject> db,int subjectId)
        {
            var entity = db.Where(s => s.Id == subjectId).Select(s => new SubjectInfoVM
            {
                Id = s.Id,
                LevelName = s.Level.Title,
                Description = s.Description,
                Name = s.Name,
                Lessons = s.Lessons.Select(l=>l.Title).ToList(),
                LogoFile=s.LogoFile
            }).AsNoTracking()
                .FirstOrDefault() ;

            return entity;
        }
        public static SubjectAddEditVM GetForEdit (this DbSet<Subject> db ,int id)
        {
            var entity=db.Where(s=>s.Id==id).Select(s=> new SubjectAddEditVM 
            {
                Description = s.Description,
                Name=s.Name,
                LogoFile=s.LogoFile,
                LevelId = s.LevelId
                 
                 
            }).FirstOrDefault() ;
            return entity;

        }

    }
}
