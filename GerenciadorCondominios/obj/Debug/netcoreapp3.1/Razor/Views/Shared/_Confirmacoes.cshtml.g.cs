#pragma checksum "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43d5a59eb44a9f8e4d59eb2a3f463915e8f8a346"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Confirmacoes), @"mvc.1.0.view", @"/Views/Shared/_Confirmacoes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d5a59eb44a9f8e4d59eb2a3f463915e8f8a346", @"/Views/Shared/_Confirmacoes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b7e14b9ef93b8f167e18c3ab93b41ee90dab424", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Confirmacoes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
 if (TempData["NovoRegistro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-panel green darken-3 valign-wrapper white-text\">\n        <div class=\"col s1\">\n            <i class=\"material-icons\">check_box</i>\n        </div>\n\n        <div class=\"col s11\">\n            ");
#nullable restore
#line 9 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
       Write(TempData["NovoRegistro"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n");
#nullable restore
#line 12 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 15 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
 if (TempData["Atualizacao"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-panel blue darken-3 valign-wrapper white-text\">\n        <div class=\"col s1\">\n            <i class=\"material-icons\">check_box</i>\n        </div>\n\n        <div class=\"col s11\">\n            ");
#nullable restore
#line 23 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
       Write(TempData["Atualizacao"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n");
#nullable restore
#line 26 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 28 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
 if (TempData["Exclusao"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-panel red darken-3 valign-wrapper white-text\">\n        <div class=\"col s1\">\n            <i class=\"material-icons\">check_box</i>\n        </div>\n\n        <div class=\"col s11\">\n            ");
#nullable restore
#line 36 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
       Write(TempData["Exclusao"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n");
#nullable restore
#line 39 "E:\Udemy\GerenciadorCondominios-master\GerenciadorCondominios\Views\Shared\_Confirmacoes.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
