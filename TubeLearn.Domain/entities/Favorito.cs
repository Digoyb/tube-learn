using System;
using TubeLearn.Domain.Entities.Base;

namespace TubeLearn.Domain.entities
{
    public class Favorito: EntityBase
    {
        public Video Video { get; set; }
        public Usuario Usuario { get; set; }
    }
}