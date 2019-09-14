using TubeLearn.Domain.Arguments.Usuario;

namespace TubeLearn.Domain.Interfaces.Services
{
    public interface IServiceUsuario
    {

        AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request);

        AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);



    }
}