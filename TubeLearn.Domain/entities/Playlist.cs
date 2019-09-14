using System;
using TubeLearn.Domain.Enums;

namespace TubeLearn.Domain.entities
{
    public class Playlist
    {
        public Guid Id { get; set; }
        public Usuario Usuario { get; set; }

        //Em análise, aprovado, reprovado
        public EnumStatus Status { get; set; }
    }
}