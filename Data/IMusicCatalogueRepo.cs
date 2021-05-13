using System.Collections.Generic;
using MusicCatalogue.Models;

namespace MusicCatalogue.Data
{
    public interface IMusicCatalogueRepo
    {
        IEnumerable<Album> GetAllAlbums();
        IEnumerable<Album> GetAlbumsByArtist(string artist);
        IEnumerable<Album> GetAlbumsByYear(int year);
        
    }
}