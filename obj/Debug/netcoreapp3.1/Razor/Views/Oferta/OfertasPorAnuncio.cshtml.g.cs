#pragma checksum "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f1d02e2699adb57afb5b4c255c7748452c502f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Oferta_OfertasPorAnuncio), @"mvc.1.0.view", @"/Views/Oferta/OfertasPorAnuncio.cshtml")]
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
#line 1 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\_ViewImports.cshtml"
using AppBarganhaWEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\_ViewImports.cshtml"
using AppBarganhaWEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1d02e2699adb57afb5b4c255c7748452c502f3", @"/Views/Oferta/OfertasPorAnuncio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"028ff04cf34ff076aa9e02b480e626b96f4da477", @"/Views/_ViewImports.cshtml")]
    public class Views_Oferta_OfertasPorAnuncio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppBarganhaWEB.ViewsObject.OfertasPorAnuncioVO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/5by5.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:40px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<nav class=\"navbar navbar-expand-sm bg-dark navbar-dark\">\r\n    <a class=\"navbar-brand\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0f1d02e2699adb57afb5b4c255c7748452c502f34330", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </a>\r\n\r\n    <ul class=\"navbar-nav\">\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" ");
#nullable restore
#line 10 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                           Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" ");
#nullable restore
#line 13 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                           Write(Html.ActionLink("Voltar", "Index", "Oferta"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" ");
#nullable restore
#line 16 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                           Write(Html.ActionLink("Sair", "LogOut", "Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n    </ul>\r\n</nav>\r\n<br />\r\n\r\n");
#nullable restore
#line 22 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
  
    var anuncio = Model.Anuncio;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <h2>Anúncio</h2>
        <p>Detalhes do anúncio:</p>
        <table class=""table"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Índice</th>
                    <th>Nome</th>
                    <th>Descrição</th>
                    <th>Valor</th>
                    <th>Data da Publicação</th>
                    <th>Categoria</th>
                </tr>
            </thead>

            <tbody>
                <tr>
                    <td>1</td>
                    <td>");
#nullable restore
#line 43 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                   Write(anuncio.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                   Write(anuncio.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                   Write(anuncio.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                   Write(anuncio.DataPublicacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>A FAZER</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
            WriteLiteral(@"
<br />

<div class=""container"">
    <h2>Oferta</h2>
    <p>Detalhes da oferta:</p>
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th>Índice</th>
                <th>Descrição</th>
                <th>Valor</th>
                <th>Data da Oferta</th>
                <th>Data da Atualização</th>
                <th>Situação</th>
            </tr>
        </thead>
");
#nullable restore
#line 70 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
          
            int count = 1;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
             foreach (var oferta in Model.Ofertas)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tbody>\r\n                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 76 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 77 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                       Write(oferta.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 78 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                       Write(oferta.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 79 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                       Write(oferta.DataOferta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 80 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                       Write(oferta.DataAtualizacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 81 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                           if (oferta.Status == OfertaStatus.ABERTO)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    ");
#nullable restore
#line 84 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                               Write(Html.ActionLink("Aceitar", "Aceitar", "Oferta", new { idOferta = oferta.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 85 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                               Write(Html.ActionLink("Recusar", "Recusar", "Oferta", new { idOferta = oferta.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 87 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                            }
                            else if (oferta.Status == OfertaStatus.ACEITO)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    ");
#nullable restore
#line 91 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                               Write(Html.ActionLink("Avaliar", "Index", "Avaliacao", new { idOferta = oferta.Id, modo = "OFERTANTE" }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 93 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    ");
#nullable restore
#line 97 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                               Write(oferta.Status.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 99 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n                </tbody>\r\n");
#nullable restore
#line 103 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Oferta\OfertasPorAnuncio.cshtml"
                count++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppBarganhaWEB.ViewsObject.OfertasPorAnuncioVO> Html { get; private set; }
    }
}
#pragma warning restore 1591
