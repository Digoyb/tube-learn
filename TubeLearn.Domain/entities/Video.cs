using System;
using TubeLearn.Domain.Entities.Base;
using TubeLearn.Domain.Enums;

namespace TubeLearn.Domain.entities
{
    public class Video : EntityBase
    {

        public Canal Canal { get; set; }
        public Playlist Playlist { get; set; }
        public string Descricao { get; set; }
        public string Tags { get; set; }
        public string OrdemNaPlaylist { get; set; }
        public string IdVideoYoutube { get; set; }
        public Usuario UsuarioSugeriu { get; set; }
        public EnumStatus Status { get; set; }
        
    }
}