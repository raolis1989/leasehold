#pragma checksum "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4c37c9a1cf220833ce5844e65d5ae7617ff9c61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owners_Details), @"mvc.1.0.view", @"/Views/Owners/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Owners/Details.cshtml", typeof(AspNetCore.Views_Owners_Details))]
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
#line 1 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\_ViewImports.cshtml"
using LeaseHold.Web;

#line default
#line hidden
#line 2 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\_ViewImports.cshtml"
using LeaseHold.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c37c9a1cf220833ce5844e65d5ae7617ff9c61", @"/Views/Owners/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3618c500bb3ae8f9eb5786eaa2be4ac2aa6fc898", @"/Views/_ViewImports.cshtml")]
    public class Views_Owners_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeaseHold.Web.Data.Entities.Owner>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProperty", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProperty", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsProperty", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProperty", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 119, true);
            WriteLiteral("\r\n<h2>Owner</h2>\r\n\r\n<div>\r\n    <h4>Details</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(207, 49, false);
#line 14 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Document));

#line default
#line hidden
            EndContext();
            BeginContext(256, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(300, 45, false);
#line 17 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Document));

#line default
#line hidden
            EndContext();
            BeginContext(345, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(389, 50, false);
#line 20 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(439, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(483, 46, false);
#line 23 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(529, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(573, 49, false);
#line 26 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(622, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(666, 45, false);
#line 29 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(711, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(755, 46, false);
#line 32 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Email));

#line default
#line hidden
            EndContext();
            BeginContext(801, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(845, 42, false);
#line 35 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Email));

#line default
#line hidden
            EndContext();
            BeginContext(887, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(931, 48, false);
#line 38 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.Address));

#line default
#line hidden
            EndContext();
            BeginContext(979, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1023, 44, false);
#line 41 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1111, 52, false);
#line 44 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1163, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1207, 48, false);
#line 47 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 49, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1304, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c273e7874f544f8d8a630552beeeb567", async() => {
                BeginContext(1374, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1382, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1388, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdf8f041e1994c3097a748f7e3720f61", async() => {
                BeginContext(1465, 11, true);
                WriteLiteral("Add Prperty");
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
#line 54 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
                                  WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1480, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1486, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b978c806ccf42acb03e39dcd932beb8", async() => {
                BeginContext(1532, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1548, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            EndContext();
#line 59 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
 if (Model.Properties.Count==0)
{

#line default
#line hidden
            BeginContext(1598, 37, true);
            WriteLiteral(" <h5>Not Properties added yet.</h5>\r\n");
            EndContext();
#line 62 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
}
else 
{

#line default
#line hidden
            BeginContext(1648, 84, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1733, 76, false);
#line 69 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Properties.FirstOrDefault().Neighborhood));

#line default
#line hidden
            EndContext();
            BeginContext(1809, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1865, 71, false);
#line 72 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Properties.FirstOrDefault().Address));

#line default
#line hidden
            EndContext();
            BeginContext(1936, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1992, 69, false);
#line 75 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Properties.FirstOrDefault().Price));

#line default
#line hidden
            EndContext();
            BeginContext(2061, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2117, 76, false);
#line 78 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Properties.FirstOrDefault().SquareMeters));

#line default
#line hidden
            EndContext();
            BeginContext(2193, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2249, 69, false);
#line 81 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Properties.FirstOrDefault().Rooms));

#line default
#line hidden
            EndContext();
            BeginContext(2318, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2374, 75, false);
#line 84 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Properties.FirstOrDefault().IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(2449, 211, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Images\r\n            </th>\r\n            <th>\r\n                Contracts\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 96 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
         foreach(var item in Model.Properties)
        {

#line default
#line hidden
            BeginContext(2719, 51, true);
            WriteLiteral("         <tr>\r\n             <td>\r\n                 ");
            EndContext();
            BeginContext(2771, 48, false);
#line 100 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
            Write(Html.DisplayFor(modelItem  => item.Neighborhood));

#line default
#line hidden
            EndContext();
            BeginContext(2819, 58, true);
            WriteLiteral("\r\n             </td>\r\n             <td>\r\n                 ");
            EndContext();
            BeginContext(2878, 42, false);
#line 103 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
            Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2920, 58, true);
            WriteLiteral("\r\n             </td>\r\n             <td>\r\n                 ");
            EndContext();
            BeginContext(2979, 40, false);
#line 106 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
            Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3019, 58, true);
            WriteLiteral("\r\n             </td>\r\n             <td>\r\n                 ");
            EndContext();
            BeginContext(3078, 47, false);
#line 109 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
            Write(Html.DisplayFor(modelItem => item.SquareMeters));

#line default
#line hidden
            EndContext();
            BeginContext(3125, 58, true);
            WriteLiteral("\r\n             </td>\r\n             <td>\r\n                 ");
            EndContext();
            BeginContext(3184, 40, false);
#line 112 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
            Write(Html.DisplayFor(modelItem => item.Rooms));

#line default
#line hidden
            EndContext();
            BeginContext(3224, 58, true);
            WriteLiteral("\r\n             </td>\r\n             <td>\r\n                 ");
            EndContext();
            BeginContext(3283, 46, false);
#line 115 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
            Write(Html.DisplayFor(modelItem => item.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(3329, 58, true);
            WriteLiteral("\r\n             </td>\r\n             <td>\r\n                 ");
            EndContext();
            BeginContext(3388, 55, false);
#line 118 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
            Write(Html.DisplayFor(modelItem => item.PropertyImages.Count));

#line default
#line hidden
            EndContext();
            BeginContext(3443, 58, true);
            WriteLiteral("\r\n             </td>\r\n             <td>\r\n                 ");
            EndContext();
            BeginContext(3502, 50, false);
#line 121 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
            Write(Html.DisplayFor(modelItem => item.Contracts.Count));

#line default
#line hidden
            EndContext();
            BeginContext(3552, 58, true);
            WriteLiteral("\r\n             </td>\r\n             <td>\r\n                 ");
            EndContext();
            BeginContext(3610, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58ec4e991516450896ef588b86bbf806", async() => {
                BeginContext(3687, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 124 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
                                                WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3695, 21, true);
            WriteLiteral(" |\r\n                 ");
            EndContext();
            BeginContext(3716, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83388f7e66264a27a22dc65b403fc841", async() => {
                BeginContext(3793, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 125 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3804, 21, true);
            WriteLiteral(" |\r\n                 ");
            EndContext();
            BeginContext(3825, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a56a06eee6384eaa938cbf9c641e1969", async() => {
                BeginContext(3903, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 126 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3913, 38, true);
            WriteLiteral("\r\n             </td>\r\n         </tr>\r\n");
            EndContext();
#line 129 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(3962, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
#line 132 "D:\Desarrollos\RepositoriosPersonales\Leasing\leasehold\LeaseHold.Web\Views\Owners\Details.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeaseHold.Web.Data.Entities.Owner> Html { get; private set; }
    }
}
#pragma warning restore 1591
