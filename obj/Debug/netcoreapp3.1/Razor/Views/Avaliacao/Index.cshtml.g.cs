#pragma checksum "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da1aaf6658765d03a3e93068cc4f1973cf1935db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Avaliacao_Index), @"mvc.1.0.view", @"/Views/Avaliacao/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da1aaf6658765d03a3e93068cc4f1973cf1935db", @"/Views/Avaliacao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"028ff04cf34ff076aa9e02b480e626b96f4da477", @"/Views/_ViewImports.cshtml")]
    public class Views_Avaliacao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppBarganhaWEB.ViewsObject.AvaliacaoVO>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "da1aaf6658765d03a3e93068cc4f1973cf1935db4964", async() => {
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
#line 10 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                           Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" ");
#nullable restore
#line 13 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                           Write(Html.ActionLink("Voltar", "OfertasOfertante", "Oferta"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" ");
#nullable restore
#line 16 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                           Write(Html.ActionLink("Sair", "LogOut", "Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n    </ul>\r\n</nav>\r\n\r\n<br />\r\n\r\n");
#nullable restore
#line 23 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
  
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
                    <th>Data de Publicação</th>
                    <th>Data de Encerramento</th>
                    <th>Foto</th>
                    <th>Categoria</th>
                </tr>
            </thead>

            <tbody>
                <tr>
                    <td>1</td>
                    <td>");
#nullable restore
#line 46 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                   Write(anuncio.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                   Write(anuncio.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>R$ ");
#nullable restore
#line 48 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                      Write(anuncio.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                   Write(anuncio.DataPublicacao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                   Write(anuncio.DataFinal.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td>
                        <div class=""container"">
                            <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#modalAnuncioSS"">Imagem</button>
                            <div class=""modal"" id=""modalAnuncioSS"">
                                <div class=""modal-dialog"">
                                    <div class=""modal-content"">
                                        <div class=""modal-body"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da1aaf6658765d03a3e93068cc4f1973cf1935db10123", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2159, "~/img/", 2159, 6, true);
#nullable restore
#line 58 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
AddHtmlAttributeValue("", 2165, anuncio.Foto, 2165, 13, false);

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
                        <div class=""dropdown"">
                            <button type=""button"" class=""btn btn-primary dropdown-toggle"" data-toggle=""dropdown"">Categorias</button>
                            <div class=""dropdown-menu"">
");
#nullable restore
#line 69 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                                 foreach (var categorias in anuncio.Categorias)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"dropdown-item\">");
#nullable restore
#line 71 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                                                        Write(categorias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 72 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
            WriteLiteral("\r\n<br />\r\n\r\n");
#nullable restore
#line 84 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
  
    var oferta = Model.Oferta;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
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
                </tr>
            </thead>

            <tbody>
                <tr>
                    <td>1</td>
                    <td>");
#nullable restore
#line 104 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                   Write(oferta.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 105 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                   Write(oferta.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 106 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                   Write(oferta.DataOferta.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 107 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                   Write(oferta.DataAtualizacao.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 115 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
  
    var usuario = Model.Usuario;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n");
#nullable restore
#line 119 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
         if (Model.Modo == "ANUNCIANTE")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Anunciante</h2>\r\n            <p>Detalhes do anunciante a ser avaliado:</p>\r\n");
#nullable restore
#line 123 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Ofertante</h2>\r\n            <p>Detalhes do ofertante a ser avaliado:</p>\r\n");
#nullable restore
#line 128 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Índice</th>
                    <th>Login</th>
                    <th>Pontuação</th>
                    <th>Foto</th>
                </tr>
            </thead>

            <tbody>
                <tr>
                    <td>1</td>
                    <td>");
#nullable restore
#line 142 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                   Write(usuario.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 143 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                   Write(usuario.Pontuacao);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td>
                        <div class=""container"">
                            <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#modalAnuncioUU"">Imagem</button>
                            <div class=""modal"" id=""modalAnuncioUU"">
                                <div class=""modal-dialog"">
                                    <div class=""modal-content"">
                                        <div class=""modal-body"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da1aaf6658765d03a3e93068cc4f1973cf1935db17888", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5327, "~/img/", 5327, 6, true);
#nullable restore
#line 151 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
AddHtmlAttributeValue("", 5333, usuario.Foto, 5333, 13, false);

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
                </tr>
            </tbody>
        </table>
    </div>
");
            WriteLiteral("\r\n");
#nullable restore
#line 164 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
 using (Html.BeginForm("Avaliar", "Avaliacao", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h2>Avaliação</h2>
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th>Positivo</th>
                <th>Neutro</th>
                <th>Negativo</th>
            </tr>
        </thead>

        <tbody>
            <tr>
                <td>&#128515 ");
#nullable restore
#line 178 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                        Write(Html.RadioButton("Pontos", "Positivo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>&#128528 ");
#nullable restore
#line 179 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                        Write(Html.RadioButton("Pontos", "Neutro"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>&#128544 ");
#nullable restore
#line 180 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
                        Write(Html.RadioButton("Pontos", "Negativo"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
            </tr>
        </tbody>
    </table>
    <div class=""container"">
        <div class=""d-flex py-2"">
            <div class=""col-md-10"">
                <input type=""submit"" value=""Avaliar"" class=""btn btn-success form-control px-5"" />
            </div>
        </div>
        ");
#nullable restore
#line 190 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
   Write(Html.HiddenFor(model => model.Usuario.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 191 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
   Write(Html.HiddenFor(model => model.Oferta.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 192 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
   Write(Html.HiddenFor(model => model.Modo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 194 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Avaliacao\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppBarganhaWEB.ViewsObject.AvaliacaoVO> Html { get; private set; }
    }
}
#pragma warning restore 1591
