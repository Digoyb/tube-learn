using System;

namespace TubeLearn.Domain.entities
{
    public class Video
    {
        public Guid Id { get; set; }
        public Canal Canal { get; set; }
        public Playlist Playlist { get; set; }
        public string Descricao { get; set; }
        public string Tags { get; set; }
        public string OrdemNaPlaylist { get; set; }
        public string IdVideoYoutube { get; set; }
        public Usuario UsuarioSugeriu { get; set; }
        public string Status { get; set; }
        
    }
}