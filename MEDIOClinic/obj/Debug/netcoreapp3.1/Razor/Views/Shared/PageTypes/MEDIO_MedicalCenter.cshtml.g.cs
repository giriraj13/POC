#pragma checksum "C:\inetpub\wwwroot\Kentico13_8\MEDIOClinic\Views\Shared\PageTypes\MEDIO_MedicalCenter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19cd47df40694072c8d8a7361cfadbbfb3aab9ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PageTypes_MEDIO_MedicalCenter), @"mvc.1.0.view", @"/Views/Shared/PageTypes/MEDIO_MedicalCenter.cshtml")]
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
#line 2 "C:\inetpub\wwwroot\Kentico13_8\MEDIOClinic\Views\Shared\PageTypes\MEDIO_MedicalCenter.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cd47df40694072c8d8a7361cfadbbfb3aab9ed", @"/Views/Shared/PageTypes/MEDIO_MedicalCenter.cshtml")]
    #nullable restore
    public class Views_Shared_PageTypes_MEDIO_MedicalCenter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kentico.Content.Web.Mvc.Routing.IPageViewModel<CMS.DocumentEngine.Types.MEDIO.MedicalCenter>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\inetpub\wwwroot\Kentico13_8\MEDIOClinic\Views\Shared\PageTypes\MEDIO_MedicalCenter.cshtml"
  
    ViewBag.Title = Model.Page.DocumentName;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"teaser\">\r\n\t\t<div class=\"col-sm-offset-3 col-sm-4\">\r\n\t\t\t<p>");
#nullable restore
#line 11 "C:\inetpub\wwwroot\Kentico13_8\MEDIOClinic\Views\Shared\PageTypes\MEDIO_MedicalCenter.cshtml"
          Write(Model.Page.Fields.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t</div>\r\n\t\t<div class=\"clearfix\"></div>\r\n\t</section>\r\n\t<section class=\"content\">\r\n\t\t<div class=\"col-sm-offset-3 col-sm-5\">\r\n\t\t\t");
#nullable restore
#line 17 "C:\inetpub\wwwroot\Kentico13_8\MEDIOClinic\Views\Shared\PageTypes\MEDIO_MedicalCenter.cshtml"
       Write(Html.Kentico().ResolveUrls(Model.Page.Fields.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div class=\"clearfix\"></div>\r\n\t</section>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kentico.Content.Web.Mvc.Routing.IPageViewModel<CMS.DocumentEngine.Types.MEDIO.MedicalCenter>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591