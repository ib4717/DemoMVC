#pragma checksum "/Volumes/Study/LTI/DotNet/ASP.NET/DemoMvcSolution/DemoMVC/Views/Movie/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c84a634f055bea7f1cbe5373dbf6220a380107d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_List), @"mvc.1.0.view", @"/Views/Movie/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84a634f055bea7f1cbe5373dbf6220a380107d2", @"/Views/Movie/List.cshtml")]
    #nullable restore
    public class Views_Movie_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DemoMVC.Models.Movie>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Movie Listing</h1>\n<hr />\n<table>\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 9 "/Volumes/Study/LTI/DotNet/ASP.NET/DemoMvcSolution/DemoMVC/Views/Movie/List.cshtml"
           Write(Html.DisplayNameFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 12 "/Volumes/Study/LTI/DotNet/ASP.NET/DemoMvcSolution/DemoMVC/Views/Movie/List.cshtml"
           Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 15 "/Volumes/Study/LTI/DotNet/ASP.NET/DemoMvcSolution/DemoMVC/Views/Movie/List.cshtml"
           Write(Html.DisplayNameFor(m => m.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 18 "/Volumes/Study/LTI/DotNet/ASP.NET/DemoMvcSolution/DemoMVC/Views/Movie/List.cshtml"
           Write(Html.DisplayNameFor(m => m.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 23 "/Volumes/Study/LTI/DotNet/ASP.NET/DemoMvcSolution/DemoMVC/Views/Movie/List.cshtml"
         foreach (var data in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 26 "/Volumes/Study/LTI/DotNet/ASP.NET/DemoMvcSolution/DemoMVC/Views/Movie/List.cshtml"
               Write(Html.DisplayFor(m => data.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 27 "/Volumes/Study/LTI/DotNet/ASP.NET/DemoMvcSolution/DemoMVC/Views/Movie/List.cshtml"
               Write(Html.DisplayFor(m => data.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 28 "/Volumes/Study/LTI/DotNet/ASP.NET/DemoMvcSolution/DemoMVC/Views/Movie/List.cshtml"
               Write(Html.DisplayFor(m => data.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 29 "/Volumes/Study/LTI/DotNet/ASP.NET/DemoMvcSolution/DemoMVC/Views/Movie/List.cshtml"
               Write(Html.DisplayFor(m => data.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 31 "/Volumes/Study/LTI/DotNet/ASP.NET/DemoMvcSolution/DemoMVC/Views/Movie/List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DemoMVC.Models.Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
