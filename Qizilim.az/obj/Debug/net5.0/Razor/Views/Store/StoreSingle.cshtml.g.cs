#pragma checksum "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f407c9ee3b1c6e24c4d5acc87668ad7ede3ef77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_StoreSingle), @"mvc.1.0.view", @"/Views/Store/StoreSingle.cshtml")]
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
#line 2 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\_ViewImports.cshtml"
using Qizilim.az.AppCode.Modules.AccountModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\_ViewImports.cshtml"
using Qizilim.az.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\_ViewImports.cshtml"
using Qizilim.az.Models.Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\_ViewImports.cshtml"
using Qizilim.az.Models.Entities.Membreship;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\_ViewImports.cshtml"
using Qizilim.az.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\_ViewImports.cshtml"
using Qizilim.az.Models.FormModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f407c9ee3b1c6e24c4d5acc87668ad7ede3ef77", @"/Views/Store/StoreSingle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698ed7c4398029bc42f35fc477db47670182b645", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_StoreSingle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("shop-page-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "homepage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "vipproducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-shw-all-vip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductSingle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
   Layout = "_LayoutStore"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"shop-details-main-div\">\r\n    <div class=\"shop-details-img-follow-div\">\r\n        <div class=\"shop-img-div\">\r\n            <div class=\"shop-img\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f407c9ee3b1c6e24c4d5acc87668ad7ede3ef777138", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 257, "~/photouploads/ShopImages/", 257, 26, true);
#nullable restore
#line 7 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
AddHtmlAttributeValue("", 283, ViewBag.Shop.ProfileImg, 283, 24, false);

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
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 9 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
             if (User.Identity.Name != null && User.IsInRole("User") && ViewBag.Follow == false)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""follow-button-div"">
                    <button class=""follow-button-buton"" id=""follow-button"">
                        <div id=""follow-button-svg-div"">


                        </div>Follow
                    </button>
                </div>
                <input style=""display: none;""");
            BeginWriteAttribute("value", " value=\"", 777, "\"", 801, 1);
#nullable restore
#line 19 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
WriteAttributeValue("", 785, ViewBag.Shop.Id, 785, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"shopId\" />\r\n");
#nullable restore
#line 20 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
            }else if(User.Identity.Name != null && User.IsInRole("User") && ViewBag.Follow == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""follow-button-div"">
                    <button class=""follow-button-buton "" style=""background-color: green !important;"" id=""follow-button"">
                        <div id=""follow-button-svg-div"">


                        </div>Followed
                    </button>
                </div>
                <input style=""display: none;""");
            BeginWriteAttribute("value", " value=\"", 1308, "\"", 1332, 1);
#nullable restore
#line 30 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
WriteAttributeValue("", 1316, ViewBag.Shop.Id, 1316, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"shopId\" />\r\n");
#nullable restore
#line 31 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"shop-details-name-description\">\r\n        <div class=\"shop-name-div-main\">\r\n            <span class=\"shop-name-div\"><u>");
#nullable restore
#line 36 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                                      Write(ViewBag.Shop.shopName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></span>\r\n        </div>\r\n        <div class=\"follower-counter-div\">\r\n            <span class=\"follower-counter-span\" id=\"follower-counter\">");
#nullable restore
#line 39 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                                                                 Write(ViewBag.Shop.FollowerCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"follower-word-span\">Follower</span>\r\n        </div>\r\n        <div class=\"shop-description-div\">\r\n            <div class=\"shop-description\">\r\n                <span>");
#nullable restore
#line 43 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                 Write(ViewBag.Shop.aboutShop);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>
        </div>

    </div>
    <div class=""shop-contact-details-div"">
        <div class=""shop-contact-loaction"">
            <span>
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""18"" height=""18"" fill=""currentColor"" class=""bi bi-shop-window"" viewBox=""0 0 16 16"">
                    <path d=""M2.97 1.35A1 1 0 0 1 3.73 1h8.54a1 1 0 0 1 .76.35l2.609 3.044A1.5 1.5 0 0 1 16 5.37v.255a2.375 2.375 0 0 1-4.25 1.458A2.371 2.371 0 0 1 9.875 8 2.37 2.37 0 0 1 8 7.083 2.37 2.37 0 0 1 6.125 8a2.37 2.37 0 0 1-1.875-.917A2.375 2.375 0 0 1 0 5.625V5.37a1.5 1.5 0 0 1 .361-.976l2.61-3.045zm1.78 4.275a1.375 1.375 0 0 0 2.75 0 .5.5 0 0 1 1 0 1.375 1.375 0 0 0 2.75 0 .5.5 0 0 1 1 0 1.375 1.375 0 1 0 2.75 0V5.37a.5.5 0 0 0-.12-.325L12.27 2H3.73L1.12 5.045A.5.5 0 0 0 1 5.37v.255a1.375 1.375 0 0 0 2.75 0 .5.5 0 0 1 1 0zM1.5 8.5A.5.5 0 0 1 2 9v6h12V9a.5.5 0 0 1 1 0v6h.5a.5.5 0 0 1 0 1H.5a.5.5 0 0 1 0-1H1V9a.5.5 0 0 1 .5-.5zm2 .5a.5.5 0 0 1 .5.5V13h8V9.5a.5.5 0 0 1 1 0V13a1 1 0 0 1-1 ");
            WriteLiteral("1H4a1 1 0 0 1-1-1V9.5a.5.5 0 0 1 .5-.5z\" />\r\n                </svg> ");
