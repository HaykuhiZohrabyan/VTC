using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.ViewModels;
namespace VTC.Application.Services.Interfaces
{
    public interface ILevelService
    {
        public List<LevelVM> GetAllLevels(int? packageId);
    }
}
