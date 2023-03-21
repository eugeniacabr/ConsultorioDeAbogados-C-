/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 11/5/2022
 * Hora: 14:05
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Programa_principal
{
	public class Abogado
	{
		private string nombre, apellido, especialidad;
		private int dni, cant;

		public Abogado(){}
		
		public Abogado(string nombre, string apellido, string especialidad, int dni, int cant)
		{
			this.nombre=nombre;
			this.apellido=apellido;
			this.especialidad=especialidad;
			this.dni=dni;
			this.cant=cant;
		}
		public string Nombre{
			set{nombre=value;}
			get{return nombre;}
		}	
		public string Apellido{
			set{apellido=value;}
			get{return apellido;}
		}
		public string Especialidad{
			set{especialidad=value;}
			get{return especialidad;}
		}
		public int Dni{
			set{dni=value;}
			get{return dni;}
		}
		public int Cant{
			set{cant=value;}
			get{return cant;}
		}
	}
}
