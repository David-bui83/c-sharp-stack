#pragma checksum "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/Home/AddProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f7fe2de9199d304ed887d788df18708b4027097"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddProduct), @"mvc.1.0.view", @"/Views/Home/AddProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AddProduct.cshtml", typeof(AspNetCore.Views_Home_AddProduct))]
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
#line 1 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/_ViewImports.cshtml"
using products;

#line default
#line hidden
#line 2 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/_ViewImports.cshtml"
using products.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f7fe2de9199d304ed887d788df18708b4027097", @"/Views/Home/AddProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b969181cdd7a0166bf1e000b157ecc68b3e717bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Association>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-for", new global::Microsoft.AspNetCore.Html.HtmlString("ProductId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/Home/AddProduct.cshtml"
  
  ViewData["Title"] = "Add Product";

#line default
#line hidden
            BeginContext(61, 24, true);
            WriteLiteral("<h1 class=\"text-center\">");
            EndContext();
            BeginContext(86, 21, false);
#line 5 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/Home/AddProduct.cshtml"
                   Write(ViewBag.catName.CName);

#line default
#line hidden
            EndContext();
            BeginContext(107, 83, true);
            WriteLiteral("</h1>\n<div class=\"row mt-5\">\n  <div class=\"col-6\">\n    <h2>Products:</h2>\n    <ul>\n");
            EndContext();
#line 10 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/Home/AddProduct.cshtml"
       
       foreach(var p in ViewBag.catName.ProAss)
       {

#line default
#line hidden
            BeginContext(255, 17, true);
            WriteLiteral("         <li><h3>");
            EndContext();
            BeginContext(273, 14, false);
#line 13 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/Home/AddProduct.cshtml"
            Write(p.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(287, 11, true);
            WriteLiteral("</h3></li>\n");
            EndContext();
#line 14 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/Home/AddProduct.cshtml"
       }
     

#line default
#line hidden
            BeginContext(314, 71, true);
            WriteLiteral("    </ul>\n  </div>\n  <div class=\"col-6\">\n    <h2>Add Product:</h2>\n    ");
            EndContext();
            BeginContext(385, 402, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f7fe2de9199d304ed887d788df18708b40270976174", async() => {
                BeginContext(458, 7, true);
                WriteLiteral("\n      ");
                EndContext();
                BeginContext(465, 236, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f7fe2de9199d304ed887d788df18708b40270976555", async() => {
                    BeginContext(514, 1, true);
                    WriteLiteral("\n");
                    EndContext();
#line 22 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/Home/AddProduct.cshtml"
         
         foreach(var p in ViewBag.pros)
         {

#line default
#line hidden
                    BeginContext(576, 11, true);
                    WriteLiteral("           ");
                    EndContext();
                    BeginContext(587, 78, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f7fe2de9199d304ed887d788df18708b40270977274", async() => {
                        BeginContext(637, 6, false);
#line 25 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/Home/AddProduct.cshtml"
                                                       Write(p.Name);

#line default
#line hidden
                        EndContext();
                        BeginContext(643, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(645, 11, false);
#line 25 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/Home/AddProduct.cshtml"
                                                               Write(p.ProductId);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    BeginWriteTagHelperAttribute();
#line 25 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/Home/AddProduct.cshtml"
                                  WriteLiteral(p.ProductId);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(665, 1, true);
                    WriteLiteral("\n");
                    EndContext();
#line 26 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/Home/AddProduct.cshtml"
         }
       

#line default
#line hidden
                    BeginContext(686, 6, true);
                    WriteLiteral("      ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 21 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/Home/AddProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(701, 79, true);
                WriteLiteral("\n      <button type=\"submit\" class=\"btn btn-dark btn-lg mt-4\">Add</button>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 399, "/addProduct/add/", 399, 16, true);
#line 20 "/Users/davidbui/Desktop/stack_projects/c-sharp-stack/products/Views/Home/AddProduct.cshtml"
AddHtmlAttributeValue("", 415, ViewBag.catName.CategoryId, 415, 27, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(787, 16, true);
            WriteLiteral("\n  </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Association> Html { get; private set; }
    }
}
#pragma warning restore 1591
