﻿using ApiExamenAWS2.Models;
using ApiExamenAWS2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiExamenAWS2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private RepositoryEventos repo;

        public EventosController(RepositoryEventos repo) 
        {
            this.repo = repo;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Evento>>> GetEventos()
        {
            return await this.repo.GetEventosAsync();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<CategoriaEvento>>> GetCategorias()
        {
            return await this.repo.GetCategoriasAsync();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<List<Evento>>> EventosCategorias(int id)
        { 
            return await this.repo.GetEventosCategoriasAsync(id);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Evento>> FindEvento(int idcategoria)
        {
            return await this.repo.FindEventoAsync(idcategoria);
        }

    }
}
