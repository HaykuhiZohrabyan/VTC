using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.ViewModels;
using VTC.Data.Entities;

namespace VTC.Application.Queries
{
    public static class FormExtention
    {
        public static List<ParentListVM> GetParentList(this DbSet<ParentAgreement> db)
        {
            return db.AsNoTracking().Select(p => new ParentListVM() {
                Id=p.Id,
                ParentFullName=p.ParentFullName,
                ParentIdNumber=p.ParentIdNumber,
                ChildFullName=p.ChildFullName,
                
            }).ToList();

        }
        public static ParentAgreementVM GetById(this DbSet<ParentAgreement> db,int Id)
        {
            var data = db.Where(p => p.Id == Id).Select(p => new ParentAgreementVM()
            {
                Id = p.Id,
                ParentFullName = p.ParentFullName,
                ChildBirthCertificate = p.ChildBirthCertificate,
                ParentDob = p.ParentDob,
                ParentIdFrom = p.ParentIdFrom,
                ParentSocialCard = p.ParentSocialCard,
                Address = p.Address,
                ParentIdIssueddate = p.ParentIdIssueddate,
                ParentIdNumber = p.ParentIdNumber,
                ChildFullName = p.ChildFullName,
                CreatedDate = p.CreatedDate
            }).AsNoTracking().FirstOrDefault();
            return data;
        }
    }
}
