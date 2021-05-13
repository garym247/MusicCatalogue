using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MusicCatalogue.Data;
using MusicCatalogue.Models;

namespace MusicCatalogue.Controllers
{
    [Route("api/MusicCatalogue")]
    [ApiController]
    public class MusicCatalogueController : ControllerBase
    {
        private readonly MockMusicCatalogueRepo repo = new MockMusicCatalogueRepo();

        [HttpGet("GetAlbumsByArtist")]
        public ActionResult<IEnumerable<Album>> GetAlbumsByArtist()
        {
            return Ok(repo.GetAlbumsByArtist(""));
        }

        [HttpGet("GetAlbumsByYear")]
        public ActionResult<IEnumerable<Album>>  GetAlbumsByYear()
        {
            return Ok(repo.GetAlbumsByYear(0));
        }

        [HttpGet("GetAllAlbums")]
        public ActionResult<IEnumerable<Album>>  GetAllAlbums()
        {
            return Ok(repo.GetAllAlbums());
        }
        
    }
}