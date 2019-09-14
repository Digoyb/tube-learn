using System;
using TubeLearn.Domain.ValueObjects;

namespace TubeLearn.Domain.entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
    }
}