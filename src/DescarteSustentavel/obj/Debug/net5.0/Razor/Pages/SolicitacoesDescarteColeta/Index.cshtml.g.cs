#pragma checksum "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ca299079b0de3b9366fccd32bb86c6644addd86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DescarteSustentavel.Pages.SolicitacoesDescarteColeta.Pages_SolicitacoesDescarteColeta_Index), @"mvc.1.0.razor-page", @"/Pages/SolicitacoesDescarteColeta/Index.cshtml")]
namespace DescarteSustentavel.Pages.SolicitacoesDescarteColeta
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
#line 1 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\_ViewImports.cshtml"
using DescarteSustentavel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ca299079b0de3b9366fccd32bb86c6644addd86", @"/Pages/SolicitacoesDescarteColeta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3e83567e4211cbe79a1c08f0ee217742d2a8279", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SolicitacoesDescarteColeta_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: white; font-family: \'Rubik\', sans-serif; font-size: 1.1em; font-weight: normal; background-color: #00A4FF; border-radius: 8px; border: none; display: flex; flex-wrap: nowrap; align-content: center;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"flex-container\" ");
            WriteLiteral(@""">
    <div id=""titulo_icon_botao"" style=""display: flex; flex-wrap: nowrap; align-items: center; justify-content: space-between; margin-top: 10vh; margin-bottom: 4vh;"">
        <h1 style=""font-family: 'Rubik', sans-serif; font-size: 2.2em; font-weight: lighter; color: #000; text-align: left; width: 900px;  display: flex; align-items: center;""><img src=""/historico_icon.svg"" alt=""icon_historico"" width=""50vh"" style=""margin-right: 2vh;"">Histórico de Descartes</h1>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ca299079b0de3b9366fccd32bb86c6644addd865443", async() => {
                WriteLiteral("\r\n            <img src=\"/nova-solicitacao_icon.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 3125, "\"", 3131, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"margin: 0 15px; padding: 0;\">\r\n            <p style=\"margin-right: 15px;\">Nova Solicitação</p>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <h1 style=""font-family: 'Rubik', sans-serif; font-size: 28px; font-weight: normal; color: #000; text-align: left; width: 900px; margin-top: 5vh; margin-bottom: 6px;"">RECICLÁVEIS</h1>
    <div style=""display: flex; flex-wrap: nowrap; align-items:center; justify-content:start;"">
        <span style=""width: 100px; height: 5px; background-image: linear-gradient(to right,#00FFB9, #00A4FF); border-radius: 100em; margin: 0 0 25px;""></span>
    </div>
    <div class=""cardsCorpo"" style=""display: flex; flex-direction: row; flex-wrap: wrap; align-items: center; justify-content: space-between;"">
");
#nullable restore
#line 81 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
         foreach (var item in Model.SolicitacaoDescarteColeta)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
             if (item.TipoDoMaterial == "Reciclável")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card1"" style=""border-radius: 18px; box-shadow: 0 4px 8px 0 rgba(100, 100, 100, 0.2), 0 6px 20px 0 rgba(100, 100, 100, 0.19); width: 275px; height: 375px; padding: 5px 5px 0;"">
                    <div style=""display: flex; flex-wrap: nowrap; align-items:center; justify-content: space-between; margin: 20px 3px 0 20px;"">
                        <h1 style=""font-family: 'Rubik', sans-serif; font-weight: lighter; font-size: 24px; color: #000; margin-bottom: 6px;"">");
#nullable restore
#line 87 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                                                                                                                                         Write(Html.DisplayFor(modelItem => item.TipoDoMaterial));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                        <span style=""width: 20px; height: 20px; background-color: red; border-radius: 50%; margin: 0 20px 5px 0;""></span>
                    </div>
                    <span class=""col-12"" style=""display: flex; flex-wrap: nowrap; align-items:center; width: 50px; height: 5px; background-color: #10FF69; border-radius: 100em; margin: 0 0 0 20px;""></span>

                    <ul style=""font-family: 'Rubik', sans-serif; font-weight: lighter; font-size: 0.9em; color: #000; list-style: none; text-align: left; padding: 0 0 0 25px; margin-top: 25px;"">
                        <li><b>Numero da Solicitação:</b>   ");
#nullable restore
#line 93 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.IDSolicitacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <br>\r\n                        <li><b>Ecoponto:</b>  ");
#nullable restore
#line 95 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.IDDescartador));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </li>
                        <br>
                        <div style=""display: flex; flex-wrap: nowrap; align-items:center;"">
                            <span style=""width: 225px; height: 2px; background-color: #C8C8C8; border-radius: 100em; margin: 0 0 20px 0;""></span>
                        </div>
                        <li><b>Data da Solicitação:</b> ");
#nullable restore
#line 100 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.DataDaSolicitacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <br>\r\n                        <li><b>Qtde de Itens:</b> ");
#nullable restore
#line 102 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.QtdeDeItens));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <br>\r\n                        <li><b>Status:</b> Em Andamento</li>\r\n                        <br>\r\n                        <li><b>Data de Encerramento:</b> ");
#nullable restore
#line 106 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                                                    Write(Html.DisplayFor(modelItem => item.DataDeEncerramento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                </div>\r\n");
#nullable restore
#line 109 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"     </div>

    <h1 style=""font-family: 'Rubik', sans-serif; font-size: 28px; font-weight: normal; color: #000; text-align: left; width: 900px; margin-top: 5vh; margin-bottom: 6px;"">ELETRÔNICOS</h1>
    <div style=""display: flex; flex-wrap: nowrap; align-items:center; justify-content:start;"">
        <span style=""width: 100px; height: 5px; background-image: linear-gradient(to right,#00FFB9, #00A4FF); border-radius: 100em; margin: 0 0 25px;""></span>
    </div>
            <div class=""cardsCorpo"" style=""display: flex; flex-direction: row; flex-wrap: nowrap; align-items: center; justify-content: space-between;"">
");
#nullable restore
#line 118 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                 foreach (var item in Model.SolicitacaoDescarteColeta)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                     if (item.TipoDoMaterial == "Eletronico")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""card1"" style=""border-radius: 18px; box-shadow: 0 4px 8px 0 rgba(100, 100, 100, 0.2), 0 6px 20px 0 rgba(100, 100, 100, 0.19); width: 275px; height: 375px; padding: 5px 5px 0;"">
                            <div style=""display: flex; flex-wrap: nowrap; align-items:center; justify-content: space-between; margin: 20px 3px 0 20px;"">
                                <h1 style=""font-family: 'Rubik', sans-serif; font-weight: lighter; font-size: 24px; color: #000; margin-bottom: 6px;"">");
#nullable restore
#line 124 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                                                                                                                                                 Write(Html.DisplayFor(modelItem => item.TipoDoMaterial));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                                <span style=""width: 20px; height: 20px; background-color: red; border-radius: 50%; margin: 0 20px 5px 0;""></span>
                            </div>
                            <span class=""col-12"" style=""display: flex; flex-wrap: nowrap; align-items: center; width: 50px; height: 5px; background-color: #005AFF; border-radius: 100em; margin: 0 0 0 20px;""></span>

                            <ul style=""font-family: 'Rubik', sans-serif; font-weight: lighter; font-size: 0.9em; color: #000; list-style: none; text-align: left; padding: 0 0 0 25px; margin-top: 25px;"">
                                <li><b>Numero da Solicitação:</b>   ");
#nullable restore
#line 130 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.IDSolicitacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                <br>\r\n                                <li><b>Ecoponto:</b>  ");
#nullable restore
#line 132 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.IDDescartador));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </li>
                                <br>
                                <div style=""display: flex; flex-wrap: nowrap; align-items:center;"">
                                    <span style=""width: 225px; height: 2px; background-color: #C8C8C8; border-radius: 100em; margin: 0 0 20px 0;""></span>
                                </div>
                                <li><b>Data da Solicitação:</b> ");
#nullable restore
#line 137 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.DataDaSolicitacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                <br>\r\n                                <li><b>Qtde de Itens:</b> ");
#nullable restore
#line 139 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.QtdeDeItens));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                <br>\r\n                                <li><b>Status:</b> Em Andamento</li>\r\n                                <br>\r\n                                <li><b>Data de Encerramento:</b> ");
#nullable restore
#line 143 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.DataDeEncerramento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            </ul>\r\n                        </div>\r\n");
#nullable restore
#line 146 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\Users\gusta\source\repos\DescarteSustentavel\Pages\SolicitacoesDescarteColeta\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DescarteSustentavel.Pages.SolicitacoesDescarteColeta.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DescarteSustentavel.Pages.SolicitacoesDescarteColeta.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DescarteSustentavel.Pages.SolicitacoesDescarteColeta.IndexModel>)PageContext?.ViewData;
        public DescarteSustentavel.Pages.SolicitacoesDescarteColeta.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
