using System;
using TubeLearn.Domain.entities;

namespace TubeLearn.Domain.Arguments.Usuario
{
    public class AutenticarUsuarioResponse
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }

        public static explicit operator AutenticarUsuarioResponse(entities.Usuario v)
        {
            throw new NotImplementedException();
        }
    }
}