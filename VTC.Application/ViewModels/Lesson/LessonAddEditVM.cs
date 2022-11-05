using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Data.Entities;

namespace VTC.Application.ViewModels
{
   public class LessonAddEditVM
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string? ShortDescription { get; set; }
        public string Content { get; set; }
        public int SubjectId { get; set; }
        
    }
}
