#pragma checksum "C:\Users\GENC\source\repos\eksiSozluk\ExchangeBook\Views\Shared\_Opinion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a184f259cd81c000d970d38e0b66b8c2729542c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Opinion), @"mvc.1.0.view", @"/Views/Shared/_Opinion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Opinion.cshtml", typeof(AspNetCore.Views_Shared__Opinion))]
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
#line 1 "C:\Users\GENC\source\repos\eksiSozluk\ExchangeBook\Views\_ViewImports.cshtml"
using ExchangeBook;

#line default
#line hidden
#line 2 "C:\Users\GENC\source\repos\eksiSozluk\ExchangeBook\Views\_ViewImports.cshtml"
using ExchangeBook.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a184f259cd81c000d970d38e0b66b8c2729542c3", @"/Views/Shared/_Opinion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb83ffc21116d9eb28edc12c03ccee8cc43bb27", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Opinion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/adsiter/images/client-img.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\GENC\source\repos\eksiSozluk\ExchangeBook\Views\Shared\_Opinion.cshtml"
  
    Context db = new Context();
    List<Opinion> opinionList= db.Opinions.Where(x=>x.Published==true).ToList();
    int counter = 0;

#line default
#line hidden
            BeginContext(144, 506, true);
            WriteLiteral(@"<div class=""layout_padding clients_section"">
    <div class=""container"">
        <div id=""client_slide"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#client_slide"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#client_slide"" data-slide-to=""1""></li>
                <li data-target=""#client_slide"" data-slide-to=""2""></li>
            </ol>
         
            <div class=""carousel-inner"">

");
            EndContext();
#line 17 "C:\Users\GENC\source\repos\eksiSozluk\ExchangeBook\Views\Shared\_Opinion.cshtml"
                 foreach (var item in opinionList)
                            {
                                User user = db.Users.Where(x => x.UserId == item.UserId).SingleOrDefault();
                                if (counter == 0)
                                {

#line default
#line hidden
            BeginContext(926, 360, true);
            WriteLiteral(@"<div class=""carousel-item active"">
                            <div class=""row"">
                                <div class=""col-sm-12"">
                                    <h1 class=""promoted_text""> <span style=""border-bottom: 5px solid saddlebrown;"">BİZİM HAKKIMIZDAKİ GÖRÜŞLERİNİZ</span></h1>
                                    <div class=""client_img"">");
            EndContext();
            BeginContext(1286, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e37f24ff95da4b0b88b5d70ebebad336", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1329, 68, true);
            WriteLiteral("</div>\r\n                                    <h1 class=\"client_text\">");
            EndContext();
            BeginContext(1398, 13, false);
#line 26 "C:\Users\GENC\source\repos\eksiSozluk\ExchangeBook\Views\Shared\_Opinion.cshtml"
                                                       Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1411, 64, true);
            WriteLiteral("</h1>\r\n                                    <p class=\"long_text\">");
            EndContext();
            BeginContext(1476, 16, false);
#line 27 "C:\Users\GENC\source\repos\eksiSozluk\ExchangeBook\Views\Shared\_Opinion.cshtml"
                                                    Write(item.YourOpinion);

#line default
#line hidden
            EndContext();
            BeginContext(1492, 114, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 31 "C:\Users\GENC\source\repos\eksiSozluk\ExchangeBook\Views\Shared\_Opinion.cshtml"
                        counter = 1;
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1714, 355, true);
            WriteLiteral(@" <div class=""carousel-item "">
                            <div class=""row"">
                                <div class=""col-sm-12"">
                                    <h1 class=""promoted_text""> <span style=""border-bottom: 5px solid saddlebrown;"">BİZİM HAKKIMIZDAKİ GÖRÜŞLERİNİZ</span></h1>
                                    <div class=""client_img"">");
            EndContext();
            BeginContext(2069, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8b38e482b2c341a4a6eb0c01e7a14a7f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2112, 68, true);
            WriteLiteral("</div>\r\n                                    <h1 class=\"client_text\">");
            EndContext();
            BeginContext(2181, 13, false);
#line 39 "C:\Users\GENC\source\repos\eksiSozluk\ExchangeBook\Views\Shared\_Opinion.cshtml"
                                                       Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2194, 64, true);
            WriteLiteral("</h1>\r\n                                    <p class=\"long_text\">");
            EndContext();
            BeginContext(2259, 16, false);
#line 40 "C:\Users\GENC\source\repos\eksiSozluk\ExchangeBook\Views\Shared\_Opinion.cshtml"
                                                    Write(item.YourOpinion);

#line default
#line hidden
            EndContext();
            BeginContext(2275, 112, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>");
            EndContext();
#line 43 "C:\Users\GENC\source\repos\eksiSozluk\ExchangeBook\Views\Shared\_Opinion.cshtml"
                              }


                }

#line default
#line hidden
            BeginContext(2413, 69, true);
            WriteLiteral("            </div> \r\n            \r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
