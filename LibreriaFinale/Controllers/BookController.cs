using LibreriaFinale.Model.Dto;
using LibreriaFinale.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using LibreriaFinale.Database;
using LibreriaFinale.Model;

namespace LibreriaFinale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly ILogger<LibroController> _logger;
        private readonly ApplicationDbContext _db;
        
        public LibroController(ILogger<LibroController> logger, ApplicationDbContext db)
        {
            _db = db;
            _logger = logger;
        }

        [HttpGet("GetLibreria", Name = "GetLibreria")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<LibroDTO>> GetLibri()
        {
            _logger.LogInformation("Get libri nella libreria");
            var listaLibri = _db.Scaffale;
            if (listaLibri == null || !listaLibri.Any())
            {
                return NoContent();
            }

            return Ok(_db.Scaffale.ToList());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<LibroDTO> CreateLibro([FromBody] LibroDTO librodto)
        {
            if (librodto == null)
            {
                return BadRequest();
            }

            Libro model = new() 
            {
                ISBN = librodto.ISBN,
                Autore = librodto.Autore,
                Genere = librodto.Genere,
                Titolo = librodto.Titolo,
                Anno = librodto.Anno
            };

            _db.Scaffale.Add(model);
            _db.SaveChanges();

            return CreatedAtAction(nameof(GetLibro), new { titolo = librodto.Titolo }, librodto);
        }

        [HttpDelete("{isbn}", Name = "DeleteLibro")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult DeleteBiblioteca(string isbn)
        {
            if (isbn.Length != 10 && isbn.Length != 13) return BadRequest();
            var libro = _db.Scaffale.FirstOrDefault(l => l.ISBN == isbn);
            if (libro == null) return NotFound();
            _db.Scaffale    .Remove(libro);
            return CreatedAtAction(nameof(GetLibri), new { }, libro);
        }

        [HttpGet("{titolo}", Name = "GetLibro")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<LibroDTO> GetLibro(string titolo)
        {
            if (titolo == null)
            {
                _logger.LogError("Get libro error with titolo " + titolo);
                return BadRequest();
            }
            var libro = _db.Scaffale.FirstOrDefault(l => l.Titolo.ToLower().Equals(titolo.ToLower()));
            if (libro == null) return NotFound();
            return Ok(libro);
        }

        [HttpPatch("{isbn}", Name = "UpdatePartialScaffale")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult UpdatePartialScaffale(string isbn, JsonPatchDocument<LibroDTO> patchDTO)
        {
            if (patchDTO == null || !_db.Scaffale.Any(l => l.ISBN.Equals(isbn))) return BadRequest();

            var libro = _db.Scaffale.AsNoTracking().FirstOrDefault(l => l.ISBN == isbn);
            if (libro == null) return NotFound();

            LibroDTO libroDTO = new LibroDTO()
            {
                ISBN = libro.ISBN,
                Autore = libro.Autore,
                Genere = libro.Genere,
                Titolo = libro.Titolo,
                Anno = libro.Anno
            };

            patchDTO.ApplyTo(libroDTO, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

            Libro model = new Libro()
            {
                ISBN = libroDTO.ISBN,
                Autore = libroDTO.Autore,
                Genere = libroDTO.Genere,
                Titolo = libroDTO.Titolo,
                Anno = libroDTO.Anno
            };

            _db.Scaffale.Update(model);
            _db.SaveChanges();

            if (!ModelState.IsValid) return BadRequest(ModelState);

            return CreatedAtAction(nameof(GetLibro), new { titolo = libro.Titolo }, libro);
        }
    }
}
