using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Vadharuiskafferiet.Application.DTOs;
using Vadharuiskafferiet.Application.Recepies.Query;
using Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities;

namespace Vadharuiskafferiet.Application.Extensions
{
    public static class RecepieExtensions
    {
        public static RecepieDTO ToRecepieDTO(this Recepie recepie)
        {
            return new RecepieDTO
            {
                Description = recepie.Description.Value,
                Id = recepie.Id,
                Ingredients = recepie.Ingredients.Select(ingr => ingr.Name.Value).ToList(),
                Name = recepie.RecepieName.Value,
                Steps = recepie.Steps.ValuesToList,
                IsVegan = recepie.IsVegan,
                IsVegetarian = recepie.IsVegetarian,
                Image = recepie.ImageUrl
            };
        }
    }
}
