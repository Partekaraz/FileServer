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
		public static Boolean FileExist(String Path)
		{
			return File.Exists(Path);
		}

		public static Boolean FileCreate(String Path)
		{
			StreamWriter streamWriter = null;
			Boolean vRetorno = true;
			try
			{
				if (!File.Exists(Path)) streamWriter = new StreamWriter(Path);
			}
			catch
			{
				vRetorno = false;
			}
			finally
			{
				if (streamWriter != null) streamWriter.Close();
			}

			return vRetorno;

		}

		//public static Boolean FileWrite(String Path)
		//{
		//	StreamWriter streamWriter = null;
		//	Boolean vRetorno = true;
		//	try
		//	{
		//		if (!File.Exists(Path)) streamWriter = new StreamWriter(Path);
		//	}
		//	catch
		//	{
		//		vRetorno = false;
		//	}
		//	finally
		//	{
		//		if (streamWriter != null) streamWriter.Close();
		//	}

		//	return vRetorno;

		//	//StreamWriter streamWriter = null;
		//	//try
		//	//{
		//	//	string AlumnoJson = JsonConvert.SerializeObject(alumno);

		//	//	streamWriter = new StreamWriter(@"c:\Albert\json.txt", true);
		//	//	streamWriter.WriteLine(AlumnoJson);

		//	//	alumno = JsonConvert.DeserializeObject<Alumno>(AlumnoJson);
		//	//}
		//	//catch (Exception ex)
		//	//{
		//	//	Console.WriteLine(ex.Message);
		//	//	alumno.Id = 0;
		//	//}
		//	//finally
		//	//{
		//	//	if (streamWriter != null) streamWriter.Close();
		//	//}



		//}
	}
}
