#pragma checksum "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "666ca654c93b5fe7bbbc20d141dac5454658ff09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
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
#line 1 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\_ViewImports.cshtml"
using GerenciadorCondominios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\_ViewImports.cshtml"
using GerenciadorCondominios.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
using GerenciadorCondominios.BLL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"666ca654c93b5fe7bbbc20d141dac5454658ff09", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b7e14b9ef93b8f167e18c3ab93b41ee90dab424", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GerenciadorCondominios.BLL.Models.Usuario>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Confirmacoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-floating blue darken-4 tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GerenciarUsuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-position", new global::Microsoft.AspNetCore.Html.HtmlString("right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tooltip", new global::Microsoft.AspNetCore.Html.HtmlString("Gerenciar usuário"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/OperacoesUsuario.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 5 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Moradores cadastrados";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"tabelas\">\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "666ca654c93b5fe7bbbc20d141dac5454658ff096422", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <div class=""collection with-header"">
        <div class=""collection-header grey darken-1"">
            <div class=""row"">
                <div class=""col s10"">
                    <h6 class=""white-text"">Moradores cadastrados</h6>
                </div>

                <div class=""col s2"">

                </div>
            </div>
        </div>

        <div class=""collection-item"">

            <table class=""striped highlight"">
                <thead>
                    <tr>
                        <th>
                            Nome
                        </th>

                        <th>
                            CPF
                        </th>

                        <th>
                            Email
                        </th>

                        <th>
                            Telefone
                        </th>
                        
                        <th>
                            Status
                        </th>
                    </tr>
               ");
            WriteLiteral(" </thead>\n                <tbody>\n");
#nullable restore
#line 54 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>\n                            ");
#nullable restore
#line 58 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 61 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 64 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 67 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </td>\n\n");
#nullable restore
#line 70 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                         if (item.Status == StatusConta.Analisando)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\n                                <span class=\"new badge purple darken-3\" data-badge-caption=\"\"");
            BeginWriteAttribute("id", " id=\"", 2118, "\"", 2131, 1);
#nullable restore
#line 73 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2123, item.Id, 2123, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                                                                                                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            </td>\n");
            WriteLiteral("                            <td");
            BeginWriteAttribute("class", " class=\"", 2249, "\"", 2265, 1);
#nullable restore
#line 76 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2257, item.Id, 2257, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                <a class=\"btn-floating blue darken-4 btnAprovar tooltip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2356, "\"", 2411, 6);
            WriteAttributeValue("", 2366, "AprovarUsuarios(\'", 2366, 17, true);
#nullable restore
#line 77 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2383, item.Id, 2383, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2391, "\',", 2391, 2, true);
            WriteAttributeValue(" ", 2393, "\'", 2394, 2, true);
#nullable restore
#line 77 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2395, item.UserName, 2395, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2409, "\')", 2409, 2, true);
            EndWriteAttribute();
            WriteLiteral(" data-position=\"right\" data-tooltip=\"Aprovar usuário\"><i class=\"material-icons\">thumb_up</i></a>\n                                <a class=\"btn-floating red darken-4 btnReprovar tooltip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2597, "\"", 2653, 6);
            WriteAttributeValue("", 2607, "ReprovarUsuarios(\'", 2607, 18, true);
#nullable restore
#line 78 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2625, item.Id, 2625, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2633, "\',", 2633, 2, true);
            WriteAttributeValue(" ", 2635, "\'", 2636, 2, true);
#nullable restore
#line 78 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
WriteAttributeValue("", 2637, item.UserName, 2637, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2651, "\')", 2651, 2, true);
            EndWriteAttribute();
            WriteLiteral(" data-position=\"right\" data-tooltip=\"Reprovar usuário\"><i class=\"material-icons\">thumb_down</i></a>\n\n                            </td>\n");
#nullable restore
#line 81 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"

                        }
                        else if (item.Status == StatusConta.Aprovado)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\n                                <span class=\"new badge green darken-3\" data-badge-caption=\"\">");
#nullable restore
#line 86 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            </td>\n");
            WriteLiteral("                            <td>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "666ca654c93b5fe7bbbc20d141dac5454658ff0915186", async() => {
                WriteLiteral("<i class=\"material-icons\">group</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-usuarioId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                                                                                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["usuarioId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-usuarioId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["usuarioId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                                                                                                                                                                         WriteLiteral(item.UserName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </td>\n");
#nullable restore
#line 92 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\n                                <span class=\"new badge orange darken-3\" data-badge-caption=\"\">");
#nullable restore
#line 97 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            </td>\n");
#nullable restore
#line 99 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\n");
#nullable restore
#line 101 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Usuarios\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "666ca654c93b5fe7bbbc20d141dac5454658ff0920310", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GerenciadorCondominios.BLL.Models.Usuario>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
