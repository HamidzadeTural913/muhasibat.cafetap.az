#pragma checksum "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f141d7b3630330ff450cbbdc9be253153e3e00d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Panel_Views_ContractPayments_ContractPayments), @"mvc.1.0.view", @"/Areas/Panel/Views/ContractPayments/ContractPayments.cshtml")]
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
#line 4 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using Infrastructure.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\_ViewImports.cshtml"
using Humanizer.Localisation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f141d7b3630330ff450cbbdc9be253153e3e00d", @"/Areas/Panel/Views/ContractPayments/ContractPayments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e678e1e498e0b84e32a5b9531791a8b8e4be48", @"/Areas/Panel/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Panel_Views_ContractPayments_ContractPayments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccess.Pagination.PaginatedList<ContractPayment>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ContractPayments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Panel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Ödanışlər";
    ViewData["MainTitle"] = "Ödəniş";
    ViewData["SubTitle"] = "Siyahə";
    int counter = 1;
    int modalCounter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!-- Bordered table -->\n<div class=\"card\">\n    <div class=\"card-header header-elements-inline\">\n        <h5 class=\"card-title\">Bordered table</h5>\n        <div class=\"header-elements\">\n");
            WriteLiteral("        </div>\n    </div>\n\n    <div class=\"card-body\">\n");
#nullable restore
#line 25 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
         if (Model != null)
        {
            if (Model.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f141d7b3630330ff450cbbdc9be253153e3e00d7735", async() => {
                WriteLiteral("Müqaviləa yeni ödaniş et");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                                                                                        WriteLiteral(Model.FirstOrDefault()!.ContractId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n");
#nullable restore
#line 30 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>

    <table class=""table datatable-basic table-bordered"">
        <thead>
            <tr>
                <th>No</th>
                <th>Restoran</th>
                <th>Müqavilə</th>
                <th>Ödəniş zamanı</th>
                <th>Məbləğ</th>
                <th class=""text-center"">Əməliyyatlar</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 46 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                 if (Model.Count != 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                     for (int i = 0; i < Model.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 53 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 54 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                           Write(Model[i].Contract.Restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 55 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                           Write(Model[i].Contract.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 56 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                           Write(Model[i].PaidAt.ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 57 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                           Write(Model[i].Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td class=""text-center"">
                                <div class=""list-icons"">
                                    <div class=""dropdown"">
                                        <a href=""#"" class=""list-icons-item"" data-toggle=""dropdown"">
                                            <i class=""icon-menu9""></i>
                                        </a>

                                        <div class=""dropdown-menu dropdown-menu-right"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f141d7b3630330ff450cbbdc9be253153e3e00d13939", async() => {
                WriteLiteral("<i class=\"icon-pencil\"></i>Redakta");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                                                                                                       WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                            <a data-toggle=\"modal\" data-target=\"#modal_theme_danger-");
#nullable restore
#line 67 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                                                                                               Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"dropdown-item\"><i class=\"icon-eraser3\"></i>Sil</a>\n                                        </div>\n                                    </div>\n                                </div>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 73 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </tbody>\n    </table>\n</div>\n<!-- /bordered table -->\n\n\n");
#nullable restore
#line 83 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
 if (Model != null)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
     foreach (var cp in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("id", " id=\"", 3145, "\"", 3182, 2);
            WriteAttributeValue("", 3150, "modal_theme_danger-", 3150, 19, true);
#nullable restore
#line 88 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
WriteAttributeValue("", 3169, modalCounter, 3169, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal fade\" tabindex=\"-1\">\n");
#nullable restore
#line 89 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
              
                modalCounter += 1;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"modal-dialog\">\n                <div class=\"modal-content\">\n                    <div class=\"modal-header bg-danger\">\n                        <h6 class=\"modal-title\">Müqavilə ödənişi silmək ");
#nullable restore
#line 95 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                                                                   Write(cp.Contract.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    </div>

                    <div class=""modal-body"">
                        <div class=""modal-body"">
                            <h6 class=""font-weight-semibold"">Öəmnli bildiriş!!!</h6>
                            <p>Sildikdən sonra geri qayıtmayacaq. silməyinizdən əmin misiniz?</p>
                        </div>
                    </div>

                    <div class=""modal-footer"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f141d7b3630330ff450cbbdc9be253153e3e00d20379", async() => {
                WriteLiteral("\n                            <button type=\"button\" class=\"btn btn-link\" data-dismiss=\"modal\">Bağla</button>\n                            <button type=\"submit\" class=\"btn bg-danger\">Sil</button>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
                                                                                                       WriteLiteral(cp.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 115 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Areas\Panel\Views\ContractPayments\ContractPayments.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AzCultureInfo AzCulture { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccess.Pagination.PaginatedList<ContractPayment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
