#pragma checksum "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17fd05c1e62d5ee33ad2be136c0fd83fc377b0d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdmUsers_Index), @"mvc.1.0.view", @"/Views/AdmUsers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdmUsers/Index.cshtml", typeof(AspNetCore.Views_AdmUsers_Index))]
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
#line 1 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\_ViewImports.cshtml"
using DccyOrigination;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\_ViewImports.cshtml"
using DccyOrigination.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17fd05c1e62d5ee33ad2be136c0fd83fc377b0d7", @"/Views/AdmUsers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"605861197891e1742ee9875955015cabcad8ff3e", @"/Views/_ViewImports.cshtml")]
    public class Views_AdmUsers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DccyOrigination.Models.SysManagement.AdmUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(109, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(138, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d50abb5439114a7e8b36944bd72414dc", async() => {
                BeginContext(161, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(175, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(268, 48, false);
#line 16 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserAccounts));

#line default
#line hidden
            EndContext();
            BeginContext(316, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(372, 44, false);
#line 19 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(416, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(472, 49, false);
#line 22 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastLoginTime));

#line default
#line hidden
            EndContext();
            BeginContext(521, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(577, 42, false);
#line 25 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoleId));

#line default
#line hidden
            EndContext();
            BeginContext(619, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(675, 41, false);
#line 28 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DepId));

#line default
#line hidden
            EndContext();
            BeginContext(716, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(772, 39, false);
#line 31 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(811, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(867, 41, false);
#line 34 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(908, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(964, 39, false);
#line 37 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tel));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1059, 43, false);
#line 40 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1158, 51, false);
#line 43 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DetailedAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1265, 47, false);
#line 46 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumOfLogins));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1368, 50, false);
#line 49 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ThumbnailImage));

#line default
#line hidden
            EndContext();
            BeginContext(1418, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1474, 46, false);
#line 52 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1576, 44, false);
#line 55 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsDelete));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1676, 47, false);
#line 58 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1723, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 64 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1841, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1890, 47, false);
#line 67 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserAccounts));

#line default
#line hidden
            EndContext();
            BeginContext(1937, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1993, 43, false);
#line 70 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(2036, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2092, 48, false);
#line 73 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastLoginTime));

#line default
#line hidden
            EndContext();
            BeginContext(2140, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2196, 41, false);
#line 76 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoleId));

#line default
#line hidden
            EndContext();
            BeginContext(2237, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2293, 40, false);
#line 79 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DepId));

#line default
#line hidden
            EndContext();
            BeginContext(2333, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2389, 38, false);
#line 82 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(2427, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2483, 40, false);
#line 85 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2523, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2579, 38, false);
#line 88 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tel));

#line default
#line hidden
            EndContext();
            BeginContext(2617, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2673, 42, false);
#line 91 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2715, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2771, 50, false);
#line 94 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DetailedAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2821, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2877, 46, false);
#line 97 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumOfLogins));

#line default
#line hidden
            EndContext();
            BeginContext(2923, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2979, 49, false);
#line 100 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ThumbnailImage));

#line default
#line hidden
            EndContext();
            BeginContext(3028, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3084, 45, false);
#line 103 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreateTime));

#line default
#line hidden
            EndContext();
            BeginContext(3129, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3185, 43, false);
#line 106 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsDelete));

#line default
#line hidden
            EndContext();
            BeginContext(3228, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3284, 46, false);
#line 109 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3330, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3385, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da07a21cd05449248038a55e2a191da2", async() => {
                BeginContext(3430, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3438, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3458, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9ce3709459f4b2889490e797b0eacda", async() => {
                BeginContext(3506, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 113 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3517, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3537, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4873d0e093f46a0b84630141357ddd7", async() => {
                BeginContext(3584, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 114 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3594, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 117 "C:\Users\Administrator\Desktop\DccyOrigination(1)\DccyOrigination\DccyOrigination\DccyOrigination\Views\AdmUsers\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3633, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DccyOrigination.Models.SysManagement.AdmUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
