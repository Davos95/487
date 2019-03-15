using System;
using System.Threading.Tasks;
using System.Web.Http;
using ApiEmpleadosSeguridad.Credentials;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(ApiEmpleadosSeguridad.Startup))]

namespace ApiEmpleadosSeguridad
{
    public class Startup
    {
        //DEBEMOS CREAR UN METODO QUE CONFIGURE EL ENDPOINT DE ACCESO AL LOGIN
        //EL TIEMPO DE ACCESO CON EL TOKEN
        //Y LA CLASE PARA VALIDAR EL USUARIO
        public void ConfigurationOAuth(IAppBuilder app)
        {
            //LO PRIMERO ES CREARNOS LA CLASE CON LAS OPCIONES DE LA CONFIGURACION DE SEGURIDAD
            OAuthAuthorizationServerOptions authoptions = new OAuthAuthorizationServerOptions()
            {
                //PERMITIR ACCESO DESDE HTTP
                AllowInsecureHttp = true,
                //CREARNOS LA RUTA DE ACCESO AL TOKEN
                TokenEndpointPath = new PathString("/login"),
                //TIEMPO DE ACCESO CON EL TOKEN
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(10),
                //LA CLASE QUE SE ENCARGA DE VALIDAR AL USUARIO
                Provider = new AutorizationEmpleadosToken()
            };
            //indicar a nuestra app las opciones de autorizacion
            app.UseOAuthAuthorizationServer(authoptions);
            //CREAREMOS LAS OPCIONES DE AUTORIZACION BEARER QUE NOS GENERARAN EL TOKEN
            OAuthBearerAuthenticationOptions bearerOptions = new OAuthBearerAuthenticationOptions()
            {
                //INDICAMOS QUE UTILIZAMOS LA AUTORIZACION DE TIPO OWIN
                AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode.Active
            };
            //CONFIRMAMOS LA APLICACION INDICANDO LAS OPCIONES DE SEGURIDAD BEARER
            app.UseOAuthBearerAuthentication(bearerOptions);

        }

        public void Configuration(IAppBuilder app)
        {
            //ESTE METODO ES EL ACCESSO DE ARRANQUE DE NUESTRA APP WEB API
            //CREAMOS EL OBJETO PARA CONFIGURACION DE NUESTRA API
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);

            //SI DESEAMOS INCLUIR SEGURIDAD LLAMAMOS AL METODO DE LA CONFIGURACION OAUTH
            ConfigurationOAuth(app);

            //INDICAMOS LA APLICACION LA CONFIGURACION DEL API
            app.UseWebApi(config);
        }
    }
}
