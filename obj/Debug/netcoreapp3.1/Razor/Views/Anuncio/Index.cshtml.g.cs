#pragma checksum "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c2c87171a94f3ebf1b4fe1616551f6349745d26"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2c87171a94f3ebf1b4fe1616551f6349745d26", @"/Views/Anuncio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"028ff04cf34ff076aa9e02b480e626b96f4da477", @"/Views/_ViewImports.cshtml")]
    public class Views_Anuncio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppBarganhaWEB.ViewsObject.AnuncioVO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
 using (Html.BeginForm("Cadastrar", "Anuncio", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <main class=\"d-flex justify-content-center\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 221, "\"", 229, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 9 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
               Write(Html.LabelFor(model => model.Nome, "Nome", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 11 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
                   Write(Html.EditorFor(model => model.Nome, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 12 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
               Write(Html.LabelFor(model => model.Descricao, "Descrição", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
                   Write(Html.EditorFor(model => model.Descricao, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 20 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Descricao, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
               Write(Html.LabelFor(model => model.InteressesSelecionados, "Categoria", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
                   Write(Html.ListBoxFor(model => model.InteressesSelecionados, ViewBag.Interesses as MultiSelectList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
               Write(Html.LabelFor(model => model.Valor, "Valor", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 34 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
                   Write(Html.EditorFor(model => model.Valor, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 35 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Valor, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"d-flex py-2\">\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 41 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
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
#line 53 "C:\Users\viesi\source\reposWEB\AppBarganhaWEB\Views\Anuncio\Index.cshtml"
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
