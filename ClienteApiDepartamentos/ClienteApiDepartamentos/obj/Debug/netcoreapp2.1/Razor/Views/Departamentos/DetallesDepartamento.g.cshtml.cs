#pragma checksum "C:\Users\AlumnoMCSD\source\repos\ClienteApiDepartamentos\ClienteApiDepartamentos\Views\Departamentos\DetallesDepartamento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ec01f2e32f1a1ac3a34d3fd0f2f018a0d374740"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departamentos_DetallesDepartamento), @"mvc.1.0.view", @"/Views/Departamentos/DetallesDepartamento.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Departamentos/DetallesDepartamento.cshtml", typeof(AspNetCore.Views_Departamentos_DetallesDepartamento))]
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
#line 1 "C:\Users\AlumnoMCSD\source\repos\ClienteApiDepartamentos\ClienteApiDepartamentos\Views\_ViewImports.cshtml"
using ClienteApiDepartamentos;

#line default
#line hidden
#line 1 "C:\Users\AlumnoMCSD\source\repos\ClienteApiDepartamentos\ClienteApiDepartamentos\Views\Departamentos\DetallesDepartamento.cshtml"
using ClienteApiDepartamentos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ec01f2e32f1a1ac3a34d3fd0f2f018a0d374740", @"/Views/Departamentos/DetallesDepartamento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"945bc1eb0b13926a9c77d9eadb5f3c335e58e9c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Departamentos_DetallesDepartamento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Departamento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\AlumnoMCSD\source\repos\ClienteApiDepartamentos\ClienteApiDepartamentos\Views\Departamentos\DetallesDepartamento.cshtml"
  
    ViewData["Title"] = "DetallesDepartamento";

#line default
#line hidden
            BeginContext(116, 188, true);
            WriteLiteral("\r\n<h2>Detalles Departamento</h2>\r\n\r\n<div>\r\n    <h4>Departamento</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n           Numero\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(305, 12, false);
#line 17 "C:\Users\AlumnoMCSD\source\repos\ClienteApiDepartamentos\ClienteApiDepartamentos\Views\Departamentos\DetallesDepartamento.cshtml"
       Write(Model.Numero);

#line default
#line hidden
            EndContext();
            BeginContext(317, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Nombre\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(410, 12, false);
#line 23 "C:\Users\AlumnoMCSD\source\repos\ClienteApiDepartamentos\ClienteApiDepartamentos\Views\Departamentos\DetallesDepartamento.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(422, 95, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Localidad\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(518, 15, false);
#line 29 "C:\Users\AlumnoMCSD\source\repos\ClienteApiDepartamentos\ClienteApiDepartamentos\Views\Departamentos\DetallesDepartamento.cshtml"
       Write(Model.Localidad);

#line default
#line hidden
            EndContext();
            BeginContext(533, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(581, 68, false);
#line 34 "C:\Users\AlumnoMCSD\source\repos\ClienteApiDepartamentos\ClienteApiDepartamentos\Views\Departamentos\DetallesDepartamento.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(649, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(657, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7980ded450f942d2b795e31a779961c9", async() => {
                BeginContext(679, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(695, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Departamento> Html { get; private set; }
    }
}
#pragma warning restore 1591
