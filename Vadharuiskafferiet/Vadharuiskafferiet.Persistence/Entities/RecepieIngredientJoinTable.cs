using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vadharuiskafferiet.Persistence.Entities
{
    public class RecepieIngredientJoinTable
    {
        public Guid RecepieId { get; set; }
        public Guid IngredientId { get; set; }
    }
}
