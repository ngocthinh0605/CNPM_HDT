#pragma checksum "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be2d1be62b25fa76d64f32bad25c5edffcc9b559"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThuCung_Checkout), @"mvc.1.0.view", @"/Views/ThuCung/Checkout.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\_ViewImports.cshtml"
using mvcPet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\_ViewImports.cshtml"
using mvcPet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
using Application.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be2d1be62b25fa76d64f32bad25c5edffcc9b559", @"/Views/ThuCung/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e5ce0f96bfa08ef20895bf13149609575b427d", @"/Views/_ViewImports.cshtml")]
    public class Views_ThuCung_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewBills", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("pointer-events: none; color:currentColor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-red"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
  
	ViewData["Title"]="Check Out";
    Layout="~/Views/Shared/_Layout.cshtml";
    ViewBag.total=0;
	ViewBag.sl=0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-container"">
<!-- compare content -->
	<!-- Main content starts -->

	<div class=""main-block"">



		<div class=""container"">

			<!-- Actual content -->
			<div class=""ecommerce pt-40"">
				<div class=""row"">
					<div class=""col-md-12 col-sm-12"">
						<!-- Shopping items content -->
						<div class=""shopping-content"">
							<!-- Block Title -->

							<!-- Shopping Edit Profile -->
							<div class=""shopping-wishlist"">
								<!-- Recent Purchase Table -->
								<div class="" table-responsive"">
									<table class=""table table-bordered"">
");
#nullable restore
#line 36 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                          
										var sessionco = HttpContextAccessor.HttpContext.Session;
										string user = sessionco.GetString("TenUser");

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<h2 class=\"alert alert-success\">Danh sách đơn hàng của quý khách ");
#nullable restore
#line 39 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                                                                                    Write(user);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h2>\r\n");
            WriteLiteral(@"										<!-- Table Header -->
										<thead>
										<tr>
											<th>Ngày thanh toán</th>
											<th>Số lượng mua</th>
											<th>Tổng tiền</th>
											<th>Trạng thái</th>
											<th>Xem đơn hàng</th>
											<th>Hủy đơn hàng</th>
										</tr>
										</thead>
										<tbody>
");
#nullable restore
#line 53 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                         foreach (var item in Model.getHoaDon)
										{
											

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                             foreach (var item1 in Model.GetTrangThai)
											{
												

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                                 if(@item.IdTrangThai == @item1.IdTrangThai)
												{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 60 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                                   Write(item.NgayLap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<!-- Product image -->\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 62 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                                   Write(item.SoLuongMua);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 63 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                                   Write(item.TongTien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<td class=\"alert alert-warning\">");
#nullable restore
#line 64 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                                                               Write(item1.TenTrangThai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 65 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                                     if(@item.IdTrangThai==4)
													{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be2d1be62b25fa76d64f32bad25c5edffcc9b55910056", async() => {
                WriteLiteral("<i class=\"fa fa-edit\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idhoadon", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                                                                                                                               WriteLiteral(item.IdHoaDon);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idhoadon"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idhoadon", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idhoadon"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be2d1be62b25fa76d64f32bad25c5edffcc9b55912574", async() => {
                WriteLiteral("<i class=\"fa fa-trash-o\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idhoadon", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                                                                                                                             WriteLiteral(item.IdHoaDon);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idhoadon"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idhoadon", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idhoadon"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 69 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
													}
													else
													{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be2d1be62b25fa76d64f32bad25c5edffcc9b55915345", async() => {
                WriteLiteral("<i class=\"fa fa-edit\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idhoadon", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                                                                              WriteLiteral(item.IdHoaDon);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idhoadon"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idhoadon", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idhoadon"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be2d1be62b25fa76d64f32bad25c5edffcc9b55917731", async() => {
                WriteLiteral("<i class=\"fa fa-trash-o\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idhoadon", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                                                                           WriteLiteral(item.IdHoaDon);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idhoadon"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idhoadon", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idhoadon"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 74 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
													}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 76 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
												}

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                                 	
											}

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\Checkout.cshtml"
                                             
										}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<br />\r\n\r\n\r\n\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<!-- Main content ends -->\r\n<!-- end service area -->\r\n</main>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""js/vendor/jquery-1.10.2.min.js""></script>
	<script src=""js/bootstrap.min.js""></script>
	<script src=""js/smoothscroll.js""></script>
	<!-- Scroll up js
	============================================ -->
	<script src=""js/jquery.scrollUp.js""></script>
	<script src=""js/menu.js""></script>

	<script src=""js/owl.carousel.min.js""></script>
	<script src=""js/main.js""></script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
