using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileServer.Infrastructure.Repository.Interfaces;
using FileServer.Common.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FileServer.Infrastructure.Repository.Repositories.Tests
{
	[TestClass()]
	public class AlumnoRepositorynTests
	{
		IAlumnoRepository iAlumnoRepository = new AlumnoRepository();

		[DataTestMethod()]
		[DataRow(1, "Alberto", "Azor Polo", "12345678A")]
		[DataRow(2, "Miquel", "Casals Barbany", "12345678A")]
		public void AddTest(Int32 xId, String xNombre, String xApellidos, String xDni)
		{
			Alumno alumnoIn = new Alumno(xId, xNombre, xApellidos, xDni);
			Alumno alumnoOut = iAlumnoRepository.Add(alumnoIn);
			Assert.IsTrue(alumnoIn.Equals(alumnoOut));
		}
	}
}