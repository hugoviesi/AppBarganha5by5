#pragma checksum "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "497996a548b712ea2f93f9d5aaec5ceeeff525a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anuncio_Index), @"mvc.1.0.view", @"/Views/Anuncio/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"497996a548b712ea2f93f9d5aaec5ceeeff525a6", @"/Views/Anuncio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"028ff04cf34ff076aa9e02b480e626b96f4da477", @"/Views/_ViewImports.cshtml")]
    public class Views_Anuncio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppBarganhaWEB.ViewsObject.AnuncioVO>
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
            WriteLiteral("\r\n\r\n<nav class=\"navbar navbar-expand-sm bg-dark navbar-dark\">\r\n    <a class=\"navbar-brand\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "497996a548b712ea2f93f9d5aaec5ceeeff525a64269", async() => {
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
#line 11 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
                           Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" ");
#nullable restore
#line 14 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
                           Write(Html.ActionLink("Sair", "LogOut", "Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n    </ul>\r\n</nav>\r\n<br />\r\n");
#nullable restore
#line 19 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
 using (Html.BeginForm("Cadastrar", "Anuncio", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h2>Cadastro de Anúncio</h2>\r\n    <p>Preencha o formulário para realizar o seu anuncio:</p>\r\n    <main class=\"d-flex justify-content-center\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 784, "\"", 792, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 27 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
           Write(Html.LabelFor(model => model.Nome, "Nome", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
               Write(Html.EditorFor(model => model.Nome, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 30 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
               Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 35 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
           Write(Html.LabelFor(model => model.Descricao, "Descrição", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
               Write(Html.EditorFor(model => model.Descricao, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 38 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
               Write(Html.ValidationMessageFor(model => model.Descricao, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 43 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
           Write(Html.LabelFor(model => model.InteressesSelecionados, "Categoria", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 45 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
               Write(Html.ListBoxFor(model => model.InteressesSelecionados, ViewBag.Interesses as MultiSelectList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 50 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
           Write(Html.LabelFor(model => model.Valor, "Valor", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 52 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
               Write(Html.EditorFor(model => model.Valor, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 53 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
               Write(Html.ValidationMessageFor(model => model.Valor, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"d-flex py-2\">\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 59 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
               Write(Html.TextBoxFor(model => model.picAnuncio, new { type = "file" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>

            <div class=""d-flex py-2"">
                <div class=""col-md-10"">
                    <input type=""submit"" id=""cadastrarAnuncio"" value=""Anunciar"" class=""btn btn-success form-control px-5"" />
                </div>
            </div>
        </div>
    </main>
</div>
");
#nullable restore
#line 71 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppBarganhaWEB.ViewsObject.AnuncioVO> Html { get; private set; }
    }
}
#pragma warning restore 1591
