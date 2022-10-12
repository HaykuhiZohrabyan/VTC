using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.ViewModels;
using Microsoft.EntityFrameworkCore;
using VTC.Data.Entities;
namespace VTC.Application.Queries
{
    public static class LevelExtention
    {
        public static List<LevelVM> GetAlllevels(this DbSet<Level> db , int? packageId =null)
        {
            var data = db.Where(p => !packageId.HasValue
            || p.PackageId == packageId)
               .Select(p => new LevelVM
                {
                    Id=p.Id,
                    Title=p.Title,
                    PackageName = p.Package.Title,
                    SubjectCount = p.Subjects.Count()
                })
               .AsSplitQuery()
               .AsNoTracking().ToList();

            return data;
        }

        // GetbyId => level info + subject list Haykuhi
        
    }
}
