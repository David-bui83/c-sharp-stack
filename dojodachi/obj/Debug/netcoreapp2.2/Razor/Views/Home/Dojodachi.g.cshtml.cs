#pragma checksum "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48c208c22ddb9e5c45df7c2651543ef75334315b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dojodachi), @"mvc.1.0.view", @"/Views/Home/Dojodachi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dojodachi.cshtml", typeof(AspNetCore.Views_Home_Dojodachi))]
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
#line 1 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/_ViewImports.cshtml"
using dojodachi;

#line default
#line hidden
#line 2 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/_ViewImports.cshtml"
using dojodachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48c208c22ddb9e5c45df7c2651543ef75334315b", @"/Views/Home/Dojodachi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02c43adf8f00d921e1e3f242ef2bcc39f1c89303", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dojodachi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dachi>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml"
  
    ViewData["Title"] = "Dojodachi";

#line default
#line hidden
            BeginContext(55, 45, true);
            WriteLiteral("<div class=\"text-center\">\n    <h3 >Fullness: ");
            EndContext();
            BeginContext(101, 14, false);
#line 6 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml"
              Write(Model.Fullness);

#line default
#line hidden
            EndContext();
            BeginContext(115, 12, true);
            WriteLiteral(" Happiness: ");
            EndContext();
            BeginContext(128, 15, false);
#line 6 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml"
                                         Write(Model.Happiness);

#line default
#line hidden
            EndContext();
            BeginContext(143, 8, true);
            WriteLiteral(" Meals: ");
            EndContext();
            BeginContext(152, 11, false);
#line 6 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml"
                                                                 Write(Model.Meals);

#line default
#line hidden
            EndContext();
            BeginContext(163, 9, true);
            WriteLiteral(" Energy: ");
            EndContext();
            BeginContext(173, 12, false);
#line 6 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml"
                                                                                      Write(Model.Energy);

#line default
#line hidden
            EndContext();
            BeginContext(185, 46, true);
            WriteLiteral("</h3>\n    <div class=\"jumbotron\">\n        <h3>");
            EndContext();
            BeginContext(232, 10, false);
#line 8 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(242, 345, true);
            WriteLiteral(@"</h3>
        <div style=""width: 300px; height: 275px; border: 1px solid black; margin: auto;"">
            <img style=""width:100%; display: block;"" src=""https://assets.pokemon.com/assets/cms2/img/pokedex/full/007.png"" alt=""squirtle"">
        </div>
        <br>
        <!-- <p>You played with your Dojodachi! Happiness +10, Energy -5</p> -->

");
            EndContext();
#line 16 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml"
             if(ViewBag.gameOver == true)
            {

#line default
#line hidden
            BeginContext(654, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(674, 11, false);
#line 18 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml"
              Write(ViewBag.msg);

#line default
#line hidden
            EndContext();
            BeginContext(685, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 19 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(735, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(755, 9, false);
#line 22 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml"
              Write(Model.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(764, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 23 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml"
            }

#line default
#line hidden
            BeginContext(793, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
#line 28 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml"
         if(ViewBag.gameOver == true)
        {

#line default
#line hidden
            BeginContext(860, 67, true);
            WriteLiteral("            <a class=\"btn btn-dark btn-lg\" href=\"/reset\">Reset</a>\n");
            EndContext();
#line 31 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(960, 333, true);
            WriteLiteral(@"            <a class=""btn btn-dark btn-lg"" href=""/feed/"">Feed</a> 
            <a class=""btn btn-dark btn-lg"" href=""/play"">Play</a> 
            <a class=""btn btn-dark btn-lg"" href=""/work"">Work</a> 
            <a class=""btn btn-dark btn-lg"" href=""/sleep"">Sleep</a>
            <a class=""btn btn-dark btn-lg"" href=""/reset"">Reset</a>
");
            EndContext();
#line 39 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/dojodachi/Views/Home/Dojodachi.cshtml"
        }

#line default
#line hidden
            BeginContext(1310, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dachi> Html { get; private set; }
    }
}
#pragma warning restore 1591