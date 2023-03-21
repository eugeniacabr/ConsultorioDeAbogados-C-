/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 11/5/2022
 * Hora: 14:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Programa_principal
{
	public class Estudio{	
		private ArrayList listaExpedientes;
		private ArrayList listaAbogados;

		public Estudio(){
			listaExpedientes=new ArrayList();
			listaAbogados=new ArrayList();
		}
		 
		public ArrayList ListaAbogados{
			get{return listaAbogados;}
		}

		public ArrayList ListaExpediente{
			get{return listaExpedientes;}
		}
		
		public void agregarAbogado(Abogado UnAbo)
		{
			listaAbogados.Add(UnAbo);
		}
		
		public void eliminarAbogado(Abogado unAbo)
		{
			listaAbogados.Remove(unAbo);
		}
		
		public ArrayList todosLosAbogado()
		{
			return listaAbogados;
		}
		
		public void agregarExpediente(Expedientes UnExpe)
		{
			listaExpedientes.Add(UnExpe);
		}
		public void eliminarExpediente(Expedientes UnExpe)
		{
			listaExpedientes.Remove(UnExpe);
		}
		
		public ArrayList todosLosExpedientes()
		{
			return listaExpedientes;
		} 
	}
	
}
