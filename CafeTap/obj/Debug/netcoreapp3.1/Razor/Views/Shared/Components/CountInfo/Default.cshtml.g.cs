#pragma checksum "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Views\Shared\Components\CountInfo\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a5a654561854cdae3414e95da68b3bfb169feda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CountInfo_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CountInfo/Default.cshtml")]
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
#line 4 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Views\_ViewImports.cshtml"
using Infrastructure.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Views\_ViewImports.cshtml"
using Humanizer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Views\_ViewImports.cshtml"
using Humanizer.Localisation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Views\_ViewImports.cshtml"
using static Infrastructure.Common.ClaimsList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a5a654561854cdae3414e95da68b3bfb169feda", @"/Views/Shared/Components/CountInfo/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29cb1d535e7ca2410b898a4bdbe21b3b16e0f345", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CountInfo_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Infrastructure.Statistics.ViewModels.EmployeeRestaurantContractCountVm>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<div class=\"card card-body\">\n    <div class=\"row text-center\">\n        <div class=\"col-4\">\n            <p><i class=\"icon-store icon-2x d-inline-block text-info\"></i></p>\n            <h5 class=\"font-weight-semibold mb-0\">");
#nullable restore
#line 8 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Views\Shared\Components\CountInfo\Default.cshtml"
                                             Write(Model.RestaurantCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
            <span class=""text-muted font-size-sm"">Restoranlar</span>
        </div>

        <div class=""col-4"">
            <p><i class=""icon-file-text2 icon-2x d-inline-block text-warning""></i></p>
            <h5 class=""font-weight-semibold mb-0"">");
#nullable restore
#line 14 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Views\Shared\Components\CountInfo\Default.cshtml"
                                             Write(Model.ContractCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            <span class=\"text-muted font-size-sm\">Müqavilələr</span>\n        </div>\n\n        <div class=\"col-4\">\n            <p><i class=\"icon-user-tie icon-2x d-inline-block text-success\"></i></p>\n            <h5 class=\"font-weight-semibold mb-0\">");
#nullable restore
#line 20 "C:\Users\User\Dropbox\PC\Desktop\Cafe-master\CafeTap\Views\Shared\Components\CountInfo\Default.cshtml"
                                             Write(Model.EmployeeCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            <span class=\"text-muted font-size-sm\">İşçilər</span>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Infrastructure.Statistics.ViewModels.EmployeeRestaurantContractCountVm> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
