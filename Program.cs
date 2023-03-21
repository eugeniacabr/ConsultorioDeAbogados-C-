/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 11/5/2022
 * Hora: 14:05
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Programa_principal
{
	class Program
	{
		public static void Main(string[] args)
		{
			Estudio A;
			A=new Estudio();
			int opcion;
			
			Console.ForegroundColor=ConsoleColor.Black;
			Console.BackgroundColor=ConsoleColor.Yellow;
			Console.Clear();
			Console.WriteLine("Estudio de abogados.");
			
			//AGREGAR EXCEPCION!!!!--- System.FormatException
			
			
			try{
			do
			{
				
				Console.WriteLine(" ");
				Console.WriteLine("Elija una opción: ");
				Console.WriteLine("1) Agregar abogado. ");
				Console.WriteLine("2) Eliminar abogado. ");
				Console.WriteLine("3) Listado de abogados. ");
				Console.WriteLine("4) Listado de expedientes.");
				Console.WriteLine("5) Agregar un nuevo expediente a un abogado.");
				Console.WriteLine("6) Modificar el estado de un expediente.");
				Console.WriteLine("7) Eliminar un expediente (Con el nro de expediente).");
				Console.WriteLine("8) Listado de expediente de tipo audencia.");
			    Console.WriteLine("9) Salir.");
			    Console.WriteLine(" ");
			    
			    opcion=int.Parse(Console.ReadLine());
                 //EXCEPCION ACA LINEA 43
			    Console.Clear();
			    

				switch(opcion)
				{
					case 1:{
						agregarAbo(A);
						break;}
						
					case 2:{
						eliminarAbo(A);
						break;}
					
					case 3:{
						listaAbo(A);
						break;}

					case 4:  {
						listaExpe( A);
						break;}
						
					case 5: {
						AgregarExpe(A );
						break;}
						
					case 6: {
						modificarEstExpe(A);
						break;}
						
					case 7: {
						elimexpediente( A );
						break;}
						
					case 8: {
						lista_audiencia(A);
						break;}
						
					case 9: {
						Console.WriteLine("Saliendo del programa...");
						Console.ReadKey();
						break;}
						
				}	
		}while(opcion!=9);
			}catch(FormatException e){Console.WriteLine("Error: "+e.Message);
				Console.ReadKey();
			
			}catch(OverflowException o){Console.WriteLine("Error: "+o.Message);
				Console.ReadKey();
			
			}catch(Exception g){Console.WriteLine("Error: "+g.Message);
				Console.ReadKey();}
		}
		
		
		public static void agregarAbo(Estudio agregar)
		{
			string especialidad, nombre, apellido;
			int dni, cantidadExpe;
			
			ArrayList abo;
			abo=agregar.todosLosAbogado();

			if(abo.Count<5){
			Abogado B;
			Console.WriteLine("Ingrese nombre de abogado: ");
			nombre=Console.ReadLine();
			nombre.ToLower();
			Console.WriteLine("Ingrese apellido: ");
			apellido=Console.ReadLine();
			Console.WriteLine("Ingrese la especialidad del abogado (laboral, penal, comercial, familiar, civil):");
			especialidad=Console.ReadLine();
			if((especialidad!="laboral") &&(especialidad!="penal") && (especialidad!="comercial") && (especialidad!="familiar") && (especialidad!="civil")){
				Console.WriteLine("La especialidad ingresada es erronea .");
				Console.ReadKey();
				Console.Clear();
				return;
				
			}
			Console.WriteLine("Ingrese dni del abogado: ");
			dni=int.Parse(Console.ReadLine());
			cantidadExpe=0;
		
			B=new Abogado(nombre,apellido,especialidad,dni,cantidadExpe);
			
			agregar.agregarAbogado(B);
			}else{
				Console.WriteLine("No se puede agregar mas abogados.");
				Console.ReadKey();
			}
			
			Console.Clear();
				
		}
		public static void listaAbo( Estudio s)
		{
			ArrayList ConjuntoAbo;
			ConjuntoAbo=s.todosLosAbogado();
			
			if(ConjuntoAbo.Count>0){
			foreach(Abogado ele in ConjuntoAbo)
			{
				Console.WriteLine("Nombre: "+ele.Nombre+"| Apellido: "+ele.Apellido+"| DNI: "+ele.Dni+"| Especialidad: "+ ele.Especialidad+"| Cantidad de expedientes: "+ele.Cant);
			}
			Console.ReadKey();
			}else{
				
				Console.WriteLine("La lista de abogados esta vacía.");
				Console.ReadKey();
			}
			
			Console.Clear();
		}
		public static void eliminarAbo(Estudio eli )
		{
			ArrayList conjuntoAbo1;
			conjuntoAbo1=eli.todosLosAbogado();
			
			int dni;
			
			if(conjuntoAbo1.Count>0){
			
			foreach(Abogado ele in conjuntoAbo1)
			{
				Console.WriteLine("Nombre: "+ele.Nombre+"| Apellido: "+ele.Apellido+"| DNI: "+ele.Dni+"| Especialidad: "+ ele.Especialidad+"| Cantidad de expedientes: "+ele.Cant);
			}
			
							
			bool esta=false;
			
			Console.WriteLine("Ingrese el dni del abogado que quiera eliminar: ");
			dni=int.Parse(Console.ReadLine());
			
			foreach(Abogado elem in conjuntoAbo1){
				if(elem.Dni==dni){
					esta=true;
					eli.eliminarAbogado(elem);
					break;
				}
			}
			if(esta)
			{
				Console.WriteLine("El abogado se eliminó con éxito.");
			}
			else
			{Console.WriteLine("El abogado no existe.");
				Console.ReadKey();}
			}
			
			else{
				
				Console.WriteLine("No existen abogados en la lista para eliminar.");
				Console.ReadKey();
			}
			
			Console.Clear();
		}
		public static void listaExpe( Estudio e){
			ArrayList listaExpedientes1;
			listaExpedientes1=e.todosLosExpedientes();
			
			if(listaExpedientes1.Count>0){
			
				foreach(Expedientes elem in listaExpedientes1)
				{
					Console.WriteLine("Numero: "+elem.Numero+" Titular: "+elem.Titular+" Tipo de trámite: "+elem.TipoTramite+" Estado: " +elem.Estado+" Abogado a cargo: "+elem.AbogadoACargo+" Fecha de presentación: "+elem.FechaPresentacion);
				}
				Console.ReadKey();
			}
			else{
				
				Console.WriteLine("La lista de los expedientes esta vacía.");
				Console.ReadKey();
			}
			Console.Clear();
			}		
		public static void AgregarExpe( Estudio agreExpe){
			
			int numero;
			int titular;
			string tipodetramite;
			string estado;
			int abogadoacargo;
			DateTime fechadepresentacion;
			
			bool existeexpe;
			
			existeexpe=false;
			
			Expedientes C;
			
			ArrayList abo;
			abo=agreExpe.todosLosAbogado();
			
			if(abo.Count>0){
			
			Console.WriteLine("Ingrese el numero del expediente: ");
			numero=int.Parse(Console.ReadLine());
			
			if(!existeexpe){
				
				Console.WriteLine("Ingrese el dni del titular: ");
				titular=int.Parse(Console.ReadLine());
				Console.WriteLine("Ingrese el tipo de tramite ( audiencia o documentado ): ");
				tipodetramite=Console.ReadLine();
				if((tipodetramite!="audiencia")&&(tipodetramite!="documentado")){	
					Console.WriteLine("El dato ingresado es erroneo.");
					Console.ReadKey();
					Console.Clear();
					return;
				}
				Console.WriteLine("Ingrese el estado ( pendiente,aprobado,en tramite ) : ");
				estado=Console.ReadLine();
				if((estado!="pendiente")&& (estado!="aprobado") && (estado!= "en tramite"))
					{
					Console.WriteLine("El dato ingresado es erroneo.");
					Console.ReadKey();
					Console.Clear();
					return;
				}
				
				ArrayList listaabo;
				listaabo=agreExpe.todosLosAbogado();
				
				Console.WriteLine("------------------");
                Console.WriteLine("Lista de abogados: ");
			    Console.WriteLine("------------------");	
			    int contf=0;
				foreach(Abogado elem in listaabo){
			    	if (elem.Cant <6){
					Console.WriteLine("Nombre: "+elem.Nombre+"| Apellido: "+elem.Apellido+"| DNI: "+elem.Dni+"| Especialidad: "+ elem.Especialidad+"| Cantidad de expedientes: "+elem.Cant);
			    	}else{contf++;}
			    
			    }if (contf<5){
				
				Console.WriteLine(" ");
				Console.WriteLine("Ingrese el dni del abogado a cargo: ");
				abogadoacargo=int.Parse(Console.ReadLine());
				
				Console.WriteLine("Ingrese la fecha de presentacion del expediente (d/m/a)(00/00/00): ");
				fechadepresentacion=DateTime.Parse(Console.ReadLine());
				
				C=new Expedientes(numero,titular,tipodetramite,estado,abogadoacargo,fechadepresentacion);
			
			    agreExpe.agregarExpediente(C);
			    
			    foreach( Abogado ele in listaabo){
			    	if(ele.Dni==abogadoacargo){
			    		    ele.Cant=+1;
			    	}
			    }
			    	
			   
			    } else{
			    	
			    	Console.WriteLine("No hay abogados disponibles.");
			    }
			    
			}
			
			if(existeexpe){
				
				Console.WriteLine("El numero del expediente ya existe, por favor ingrese otro...");	
				Console.ReadKey();	
			}
	
			}
			else{
				
				Console.WriteLine("No hay abogados para agregarles expedientes.");
				Console.ReadKey();
				              
				
			}
			
			
			
			
			Console.Clear();
			
		}
		
		public static void modificarEstExpe(Estudio m){
			
			int numero_;				
			string estado;
			bool esta=false;
			ArrayList listaex;
			listaex=m.todosLosExpedientes();
			
			if(listaex.Count>0){
		    foreach(Expedientes ele in listaex)
				{
		    	    Console.WriteLine("--------------------------");
		    	    Console.WriteLine("Lista de los expedientes: ");
		            Console.WriteLine("--------------------------");
					Console.WriteLine("Numero: "+ele.Numero+" Titular: "+ele.Titular+" Tipo de trámite: "+ele.TipoTramite+"Estado: "+ele.Estado+" Abogado a cargo: "+ele.AbogadoACargo+" Fecha de presentación: "+ele.FechaPresentacion);
					
		       		  }
		    
		    Console.WriteLine("Ingrese el numero del expediente que desea modificar: ");
		    numero_=int.Parse(Console.ReadLine());
			
			 foreach(Expedientes ele in listaex)
				{
					if(ele.Numero==numero_)
		       		{
		       			Console.WriteLine("Ingrese el estado nuevo: ");
			            estado=Console.ReadLine();
		       			ele.Estado=estado;
		       			esta=true;
		       			Console.WriteLine("El expediente se modifico con exito");
		       			Console.ReadKey();
		       		  }
					
			 	}
			    if(!esta){
						
						Console.WriteLine("El expediente no se ha encontrado.");
						Console.ReadKey();
						
					}
			}
			else{
				
				Console.WriteLine("No hay expedientes existentes para modificar.");
				Console.ReadKey();
			}
			
			
			 Console.Clear();
			 
			
		}
		
		public static void elimexpediente( Estudio e){
			
			ArrayList conjexpe;
			conjexpe=e.todosLosExpedientes();
			
			int numero_exp;
							
							
			bool esta=false;
			
			if(conjexpe.Count>0){
		
			foreach(Expedientes elem in conjexpe)
			{
			   Console.WriteLine("Numero: "+elem.Numero+" Titular: "+elem.Titular+" Tipo de trámite: "+elem.TipoTramite+" Estado: " +elem.Estado+" Abogado a cargo: "+elem.AbogadoACargo+" Fecha de presentación: "+elem.FechaPresentacion);
			}
			
			
			Console.WriteLine("Ingrese el numero del expediente que desea eliminar: ");
			numero_exp=int.Parse(Console.ReadLine());
			
			
			foreach(Expedientes elem in conjexpe){
				if(elem.Numero==numero_exp){
					esta=true;
					e.eliminarExpediente(elem);
					break;
				}
			}
			if(esta)
			{
				Console.WriteLine("El expediente se eliminó con éxito.");
				Console.ReadKey();
			}
			else
			{Console.WriteLine("El expediente no existe.");
				Console.ReadKey();}
			}
			else{
				
				Console.WriteLine("No hay expedientes existentes para eliminar.");
				Console.ReadKey();
			}
			
			Console.Clear();
		
		}
		
		public static void lista_audiencia(Estudio a){
			
			DateTime fecha_inicial;
			DateTime fecha_final;
			
			Console.WriteLine("Ingrese la fecha inicial (d/m/a)(00/00/00): ");
			fecha_inicial=DateTime.Parse(Console.ReadLine());
			
			Console.WriteLine("Ingrese la fecha final (d/m/a) (00/00/00): ");
			fecha_final=DateTime.Parse(Console.ReadLine());
			
			ArrayList conjuaudiencia;
			conjuaudiencia=a.todosLosExpedientes();
			
			if(conjuaudiencia.Count>0){

				foreach(Expedientes elem in conjuaudiencia)
				{
				
				if(elem.TipoTramite == "audiencia"){
						
						if(fecha_inicial< elem.FechaPresentacion && fecha_final> elem.FechaPresentacion){
				
					Console.WriteLine("Numero: "+elem.Numero+" Titular: "+elem.Titular+" Tipo de trámite: "+elem.TipoTramite+" Estado: " +elem.Estado+" Abogado a cargo: "+elem.AbogadoACargo+" Fecha de presentación: "+elem.FechaPresentacion);
					Console.ReadKey();
				}
						else{
							
							Console.WriteLine("No se encontró ninguna fecha...");
							Console.ReadKey();
							
						}
					}
				}
				
			}
			
		
			else{
				
				Console.WriteLine("La lista de expedientes de tipo audiencia esta vacía.");
				Console.ReadKey();
			}
			
			Console.Clear();
		}
		
		
		
		}	
		}
		
	
