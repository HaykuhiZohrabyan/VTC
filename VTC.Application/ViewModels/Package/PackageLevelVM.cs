using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTC.Application.ViewModels
{
    public class PackageLevelVM
    {
        public string PackageName { get; set; }
        public List<LevelShortInfo> Levels { get; set; }
    }
}
