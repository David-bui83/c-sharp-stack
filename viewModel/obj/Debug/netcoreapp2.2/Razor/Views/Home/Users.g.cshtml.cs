#pragma checksum "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/viewModel/Views/Home/Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "524b92a21936d652c055c975323ece7062e137d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Users.cshtml", typeof(AspNetCore.Views_Home_Users))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"524b92a21936d652c055c975323ece7062e137d2", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44bf715d409bf95b936f712de5d814da16221c57", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/viewModel/Views/Home/Users.cshtml"
  
    ViewData["Title"] = "Users";
    ViewData["Header"] = "Here are some Users!";

#line default
#line hidden
            BeginContext(87, 52, true);
            WriteLiteral("<h1 style=\"text-align: center; margin-bottom:30px;\">");
            EndContext();
            BeginContext(140, 18, false);
#line 5 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/viewModel/Views/Home/Users.cshtml"
                                               Write(ViewData["Header"]);

#line default
#line hidden
            EndContext();
            BeginContext(158, 70, true);
            WriteLiteral("</h1>\n\n<div style=\"width:30%; border: 1px solid #333; padding:20px;\">\n");
            EndContext();
#line 8 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/viewModel/Views/Home/Users.cshtml"
      
        for(int i = 0; i<@Model.Count;i++)
        {

#line default
#line hidden
            BeginContext(288, 17, true);
            WriteLiteral("            <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 305, "\"", 362, 4);
            WriteAttributeValue("", 312, "/SingleUser/", 312, 12, true);
#line 11 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/viewModel/Views/Home/Users.cshtml"
WriteAttributeValue("", 324, Model[i].FirstName, 324, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 343, "/", 343, 1, true);
#line 11 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/viewModel/Views/Home/Users.cshtml"
WriteAttributeValue("", 344, Model[i].LastName, 344, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(363, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(365, 18, false);
#line 11 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/viewModel/Views/Home/Users.cshtml"
                                                                       Write(Model[i].FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(383, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(385, 17, false);
#line 11 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/viewModel/Views/Home/Users.cshtml"
                                                                                           Write(Model[i].LastName);

#line default
#line hidden
            EndContext();
            BeginContext(402, 9, true);
            WriteLiteral("</a></p>\n");
            EndContext();
#line 12 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/viewModel/Views/Home/Users.cshtml"
        }
    

#line default
#line hidden
            BeginContext(427, 7, true);
            WriteLiteral("</div>\n");
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
