#pragma checksum "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/viewModel/Views/Home/SingleUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70336b6c0741de73395e500ff81e5f7116e7a9a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SingleUser), @"mvc.1.0.view", @"/Views/Home/SingleUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SingleUser.cshtml", typeof(AspNetCore.Views_Home_SingleUser))]
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
#line 1 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/viewModel/Views/_ViewImports.cshtml"
using viewModel;

#line default
#line hidden
#line 2 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/viewModel/Views/_ViewImports.cshtml"
using viewModel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70336b6c0741de73395e500ff81e5f7116e7a9a6", @"/Views/Home/SingleUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44bf715d409bf95b936f712de5d814da16221c57", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SingleUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/viewModel/Views/Home/SingleUser.cshtml"
  
    ViewData["Title"] = "User";
    ViewData["Header"] = "Here is a User!";

#line default
#line hidden
            BeginContext(81, 52, true);
            WriteLiteral("<h1 style=\"text-align: center; margin-bottom:30px;\">");
            EndContext();
            BeginContext(134, 18, false);
#line 5 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/viewModel/Views/Home/SingleUser.cshtml"
                                               Write(ViewData["Header"]);

#line default
#line hidden
            EndContext();
            BeginContext(152, 81, true);
            WriteLiteral("</h1>\n\n<div style=\"width:30%; border: 1px solid #333; padding:20px;\">\n    \n</div>");
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
