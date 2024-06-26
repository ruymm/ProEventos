﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos1.API.Data;
using Proeventos1.API.Models;

namespace Proeventos1.API.Controllers
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
        //com rota diferente
        [HttpGet("{id}")]
        public Evento GetBys(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        } 
         [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put com id={id}";
        } 
         [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id={id}";
        } 
    }
}
