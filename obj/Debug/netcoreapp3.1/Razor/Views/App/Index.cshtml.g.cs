#pragma checksum "C:\Users\mahek\source\repos\MahekaruProfileCore\Views\App\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c900f0b65d9c5f18204e0bb789219feba302dbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Index), @"mvc.1.0.view", @"/Views/App/Index.cshtml")]
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
#line 1 "C:\Users\mahek\source\repos\MahekaruProfileCore\Views\_ViewImports.cshtml"
using MahekaruProfileCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mahek\source\repos\MahekaruProfileCore\Views\_ViewImports.cshtml"
using MahekaruProfileCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c900f0b65d9c5f18204e0bb789219feba302dbb", @"/Views/App/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d17696c6fa83b45ee7127368f495ff9915690dac", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MahekaruProfileCore.Models.AppModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/app.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mahek\source\repos\MahekaruProfileCore\Views\App\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c900f0b65d9c5f18204e0bb789219feba302dbb4174", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2c900f0b65d9c5f18204e0bb789219feba302dbb4440", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<wrapper>\r\n    <logo></logo>\r\n    <apps>\r\n");
#nullable restore
#line 12 "C:\Users\mahek\source\repos\MahekaruProfileCore\Views\App\Index.cshtml"
         foreach (App i in Model.Apps)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <app>\r\n                <app-title>");
#nullable restore
#line 15 "C:\Users\mahek\source\repos\MahekaruProfileCore\Views\App\Index.cshtml"
                      Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</app-title>\r\n                <app-img>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 377, "\"", 395, 1);
#nullable restore
#line 17 "C:\Users\mahek\source\repos\MahekaruProfileCore\Views\App\Index.cshtml"
WriteAttributeValue("", 383, i.ImageName, 383, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </app-img>\r\n                <app-description>\r\n                    ");
#nullable restore
#line 20 "C:\Users\mahek\source\repos\MahekaruProfileCore\Views\App\Index.cshtml"
               Write(i.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </app-description>\r\n                <app-buttons>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 589, "\"", 609, 1);
#nullable restore
#line 23 "C:\Users\mahek\source\repos\MahekaruProfileCore\Views\App\Index.cshtml"
WriteAttributeValue("", 596, i.GithubLink, 596, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Github</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 645, "\"", 662, 1);
#nullable restore
#line 24 "C:\Users\mahek\source\repos\MahekaruProfileCore\Views\App\Index.cshtml"
WriteAttributeValue("", 652, i.AppLink, 652, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Open App</a>\r\n                </app-buttons>\r\n            </app>\r\n");
#nullable restore
#line 27 "C:\Users\mahek\source\repos\MahekaruProfileCore\Views\App\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </apps>\r\n</wrapper>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MahekaruProfileCore.Models.AppModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
