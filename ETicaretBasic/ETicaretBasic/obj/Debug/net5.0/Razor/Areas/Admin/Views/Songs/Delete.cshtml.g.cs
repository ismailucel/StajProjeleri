#pragma checksum "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74c94ac910cb8070b689f36c60cee797536a934f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Songs_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Songs/Delete.cshtml")]
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
#line 1 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\_ViewImports.cshtml"
using ETicaretBasic.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\_ViewImports.cshtml"
using ETicaretBasic.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74c94ac910cb8070b689f36c60cee797536a934f", @"/Areas/Admin/Views/Songs/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df2aeb21e2998c9b0f7fedf08bea87dbae1f0728", @"/Areas/Admin/Views/Songs/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Songs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ETicaretBasic.Models.Song>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
   ViewData["Title"] = lang["Baslik"].Value; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n");
#nullable restore
#line 8 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
     if (Model.Active == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 10 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
Write(lang["Deaktiflestir"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3> ");
#nullable restore
#line 10 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
                                }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 13 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
Write(lang["Aktiflestir"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
#nullable restore
#line 13 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <hr />\n    <div>\n        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 19 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.SongName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 22 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.SongName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 25 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 28 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 31 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 34 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 37 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 40 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 43 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.PublishYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 46 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.PublishYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 49 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 52 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n");
            WriteLiteral("            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 61 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ArtistId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 64 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Artist.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 67 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 70 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 73 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstPhoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "74c94ac910cb8070b689f36c60cee797536a934f13370", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2625, "~/images/", 2625, 9, true);
#nullable restore
#line 76 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
AddHtmlAttributeValue("", 2634, Model.FirstPhoto, 2634, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 79 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.SecondPhoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "74c94ac910cb8070b689f36c60cee797536a934f15467", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2889, "~/images/", 2889, 9, true);
#nullable restore
#line 82 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
AddHtmlAttributeValue("", 2898, Model.SecondPhoto, 2898, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 85 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ThirdPhoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "74c94ac910cb8070b689f36c60cee797536a934f17564", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3153, "~/images/", 3153, 9, true);
#nullable restore
#line 88 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
AddHtmlAttributeValue("", 3162, Model.ThirdPhoto, 3162, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </dd>\n        </dl>\n        <div class=\"row\">\n            <div class=\"col-md-3\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74c94ac910cb8070b689f36c60cee797536a934f19351", async() => {
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "74c94ac910cb8070b689f36c60cee797536a934f19628", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 94 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
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
#line 95 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
                     if (Model.Active == true)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 3486, "\"", 3510, 1);
#nullable restore
#line 97 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
WriteAttributeValue("", 3494, lang["Deaktif"], 3494, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-block btn-danger\" /> ");
#nullable restore
#line 97 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
                                                                                          }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 3585, "\"", 3607, 1);
#nullable restore
#line 100 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
WriteAttributeValue("", 3593, lang["Aktif"], 3593, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-block btn-danger\" />");
#nullable restore
#line 100 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n            <div class=\"col-md-3\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74c94ac910cb8070b689f36c60cee797536a934f24441", async() => {
                WriteLiteral("\n                    <div class=\"form-group\">\n                        <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 3855, "\"", 3882, 1);
#nullable restore
#line 106 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Areas\Admin\Views\Songs\Delete.cshtml"
WriteAttributeValue("", 3863, lang["ListeyeDon"], 3863, 19, false);

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ETicaretBasic.Models.Song> Html { get; private set; }
    }
}
#pragma warning restore 1591
