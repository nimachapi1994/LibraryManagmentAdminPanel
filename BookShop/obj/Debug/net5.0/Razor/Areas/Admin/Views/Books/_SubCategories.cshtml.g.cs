#pragma checksum "E:\داکیومنت های برنامه نویسی\NimaIsDeveloper1\Projects\MystartUpsProject\BookShop\BookShop\Areas\Admin\Views\Books\_SubCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e5b294a88f88f3d481d674098b647920574de15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books__SubCategories), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/_SubCategories.cshtml")]
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
#line 1 "E:\داکیومنت های برنامه نویسی\NimaIsDeveloper1\Projects\MystartUpsProject\BookShop\BookShop\Areas\Admin\Views\_ViewImports.cshtml"
using BookShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\داکیومنت های برنامه نویسی\NimaIsDeveloper1\Projects\MystartUpsProject\BookShop\BookShop\Areas\Admin\Views\_ViewImports.cshtml"
using BookShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e5b294a88f88f3d481d674098b647920574de15", @"/Areas/Admin/Views/Books/_SubCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee4735df80bb67d1ce7d40fc94d37240032cc50", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Books__SubCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookShop.Models.ViewModels.TreeViewCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\داکیومنت های برنامه نویسی\NimaIsDeveloper1\Projects\MystartUpsProject\BookShop\BookShop\Areas\Admin\Views\Books\_SubCategories.cshtml"
   var d = new List<int>();

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\داکیومنت های برنامه نویسی\NimaIsDeveloper1\Projects\MystartUpsProject\BookShop\BookShop\Areas\Admin\Views\Books\_SubCategories.cshtml"
 if (ViewBag.showcategory != null)
{
    d = ViewBag.showcategory as
        List<int>;
}
 

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul>\r\n");
#nullable restore
#line 12 "E:\داکیومنت های برنامه نویسی\NimaIsDeveloper1\Projects\MystartUpsProject\BookShop\BookShop\Areas\Admin\Views\Books\_SubCategories.cshtml"
     foreach (var item in Model)
    {
        var f =d.Where (x => x == item.Category_Id).Select(x => (int)x).Any();
        if (f)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <input type=\"checkbox\" checked=\"checked\" name=\"CategoryID\"");
            BeginWriteAttribute("value", " value=\"", 549, "\"", 574, 1);
#nullable restore
#line 19 "E:\داکیومنت های برنامه نویسی\NimaIsDeveloper1\Projects\MystartUpsProject\BookShop\BookShop\Areas\Admin\Views\Books\_SubCategories.cshtml"
WriteAttributeValue("", 557, item.Category_Id, 557, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                ");
#nullable restore
#line 20 "E:\داکیومنت های برنامه نویسی\NimaIsDeveloper1\Projects\MystartUpsProject\BookShop\BookShop\Areas\Admin\Views\Books\_SubCategories.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        \r\n\r\n            </li>\r\n");
#nullable restore
#line 24 "E:\داکیومنت های برنامه نویسی\NimaIsDeveloper1\Projects\MystartUpsProject\BookShop\BookShop\Areas\Admin\Views\Books\_SubCategories.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n\r\n                <input type=\"checkbox\" name=\"CategoryID\"");
            BeginWriteAttribute("value", " value=\"", 759, "\"", 784, 1);
#nullable restore
#line 29 "E:\داکیومنت های برنامه نویسی\NimaIsDeveloper1\Projects\MystartUpsProject\BookShop\BookShop\Areas\Admin\Views\Books\_SubCategories.cshtml"
WriteAttributeValue("", 767, item.Category_Id, 767, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> ");
#nullable restore
#line 29 "E:\داکیومنت های برنامه نویسی\NimaIsDeveloper1\Projects\MystartUpsProject\BookShop\BookShop\Areas\Admin\Views\Books\_SubCategories.cshtml"
                                                                                 Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 31 "E:\داکیومنت های برنامه نویسی\NimaIsDeveloper1\Projects\MystartUpsProject\BookShop\BookShop\Areas\Admin\Views\Books\_SubCategories.cshtml"
           Write(await Html.PartialAsync("_SubCategories", item.SubCategory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 33 "E:\داکیومنت های برنامه نویسی\NimaIsDeveloper1\Projects\MystartUpsProject\BookShop\BookShop\Areas\Admin\Views\Books\_SubCategories.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookShop.Models.ViewModels.TreeViewCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
