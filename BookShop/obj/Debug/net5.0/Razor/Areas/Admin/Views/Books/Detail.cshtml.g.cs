#pragma checksum "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "774c7ad223be582c9f7af05f264bd57b2c61f86d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/Detail.cshtml")]
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
#line 1 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\_ViewImports.cshtml"
using BookShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\_ViewImports.cshtml"
using BookShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
using BookShop.GeneralMethods;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"774c7ad223be582c9f7af05f264bd57b2c61f86d", @"/Areas/Admin/Views/Books/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee4735df80bb67d1ce7d40fc94d37240032cc50", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Books_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookShop.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Book.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header bg-light\">\r\n                اطلاعات کتاب ");
#nullable restore
#line 13 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                        Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-3\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "774c7ad223be582c9f7af05f264bd57b2c61f86d4999", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-md-9\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                                <p>عنوان کتاب : ");
#nullable restore
#line 24 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>شابک : ");
#nullable restore
#line 25 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                     Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>سال انتشار : ");
#nullable restore
#line 26 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                           Write(Model.PublishYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>قیمت : ");
#nullable restore
#line 27 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                     Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>موجودی : ");
#nullable restore
#line 28 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                       Write(Model.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>تعداد صفحات : ");
#nullable restore
#line 29 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                            Write(Model.NumOfPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>زبان کتاب : ");
#nullable restore
#line 30 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                          Write(Model.Language.LanguageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n\r\n                                <p>ناشر : ");
#nullable restore
#line 34 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                     Write(Model.Publisher.PublisherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>\r\n                                    نویسندگان :\r\n");
#nullable restore
#line 37 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                      string Authors = "";

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                     foreach (var item in ViewBag.showAuthors as IEnumerable<BookShop.Models.Auther>)
                                    {
                                        if (Authors != "")
                                        {
                                            Authors = Authors + " - " + item.FirstName + " " + item.LastName;
                                        }
                                        else
                                        {
                                            Authors = item.FirstName + " " + item.LastName;
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 50 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                               Write(Authors);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p>\r\n                                    مترجمان :\r\n");
#nullable restore
#line 54 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                      var TranslatorsList = ViewBag.Translators_book as IEnumerable<BookShop.Models.Translator>;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                     if (TranslatorsList.Count() != 0)
                                    {

                                        string Translators = "";
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                         foreach (var item in TranslatorsList)
                                        {
                                            if (Translators != "")
                                            {
                                                Translators = Translators + " - " + item.Name;
                                            }
                                            else
                                            {
                                                Translators = item.Name;
                                            }
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                   Write(Translators);

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                                    
                                    }

                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>-</span>\r\n");
#nullable restore
#line 77 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p>\r\n                                    دسته بندی ها :\r\n");
#nullable restore
#line 82 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                       var CategoriesList = ViewBag.Category_book as IEnumerable<BookShop.Models.Category>;

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                     if (CategoriesList.Count() != 0)
                                    {
                                        string Categories = "";
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                         foreach (var item in CategoriesList)
                                        {
                                            if (Categories != "")
                                            {
                                                Categories = Categories + " - " + item.Category_Name;
                                            }
                                            else
                                            {
                                                Categories = item.Category_Name;
                                            }
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                   Write(Categories);

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                                   
                                    }

                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>-</span>\r\n");
#nullable restore
#line 104 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p>\r\n                                    تاریخ انتشار :\r\n");
#nullable restore
#line 109 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                     if (Model.PublishDate != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                   Write(PersianDatetimeCalculator.ConvertMidaldiToShamsi((DateTime)Model.PublishDate));

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                                                                                                      
                                    }

                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>-</span>\r\n");
#nullable restore
#line 117 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </p>\r\n                                <p>\r\n                                    وضعیت :\r\n");
#nullable restore
#line 121 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                     if (Model.IsPublish == true)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>منتشر شده</span>\r\n");
#nullable restore
#line 124 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                    }

                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>پیش نویس</span>\r\n");
#nullable restore
#line 129 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </p>

                            </div>

                        </div>

                    </div>

                    <div class=""col-md-12"">
                        <hr />
                        <p>
                            خلاصه کتاب : ");
#nullable restore
#line 141 "C:\Users\NimaChapi\Desktop\MyNImaVookShop\BookShop\BookShop\Areas\Admin\Views\Books\Detail.cshtml"
                                    Write(Model.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookShop.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
