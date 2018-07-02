using System;
using System.Configuration;
using System.IO;
using FileServer.Common.Model;
using FileServer.Infrastructure.Repository.Interfaces;
using Newtonsoft.Json;

namespace FileServer.Infrastructure.Repository.Repositories
{
	public class AlumnoRepository : IAlumnoRepository
	{
		String vFicheroJson = "";

		public AlumnoRepository()
		{
			vFicheroJson = ConfigurationManager.AppSettings.Get("RutaWin") +
			               ConfigurationManager.AppSettings.Get("NombreFichero");

			if (!Manager.FileManager.FileExist(vFicheroJson)) Manager.FileManager.FileCreate(vFicheroJson);
		}


		public Alumno Add(Alumno alumno)
		{
			StreamWriter sw = null;
			try
			{
				sw = new StreamWriter(vFicheroJson, true);
				string AlumnoJson = JsonConvert.SerializeObject(alumno);
				sw.WriteLine(AlumnoJson);
				alumno = JsonConvert.DeserializeObject<Alumno>(AlumnoJson);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				alumno.Id = 0;
			}
			finally
			{
				if (sw != null) sw.Close();
			}

			return alumno;
		}
	}
}
