#pragma checksum "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b9b3af7fe3505e1ac52ebe31a1de8458efa22af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\_ViewImports.cshtml"
using ETicaretBasic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\_ViewImports.cshtml"
using ETicaretBasic.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b9b3af7fe3505e1ac52ebe31a1de8458efa22af", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b8de7df2e51f5b9f4767a1c174cf8ac5dec67b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Song>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icon-heart1 dis-block trans-04 m-all--10 p-all-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:350px; width:350px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("stext-104 cl4 hov-cl1 trans-04 js-name-b2 p-b-6 m-all--10 p-all-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SongDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
   ViewData["Title"] = "EMusic"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n<section class=\"static about-sec\">\n    <div class=\"container\">\n        <h2>");
#nullable restore
#line 10 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
       Write(lang["Sarkilar"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n        <div class=\"recent-book-sec\">\n            <div class=\"row\">\n");
#nullable restore
#line 13 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
                 if (Model.Any())
                {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
     foreach (var _song in Model)
    {

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
 if (_song.Active == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"block2\">\n    <div class=\"block2-pic hov-img0 m-all--3 p-all-3\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b9b3af7fe3505e1ac52ebe31a1de8458efa22af6613", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 593, "~/images/", 593, 9, true);
#nullable restore
#line 21 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 602, _song.FirstPhoto, 602, 17, false);

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
            WriteLiteral("\n        <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b9b3af7fe3505e1ac52ebe31a1de8458efa22af8276", async() => {
#nullable restore
#line 22 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
                                                                                                                                                                   Write(_song.SongName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-searchId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
                                                                                                                                                 WriteLiteral(_song.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-searchId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\n        <h6><span class=\"stext-105 cl3\">");
#nullable restore
#line 23 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
                                   Write(_song.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
                                                Write(lang["Birim"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> / ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b9b3af7fe3505e1ac52ebe31a1de8458efa22af11743", async() => {
#nullable restore
#line 23 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
                                                                                                                                                         Write(lang["SatınAl"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-searchId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
                                                                                                                                       WriteLiteral(_song.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-searchId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h6>\n    </div>\n</div>");
#nullable restore
#line 25 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
         }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p style=\"margin-left:50px;\">");
#nullable restore
#line 28 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
                        Write(lang["SarkiYok"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 28 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 30 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
                 if (Model.Count() == 1 && Model.First().Active == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"margin-left:50px;\">");
#nullable restore
#line 32 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
                                    Write(lang["SarkiYok"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 32 "C:\Users\ismail.ucel\source\repos\ETicaretBasic\ETicaretBasic\Views\Home\Index.cshtml"
                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</section>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Song>> Html { get; private set; }
    }
}
#pragma warning restore 1591
