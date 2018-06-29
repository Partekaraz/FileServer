using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Common.Model
{
	public class Alumno
	{

		#region Propiedades

		// escribir PROP tabulador, tabulador y ya escribe la propiedad
		public Int32 Id { get; set; }
		public String Nombre { get; set; }
		public String Apellidos { get; set; }
		public String Dni { get; set; }	

		#endregion

		#region Constructores

		public Alumno()
		{
		}

		public Alumno(Int32 Id, String Nombre, 
			            String Apellidos, String Dni)
		{
			this.Id = Id;
			this.Nombre = Nombre;
			this.Apellidos = Apellidos;
			this.Dni = Dni; 
		}

		#endregion

		#region Métodos

		public override bool Equals(Object obj)
		{
			bool vRetorno = false;
			if (obj != null) vRetorno = (this.Id.Equals(((Alumno)obj).Id));
			return vRetorno;
		}

		public override int GetHashCode()
		{
			return 0; // ShiftAndWrap(x.GetHashCode(), 2) ^ y.GetHashCode();
		}


		#endregion
	}
}
