using System;
using System.ComponentModel.DataAnnotations;

namespace ApiBugs.Models
{
	public class bugModel
	{
        
        [Key]
		public int ID { get; set; }
		public string? Nombre { get; set; }
		public string? Reporta { get; set; }
		public DateTime FechaReporte { get; set; }
		public string? Resumen { get; set; }
		public string? Url { get; set; }
		public string? Pantalla { get; set; }
		public string? Plataforma { get; set; }
		public string? SistemaOperativo { get; set; }
		public string? App { get; set; }
		public string? Severidad { get; set; }
		public string? Atiende { get; set; }
		public string? Prioridad { get; set; }


    }
}

