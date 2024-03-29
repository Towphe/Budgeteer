#pragma checksum "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\Wallet\Savings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbc57abe218bb07c1c513dc2eb14ffcbd9d0ec85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wallet_Savings), @"mvc.1.0.view", @"/Views/Wallet/Savings.cshtml")]
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
#line 2 "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\_ViewImports.cshtml"
using Budgeteer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\_ViewImports.cshtml"
using Budgeteer.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbc57abe218bb07c1c513dc2eb14ffcbd9d0ec85", @"/Views/Wallet/Savings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aee779a2e8039d6544e83b719e0d74f51dbc7ea6", @"/Views/_ViewImports.cshtml")]
    public class Views_Wallet_Savings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SavingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteSavings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSavings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h2 style=\"position:center\">Savings</h2>\r\n\r\n    <div>\r\n        <table>\r\n            <tr>\r\n                <th>Title</th>\r\n                <th>Amount</th>\r\n                <th>Date</th>\r\n                <th>Category</th>\r\n            </tr>\r\n");
#nullable restore
#line 13 "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\Wallet\Savings.cshtml"
             for (int i = 0; i < Model.Savings.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\Wallet\Savings.cshtml"
           Write(Model.Savings[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\Wallet\Savings.cshtml"
           Write(Model.Savings[i].Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\Wallet\Savings.cshtml"
           Write(Model.Savings[i].Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\Wallet\Savings.cshtml"
           Write(Model.Savings[i].Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbc57abe218bb07c1c513dc2eb14ffcbd9d0ec856030", async() => {
                WriteLiteral("\r\n                    <input name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 687, "\"", 715, 1);
#nullable restore
#line 22 "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\Wallet\Savings.cshtml"
WriteAttributeValue("", 695, Model.Savings[i].Id, 695, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" style=\"visibility:hidden\" />\r\n                    <button type=\"submit\">Delete</button>\r\n                ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <button><a");
            BeginWriteAttribute("href", " href=\"", 906, "\"", 956, 2);
            WriteAttributeValue("", 913, "/Wallet/EditSavings?id=", 913, 23, true);
#nullable restore
#line 27 "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\Wallet\Savings.cshtml"
WriteAttributeValue("", 936, Model.Savings[i].Id, 936, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a></button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\Wallet\Savings.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n    <ul>\r\n");
#nullable restore
#line 34 "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\Wallet\Savings.cshtml"
          
            for (int i = 0; i < Model.PageCount; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 1172, "\"", 1208, 2);
            WriteAttributeValue("", 1179, "/wallet/purchases?page=", 1179, 23, true);
#nullable restore
#line 37 "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\Wallet\Savings.cshtml"
WriteAttributeValue("", 1202, i+1, 1202, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 37 "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\Wallet\Savings.cshtml"
                                                        Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 38 "C:\Users\5431\Documents\Programming Files\Backend Development\Projects\Budgeteer\Views\Wallet\Savings.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n<div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbc57abe218bb07c1c513dc2eb14ffcbd9d0ec8510517", async() => {
                WriteLiteral(@"
            <label>Description</label>
            <input name=""description"" type=""text"" />
            <label>Amount</label>
            <input name=""amount"" type=""number"" />
            <label>Category</label>
            <input name=""category"" type=""text"" />
            <button type=""submit"">Add</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SavingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
