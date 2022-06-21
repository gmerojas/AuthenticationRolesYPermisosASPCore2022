using AuthRolPermisosCSharp2022.Models;

namespace AuthRolPermisosCSharp2022.Data
{
    public class DA_Logica
    {
        public List<Usuario> ListaUsuarios()
        {
            return new List<Usuario>
            {
                new Usuario{ Nombre="jose",Correo="administrador@gmail.com",Clave="123",Roles=new string[]{ "Administrador"} },
                new Usuario{ Nombre="jose",Correo="supervisor@gmail.com",Clave="123",Roles=new string[]{ "Supervisor" } },
                new Usuario{ Nombre="jose",Correo="empleado@gmail.com",Clave="123",Roles=new string[]{ "Empleado" } },
                new Usuario{ Nombre="jose",Correo="superempleado@gmail.com",Clave="123",Roles=new string[]{ "Administrador", "Empleado" } }
            };
        }

        public Usuario ValidarUsuario(string correo, string clave)
        {
            return ListaUsuarios().Where(item => item.Correo == correo && item.Clave == clave).FirstOrDefault();
        }
    }
}
