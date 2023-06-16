using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vadharuiskafferiet.Application.DTOs;
using Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities;

namespace Vadharuiskafferiet.Application.Recepies.Query
{
    public class GetRecepiesQuery : IRequest<List<RecepieDTO>>
    {
        public List<int> Ingredients { get; set; }
        public bool IsVegan { get; set; }
        public bool IsVegetarian { get; set; }
    }
}
