#pragma checksum "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "294da8b6ebc6d9bbf74c656d623fc72100a14ecc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultas_Details), @"mvc.1.0.view", @"/Views/Consultas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consultas/Details.cshtml", typeof(AspNetCore.Views_Consultas_Details))]
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
#line 1 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\_ViewImports.cshtml"
using ClinicaVeterinaria;

#line default
#line hidden
#line 2 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\_ViewImports.cshtml"
using ClinicaVeterinaria.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"294da8b6ebc6d9bbf74c656d623fc72100a14ecc", @"/Views/Consultas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f71463ec479d3cbaed29df3a99535ec7fcd0fd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicaVeterinaria.Models.Consulta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(88, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Consulta</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(211, 49, false);
#line 14 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Data_Consulta));

#line default
#line hidden
            EndContext();
            BeginContext(260, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(304, 45, false);
#line 17 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Data_Consulta));

#line default
#line hidden
            EndContext();
            BeginContext(349, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(393, 39, false);
#line 20 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet));

#line default
#line hidden
            EndContext();
            BeginContext(432, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(476, 40, false);
#line 23 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(516, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(560, 52, false);
#line 26 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet.Proprietario));

#line default
#line hidden
            EndContext();
            BeginContext(612, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(656, 53, false);
#line 29 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.Proprietario.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(709, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(753, 47, false);
#line 32 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Veterinario));

#line default
#line hidden
            EndContext();
            BeginContext(800, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(844, 48, false);
#line 35 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Veterinario.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(892, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(936, 43, false);
#line 38 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Receita));

#line default
#line hidden
            EndContext();
            BeginContext(979, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1023, 39, false);
#line 41 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Receita));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1106, 42, false);
#line 44 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Motivo));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1192, 38, false);
#line 47 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Motivo));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1274, 45, false);
#line 50 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1363, 41, false);
#line 53 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1448, 52, false);
#line 56 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ExamesRealizados));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1544, 48, false);
#line 59 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
       Write(Html.DisplayFor(model => model.ExamesRealizados));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1639, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd8e285eddf443feba0a55e90932dbfb", async() => {
                BeginContext(1685, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Consultas\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1693, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1701, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d8c23469f4e48b48500e298b60870eb", async() => {
                BeginContext(1723, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1739, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicaVeterinaria.Models.Consulta> Html { get; private set; }
    }
}
#pragma warning restore 1591