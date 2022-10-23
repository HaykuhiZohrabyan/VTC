using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Data.Entities;
using VTC.Data.Enums;
namespace VTC.Data.Repositories.Interfaces
{
    public interface ISubjectRepository
    {

        void Add(Subject subject);
        void Update(Subject subject);
        void UpdateStatus(int id, EntityStatus entityStatus);
    }
}
