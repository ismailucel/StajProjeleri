#pragma checksum "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94a31586a52c88db7a874939fe4c03ccb8f900c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SongDetails), @"mvc.1.0.view", @"/Views/Home/SongDetails.cshtml")]
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
#line 1 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\_ViewImports.cshtml"
using ETicaretBasic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\_ViewImports.cshtml"
using ETicaretBasic.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94a31586a52c88db7a874939fe4c03ccb8f900c0", @"/Views/Home/SongDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b8de7df2e51f5b9f4767a1c174cf8ac5dec67b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SongDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Song>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100%;width:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddReviews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSongToBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SongDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 6 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
  var count = 0; var song1 = Model.Last();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
   ViewData["Title"] = "Emusic"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n    <section class=\"sec-product-detail bg0 p-t-65 p-b-60\">\n        <div class=\"container\">\n            <h1 class=\"mb-4\">");
#nullable restore
#line 15 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                        Write(song1.SongName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
            <div class=""row"">
                <div class=""col-md-6 slider-sec"">
                    <!-- main slider carousel -->
                    <div id=""myCarousel"" class=""carousel slide"">
                        <!-- main slider carousel items -->
                        <div class=""carousel-inner"">
                            <div class=""active item carousel-item"" data-slide-number=""0"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "94a31586a52c88db7a874939fe4c03ccb8f900c08077", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 783, "~/images/", 783, 9, true);
#nullable restore
#line 23 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
AddHtmlAttributeValue("", 792, song1.FirstPhoto, 792, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                            <div class=\"item carousel-item\" data-slide-number=\"1\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "94a31586a52c88db7a874939fe4c03ccb8f900c09895", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1022, "~/images/", 1022, 9, true);
#nullable restore
#line 26 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
AddHtmlAttributeValue("", 1031, song1.SecondPhoto, 1031, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                            <div class=\"item carousel-item\" data-slide-number=\"2\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "94a31586a52c88db7a874939fe4c03ccb8f900c011718", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1262, "~/images/", 1262, 9, true);
#nullable restore
#line 29 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
AddHtmlAttributeValue("", 1271, song1.ThirdPhoto, 1271, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <!-- main slider carousel nav controls -->
                        <ul class=""carousel-indicators list-inline"">
                            <li class=""list-inline-item active"" style=""border-top: 0px solid transparent!important;"">
                                <a id=""carousel-selector-0"" class=""selected"" data-slide-to=""0"" data-target=""#myCarousel"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "94a31586a52c88db7a874939fe4c03ccb8f900c013877", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1829, "~/images/", 1829, 9, true);
#nullable restore
#line 36 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
AddHtmlAttributeValue("", 1838, song1.FirstPhoto, 1838, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </a>
                            </li>
                            <li class=""list-inline-item"" style=""border-top: 0px solid transparent!important;"">
                                <a id=""carousel-selector-1"" data-slidce-to=""1"" data-target=""#myCarousel"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "94a31586a52c88db7a874939fe4c03ccb8f900c015878", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2242, "~/images/", 2242, 9, true);
#nullable restore
#line 41 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
AddHtmlAttributeValue("", 2251, song1.SecondPhoto, 2251, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </a>
                            </li>
                            <li class=""list-inline-item"" style=""border-top: 0px solid transparent!important;"">
                                <a id=""carousel-selector-2"" data-slide-to=""2"" data-target=""#myCarousel"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "94a31586a52c88db7a874939fe4c03ccb8f900c017879", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2655, "~/images/", 2655, 9, true);
#nullable restore
#line 46 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
AddHtmlAttributeValue("", 2664, song1.ThirdPhoto, 2664, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </a>
                            </li>
                        </ul>
                    </div>
                    <!--/main slider carousel-->
                </div>
                <div class=""col-md-6 slider-content"">
                    <p>");
#nullable restore
#line 54 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                  Write(song1.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <ul>\n                        <li>\n                            <span class=\"name\">Stok</span><span class=\"clm\">:</span>\n                            <span class=\"price\" style=\"text-decoration: none;\">");
#nullable restore
#line 58 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                                                                          Write(song1.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </li>\n                        <li>\n                            <span class=\"name\">Fiyat</span><span class=\"clm\">:</span>\n                            <span class=\"price\">");
#nullable restore
#line 62 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                                            Write(song1.Price * 2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</span>\n                        </li>\n                        <li>\n                            <span class=\"name\">");
#nullable restore
#line 65 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                                          Write(lang["IndirimliFiyat"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"clm\">:</span>\n                            <span class=\"price final\">");
#nullable restore
#line 66 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                                                 Write(song1.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 66 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                                                              Write(lang["Birim"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </li>\n                        <li><span class=\"save-cost\">");
#nullable restore
#line 68 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                                               Write(lang["Kar"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 68 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                                                              Write(song1.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 68 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                                                                           Write(lang["Birim"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (%50)</span></li>\n\n\n                    </ul>\n\n                    <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94a31586a52c88db7a874939fe4c03ccb8f900c023223", async() => {
                WriteLiteral("<i class=\"fa fa-long-arrow-right\" aria-hidden=\"true\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\n\n\n\n");
#nullable restore
#line 77 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                     if (song1.Stock != 0)
                    {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                 if (this.User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94a31586a52c88db7a874939fe4c03ccb8f900c025210", async() => {
                WriteLiteral("\n                    <div class=\"btn-sec\">\n                        <button name=\"songId\"");
                BeginWriteAttribute("value", " value=\"", 4381, "\"", 4398, 1);
#nullable restore
#line 83 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
WriteAttributeValue("", 4389, song1.Id, 4389, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn black\">");
#nullable restore
#line 83 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                                                                             Write(lang["SepeteEkle"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n                    </div>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 85 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                        }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"btn-sec\">\n                    ");
#nullable restore
#line 89 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
               Write(lang["Uyari"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>");
#nullable restore
#line 90 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                        }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"btn-sec\">\n                    ");
#nullable restore
#line 94 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
               Write(lang["StokDurumu"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>");
#nullable restore
#line 95 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </section>\n    <section class=\"related-books\">\n        <div class=\"container\">\n            <div class=\"recomended-sec\">\n                <h2>");
#nullable restore
#line 103 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
               Write(lang["DigerSarkilar"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                <div class=\"row\">\n");
#nullable restore
#line 105 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                     foreach (var song in Model)
                    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
         if (count != Model.Count() - 1)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-3 col-md-6\">\n    <div class=\"item\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "94a31586a52c88db7a874939fe4c03ccb8f900c030648", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5222, "~/images/", 5222, 9, true);
#nullable restore
#line 112 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
AddHtmlAttributeValue("", 5231, song.FirstPhoto, 5231, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <h3>");
#nullable restore
#line 113 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
       Write(song.SongName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <h6><span class=\"price\">");
#nullable restore
#line 114 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                           Write(song.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</span></h6>\n        <div class=\"hover\">\n            <span>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94a31586a52c88db7a874939fe4c03ccb8f900c032929", async() => {
                WriteLiteral("<i class=\"fa fa-long-arrow-right\" aria-hidden=\"true\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-searchId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
                                                                            WriteLiteral(song.Id);

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
            WriteLiteral("</span>\n        </div>\n    </div>\n</div>");
#nullable restore
#line 119 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\İSMAİL\Desktop\ETicaretBasic\ETicaretBasic\ETicaretBasic\Views\Home\SongDetails.cshtml"
       count++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </section>\n");
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