#nullable restore
#line 53 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                  Write(ViewBag.Shop.shopLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </span>
        </div>
        <div class=""shop-contact-header"">
            <span>Əlaqə məlumatları :</span>
        </div>
        <div class=""shop-contact-details"">
            <ul class=""shop-page-contact-list-ul"">

                <li class=""shop-page-contacts-li"">
                    <a href=""#"">
                        <img class=""shop-list-li-img"" src=""../../Main/images/asist-imgs/phone.png""");
            BeginWriteAttribute("alt", " alt=\"", 3469, "\"", 3475, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 65 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                   Write(ViewBag.Shop.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 68 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                 if (ViewBag.Shop.whatsappNumber != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"shop-page-contacts-li\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3739, "\"", 3788, 2);
            WriteAttributeValue("", 3746, "https://wa.me/", 3746, 14, true);
#nullable restore
#line 71 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
WriteAttributeValue("", 3760, ViewBag.Shop.whatsappNumber, 3760, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"shop-list-li-img\" src=\"../../Main/images/asist-imgs/whatsapp-svgrepo-com.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3909, "\"", 3915, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 73 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                       Write(ViewBag.Shop.whatsappNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 76 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                 if (ViewBag.Shop.instagramLink != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"shop-page-contacts-li\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4212, "\"", 4272, 2);
            WriteAttributeValue("", 4219, "https://www.instagram.com/", 4219, 26, true);
#nullable restore
#line 80 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
WriteAttributeValue("", 4245, ViewBag.Shop.instagramLink, 4245, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"shop-list-li-img\" src=\"../../Main/images/asist-imgs/instagram-svgrepo-com.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 4394, "\"", 4400, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 82 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                       Write(ViewBag.Shop.instagramLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </li>  \r\n");
#nullable restore
#line 85 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                 if (ViewBag.Shop.tiktokLink != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"shop-page-contacts-li\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4695, "\"", 4749, 2);
            WriteAttributeValue("", 4702, "https://www.tiktok.com/", 4702, 23, true);
#nullable restore
#line 89 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
WriteAttributeValue("", 4725, ViewBag.Shop.tiktokLink, 4725, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"shop-list-li-img\" src=\"../../Main/images/asist-imgs/tiktok-icon-white-1-logo-svgrepo-com.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 4886, "\"", 4892, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 91 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                       Write(ViewBag.Shop.tiktokLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 94 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </ul>\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n<div class=\"premium-products-shop\">\r\n    <div class=\"vip-child-div\">\r\n        <div class=\"vip-text-premium-shop\">Premium elanlar</div>\r\n         <div class=\"all-vip-btn\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f407c9ee3b1c6e24c4d5acc87668ad7ede3ef7719706", async() => {
                WriteLiteral("Butun Vip Elanlar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div> \r\n    </div>\r\n    <div class=\"premium\">\r\n\r\n");
#nullable restore
#line 112 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
         foreach (var item in Model.Products.OrderByDescending(p => p.IreliCekilmisProduct == true))
        {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
     if (item.PremiumProduct)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f407c9ee3b1c6e24c4d5acc87668ad7ede3ef7721743", async() => {
                WriteLiteral("\r\n            <div class=\"container\">\r\n\r\n                <div class=\"image\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f407c9ee3b1c6e24c4d5acc87668ad7ede3ef7722105", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5813, "~/photouploads/ProductImages/", 5813, 29, true);
#nullable restore
#line 120 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
AddHtmlAttributeValue("", 5842, item.ProductImages.FirstOrDefault(x=>x.IsMain==true).Image.Path, 5842, 64, false);

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
                WriteLiteral("\r\n                </div>\r\n                <div class=\"info\">\r\n\r\n                    <div class=\"price-vip\"><span>");
#nullable restore
#line 124 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                                            Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" AZN</span><i class=\"fa-solid fa-gem\" style=\"color: #C1957C;\"></i></div>\r\n\r\n                    <div class=\"prob-weight-div\">\r\n\r\n                        <div class=\"prob\">\r\n                            ");
#nullable restore
#line 129 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                       Write(item.ProductEyar.FirstOrDefault().Eyar.EyarOlcusu);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"weight\">");
#nullable restore
#line 131 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                                       Write(item.Weight);

#line default
#line hidden
#nullable disable
                WriteLiteral(" gr</div><span class=\"sep-w-c\">/</span>\r\n");
#nullable restore
#line 132 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                         if (item.HasDiamond)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"carat\">");
#nullable restore
#line 134 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                                          Write(item.CountDiamond);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ct</div>\r\n");
#nullable restore
#line 135 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"title-of-product\">");
#nullable restore
#line 138 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                                             Write(item.aboutProduct.HtmlToPlainText().ToEllipse(20));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n                    <div class=\"time\">Bakı, ");
#nullable restore
#line 140 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                                       Write(item.CreatedDate.ToString("MMM d, yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 144 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    </div>

</div>

<div class=""vip-products-text-area"">
    <div class=""vip-child-div"">
        <div class=""vip-text"">Mağazanın elanları</div>
        <div class=""all-vip-btn""><button class=""btn-shw-all-vip"">Butun Vip Elanlar</button></div>
    </div>

</div>

<div class=""praducts"">

");
#nullable restore
#line 162 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
     foreach (var item in Model.Products.OrderByDescending(p => p.CreatedDate))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f407c9ee3b1c6e24c4d5acc87668ad7ede3ef7729758", async() => {
                WriteLiteral("\r\n                <div class=\"container\">\r\n\r\n                    <div class=\"image\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f407c9ee3b1c6e24c4d5acc87668ad7ede3ef7730132", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 7531, "~/photouploads/ProductImages/", 7531, 29, true);
#nullable restore
#line 168 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
AddHtmlAttributeValue("", 7560, item.ProductImages.FirstOrDefault(x=>x.IsMain==true).Image.Path, 7560, 64, false);

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
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"info\">\r\n\r\n                        <div class=\"price-vip\"><span>");
#nullable restore
#line 172 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                                                Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" AZN</span></div>\r\n\r\n                        <div class=\"prob-weight-div\">\r\n\r\n                            <div class=\"prob\">\r\n                                ");
#nullable restore
#line 177 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                           Write(item.ProductEyar.FirstOrDefault().Eyar.EyarOlcusu);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"weight\">");
#nullable restore
#line 179 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                                           Write(item.Weight);

#line default
#line hidden
#nullable disable
                WriteLiteral(" gr</div><span class=\"sep-w-c\">/</span>\r\n");
#nullable restore
#line 180 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                             if (item.HasDiamond)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"carat\">");
#nullable restore
#line 182 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                                              Write(item.CountDiamond);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ct</div>\r\n");
#nullable restore
#line 183 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"title-of-product\">");
#nullable restore
#line 186 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                                                 Write(item.aboutProduct.HtmlToPlainText().ToEllipse(20));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n                        <div class=\"time\">Bakı, ");
#nullable restore
#line 188 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                                           Write(item.CreatedDate.ToString("MMM d, yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 164 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 192 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    }\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n");
            DefineSection("js", async() => {
                WriteLiteral(@"
    <script>
    var followBtn = document.querySelector('#follow-button')

    followBtn.addEventListener(""click"", function (e) {
        e.preventDefault()
        var shopId = document.querySelector('#shopId').value

        console.log(shopId)
        console.log(""yoxlama"")
                $.ajax({
                    url: """);
#nullable restore
#line 214 "C:\Users\HP\Desktop\Qizilim\Qizilim.az\Views\Store\StoreSingle.cshtml"
                     Write(Url.Action("FollowTheUser", "Store"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    data: {
                        shopId: shopId
                    },


                    dataType: ""json"",
                    type: ""post"",
                    success: function (data) {
                        if (data.status == 200) {
                            location.reload(true)
                        }
                    }

                })

    })

    //function followReaction() {
    //    document.getElementById(""follow-button"").classList.toggle(""follow-button-buton-followed"")
    //    document.getElementById(""follow-button"").classList.toggle(""follow-button-buton"")
    //    const followButton = document.getElementById(""follow-button"")
    //    let countFollower = Number(document.getElementById(""follower-counter"").textContent)
    //    if (document.getElementById(""follow-button"").classList[0] == ""follow-button-buton-followed"") {
    //        followButton.innerHTML = 'Followed'

    //    }
    //    else {

    //        followButton.");
                WriteLiteral("innerHTML = \'Follow\'\r\n    //    }\r\n    //    document.getElementById(\"follower-counter\").innerHTML = countFollower\r\n\r\n    //}\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
