using System;

namespace TubeLearn.Domain.entities
{
    public class Favorito
    {
        public Guid Id { get; set; }
        public Video Video { get; set; }
        public Usuario Usuario { get; set; }
    }
}