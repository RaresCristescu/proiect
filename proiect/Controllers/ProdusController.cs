﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proiect.Models;
using proiect.Models.DTOs;
using proiect.Services.ProdusServ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdusController : ControllerBase
    {
        private readonly IProdusService _produsService;
        public ProdusController(IProdusService produsService)
        {
            _produsService = produsService;
        }

        [HttpGet("getAll")]
        public IActionResult GetByTitleHeader()//[FromHeader]
        {
            var result = _produsService.GetAllDataMapped();
            return Ok(result);
        }

        [HttpGet("readByTitlu")]
        public IActionResult GetByCodPostal(string titlu)//[FromHeader]
        {
            var result = _produsService.GetDataMappedByTitlu(titlu);
            return Ok(result);
        }

        [HttpGet("readById")]
        public IActionResult GetById(Guid Id)//[FromHeader]
        {
            var result = _produsService.GetDataMappedById(Id);
            return Ok(result);
        }

        [HttpGet("fromQuery")]
        public IActionResult GetByTitleQuerr([FromQuery]string titlu)//[FromHeader]
        {
            var result = _produsService.GetDataMappedByTitlu(titlu);
            return Ok(result);
        }
        [HttpGet("fromHeader")]
        public IActionResult GetByTitleHeader([FromHeader]string titlu)//[FromHeader]
        {
            var result = _produsService.GetDataMappedByTitlu(titlu);
            return Ok(result);
        }
        [HttpPost("create")]
        public IActionResult Create(ProdusRequestDTO produs)
        {
            var produsToCreate = new Produs
            {
                Titlu = produs.Titlu,
                Descriere = produs.Descriere,
                Imagine = produs.Imagine,
                Pret = produs.Pret,
                CategorieId=produs.CategorieId
            };
            var result = _produsService.PostDataMappedByTitlu(produsToCreate);
            return Ok(result);
        }
        [HttpPost("fromForm")]
        public IActionResult CreateFromForm([FromForm]ProdusRequestDTO produs)
        {
            var produsToCreate = new Produs
            {
                Titlu = produs.Titlu,
                Descriere = produs.Descriere,
                Imagine = produs.Imagine,
                Pret = produs.Pret,
                CategorieId = produs.CategorieId
            };
            var result = _produsService.PostDataMappedByTitlu(produsToCreate);
            return Ok(result);
        }
        [HttpPut("update")]
        public IActionResult Update(Guid produsId, ProdusRequestDTO produs)
        {
            var produsToCreate = new Produs
            {
                Titlu = produs.Titlu,
                Descriere = produs.Descriere,
                Imagine = produs.Imagine,
                Pret = produs.Pret
            };

            var result = _produsService.PutDataMappedById(produsId, produsToCreate);
            return Ok(result);
        }
        [HttpDelete("deleteById")]
        public IActionResult Delete(Guid produsId)
        {
            var result = _produsService.DeleteDataMappedById(produsId);
            return Ok(result);
        }

    }
}
