using System;

namespace TubeLearn.Domain.entities
{
    public class Playlist
    {
        public Guid Id { get; set; }
        public Usuario Usuario { get; set; }

        //Em análise, aprovado, reprovado
        public string Status { get; set; }
    }
}