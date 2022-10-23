using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTC.Application.ViewModels
{
    public class SubjectInfoVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? LogoFile { get; set; }
        public string LevelName { get; set; }
        public List<string>  Lessons { get; set; }
    }
}
