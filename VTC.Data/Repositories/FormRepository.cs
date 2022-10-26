using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Data.Entities;
using VTC.Data.Repositories.Interfaces;

namespace VTC.Data.Repositories
{
    public class FormRepository:IFormRepository

    {
        private readonly VTCDataContext _context;
        public FormRepository(VTCDataContext context)
        {
            _context = context;
        }

        public void Add(ParentAgreement model)
        {
            _context.ParentAgreements.Add(model);
        }
    }
}
