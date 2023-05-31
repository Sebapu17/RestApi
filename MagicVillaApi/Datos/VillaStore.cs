using System;
using MagicVillaApi.Modelos.Dto;

namespace MagicVillaApi.Datos
{
	public class VillaStore
	{
		public static List<VillaDto> villaList = new List<VillaDto>
           {
           new VillaDto { Id = 1, Nombre = "Vista al mar", Ocupantes = 3, MetrosCuadrados=50 },
           new VillaDto { Id = 2, Nombre = "Vista a la playa", Ocupantes=2, MetrosCuadrados=100 }
           };
    }
}

