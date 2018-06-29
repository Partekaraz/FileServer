using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FileServer.Infrastructure.Repository.Manager
{
	public class FileManager
	{
		public static Boolean EscribirJson(String xTexto)
		{

			throw new NotImplementedException("The method is not implemented yet");
			//StreamWriter streamWriter = null;
			//try
			//{
			//	string AlumnoJson = JsonConvert.SerializeObject(alumno);

			//	streamWriter = new StreamWriter(@"c:\Albert\json.txt", true);
			//	streamWriter.WriteLine(AlumnoJson);

			//	alumno = JsonConvert.DeserializeObject<Alumno>(AlumnoJson);
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine(ex.Message);
			//	alumno.Id = 0;
			//}
			//finally
			//{
			//	if (streamWriter != null) streamWriter.Close();
			//}
		}
	}
}
