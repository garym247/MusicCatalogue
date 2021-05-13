using System.Collections.Generic;
using MusicCatalogue.Models;

namespace MusicCatalogue.Data
{
    public class MockMusicCatalogueRepo : IMusicCatalogueRepo
    {
        public IEnumerable<Album> GetAlbumsByArtist(string artist)
        {
            return new List<Album> 
            {
                new Album {Artist="Depeche Mode", Title="Songs Of Faith and Devotion", Year=1993}
            };
        }

        public IEnumerable<Album> GetAlbumsByYear(int year)
        {
            return new List<Album> 
            {
                new Album {Artist="Nick Drake", Title="Pink Mook", Year=1970}
            };
        }

        public IEnumerable<Album> GetAllAlbums()
        {
            return new List<Album> 
            {
                new Album {Artist="Rush", Title="Hemispheres", Year=1979},
                new Album {Artist="Elliot Smith", Title="Figure 8", Year=1979},
                new Album {Artist="Gary Numan", Title="Telekon", Year=1979}
            };
        }
    }
}