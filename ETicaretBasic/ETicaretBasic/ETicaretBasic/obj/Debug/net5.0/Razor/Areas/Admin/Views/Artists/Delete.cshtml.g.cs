#pragma checksum "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ecbb6e659252ef37e83eed250555922d259f59d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Artists_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Artists/Delete.cshtml")]
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
#line 1 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\_ViewImports.cshtml"
using ETicaretBasic.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\_ViewImports.cshtml"
using ETicaretBasic.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ecbb6e659252ef37e83eed250555922d259f59d", @"/Areas/Admin/Views/Artists/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df2aeb21e2998c9b0f7fedf08bea87dbae1f0728", @"/Areas/Admin/Views/Artists/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Artists_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ETicaretBasic.Models.Artist>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
  
    ViewData["Title"] = "EMusic";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 11 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
Write(lang["Sil"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<div class=\"container\">\n\n");
#nullable restore
#line 15 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
     if (Model.Active == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>");
#nullable restore
#line 17 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
       Write(lang["Deaktifleştir"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3> ");
#nullable restore
#line 17 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
                                        }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>");
#nullable restore
#line 20 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
       Write(lang["Aktiflestir"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
#nullable restore
#line 20 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <hr />\n    <div>\n        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 26 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 29 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n        </dl>\n        <div class=\"row\">\n            <div class=\"col-md-3\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ecbb6e659252ef37e83eed250555922d259f59d7726", async() => {
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ecbb6e659252ef37e83eed250555922d259f59d8002", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 35 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 36 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
                     if (Model.Active == true)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 947, "\"", 977, 1);
#nullable restore
#line 38 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
WriteAttributeValue("", 955, lang["Deaktifleştir"], 955, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-block btn-danger\" /> ");
#nullable restore
#line 38 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
                                                                                                                }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 1108, "\"", 1136, 1);
#nullable restore
#line 41 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
WriteAttributeValue("", 1116, lang["Aktiflestir"], 1116, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-block btn-danger\" />");
#nullable restore
#line 41 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
                                                                                                             }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n            <div class=\"col-md-3\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ecbb6e659252ef37e83eed250555922d259f59d12980", async() => {
                WriteLiteral("\n                    <div class=\"form-group\">\n                        <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 1384, "\"", 1411, 1);
#nullable restore
#line 47 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Artists\Delete.cshtml"
WriteAttributeValue("", 1392, lang["ListeyeDon"], 1392, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-block btn-primary\" />\n                    </div>\n                ");
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
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ETicaretBasic.Models.Artist> Html { get; private set; }
    }
}
#pragma warning restore 1591
