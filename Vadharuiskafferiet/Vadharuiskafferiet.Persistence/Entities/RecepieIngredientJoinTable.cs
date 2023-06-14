using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vadharuiskafferiet.Persistence.Entities
{
    public class RecepieIngredientJoinTable
    {
        public int RecepieId { get; set; }
        public int IngredientId { get; set; }
    }
}
