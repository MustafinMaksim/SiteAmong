#pragma checksum "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eea31eabf445b1805a91b6d06c920996738a013"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GameWebSiteProject.Pages.Pages_GalleryReg), @"mvc.1.0.razor-page", @"/Pages/GalleryReg.cshtml")]
namespace GameWebSiteProject.Pages
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
#line 1 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\_ViewImports.cshtml"
using GameWebSiteProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eea31eabf445b1805a91b6d06c920996738a013", @"/Pages/GalleryReg.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d45aa2a4772bf641dcf4704a1c23489fee57be6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GalleryReg : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
  
    ViewData["Title"] = "TOP OF THIS MONTH";
    if (HttpContext.Session.GetString("username") == null) Layout = "_LayoutUnReg";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""carousel-example-2"" class=""carousel slide carousel-fade"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
        <li data-target=""#carousel-example-2"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#carousel-example-2"" data-slide-to=""1""></li>
        <li data-target=""#carousel-example-2"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"" role=""listbox"">
");
#nullable restore
#line 15 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
         for (int i = 0; i < Model.Works.Count; i++)
        {
            if (Model.Works[i].Type != "Meme" || Model.Works[i].DateSent.Month != DateTime.Now.Month) continue;
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-item active\">\r\n                    <div class=\"view\">\r\n                        <img id=\"slideImage\"");
            BeginWriteAttribute("src", " src=\"", 991, "\"", 1069, 3);
            WriteAttributeValue("", 997, "data:image/jpeg;", 997, 16, true);
            WriteAttributeValue(" ", 1013, "base64,", 1014, 8, true);
#nullable restore
#line 22 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue(" ", 1021, Convert.ToBase64String(Model.Works[i].Image), 1022, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                             alt=""First slide"" />
                        <div class=""mask rgba-black-light""></div>
                    </div>
                    <div class=""carousel-caption"">
                        <h2 id=""colorText"" class=""h3-responsive"">Top meme - ");
#nullable restore
#line 27 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                                                                       Write(Model.Works[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p><h3 id=\"colorText\">Author - ");
#nullable restore
#line 28 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                                                  Write(Model.GetAuthorUsername(Model.Works[i].User_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></p>\r\n                        <input class=\"btn btn-success\" disabled");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1550, "\"", 1591, 2);
            WriteAttributeValue("", 1564, "Likes", 1564, 5, true);
#nullable restore
#line 29 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue(" ", 1569, Model.Works[i].Likes, 1570, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 30 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                         if (HttpContext.Session.GetString("username") != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eea31eabf445b1805a91b6d06c920996738a0138486", async() => {
                WriteLiteral("\r\n                                <input id=\"workname\" name=\"workname\"");
                BeginWriteAttribute("value", " value=\"", 1823, "\"", 1851, 1);
#nullable restore
#line 33 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue("", 1831, Model.Works[i].Name, 1831, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eea31eabf445b1805a91b6d06c920996738a0139255", async() => {
                    WriteLiteral("<p class=\"card-text\">Leave a comment</p>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 36 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 39 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                break;
            }

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
         for (int i = 0; i < Model.Works.Count; i++)
        {
            if (Model.Works[i].Type != "FanArt" || Model.Works[i].DateSent.Month != DateTime.Now.Month) continue;
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-item\">\r\n                    <div class=\"view\">\r\n                        <img id=\"slideImage\"");
            BeginWriteAttribute("src", " src=\"", 2523, "\"", 2601, 3);
            WriteAttributeValue("", 2529, "data:image/jpeg;", 2529, 16, true);
            WriteAttributeValue(" ", 2545, "base64,", 2546, 8, true);
#nullable restore
#line 50 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue(" ", 2553, Convert.ToBase64String(Model.Works[i].Image), 2554, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                             alt=""First slide"" />
                        <div class=""mask rgba-black-light""></div>
                    </div>
                    <div class=""carousel-caption"">
                        <h2 id=""colorText"" class=""h3-responsive"">Top Fan Art - ");
#nullable restore
#line 55 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                                                                          Write(Model.Works[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p><h3 id=\"colorText\">Author - ");
#nullable restore
#line 56 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                                                  Write(Model.GetAuthorUsername(Model.Works[i].User_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></p>\r\n                        <input class=\"btn btn-success\" disabled");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3085, "\"", 3126, 2);
            WriteAttributeValue("", 3099, "Likes", 3099, 5, true);
#nullable restore
#line 57 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue(" ", 3104, Model.Works[i].Likes, 3105, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 58 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                         if (HttpContext.Session.GetString("username") != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eea31eabf445b1805a91b6d06c920996738a01315427", async() => {
                WriteLiteral("\r\n                                <input id=\"workname\" name=\"workname\"");
                BeginWriteAttribute("value", " value=\"", 3358, "\"", 3386, 1);
#nullable restore
#line 61 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue("", 3366, Model.Works[i].Name, 3366, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eea31eabf445b1805a91b6d06c920996738a01316197", async() => {
                    WriteLiteral("<p class=\"card-text\">Leave a comment</p>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 64 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 67 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                break;
            }

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
         for (int i = 0; i < Model.Works.Count; i++)
            {
                if (Model.Works[i].Type != "CustomSkin" || Model.Works[i].DateSent.Month != DateTime.Now.Month) continue;
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"carousel-item\">\r\n                    <div class=\"view\">\r\n                        <img id=\"slideImage\"");
            BeginWriteAttribute("src", " src=\"", 4070, "\"", 4148, 3);
            WriteAttributeValue("", 4076, "data:image/jpeg;", 4076, 16, true);
            WriteAttributeValue(" ", 4092, "base64,", 4093, 8, true);
#nullable restore
#line 78 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue(" ", 4100, Convert.ToBase64String(Model.Works[i].Image), 4101, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                             alt=""First slide"" />
                        <div class=""mask rgba-black-light""></div>
                    </div>
                    <div class=""carousel-caption"">
                        <h2 id=""colorText"" class=""h3-responsive"">Top Custom Skin - ");
#nullable restore
#line 83 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                                                                              Write(Model.Works[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p><h3 id=\"colorText\">Author - ");
#nullable restore
#line 84 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                                                  Write(Model.GetAuthorUsername(Model.Works[i].User_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></p>\r\n                        <input class=\"btn btn-success\" disabled");
            BeginWriteAttribute("placeholder", " placeholder=\"", 4636, "\"", 4677, 2);
            WriteAttributeValue("", 4650, "Likes", 4650, 5, true);
#nullable restore
#line 85 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue(" ", 4655, Model.Works[i].Likes, 4656, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 86 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                         if (HttpContext.Session.GetString("username") != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eea31eabf445b1805a91b6d06c920996738a01322390", async() => {
                WriteLiteral("\r\n                                <input id=\"workname\" name=\"workname\"");
                BeginWriteAttribute("value", " value=\"", 4909, "\"", 4937, 1);
#nullable restore
#line 89 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue("", 4917, Model.Works[i].Name, 4917, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1eea31eabf445b1805a91b6d06c920996738a01323160", async() => {
                    WriteLiteral("<p class=\"card-text\">Leave a comment</p>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 92 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 95 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                break;
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <a class=""carousel-control-prev"" href=""#carousel-example-2"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carousel-example-2"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameWebSiteProject.Pages.GalleryRegModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GameWebSiteProject.Pages.GalleryRegModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GameWebSiteProject.Pages.GalleryRegModel>)PageContext?.ViewData;
        public GameWebSiteProject.Pages.GalleryRegModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
