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

			var alumno = new Alumno(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
			iAlumnoRepository.Add(alumno);
		}
	}
}
