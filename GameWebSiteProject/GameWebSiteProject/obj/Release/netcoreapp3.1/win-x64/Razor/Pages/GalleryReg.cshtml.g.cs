#pragma checksum "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42c81beed16b5f850abc07d6fa8f919b01ebab72"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42c81beed16b5f850abc07d6fa8f919b01ebab72", @"/Pages/GalleryReg.cshtml")]
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
#nullable restore
#line 8 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
 if (Model.Works.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"about-box\">\r\n        <h1 class=\"sitename about-title\">We don\'t have any works :(<br />So you can be first :)</h1>\r\n    </div>\r\n");
#nullable restore
#line 13 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""carousel-example-2"" class=""carousel slide carousel-fade"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#carousel-example-2"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#carousel-example-2"" data-slide-to=""1""></li>
            <li data-target=""#carousel-example-2"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"" role=""listbox"">
");
#nullable restore
#line 23 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
             for (int i = 0; i < Model.Works.Count; i++)
            {
                if (Model.Works[i].Type != "Meme" || Model.Works[i].DateSent.Month != DateTime.Now.Month) continue;
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item active\">\r\n                        <div class=\"view\">\r\n                            <img id=\"slideImage\"");
            BeginWriteAttribute("src", " src=\"", 1239, "\"", 1317, 3);
            WriteAttributeValue("", 1245, "data:image/jpeg;", 1245, 16, true);
            WriteAttributeValue(" ", 1261, "base64,", 1262, 8, true);
#nullable restore
#line 30 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue(" ", 1269, Convert.ToBase64String(Model.Works[i].Image), 1270, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                 alt=""First slide"" />
                            <div class=""mask rgba-black-light""></div>
                        </div>
                        <div class=""carousel-caption"">
                            <h2 id=""colorText1"" class=""h3-responsive"">Top meme - ");
#nullable restore
#line 35 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                                                                            Write(Model.Works[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p><h3 id=\"colorText\">Author - ");
#nullable restore
#line 36 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                                                      Write(Model.GetAuthorUsername(Model.Works[i].User_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></p>\r\n                            <input class=\"btn btn-success\" disabled");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1827, "\"", 1868, 2);
            WriteAttributeValue("", 1841, "Likes", 1841, 5, true);
#nullable restore
#line 37 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue(" ", 1846, Model.Works[i].Likes, 1847, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 38 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                             if (HttpContext.Session.GetString("username") != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c81beed16b5f850abc07d6fa8f919b01ebab729180", async() => {
                WriteLiteral("\r\n                                    <input id=\"workname\" name=\"workname\"");
                BeginWriteAttribute("value", " value=\"", 2116, "\"", 2144, 1);
#nullable restore
#line 41 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue("", 2124, Model.Works[i].Name, 2124, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c81beed16b5f850abc07d6fa8f919b01ebab729957", async() => {
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
                WriteLiteral("\r\n                                ");
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
#line 44 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 47 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                    break;
                }

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
             for (int i = 0; i < Model.Works.Count; i++)
            {
                if (Model.Works[i].Type != "FanArt" || Model.Works[i].DateSent.Month != DateTime.Now.Month) continue;
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item\">\r\n                        <div class=\"view\">\r\n                            <img id=\"slideImage\"");
            BeginWriteAttribute("src", " src=\"", 2880, "\"", 2958, 3);
            WriteAttributeValue("", 2886, "data:image/jpeg;", 2886, 16, true);
            WriteAttributeValue(" ", 2902, "base64,", 2903, 8, true);
#nullable restore
#line 58 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue(" ", 2910, Convert.ToBase64String(Model.Works[i].Image), 2911, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                 alt=""First slide"" />
                            <div class=""mask rgba-black-light""></div>
                        </div>
                        <div class=""carousel-caption"">
                            <h2 id=""colorText2"" class=""h3-responsive"">Top Fan Art - ");
#nullable restore
#line 63 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                                                                               Write(Model.Works[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p><h3 id=\"colorText\">Author - ");
#nullable restore
#line 64 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                                                      Write(Model.GetAuthorUsername(Model.Works[i].User_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></p>\r\n                            <input class=\"btn btn-success\" disabled");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3471, "\"", 3512, 2);
            WriteAttributeValue("", 3485, "Likes", 3485, 5, true);
#nullable restore
#line 65 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue(" ", 3490, Model.Works[i].Likes, 3491, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 66 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                             if (HttpContext.Session.GetString("username") != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c81beed16b5f850abc07d6fa8f919b01ebab7216239", async() => {
                WriteLiteral("\r\n                                    <input id=\"workname\" name=\"workname\"");
                BeginWriteAttribute("value", " value=\"", 3760, "\"", 3788, 1);
#nullable restore
#line 69 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue("", 3768, Model.Works[i].Name, 3768, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c81beed16b5f850abc07d6fa8f919b01ebab7217017", async() => {
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
                WriteLiteral("\r\n                                ");
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
#line 72 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 75 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                    break;
                }

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
             for (int i = 0; i < Model.Works.Count; i++)
            {
                if (Model.Works[i].Type != "CustomSkin" || Model.Works[i].DateSent.Month != DateTime.Now.Month) continue;
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item\">\r\n                        <div class=\"view\">\r\n                            <img id=\"slideImage\"");
            BeginWriteAttribute("src", " src=\"", 4528, "\"", 4606, 3);
            WriteAttributeValue("", 4534, "data:image/jpeg;", 4534, 16, true);
            WriteAttributeValue(" ", 4550, "base64,", 4551, 8, true);
#nullable restore
#line 86 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue(" ", 4558, Convert.ToBase64String(Model.Works[i].Image), 4559, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                 alt=""First slide"" />
                            <div class=""mask rgba-black-light""></div>
                        </div>
                        <div class=""carousel-caption"">
                            <h2 id=""colorText3"" class=""h3-responsive"">Top Custom Skin - ");
#nullable restore
#line 91 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                                                                                   Write(Model.Works[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p><h3 id=\"colorText\">Author - ");
#nullable restore
#line 92 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                                                      Write(Model.GetAuthorUsername(Model.Works[i].User_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></p>\r\n                            <input class=\"btn btn-success\" disabled");
            BeginWriteAttribute("placeholder", " placeholder=\"", 5123, "\"", 5164, 2);
            WriteAttributeValue("", 5137, "Likes", 5137, 5, true);
#nullable restore
#line 93 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue(" ", 5142, Model.Works[i].Likes, 5143, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 94 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                             if (HttpContext.Session.GetString("username") != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c81beed16b5f850abc07d6fa8f919b01ebab7223312", async() => {
                WriteLiteral("\r\n                                    <input id=\"workname\" name=\"workname\"");
                BeginWriteAttribute("value", " value=\"", 5412, "\"", 5440, 1);
#nullable restore
#line 97 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
WriteAttributeValue("", 5420, Model.Works[i].Name, 5420, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c81beed16b5f850abc07d6fa8f919b01ebab7224090", async() => {
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
                WriteLiteral("\r\n                                ");
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
#line 100 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 103 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
                    break;
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carousel-example-2"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carousel-example-2"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
");
#nullable restore
#line 117 "D:\Study 2\Информатика\SiteAmong\GameWebSiteProject\GameWebSiteProject\Pages\GalleryReg.cshtml"
}

#line default
#line hidden
#nullable disable
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
