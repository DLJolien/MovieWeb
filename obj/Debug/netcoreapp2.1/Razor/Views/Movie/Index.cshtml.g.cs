#pragma checksum "C:\Users\Jolien\source\repos\DLJolien\MovieWeb\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8450e695457f1f5975cb8e344fae1aaed3eb45dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Index.cshtml", typeof(AspNetCore.Views_Movie_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8450e695457f1f5975cb8e344fae1aaed3eb45dc", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc64e988175f2517e3aa8d079c79e989ebc3798", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 11, true);
            WriteLiteral("\r\n<table>\r\n");
            EndContext();
#line 4 "C:\Users\Jolien\source\repos\DLJolien\MovieWeb\Views\Movie\Index.cshtml"
     foreach (MovieListViewModel movie in Model)
    {

#line default
#line hidden
            BeginContext(109, 26, true);
            WriteLiteral("    <tr> \r\n        <td> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 135, "\"", 164, 2);
            WriteAttributeValue("", 142, "movie/detail/", 142, 13, true);
#line 7 "C:\Users\Jolien\source\repos\DLJolien\MovieWeb\Views\Movie\Index.cshtml"
WriteAttributeValue("", 155, movie.Id, 155, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(165, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(167, 11, false);
#line 7 "C:\Users\Jolien\source\repos\DLJolien\MovieWeb\Views\Movie\Index.cshtml"
                                         Write(movie.Title);

#line default
#line hidden
            EndContext();
            BeginContext(178, 33, true);
            WriteLiteral("</a> </td>\r\n        \r\n    </tr>\r\n");
            EndContext();
#line 10 "C:\Users\Jolien\source\repos\DLJolien\MovieWeb\Views\Movie\Index.cshtml"
    }  

#line default
#line hidden
            BeginContext(220, 12, true);
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
