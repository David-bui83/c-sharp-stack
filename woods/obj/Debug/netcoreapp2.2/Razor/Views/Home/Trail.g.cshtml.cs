#pragma checksum "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/woods/Views/Home/Trail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5ef167c744d078e0947d7f7cf3db4683bbd811e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Trail), @"mvc.1.0.view", @"/Views/Home/Trail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Trail.cshtml", typeof(AspNetCore.Views_Home_Trail))]
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
#line 1 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/woods/Views/_ViewImports.cshtml"
using woods;

#line default
#line hidden
#line 2 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/woods/Views/_ViewImports.cshtml"
using woods.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ef167c744d078e0947d7f7cf3db4683bbd811e", @"/Views/Home/Trail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25eb30686995a47cbcb71b4113c570075387298d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Trail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/woods/Views/Home/Trail.cshtml"
  
  ViewData["Title"]="Mailbox Peak";

#line default
#line hidden
            BeginContext(41, 139, true);
            WriteLiteral("\n<a href=\"/\" class=\"float-right\">Go Home</a>\n<h1>Mailbox Peak</h1>\n<div class=\"row\">\n  <div class=\"col-6\">\n    <h2>Description</h2>\n    <p>");
            EndContext();
            BeginContext(181, 25, false);
#line 10 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/woods/Views/Home/Trail.cshtml"
  Write(ViewBag.Trail.Description);

#line default
#line hidden
            EndContext();
            BeginContext(206, 39, true);
            WriteLiteral("</p>\n    <h2>Trail Length:</h2>\n    <p>");
            EndContext();
            BeginContext(246, 22, false);
#line 12 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/woods/Views/Home/Trail.cshtml"
  Write(ViewBag.Trail.Distance);

#line default
#line hidden
            EndContext();
            BeginContext(268, 48, true);
            WriteLiteral(" Miles</p>\n    <h2>Elevation Change</h2>\n    <p>");
            EndContext();
            BeginContext(317, 23, false);
#line 14 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/woods/Views/Home/Trail.cshtml"
  Write(ViewBag.Trail.Elevation);

#line default
#line hidden
            EndContext();
            BeginContext(340, 271, true);
            WriteLiteral(@" feet</p>

  </div>
  <div class=""col-6"">
    <div style=""width:100%;"">
      <img style=""width: 100%; display: block;"" src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQmU-N-EpFRXcnXj2PpiuX6lLD0EpXBUSrTiBxJDFYqRGrNX0f8"" alt=""map"">
    </div>
    <p>Longitude: ");
            EndContext();
            BeginContext(612, 23, false);
#line 21 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/woods/Views/Home/Trail.cshtml"
             Write(ViewBag.Trail.Longitude);

#line default
#line hidden
            EndContext();
            BeginContext(635, 24, true);
            WriteLiteral(" N</p>\n    <p>Latitude: ");
            EndContext();
            BeginContext(660, 22, false);
#line 22 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/woods/Views/Home/Trail.cshtml"
            Write(ViewBag.Trail.Latitude);

#line default
#line hidden
            EndContext();
            BeginContext(682, 22, true);
            WriteLiteral(" W</p>\n  </div>\n</div>");
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
