using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Data.Enums;

namespace VTC.Application.ViewModels
{
  public class SubjectVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string?  LogoFile { get; set; }
        public string  LevelName { get; set; }
        public int LessonCount { get; set; }
        public string PackageName { get; set; }

    }
}
