﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                 new Evento(){
                 EventoId = 1,
                 Tema = "Angular 11 e .NET 5",
                 Local = "Belo Horizonte",
                 Lote = "1º Lote",
                 QtdPessoas = 15,
                 DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                 ImagemURL = "Foto.png"
             },
             new Evento(){
                 EventoId = 2,
                 Tema = "Angular e suas novidades",
                 Local = "Uberlandia",
                 Lote = "2º Lote",
                 QtdPessoas = 50,
                 DataEvento = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"),
                 ImagemURL = "Foto2.png"
             }
        };
        public EventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
             return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
             return _evento.Where(s => s.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
             return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
             return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
             return $"Exemplo de delete com id = {id}";
        }
    }
}
