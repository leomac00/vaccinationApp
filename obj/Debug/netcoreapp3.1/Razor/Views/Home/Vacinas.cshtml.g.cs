#pragma checksum "C:\Projects\DotNet\DesafioMVC\Views\Home\Vacinas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df711aee0031f9eb6a8a61da592028ce689d08d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Vacinas), @"mvc.1.0.view", @"/Views/Home/Vacinas.cshtml")]
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
#nullable restore
#line 1 "C:\Projects\DotNet\DesafioMVC\Views\_ViewImports.cshtml"
using DesafioMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\DotNet\DesafioMVC\Views\_ViewImports.cshtml"
using DesafioMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df711aee0031f9eb6a8a61da592028ce689d08d7", @"/Views/Home/Vacinas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a443293351d1bb8ff9cea475559de325c26e078", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Vacinas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DesafioMVC.Models.Vacina>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projects\DotNet\DesafioMVC\Views\Home\Vacinas.cshtml"
  
  Layout = "_Layout";
  ViewData["Title"] = "Vacinas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df711aee0031f9eb6a8a61da592028ce689d08d73234", async() => {
                WriteLiteral(@"
  <script src=""https://code.jquery.com/jquery-3.6.0.min.js""
        integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4="" crossorigin=""anonymous""></script>
  <script src=""https://cdn.datatables.net/1.10.25/js/jquery.dataTables.min.js""></script>
  <script>
    $(document).ready(function () {
      $('#tabela').DataTable({
        ""searching"": false,
        ""language"": {
          ""lengthMenu"": ""Mostrando _MENU_ registros por página"",
          ""zeroRecords"": ""Nenhuma informação encontrada"",
          ""info"": ""Páginas: _PAGE_ / _PAGES_"",
          ""infoEmpty"": ""Páginas: 0 / _PAGES_"",
          ""search"": ""Buscar: "",
          ""paginate"": {
            ""first"": "" Primeiro "",
            ""last"": "" Último "",
            ""next"": "" Próximo "",
            ""previous"": "" Anterior ""
          }
        }
      });

    });
  </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<h2>Vacinas cadastradas</h2>
<hr />

<table id=""tabela"" class=""table table-striped table-bordered"">
  <thead>
    <tr>
      <th>ID</th>
      <th>Nome</th>
      <th>Laboratório</th>
      <th>Posologia</th>
      <th>Intervalo entre doses<br>[Dias]</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 47 "C:\Projects\DotNet\DesafioMVC\Views\Home\Vacinas.cshtml"
     foreach (var vacina in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n        <td>");
#nullable restore
#line 50 "C:\Projects\DotNet\DesafioMVC\Views\Home\Vacinas.cshtml"
       Write(vacina.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 51 "C:\Projects\DotNet\DesafioMVC\Views\Home\Vacinas.cshtml"
       Write(vacina.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 52 "C:\Projects\DotNet\DesafioMVC\Views\Home\Vacinas.cshtml"
       Write(vacina.Laboratorio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n");
#nullable restore
#line 54 "C:\Projects\DotNet\DesafioMVC\Views\Home\Vacinas.cshtml"
            
              if(vacina.Posologia)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Dose dupla</span>\r\n");
#nullable restore
#line 58 "C:\Projects\DotNet\DesafioMVC\Views\Home\Vacinas.cshtml"
              } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Dose única</span>\r\n");
#nullable restore
#line 60 "C:\Projects\DotNet\DesafioMVC\Views\Home\Vacinas.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\r\n        <td>");
#nullable restore
#line 63 "C:\Projects\DotNet\DesafioMVC\Views\Home\Vacinas.cshtml"
              
              if(vacina.Posologia)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 66 "C:\Projects\DotNet\DesafioMVC\Views\Home\Vacinas.cshtml"
                 Write(vacina.Intervalo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 67 "C:\Projects\DotNet\DesafioMVC\Views\Home\Vacinas.cshtml"
              } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span> N/A </span>\r\n");
#nullable restore
#line 69 "C:\Projects\DotNet\DesafioMVC\Views\Home\Vacinas.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      </tr>\r\n");
#nullable restore
#line 72 "C:\Projects\DotNet\DesafioMVC\Views\Home\Vacinas.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DesafioMVC.Models.Vacina>> Html { get; private set; }
    }
}
#pragma warning restore 1591
