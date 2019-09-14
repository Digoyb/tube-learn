using System;
using TubeLearn.Domain.entities;

namespace TubeLearn.Domain.Interfaces.Repositories
{
    public interface IRepositoryUsuario
    {
        Usuario Obter(Guid Id);
        Usuario Obter(string email, string senha);

        void Salvar(Usuario usuario);

        bool Existe(string email);
    }
}