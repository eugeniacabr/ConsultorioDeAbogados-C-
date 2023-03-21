/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 11/5/2022
 * Hora: 14:16
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Programa_principal
{

	public class Expedientes
	{	
		private int numero,abogadoACargo,titular;
		private string  tipoTramite, estado ;
		private DateTime fechaPresentacion;
		
		public Expedientes(){}
		public Expedientes(int numero, int titular,string tipoTramite,string estado,int abogadoACargo, DateTime fechaPresentacion)
		{ 
			this.numero=numero;
			this.titular=titular;
			this.tipoTramite=tipoTramite;
			this.estado=estado;
			this.abogadoACargo=abogadoACargo;
			this.fechaPresentacion=fechaPresentacion;
		}
		
		public int Numero{
			set{numero=value;}
			get{return numero;}
		}
		
		public int Titular{
			set{titular=value;}
			get{return titular;}
		}
		
		public string TipoTramite{
			set{tipoTramite=value;}
			get{return tipoTramite;}
		}
		
		public string Estado{
			set{estado=value;}
			get{return estado;}
			
		}
		
		public int AbogadoACargo{
			set{abogadoACargo=value;}
			get{return abogadoACargo;}
		}
		
		public DateTime FechaPresentacion{
			set{fechaPresentacion=value;}
			get{return fechaPresentacion;}
		}
	}
		
}

