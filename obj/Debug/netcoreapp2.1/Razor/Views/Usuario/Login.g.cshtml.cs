#pragma checksum "c:\Users\Usuário\Desktop\FinalProject\Views\Usuario\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76e41609e046ff6faccced1a48d0a14e1467128b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Login), @"mvc.1.0.view", @"/Views/Usuario/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Login.cshtml", typeof(AspNetCore.Views_Usuario_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e41609e046ff6faccced1a48d0a14e1467128b", @"/Views/Usuario/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cd403b176af46e85ea812cbc8b3a7a1a86d4d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "c:\Users\Usuário\Desktop\FinalProject\Views\Usuario\Login.cshtml"
  
    ViewData["Title"] = "Login | Ponto Digital";
    ViewData["H2"] = "Login";

#line default
#line hidden
#line 5 "c:\Users\Usuário\Desktop\FinalProject\Views\Usuario\Login.cshtml"
  
    Html.RenderPartial("_NavBar", ViewData["User"]);

#line default
#line hidden
            BeginContext(149, 16, true);
            WriteLiteral("<main>\r\n    <h2>");
            EndContext();
            BeginContext(166, 14, false);
#line 9 "c:\Users\Usuário\Desktop\FinalProject\Views\Usuario\Login.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(180, 15, true);
            WriteLiteral("</h2>\r\n        ");
            EndContext();
            BeginContext(195, 647, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac29b07e0edf4790a98237675927cb65", async() => {
                BeginContext(256, 482, true);
                WriteLiteral(@"
            <div>
                <label for=""email"">E-mail</label>
                <br />
                <input id=""email"" type=""email"" name=""email""/>
            </div>
            <div>
                <label for=""senha"">Senha</label>
                <br />
                <input id=""senha"" type=""password"" name=""senha""/>
            </div>
            <input type=""submit"" value=""Logar"" />
            
            <div id=""link_cadastre-se"">
                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 738, "\'", 777, 1);
#line 24 "c:\Users\Usuário\Desktop\FinalProject\Views\Usuario\Login.cshtml"
WriteAttributeValue("", 745, Url.Action("Index", "Cadastro"), 745, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(778, 57, true);
                WriteLiteral(">Quero criar uma conta!</a>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 10 "c:\Users\Usuário\Desktop\FinalProject\Views\Usuario\Login.cshtml"
AddHtmlAttributeValue("", 223, Url.Action("Login", "Usuario"), 223, 31, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(842, 11, true);
            WriteLiteral("\r\n</main>\r\n");
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
