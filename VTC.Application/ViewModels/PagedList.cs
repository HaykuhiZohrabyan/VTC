using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTC.Application.ViewModels
{
     public class PagedList<T>
    {
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
        public bool IsNext => CurrentPage < PageCount;
        public bool IsPrev => CurrentPage > 1;
        public List<T> Content { get; set; }

       
    }

   
}
