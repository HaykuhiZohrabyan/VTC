using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.Services.Interfaces;
using VTC.Application.ViewModels;
using VTC.Data;
using VTC.Application.Queries;
namespace VTC.Application.Services
{
    public class LevelService : ILevelService
    {
        private readonly VTCDataContext _context;
        public LevelService(VTCDataContext context)
        {
            _context = context;
        }
        public List<LevelVM> GetAllLevels(int? packageId)
        {
            return _context.Levels.GetAlllevels(packageId);
        }
    }
}
