using System;

namespace TubeLearn.Domain.Arguments.Usuario
{
    public class AdicionarUsuarioResponse
    {
        public AdicionarUsuarioResponse(Guid id)
        {
            this.Id = id;

        }
        public Guid Id { get; set; }
    }
}