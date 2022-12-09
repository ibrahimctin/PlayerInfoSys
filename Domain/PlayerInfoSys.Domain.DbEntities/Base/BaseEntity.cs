using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerInfoSys.Domain.DbEntities.Base
{
    public class BaseEntity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
      
    }
}
