using System;

namespace TubeLearn.Domain.entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}