using System;
using System.Windows.Forms;
using FileServer.Infrastructure.Repository.Interfaces;
using FileServer.Infrastructure.Repository.Repositories;
using FileServer.Common.Model;
using System.Configuration;

namespace FileServer.Presentation.WinSite
{
	public partial class frmAlumno : Form
	{

		IAlumnoRepository iAlumnoRepository;

		public frmAlumno()
		{
			InitializeComponent();
			iAlumnoRepository = new AlumnoRepository();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var vRuta = ConfigurationManager.AppSettings.Get("RutaWin");

			var alumno = new Alumno(1, "Alberto", "Azor Polo", "12345678A");
			iAlumnoRepository.Add(alumno);
		}
	}
}
