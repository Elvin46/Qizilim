#pragma checksum "C:\Users\HP\Desktop\Qizilim2\Qizilim.az\Views\Account\addingAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb88a8b7b4a6edf2a13e59346b5cc435055d1619"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_addingAccount), @"mvc.1.0.view", @"/Views/Account/addingAccount.cshtml")]
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
#line 3 "C:\Users\HP\Desktop\Qizilim2\Qizilim.az\Views\_ViewImports.cshtml"
using Qizilim.az.AppCode.Modules.AccountModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Qizilim2\Qizilim.az\Views\_ViewImports.cshtml"
using Qizilim.az.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\Qizilim2\Qizilim.az\Views\_ViewImports.cshtml"
using Qizilim.az.Models.Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Desktop\Qizilim2\Qizilim.az\Views\_ViewImports.cshtml"
using Qizilim.az.Models.Entities.Membreship;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Desktop\Qizilim2\Qizilim.az\Views\_ViewImports.cshtml"
using Qizilim.az.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb88a8b7b4a6edf2a13e59346b5cc435055d1619", @"/Views/Account/addingAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6746f1501d1ca445669d8cc1cc772b06165de56", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_addingAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-add-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\HP\Desktop\Qizilim2\Qizilim.az\Views\Account\addingAccount.cshtml"
   
    Layout = "_LayoutStore";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"product-add-div\">\r\n    <h3 class=\"add-prdct-h3\">Elan əlavə et</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb88a8b7b4a6edf2a13e59346b5cc435055d16194845", async() => {
                WriteLiteral("\r\n        <div class=\"product-detail-content\">\r\n            <div class=\"product-detail-header\">\r\n                <label>Elan başlığı</label>\r\n            </div>\r\n            <div class=\"product-deatil-it\">\r\n                <input type=\"text\" class=\"add\"");
                BeginWriteAttribute("name", " name=\"", 420, "\"", 427, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 428, "\"", 433, 0);
                EndWriteAttribute();
                WriteLiteral(@" maxlength=""50"" />
            </div>
        </div>
        <div class=""product-detail-content"">
            <div class=""product-detail-header"">
                <label>Kateqoriya</label>
            </div>
            <details class=""custom-select type"">
                <summary class=""radios"">
                    <input type=""radio""
                           name=""item-type""
                           id=""default""
                           title-type=""Nov""
                           checked />
                    <input type=""radio""
                           name=""item-type""
                           id=""item1""
                           title-type=""Sep"" />
                    <input type=""radio""
                           name=""item-type""
                           id=""item2""
                           title-type=""Uzuk"" />
                    <input type=""radio""
                           name=""item-type""
                           id=""item3""
                           title-ty");
                WriteLiteral(@"pe=""Qolbaq"" />
                    <input type=""radio""
                           name=""item-type""
                           id=""item4""
                           title-type=""Dest"" />
                    <input type=""radio""
                           name=""item-type""
                           id=""item5""
                           title-type=""Lorem"" />
                </summary>
                <ul class=""selector-list"">
                    <li>
                        <label class=""selector-label"" for=""item1"">Sep</label>
                    </li>
                    <li>
                        <label class=""selector-label"" for=""item2"">Uzuk</label>
                    </li>
                    <li>
                        <label class=""selector-label"" for=""item3"">Qolbaq</label>
                    </li>
                    <li>
                        <label class=""selector-label"" for=""item4"">Dest</label>
                    </li>
                    <li>
                        <lab");
                WriteLiteral(@"el class=""selector-label"" for=""item5"">Lorem</label>
                    </li>
                </ul>
            </details>
        </div>
        <div class=""product-detail-content"" id=""addFormProb"">
            <div class=""product-detail-header"">
                <label>Əyyar</label>
            </div>

            <div class=""product-deatil-it"">
                <details class=""custom-select add-degree"">
                    <summary class=""radios"">
                        <input type=""radio""
                               name=""title-add-degree""
                               id=""default""
                               title-add-degree=""Əyyar""
                               checked />
                        <input type=""radio""
                               name=""title-add-degree""
                               id=""item71""
                               title-add-degree=""583"" />
                        <input type=""radio""
                               name=""title-add-degree""
        ");
                WriteLiteral(@"                       id=""item72""
                               title-add-degree=""585"" />
                        <input type=""radio""
                               name=""title-add-degree""
                               id=""item73""
                               title-add-degree=""750"" />
                        <input type=""radio""
                               name=""title-add-degree""
                               id=""item74""
                               title-add-degree=""916"" />
                        <input type=""radio""
                               name=""title-add-degree""
                               id=""item75""
                               title-add-degree=""Digər"" />
                    </summary>
                    <ul class=""selector-list"">
                        <li>
                            <label class=""selector-label"" for=""item71"">583</label>
                        </li>
                        <li>
                            <label class=""selector-label"" for=""i");
                WriteLiteral(@"tem72"">585</label>
                        </li>
                        <li>
                            <label class=""selector-label"" for=""item73"">750</label>
                        </li>
                        <li>
                            <label class=""selector-label"" for=""item74"">916</label>
                        </li>
                        <li>
                            <label class=""selector-label"" for=""item75"">Digər</label>
                        </li>
                    </ul>
                </details>
            </div>
        </div>
        <div class=""product-detail-content"" id=""addFormProb"">
            <div class=""product-detail-header"">
                <label>Qızıl rəngi : </label>
            </div>

            <div class=""product-deatil-it"">
                <details class=""custom-select add-color"">
                    <summary class=""radios"">
                        <input type=""radio""
                               name=""title-add-colour""
             ");
                WriteLiteral(@"                  id=""default""
                               title-add-colour=""Qızıl rəngi""
                               checked />
                        <input type=""radio""
                               name=""title-add-colour""
                               id=""item91""
                               title-add-colour=""Ağ"" />
                        <input type=""radio""
                               name=""title-add-colour""
                               id=""item92""
                               title-add-colour=""Sarı"" />
                        <input type=""radio""
                               name=""title-add-colour""
                               id=""item93""
                               title-add-colour=""Rose"" />
                        <input type=""radio""
                               name=""title-add-colour""
                               id=""item95""
                               title-add-colour=""Digər"" />
                    </summary>
                    <ul class=""selector");
                WriteLiteral(@"-list"">
                        <li>
                            <label class=""selector-label"" for=""item91"">Ağ</label>
                        </li>
                        <li>
                            <label class=""selector-label"" for=""item92"">585</label>
                        </li>
                        <li>
                            <label class=""selector-label"" for=""item93"">Rose</label>
                        </li>

                        <li>
                            <label class=""selector-label"" for=""item95"">Digər</label>
                        </li>
                    </ul>
                </details>
            </div>
        </div>
        <div class=""product-detail-content"" id=""addFormWeight"">
            <div class=""product-detail-header"">
                <label>Çəki</label>
            </div>
            <div class=""product-deatil-it"">
                <input type=""number""");
                BeginWriteAttribute("name", " name=\"", 7514, "\"", 7521, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 7522, "\"", 7527, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""add"" /><label class=""detail-form"">
                    ,qram
                </label>
            </div>
        </div>
        <div class=""product-detail-content"">
            <div class=""product-detail-header"">
                <label>
                    <input type=""checkbox""
                           name=""diamon-add""
                           id=""diamonCheck""
                           onclick=""EnableDisableTextBox(this)"" />
                    Brilliant
                </label>
            </div>
            <div class=""product-deatil-it"">
                <input type=""number""");
                BeginWriteAttribute("name", "\r\n                       name=\"", 8142, "\"", 8173, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                       id=""addDiamondCount""
                       class=""add""
                       disabled=""disabled"" /><label class=""detail-form""> ,ct</label>
            </div>
        </div>

        <div class=""product-detail-content"">
            <div class=""product-detail-header"">
                <label>Ətraflı məlumat</label>
            </div>
            <div class=""product-deatil-it"">
                <textarea");
                BeginWriteAttribute("name", " name=\"", 8614, "\"", 8621, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 8622, "\"", 8627, 0);
                EndWriteAttribute();
                WriteLiteral(@" cols=""30"" rows=""10""></textarea>
            </div>
        </div>

        <div class=""product-detail-content"">
            <div class=""product-detail-header"">
                <label>Qiymət</label>
            </div>
            <div class=""product-deatil-it"">
                <input type=""number""");
                BeginWriteAttribute("name", " name=\"", 8935, "\"", 8942, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 8943, "\"", 8948, 0);
                EndWriteAttribute();
                WriteLiteral(" /><label class=\"detail-form\">\r\n                    ,AZN\r\n                </label>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
    <div class=""add-img-ads"">
        <label for=""images"" class=""drop-container"">
            <span class=""drop-title"">Şəkil əlavə et</span>
            (max : 12)

            <input type=""file""
                   class=""file-field""
                   id=""images""
                   accept=""image/*""
                   multiple
                   required />
        </label>
        <div class=""add-img-container"">

        </div>
    </div>
    <div class=""add-prdct-btn-div"">
        <button class=""add-prdct-btn"">Elani əlavə et</button>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
