#pragma checksum "C:\Users\Jolien\source\repos\DLJolien\MovieWeb\Views\Hello\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5992005233f51a7de8467e6091baf314b323fd65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hello_Welcome), @"mvc.1.0.view", @"/Views/Hello/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Hello/Welcome.cshtml", typeof(AspNetCore.Views_Hello_Welcome))]
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
#line 1 "C:\Users\Jolien\source\repos\DLJolien\MovieWeb\Views\_ViewImports.cshtml"
using MovieWeb;

#line default
#line hidden
#line 2 "C:\Users\Jolien\source\repos\DLJolien\MovieWeb\Views\_ViewImports.cshtml"
using MovieWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5992005233f51a7de8467e6091baf314b323fd65", @"/Views/Hello/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc64e988175f2517e3aa8d079c79e989ebc3798", @"/Views/_ViewImports.cshtml")]
    public class Views_Hello_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Jolien\source\repos\DLJolien\MovieWeb\Views\Hello\Welcome.cshtml"
  
    string title = "Welcome";
    string name = (string)ViewData["Name"];
    int numberOfTimes = (int)ViewData["NumberOfTimes"];

#line default
#line hidden
            BeginContext(142, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(149, 5, false);
#line 8 "C:\Users\Jolien\source\repos\DLJolien\MovieWeb\Views\Hello\Welcome.cshtml"
Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(154, 13, true);
            WriteLiteral("</h2>\r\n<ul>\r\n");
            EndContext();
#line 10 "C:\Users\Jolien\source\repos\DLJolien\MovieWeb\Views\Hello\Welcome.cshtml"
     for (int i = 0; i < numberOfTimes; i++)
    {

#line default
#line hidden
            BeginContext(220, 18, true);
            WriteLiteral("        <li>Hello ");
            EndContext();
            BeginContext(239, 4, false);
#line 12 "C:\Users\Jolien\source\repos\DLJolien\MovieWeb\Views\Hello\Welcome.cshtml"
             Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(243, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 13 "C:\Users\Jolien\source\repos\DLJolien\MovieWeb\Views\Hello\Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(257, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
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
