using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.Services.Interfaces;
using VTC.Application.ViewModels;
using VTC.Application.Queries;
using VTC.Data;
namespace VTC.Application.Services
{
    public class PackageService : IPackageService
    {
        private readonly VTCDataContext _context;
        public PackageService(VTCDataContext context)
        {
            _context = context;
        }
        public void Add(PackageVM model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PackageVM> GetAllPackages()
        {
            return _context.Packages.GetAllPackages();
        }

        public PackageVM GetById(int id)
        {
            return _context.Packages.GetById(id);
        }

        public void Update(PackageVM model)
        {
            throw new NotImplementedException();
        }
    }
}
