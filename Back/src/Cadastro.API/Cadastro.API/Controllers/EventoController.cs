using Cadastro.API.Data;
using Cadastro.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class EventoController : ControllerBase
	{
		private readonly DataContext _context;

		public EventoController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IEnumerable<Evento> Get()
		{
			return _context.Eventos;
		}

		[HttpGet("{id}")]
		public Evento GetById(int id)
		{
			return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
		}

		[HttpPost]
		public string Post()
		{
			return "";
		}
		[HttpPut]
		public string Put()
		{
			return "";
		}
		[HttpDelete]
		public string Delete()
		{
			return "";
		}
	}
}
