#pragma checksum "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5024a043fc34e6ac756979dfa0b06385d28f51d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\_ViewImports.cshtml"
using ETicaretBasic.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\_ViewImports.cshtml"
using ETicaretBasic.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5024a043fc34e6ac756979dfa0b06385d28f51d", @"/Areas/Admin/Views/Categories/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df2aeb21e2998c9b0f7fedf08bea87dbae1f0728", @"/Areas/Admin/Views/Categories/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Categories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ETicaretBasic.Models.Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 10 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
Write(lang["Detaylar"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<div class=\"container\">\n    <h1>");
#nullable restore
#line 13 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
   Write(lang["Baslik"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n    <div>\n\n        <hr />\n        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 20 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 23 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 26 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n");
#nullable restore
#line 28 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
             if (Model.Active == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-10\">\n                    <span >");
#nullable restore
#line 31 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
                      Write(lang["Aktif"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </dt>\n");
#nullable restore
#line 33 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
 }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-10\">\n                    <span>");
#nullable restore
#line 37 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
                     Write(lang["Deaktif"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </dt>\n");
#nullable restore
#line 39 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dl>\n    </div>\n    <div class=\"row\">\n        <div class=\"col-md-3\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5024a043fc34e6ac756979dfa0b06385d28f51d8413", async() => {
                WriteLiteral("\n                <div class=\"form-group\">\n                    <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 1229, "\"", 1253, 1);
#nullable restore
#line 46 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 1237, lang["Duzenle"], 1237, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-block btn-primary\" />\n                </div>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
                                                   WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <div class=\"col-md-3\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5024a043fc34e6ac756979dfa0b06385d28f51d11705", async() => {
                WriteLiteral("\n                <div class=\"form-group\">\n                    <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 1500, "\"", 1527, 1);
#nullable restore
#line 53 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 1508, lang["ListeyeDon"], 1508, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-block btn-primary\" />\n                </div>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </div>\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<ETicaretBasic.lang> lang { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ETicaretBasic.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
