#pragma checksum "C:\Users\Bogdan\Documents\GitHub\fiidotnet\MyPhotos\WebApp\Pages\Photos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c045b4b1092d45044e08b4857ebd645250476f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Photos.Pages_Photos_Details), @"mvc.1.0.razor-page", @"/Pages/Photos/Details.cshtml")]
namespace WebApp.Pages.Photos
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
#line 1 "C:\Users\Bogdan\Documents\GitHub\fiidotnet\MyPhotos\WebApp\Pages\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c045b4b1092d45044e08b4857ebd645250476f4", @"/Pages/Photos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54a580a236bf4511f2b8e02a6219a9844921dafb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Photos_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Bogdan\Documents\GitHub\fiidotnet\MyPhotos\WebApp\Pages\Photos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Details for: ");
#nullable restore
#line 7 "C:\Users\Bogdan\Documents\GitHub\fiidotnet\MyPhotos\WebApp\Pages\Photos\Details.cshtml"
            Write(ViewData["Photo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\Bogdan\Documents\GitHub\fiidotnet\MyPhotos\WebApp\Pages\Photos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Tags[0].TagId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\Bogdan\Documents\GitHub\fiidotnet\MyPhotos\WebApp\Pages\Photos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Tags[0].Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Bogdan\Documents\GitHub\fiidotnet\MyPhotos\WebApp\Pages\Photos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Tags[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Bogdan\Documents\GitHub\fiidotnet\MyPhotos\WebApp\Pages\Photos\Details.cshtml"
         foreach (var item in Model.Tags)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\Bogdan\Documents\GitHub\fiidotnet\MyPhotos\WebApp\Pages\Photos\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.TagId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\Bogdan\Documents\GitHub\fiidotnet\MyPhotos\WebApp\Pages\Photos\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\Bogdan\Documents\GitHub\fiidotnet\MyPhotos\WebApp\Pages\Photos\Details.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Bogdan\Documents\GitHub\fiidotnet\MyPhotos\WebApp\Pages\Photos\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.PhotosDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.PhotosDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.PhotosDetailsModel>)PageContext?.ViewData;
        public WebApp.PhotosDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
