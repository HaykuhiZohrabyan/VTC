using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTC.Application.ViewModels
{
    public class SubjectAddEditVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LevelId { get; set; }
        public string Description { get; set; }
        public string? LogoFile { get; set; }
        
    }
}
