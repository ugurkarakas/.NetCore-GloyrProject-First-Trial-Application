#pragma checksum "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Advertisement\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f04a986a37b788f8d7c462f1f4005f4dcbb132f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advertisement_Search), @"mvc.1.0.view", @"/Views/Advertisement/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Advertisement/Search.cshtml", typeof(AspNetCore.Views_Advertisement_Search))]
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
#line 1 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\_ViewImports.cshtml"
using gloyr5gen.Entity;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\_ViewImports.cshtml"
using gloyr5gen.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f04a986a37b788f8d7c462f1f4005f4dcbb132f0", @"/Views/Advertisement/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c108f57dabd38a30e5d6bcacb22454745773bcc0", @"/Views/_ViewImports.cshtml")]
    public class Views_Advertisement_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvertisementListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Advertisement\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
            BeginContext(75, 1075, true);
            WriteLiteral(@"
<div class=""site-wrap"">

    <div class=""site-mobile-menu site-navbar-target"">
        <div class=""site-mobile-menu-header"">
            <div class=""site-mobile-menu-close mt-3"">
                <span class=""icon-close2 js-menu-toggle""></span>
            </div>
        </div>

    </div><!-- .site-mobile-menu -->
    <!-- NAVBAR -->
    <!-- HOME -->
    <section class=""home-section section-hero inner-page overlay bg-image"" style=""background-image: url('/images/hero_11.jpg');""
             id=""home-section"">
        <div class=""container"">
            <div class=""row align-items-center justify-content-center"">
                <div class=""col-md-12"">
                    <div class=""mb-5 text-center"">
                        <h1 class=""text-white font-weight-bold""></h1>
                        <p style=""margin:0px; padding:0px;"">Gloyr İle Aradığın İşi Hemen Bul.  </p>
                        <p style=""margin:0px; padding:0px;""> Hayalindeki İlanı Bulamadıysan Daha Detaylı Arayabilirsin.</p");
            WriteLiteral(">\r\n                    </div>\r\n                    ");
            EndContext();
            BeginContext(1151, 26, false);
#line 29 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Advertisement\Search.cshtml"
               Write(Html.Partial("_SearchBox"));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 356, true);
            WriteLiteral(@"

                </div>
            </div>
        </div>

    </section>
    <section class=""site-section"">
        <div class=""container"">

           
            <div class=""row mb-5 justify-content-center"">
                <div class=""col-md-7 text-center"" >
                    <h1 class=""section-title mb-2"">
                       
");
            EndContext();
#line 44 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Advertisement\Search.cshtml"
                          
                            int ff = Model.PagingInfo.TotalItems;
                            if (ff != 0) {

#line default
#line hidden
            BeginContext(1672, 38, true);
            WriteLiteral("                                <span>");
            EndContext();
            BeginContext(1711, 2, false);
#line 47 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Advertisement\Search.cshtml"
                                 Write(ff);

#line default
#line hidden
            EndContext();
            BeginContext(1713, 23, true);
            WriteLiteral(" ilan bulundu!</span>\r\n");
            EndContext();
#line 48 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Advertisement\Search.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1830, 41, true);
            WriteLiteral("<span>Aradığınız İlan Bulunamadı !</span>");
            EndContext();
#line 50 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Advertisement\Search.cshtml"
                                                                      }
                            

#line default
#line hidden
            BeginContext(1905, 105, true);
            WriteLiteral("                    </h1>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"mb-5\">\r\n");
            EndContext();
#line 57 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Advertisement\Search.cshtml"
                 foreach (var advertisement in Model.Advertisements)
                {
                    

#line default
#line hidden
            BeginContext(2120, 49, false);
#line 59 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Advertisement\Search.cshtml"
               Write(Html.Partial("_AdvertisementItem", advertisement));

#line default
#line hidden
            EndContext();
#line 59 "C:\Users\User\Desktop\gloyr5gen - Kopya\gloyr5gen\Views\Advertisement\Search.cshtml"
                                                                      
                }

#line default
#line hidden
            BeginContext(2190, 64, true);
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </section>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvertisementListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591