using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileServer.Common.Model;

namespace FileServer.Infrastructure.Repository.Interfaces
{
	public interface IAlumnoRepository
	{
		Alumno Add(Alumno alumno);
	}
}
