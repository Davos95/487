#pragma checksum "C:\Users\AlumnoMCSD\source\repos\ClienteEmpleadosCoreAPI\ClienteEmpleadosCoreAPI\Views\Empleados\EmpleadosCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4735178beb0310173748ae3b2cf714dfd094de0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleados_EmpleadosCliente), @"mvc.1.0.view", @"/Views/Empleados/EmpleadosCliente.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Empleados/EmpleadosCliente.cshtml", typeof(AspNetCore.Views_Empleados_EmpleadosCliente))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\AlumnoMCSD\source\repos\ClienteEmpleadosCoreAPI\ClienteEmpleadosCoreAPI\Views\_ViewImports.cshtml"
using ClienteEmpleadosCoreAPI;

#line default
#line hidden
#line 2 "C:\Users\AlumnoMCSD\source\repos\ClienteEmpleadosCoreAPI\ClienteEmpleadosCoreAPI\Views\_ViewImports.cshtml"
using ClienteEmpleadosCoreAPI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4735178beb0310173748ae3b2cf714dfd094de0", @"/Views/Empleados/EmpleadosCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30444d35043b4366f769d164f2f73daac1df24b", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleados_EmpleadosCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\AlumnoMCSD\source\repos\ClienteEmpleadosCoreAPI\ClienteEmpleadosCoreAPI\Views\Empleados\EmpleadosCliente.cshtml"
  
    ViewData["Title"] = "EmpleadosCliente";

#line default
#line hidden
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(74, 1673, true);
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            cargarEmpleados();
            $(""#botonBuscar"").click(function () {
                var salario = $(""#salario"").val();
                var apiurl = ""https://apiempleadosdvb.azurewebsites.net/api/EmpleadosSalario/"" + salario;
                $.ajax({
                    url: apiurl,
                    dataType: ""json"",
                    success: function (data) {
                        $(""#cuerpo"").html("""");
                        var html = """";
                        $.each(data, function (key, value) {
                            html += ""<tr>"";
                            html += ""<td>"" + value.Apellido + ""</td><td>"" + value.Oficio + ""</td><td>"" + value.Salario + ""</td>"";
                            html += ""</tr>"";
                        });

                        $(""#cuerpo"").append(html);
                    }
                });
            });
        });

        function cargarEmpleados() {
       ");
                WriteLiteral(@"     var apiurl = ""https://apiempleadosdvb.azurewebsites.net/api/Empleados"";
            $.ajax({
                url: apiurl,
                dataType: false,
                success: function (data) {
                    var html = """";
                    $.each(data, function (key, value) {
                        html += ""<tr>"";
                        html += ""<td>"" + value.Apellido + ""</td><td>"" + value.Oficio + ""</td><td>"" + value.Salario + ""</td>"";
                        html += ""</tr>"";
                    });

                    $(""#cuerpo"").append(html);
                }
            });
        }
    </script>
");
                EndContext();
            }
            );
            BeginContext(1750, 464, true);
            WriteLiteral(@"<h2>EmpleadosCliente</h2>

<div>
    <label>Salario: </label>
    <input type=""text"" id=""salario"" class=""form-control"" />
    <button type=""button"" id=""botonBuscar"" class=""btn btn-success"">Buscar empleados</button>
</div>
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>APELLIDO</th>
            <th>OFICIO</th>
            <th>SALARIO</th>
        </tr>
    </thead>
    <tbody id=""cuerpo"">

    </tbody>
</table>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
