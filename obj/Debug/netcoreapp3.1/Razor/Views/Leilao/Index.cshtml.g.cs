#pragma checksum "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "860a80e0d5b410c973e0b160876a2c3429f363a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leilao_Index), @"mvc.1.0.view", @"/Views/Leilao/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"860a80e0d5b410c973e0b160876a2c3429f363a1", @"/Views/Leilao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"028ff04cf34ff076aa9e02b480e626b96f4da477", @"/Views/_ViewImports.cshtml")]
    public class Views_Leilao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppBarganhaWEB.ViewsObject.LeilaoVO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/5by5.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:40px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "860a80e0d5b410c973e0b160876a2c3429f363a14946", async() => {
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
#line 10 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                           Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" ");
#nullable restore
#line 13 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                           Write(Html.ActionLink("Sair", "LogOut", "Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
        </li>
    </ul>
</nav>
<br />
<div class=""container"">
    <h2>Leilão</h2>
    <p>Lista de anúncios com categorias em comum com seus interesses:</p>
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th>Índice</th>
                <th>Nome</th>
                <th>Descrição</th>
                <th>Data de Publicação</th>
                <th>Data de Encerramento</th>
                <th>Valor</th>
                <th>Categorias</th>
                <th>Foto</th>
                <th>Ofertar</th>
                <th>Situação</th>
            </tr>
        </thead>
");
#nullable restore
#line 36 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
          
            int count = 1;

            string nameModal = "Modal";

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
             foreach (var anuncio in Model.Anuncios)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tbody>\r\n                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 45 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                       Write(anuncio.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                       Write(anuncio.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                       Write(anuncio.DataPublicacao.ToString("g"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                       Write(anuncio.DataFinal.ToString("g"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                       Write(anuncio.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>
                            <div class=""dropdown"">
                                <button type=""button"" class=""btn btn-primary dropdown-toggle"" data-toggle=""dropdown"">Categorias</button>
                                <div class=""dropdown-menu"">
");
#nullable restore
#line 55 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                                     foreach (var categorias in anuncio.Categorias)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"dropdown-item\">");
#nullable restore
#line 57 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                                                            Write(categorias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 58 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""container"">
                                <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#");
#nullable restore
#line 64 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                                                                                                           Write(nameModal);

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                                                                                                                     Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Imagem</button>\r\n                                <div class=\"modal\"");
            BeginWriteAttribute("id", " id=\"", 2582, "\"", 2603, 2);
#nullable restore
#line 65 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
WriteAttributeValue("", 2587, nameModal, 2587, 10, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
WriteAttributeValue("", 2597, count, 2597, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"modal-dialog\">\r\n                                        <div class=\"modal-content\">\r\n                                            <div class=\"modal-body\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "860a80e0d5b410c973e0b160876a2c3429f363a112724", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2868, "~/img/", 2868, 6, true);
#nullable restore
#line 69 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
AddHtmlAttributeValue("", 2874, anuncio.Foto, 2874, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class=""d-flex py-2"">
                                <div class=""col-md-10"">
                                    ");
#nullable restore
#line 79 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                               Write(Html.ActionLink("Ofertar", "Index", "Oferta", new { idAnuncio = anuncio.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 83 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                       Write(anuncio.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n");
#nullable restore
#line 86 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Leilao\Index.cshtml"
                count++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppBarganhaWEB.ViewsObject.LeilaoVO> Html { get; private set; }
    }
}
#pragma warning restore 1591
