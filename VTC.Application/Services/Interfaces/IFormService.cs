using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.ViewModels;
using VTC.Data.Entities;

namespace VTC.Application.Services.Interfaces
{
    public interface IFormService
    {
        public void AddParentAgreement(ParentAgreementVM model);
        public List<ParentListVM> GetParentAgreementList();
        public ParentAgreementVM GetById(int id);
        public Tuple<List<ParentListVM>, int> GetParentList(ParentListVM model, int pageSize, int pageIndex);
    }
}
