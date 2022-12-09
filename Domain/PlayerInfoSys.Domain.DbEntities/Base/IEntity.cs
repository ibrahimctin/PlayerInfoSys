using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerInfoSys.Domain.DbEntities.Base
{
    public interface IEntity<TKey>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        TKey Id { get; set; }

    
        DateTime CreatedOn { get; set; }
        DateTime UpdatedOn { get; set; }
    }
}
