#pragma checksum "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f23650100b3a4a2c87616c300f374ae7684e5111"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
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
#line 1 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\_ViewImports.cshtml"
using MakoniSoft;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\_ViewImports.cshtml"
using MakoniSoft.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f23650100b3a4a2c87616c300f374ae7684e5111", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0c4e459abeed82f24bb71ed2c494865b08f2977", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Users</h1>\r\n");
#nullable restore
#line 8 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
 using (Html.BeginForm("Create", "Users", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
                            ;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
                                        Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
                                                                                                                                            Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
Write(Html.ValidationMessageFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
                                       Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
                                                                                                                                          Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Submit\" />\r\n");
#nullable restore
#line 16 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
Write(Html.ActionLink("Click to view data", "Download", "Users", new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
                                                                                                   
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n\r\n            window.onload = function () {\r\n                alert(\"");
#nullable restore
#line 24 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"
                  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n            };\r\n    </script>\r\n");
#nullable restore
#line 27 "C:\Users\Inn\source\repos\Interview-MakoniSoft\makonisoft-interview\MakoniSoft\Views\Users\Details.cshtml"

}





#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
