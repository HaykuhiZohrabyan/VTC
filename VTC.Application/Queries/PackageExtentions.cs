using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VTC.Application.ViewModels;
using VTC.Data.Entities;
namespace VTC.Application.Queries
{
    public static class PackageExtentions
    {
        public static List<PackageVM> GetAllPackages(this DbSet<Package> db)
        {
            return db.AsNoTracking()
                .Select(p => new PackageVM(p.Id, p.Title)).ToList();
        }

        public static PackageVM GetById(this DbSet<Package> db, int Id)
        {
            var entity = db.AsNoTracking().FirstOrDefault(p=>p.Id==Id);
            return new PackageVM(entity.Id, entity.Title);

        }

        public static List<PackageLevelVM> GetPackagesWithLevels(this DbSet<Package> db)
        {
            return db.Select(p => new PackageLevelVM
            {
                PackageName = p.Title,
                Levels = p.Levels.Select(l=>new LevelShortInfo
                {
                    Id =l.Id,
                    Name =l.Title
                }).ToList()
            }).AsNoTracking().AsSplitQuery().ToList();
        }
    }
}
