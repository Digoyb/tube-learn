using System;
using TubeLearn.Domain.Entities.Base;
using TubeLearn.Domain.Enums;

namespace TubeLearn.Domain.entities
{
    public class Playlist: EntityBase
    {
        public Usuario Usuario { get; set; }

        //Em análise, aprovado, reprovado
        public EnumStatus Status { get; set; }
    }
}