using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Data.Enums;
namespace VTC.Data.Entities
{
    public abstract class Entity
    {
        public EntityStatus EntityStatus { get; set; }

        public Entity()
        {
            EntityStatus = EntityStatus.Active;
        }
    }
}
