#pragma checksum "C:\Users\cfalv\Desktop\Repositorios\c#\aspnet\DocsTutorialHelloWorld\Pages\Hello.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c49541af5024de2a2af354f2bb5528ce3e3b4c4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DocsTutorialHelloWorld.Pages.Pages_Hello), @"mvc.1.0.razor-page", @"/Pages/Hello.cshtml")]
namespace DocsTutorialHelloWorld.Pages
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
#line 1 "C:\Users\cfalv\Desktop\Repositorios\c#\aspnet\DocsTutorialHelloWorld\Pages\_ViewImports.cshtml"
using DocsTutorialHelloWorld;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c49541af5024de2a2af354f2bb5528ce3e3b4c4f", @"/Pages/Hello.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6861168cb91c7705a00dcea2421bfafc53cf3df1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Hello : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\cfalv\Desktop\Repositorios\c#\aspnet\DocsTutorialHelloWorld\Pages\Hello.cshtml"
  
    ViewData["Title"] = "Hello World";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome <small>");
#nullable restore
#line 8 "C:\Users\cfalv\Desktop\Repositorios\c#\aspnet\DocsTutorialHelloWorld\Pages\Hello.cshtml"
                                    Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelloModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HelloModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HelloModel>)PageContext?.ViewData;
        public HelloModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
