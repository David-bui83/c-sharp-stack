#pragma checksum "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojo/Views/Home/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ee501d1c5ad9c157c84978f7c91e69a7636f95f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojo/Views/_ViewImports.cshtml"
using dojo;

#line default
#line hidden
#line 4 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojo/Views/Home/Result.cshtml"
using dojo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee501d1c5ad9c157c84978f7c91e69a7636f95f", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a56997a5b890d0d1620eddc2da9408bc1675809", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dojo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojo/Views/Home/Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
            BeginContext(75, 337, true);
            WriteLiteral(@"<h1>Results</h1>
    <div class=""jumbotron"">
      <h1>Submitted Info</h1>
      <hr class=""my-4"">
      <div class=""row"">
        <div class=""col-6"" >
          <h3>Name:</h3>
          <h3>Dojo Location:</h3>
          <h3>Language:</h3>
          <h3>Comment:</h3>
        </div>
        <div class=""col-6"">
          <h3>");
            EndContext();
            BeginContext(413, 10, false);
#line 18 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojo/Views/Home/Result.cshtml"
         Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(423, 21, true);
            WriteLiteral("</h3>\r\n          <h3>");
            EndContext();
            BeginContext(445, 14, false);
#line 19 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojo/Views/Home/Result.cshtml"
         Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(459, 21, true);
            WriteLiteral("</h3>\r\n          <h3>");
            EndContext();
            BeginContext(481, 14, false);
#line 20 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojo/Views/Home/Result.cshtml"
         Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(495, 21, true);
            WriteLiteral("</h3>\r\n          <h3>");
            EndContext();
            BeginContext(517, 13, false);
#line 21 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojo/Views/Home/Result.cshtml"
         Write(Model.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(530, 124, true);
            WriteLiteral("</h3>\r\n        </div>\r\n        <br>\r\n          <a  href=\"/\" class=\"btn btn-dark btn-lg mt-5\">Go Back</a>\r\n      </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dojo> Html { get; private set; }
    }
}
#pragma warning restore 1591