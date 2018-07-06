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
		private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public frmAlumno()
		{
			InitializeComponent();
			iAlumnoRepository = new AlumnoRepository();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			log.Info("Envío alumno.");
			var alumno = new Alumno(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
			iAlumnoRepository.Add(alumno);
			log.Info("Alumno insertado.");
		}

		private void frmAlumno_Load(object sender, EventArgs e)
		{

		}
	}
}
