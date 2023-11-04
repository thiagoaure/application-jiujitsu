namespace KbrTec.JiuJitsuSystem.Domain.Helpers;

public static class TipoUsuarioHelper
{
    public static string GetRole(ETipoUsuario tipoUsuario)
    {
        switch (tipoUsuario)
        {
            case ETipoUsuario.ADMIN:
                return "ADMIN";
            case ETipoUsuario.USUARIO_COMUM:
                return "USUARIO_COMUM";
            default:
                return null;
        }
    }
}
