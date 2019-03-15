using ApiEmpleadosSeguridad.Models;
using ApiEmpleadosSeguridad.Repositories;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace ApiEmpleadosSeguridad.Credentials
{
    public class AutorizationEmpleadosToken: OAuthAuthorizationServerProvider
    {
        RepositoryEmpleados repo;
        public AutorizationEmpleadosToken()
        {
            this.repo = new RepositoryEmpleados();
        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            return base.ValidateClientAuthentication(context);
        }

        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            //DEBEMOS VALIDAR EL USUARIO Y PASSWORD
            //DICHOS VALORES VIENEN DENTRO DEL CONTEXT
            String Apellido = context.UserName;
            int empno = int.Parse(context.Password);
            Empleado empleado = this.repo.ExisteEmpleado(Apellido, empno);
            if(empleado == null)
            {
                //SI NO EXITE EL EMPLEADO, INCLUIMOS UN ERROR DENTRO DEL CONTEXT PARA QUE NO LO VALIDE
                context.SetError("USUARIO/PASSWORD incorrecto",  "Has introducido mal tus credenciales");
            } else
            {
                //EL EMPLEADO EXISTE Y CREAMOS UNA IDENTIDAD
                ClaimsIdentity identity = new ClaimsIdentity(context.Options.AuthenticationType);
                //AÑADIMOS DATOS A LA IDENTIDAD POR SI DESEAMOS UTILIZARLOS EN ALGUN MOMENTO
                identity.AddClaim(new Claim(ClaimTypes.Name,empleado.Apellido));
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, empleado.IdEmpleado.ToString()));
                identity.AddClaim(new Claim(ClaimTypes.Role, empleado.Oficio));
                //INCLUIMOS LA IDENTIDAD DENTRO DE LA VALIDACION 
                context.Validated(identity);
            }
            return base.GrantResourceOwnerCredentials(context);
        }

    }
}