#pragma checksum "/Users/sachin/Desktop/GitHub/ASP.NET-2.2--Catching-up-with-KudVenkat/Passing Data to Views from Controller/views/Home/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "433fa342a90ab5bd903632f8b91b742c5fc494d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_Home_Details), @"mvc.1.0.view", @"/views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/views/Home/Details.cshtml", typeof(AspNetCore.views_Home_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"433fa342a90ab5bd903632f8b91b742c5fc494d4", @"/views/Home/Details.cshtml")]
    public class views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 11, true);
            WriteLiteral("<html>\n    ");
            EndContext();
            BeginContext(11, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f4b9a3a766a4a29bd6f6d8925ffdb93", async() => {
                BeginContext(17, 39, true);
                WriteLiteral("\n        <title>\n\n        </title>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(63, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(68, 287, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3085a0c5ec324d0f9067b851332cb5b1", async() => {
                BeginContext(74, 13, true);
                WriteLiteral("\n        <h3>");
                EndContext();
                BeginContext(88, 17, false);
#line 8 "/Users/sachin/Desktop/GitHub/ASP.NET-2.2--Catching-up-with-KudVenkat/Passing Data to Views from Controller/views/Home/Details.cshtml"
       Write(ViewBag.PageTitle);

#line default
#line hidden
                EndContext();
                BeginContext(105, 40, true);
                WriteLiteral(" </h3>\n\n        <div>\n           Name:  ");
                EndContext();
                BeginContext(146, 21, false);
#line 11 "/Users/sachin/Desktop/GitHub/ASP.NET-2.2--Catching-up-with-KudVenkat/Passing Data to Views from Controller/views/Home/Details.cshtml"
             Write(ViewBag.Employee.Name);

#line default
#line hidden
                EndContext();
                BeginContext(167, 52, true);
                WriteLiteral(";\n        </div>\n\n\n        <div>\n           Email:  ");
                EndContext();
                BeginContext(220, 22, false);
#line 16 "/Users/sachin/Desktop/GitHub/ASP.NET-2.2--Catching-up-with-KudVenkat/Passing Data to Views from Controller/views/Home/Details.cshtml"
              Write(ViewBag.Employee.email);

#line default
#line hidden
                EndContext();
                BeginContext(242, 57, true);
                WriteLiteral(";\n        </div>\n\n\n        <div>\n           Department:  ");
                EndContext();
                BeginContext(300, 27, false);
#line 21 "/Users/sachin/Desktop/GitHub/ASP.NET-2.2--Catching-up-with-KudVenkat/Passing Data to Views from Controller/views/Home/Details.cshtml"
                   Write(ViewBag.Employee.Department);

#line default
#line hidden
                EndContext();
                BeginContext(327, 21, true);
                WriteLiteral(";\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(355, 10, true);
            WriteLiteral("\n\n</html>\n");
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