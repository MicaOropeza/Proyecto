#pragma checksum "C:\Users\CPS-DLLO#3\Desktop\CrudEntityFramework\BlogCore\BlogCore\BlogCore\Areas\Cliente\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a486f82a2a0d49f2b6360288fb6d82ffd8f51f93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_Home_Details), @"mvc.1.0.view", @"/Areas/Cliente/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\CPS-DLLO#3\Desktop\CrudEntityFramework\BlogCore\BlogCore\BlogCore\Areas\Cliente\Views\_ViewImports.cshtml"
using BlogCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CPS-DLLO#3\Desktop\CrudEntityFramework\BlogCore\BlogCore\BlogCore\Areas\Cliente\Views\_ViewImports.cshtml"
using BlogCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a486f82a2a0d49f2b6360288fb6d82ffd8f51f93", @"/Areas/Cliente/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"784938c45a729b1006f16b3b5ebaebddb8e24285", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogCore.Models.Articulo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\CPS-DLLO#3\Desktop\CrudEntityFramework\BlogCore\BlogCore\BlogCore\Areas\Cliente\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"card\">\r\n        <div class=\"card-header bg-light text-light ml-0 row container\">\r\n            <div class=\"col-12 col-md-6\">\r\n                <h4 class=\"text-primary\">");
#nullable restore
#line 11 "C:\Users\CPS-DLLO#3\Desktop\CrudEntityFramework\BlogCore\BlogCore\BlogCore\Areas\Cliente\Views\Home\Details.cshtml"
                                    Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n            <div class=\"col-12 col-md-6\">\r\n                <h4 class=\"text-muted\">");
#nullable restore
#line 14 "C:\Users\CPS-DLLO#3\Desktop\CrudEntityFramework\BlogCore\BlogCore\BlogCore\Areas\Cliente\Views\Home\Details.cshtml"
                                  Write(Model.FechaCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <div class=\"col-12\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 600, "\"", 622, 1);
#nullable restore
#line 18 "C:\Users\CPS-DLLO#3\Desktop\CrudEntityFramework\BlogCore\BlogCore\BlogCore\Areas\Cliente\Views\Home\Details.cshtml"
WriteAttributeValue("", 606, Model.UrlImagen, 606, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail mx-auto d-block\" />\r\n                    <p class=\"text-secondary\">");
#nullable restore
#line 19 "C:\Users\CPS-DLLO#3\Desktop\CrudEntityFramework\BlogCore\BlogCore\BlogCore\Areas\Cliente\Views\Home\Details.cshtml"
                                         Write(Html.Raw(Model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-12 col-md-6 pb-1\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a486f82a2a0d49f2b6360288fb6d82ffd8f51f936278", async() => {
                WriteLiteral("Volver a la lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div> \r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogCore.Models.Articulo> Html { get; private set; }
    }
}
#pragma warning restore 1591
