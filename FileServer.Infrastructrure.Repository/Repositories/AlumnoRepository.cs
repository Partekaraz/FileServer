using System;
using FileServer.Common.Model;
using FileServer.Infrastructure.Repository.Interfaces;
using Newtonsoft.Json;

namespace FileServer.Infrastructure.Repository.Repositories
{
	public class AlumnoRepository : IAlumnoRepository
	{
		public Alumno Add(Alumno alumno)
		{
			try
			{
				string AlumnoJson = JsonConvert.SerializeObject(alumno);

				Manager.FileManager.EscribirJson(@"c:\Albert\json.txt");

				alumno = JsonConvert.DeserializeObject<Alumno>(AlumnoJson);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				alumno.Id = 0;
			}

			return alumno;
		}
	}
}
