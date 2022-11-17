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

        public static ParentAgreementVM GetById(this DbSet<ParentAgreement> db, int Id)
        {
            var data = db.Where(p => p.Id == Id).Select(p => new ParentAgreementVM()
            {
                Id = p.Id,
                ChildFirstName = p.ChildFirstName,
                ChildSecondName = p.ChildSecondName,
                ChildBirthCertificate = p.ChildBirthCertificate,
                ParentDob = p.ParentDob,
                ParentIdFrom = p.ParentIdFrom,
                ParentSocialCard = p.ParentSocialCard,
                Address = p.Address,
                ParentIdIssueddate = p.ParentIdIssueddate,
                ParentIdNumber = p.ParentIdNumber,
                ParentFirstName = p.ParentFirstName,
                ParentSecondName = p.ParentSecondName,
                CreatedDate = p.CreatedDate
            }).AsNoTracking().FirstOrDefault();
            return data;
        }

    }
}
