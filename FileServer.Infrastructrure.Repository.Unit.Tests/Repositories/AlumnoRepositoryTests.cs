using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileServer.Infrastructure.Repository.Interfaces;
using FileServer.Common.Model;
using Moq;


namespace FileServer.Infrastructure.Repository.Repositories.Tests
{
	[TestClass()]
	public class AlumnoRepositoryTests
	{
		private IAlumnoRepository mockObject; // siempre se emula la interficie

		Alumno alumno = new Common.Model.Alumno
		{

			Id = 1,
			Nombre = "Alberto",
			Apellidos = "Azor Polo",
			Dni = "12345678A"
		};

		[TestInitialize] // se ejecuta antes que el metodo de test
		public void Setup()
		{
			var mock = new Moq.Mock<IAlumnoRepository>();
			mock.Setup(x => x.Add(alumno)).Returns(alumno);
			mockObject = mock.Object;
		}

		[TestMethod()]
		public void AddTest()
		{
			var result = mockObject.Add(alumno);
		  Assert.AreEqual(alumno, result);
		}
	}
}