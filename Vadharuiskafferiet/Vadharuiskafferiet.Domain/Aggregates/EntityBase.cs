using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vadharuiskafferiet.Domain.Aggregates
{
    public class EntityBase
    {
        public EntityBase()
        {
            CreatedTimeStamp = DateTime.UtcNow;
        }
        public int Id { get; set; }
        public DateTime CreatedTimeStamp { get; set; }
        public DateTime? ModifiedTimeStamp { get; set; }
    }
}
