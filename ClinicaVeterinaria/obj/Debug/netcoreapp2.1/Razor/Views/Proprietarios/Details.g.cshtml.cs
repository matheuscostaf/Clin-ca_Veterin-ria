#pragma checksum "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Proprietarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a20a731015ae49960304c161f14cdb275d1eb1e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proprietarios_Details), @"mvc.1.0.view", @"/Views/Proprietarios/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Proprietarios/Details.cshtml", typeof(AspNetCore.Views_Proprietarios_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a20a731015ae49960304c161f14cdb275d1eb1e0", @"/Views/Proprietarios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f71463ec479d3cbaed29df3a99535ec7fcd0fd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Proprietarios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicaVeterinaria.Models.Proprietario>
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Proprietarios\Details.cshtml"
  
    ViewData["Title"] = "Informações";

#line default
#line hidden
            BeginContext(96, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(103, 17, false);
#line 7 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Proprietarios\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(120, 113, true);
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <h4>Proprietario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(234, 40, false);
#line 14 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Proprietarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(274, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(318, 36, false);
#line 17 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Proprietarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(354, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(398, 38, false);
#line 20 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Proprietarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rg));

#line default
#line hidden
            EndContext();
            BeginContext(436, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(480, 34, false);
#line 23 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Proprietarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rg));

#line default
#line hidden
            EndContext();
            BeginContext(514, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(558, 44, false);
#line 26 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Proprietarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(602, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(646, 40, false);
#line 29 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Proprietarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(686, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(730, 41, false);
#line 32 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Proprietarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(771, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(815, 37, false);
#line 35 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Proprietarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(852, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(896, 44, false);
#line 38 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Proprietarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(940, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(984, 40, false);
#line 41 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Proprietarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1071, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91268305558840cd803a764ccc50ba52", async() => {
                BeginContext(1117, 4, true);
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
#line 46 "C:\Users\mathe\Desktop\Projeto OO\ClinicaVeterinaria\ClinicaVeterinaria\Views\Proprietarios\Details.cshtml"
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
            BeginContext(1125, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1133, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb6db11491a84e40957629cb46e1dab0", async() => {
                BeginContext(1155, 12, true);
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
            BeginContext(1171, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicaVeterinaria.Models.Proprietario> Html { get; private set; }
    }
}
#pragma warning restore 1591
