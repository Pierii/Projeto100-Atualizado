#pragma checksum "c:\Users\Usuário\Desktop\FinalProject\Views\Shared\_Sucesso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67618c66e56a1e0b8131c5afaeb171a4d4b70e97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Sucesso), @"mvc.1.0.view", @"/Views/Shared/_Sucesso.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Sucesso.cshtml", typeof(AspNetCore.Views_Shared__Sucesso))]
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
#line 1 "c:\Users\Usuário\Desktop\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#line 2 "c:\Users\Usuário\Desktop\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67618c66e56a1e0b8131c5afaeb171a4d4b70e97", @"/Views/Shared/_Sucesso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cd403b176af46e85ea812cbc8b3a7a1a86d4d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Sucesso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "c:\Users\Usuário\Desktop\FinalProject\Views\Shared\_Sucesso.cshtml"
  
    Html.RenderPartial("_NavBar", ViewData["user"]);

#line default
#line hidden
            BeginContext(61, 50, true);
            WriteLiteral("<h2>Seu cadastro foi concluído com sucesso!</h2>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
