using System;
using TubeLearn.Domain.Entities.Base;
using TubeLearn.Domain.ValueObjects;

namespace TubeLearn.Domain.entities
{
    public class Usuario: EntityBase
    {
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
    }
}