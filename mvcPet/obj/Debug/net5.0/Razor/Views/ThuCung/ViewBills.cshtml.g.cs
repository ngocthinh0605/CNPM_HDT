#pragma checksum "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\ViewBills.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1c47926e379dd5922a17f492d058f58afaef6f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThuCung_ViewBills), @"mvc.1.0.view", @"/Views/ThuCung/ViewBills.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1c47926e379dd5922a17f492d058f58afaef6f8", @"/Views/ThuCung/ViewBills.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e5ce0f96bfa08ef20895bf13149609575b427d", @"/Views/_ViewImports.cshtml")]
    public class Views_ThuCung_ViewBills : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("White linen sheer dress"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\ViewBills.cshtml"
  
	ViewData["Title"]="Chi tiết đơn hàng";
    Layout="~/Views/Shared/_Layout.cshtml";
	ViewBag.total=0;
	ViewBag.sl=0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main class=""main-container"">
<!--Checkout Area Start-->
<section class=""checkout-area area-padding ptb-40"">
	<!-- Begin checkout -->
	<div class=""ld-subpage-content"">

		<div class=""checkout-content"">

			<!-- Begin checkout section -->
			<section class=""checkout"">



				<section class=""checkout-section"">

					<div class=""ld-checkout-inner"">

						<div class=""xs-margin""></div>

						<div class=""accordion"" id=""collapse"">

							<div class=""accordion-group panel darkerbg"">

								<div class=""container"">
									<h2 class=""accordion-title"">

                
                <span>Chi tiết đơn hàng
                </span> <a class=""accordion-btn open"" data-toggle=""collapse"" href=""#collapse-five""></a></h2>

									<div class=""accordion-body collapse in"" id=""collapse-five"">

										<div class=""row accordion-body-wrapper"">
			
											<div class=""col-md-12"">

							<!-- Begin table -->
							<table class=""table cart-table"">
								<thead>
								<tr>
				");
            WriteLiteral(@"					<th class=""table-title"">Tên sản phẩm</th>
									<th class=""table-title""></th>
									<th class=""table-title"">Đơn giá</th>
									<th class=""table-title"">Số lượng</th>
									<th class=""table-title""></th>
									<th class=""table-title"">Thành tiền</th>
								</tr>
								</thead>
");
#nullable restore
#line 57 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\ViewBills.cshtml"
                          foreach(var item in Model.GetCTHD)
						 { 
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\ViewBills.cshtml"
                             foreach(var item1 in Model.GetThuCung)
						    {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\ViewBills.cshtml"
                                 if(@item.IdThuCung== @item1.IdThuCung)
                                {
                                    var thanhtien= @item.SoLuong * @item1.GiaBan;
                                    ViewBag.total += thanhtien;
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n                                            <td class=\"product-name-col\">\r\n                                                <figure>\r\n                                                    <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d1c47926e379dd5922a17f492d058f58afaef6f86854", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2145, "~/ImgCuteDogs/", 2145, 14, true);
#nullable restore
#line 68 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\ViewBills.cshtml"
AddHtmlAttributeValue("", 2159, item1.Image, 2159, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                                </figure>\r\n                                                <h2 class=\"product-name\"><a href=\"#\">");
#nullable restore
#line 70 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\ViewBills.cshtml"
                                                                                Write(item1.TenThuCung);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h2>

                                            </td>
                                            <td class=""product-code""></td>
                                            <td class=""product-price-col"">
                                                <span class=""product-price-special"">");
#nullable restore
#line 75 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\ViewBills.cshtml"
                                                                               Write(item1.GiaBan);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            </td>
                                            
                                            
                                                <td>
                                                <div class=""custom-quantity-input"">
                                                   
                                                    <input type=""number""");
            BeginWriteAttribute("value", " value=\"", 3099, "\"", 3120, 1);
#nullable restore
#line 82 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\ViewBills.cshtml"
WriteAttributeValue("", 3107, item.SoLuong, 3107, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""quantity""/>
                                                </div>
                                            </td>	
                                            
                                            <td class=""product-total-col"">
                                                <span class=""product-price-special"">");
#nullable restore
#line 87 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\ViewBills.cshtml"
                                                                               Write(thanhtien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </td>\r\n                                            \r\n                                            \r\n                                        </tr>\r\n");
#nullable restore
#line 92 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\ViewBills.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\ViewBills.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\ViewBills.cshtml"
                             
					}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								<tbody>
                                
						
								</tbody>
							</table>
							<!-- End table -->

							<div class=""mt-30""></div>

							<div class=""row"">

								<div class=""col-md-8"">

									<!-- Begin tab container -->
									<div class=""tab-container left clearfix"">

										


										<!-- Begin tab content -->
										<div class=""tab-content"">

											<div class=""tab-pane fade in active"" id=""shipping"">

													
											</div>
											<!-- /.tab-pane -->
										</div>
										<!-- /.tab-content -->
									</div>
									<!-- /.tab-container -->



									<div class=""mt-30""></div>
									<a href=""#"" class=""btn btn-custom-6 btn-lger min-width-lg"">Quay lại</a>
								</div>

								<div class=""mt-30 visible-sm visible-xs clearfix""></div>

								<div class=""col-md-4"">

									<table class=""table total-table"">

										<tbody>
										<tr>
											<td>Tổng cộng:</td>
											<td>");
#nullable restore
#line 143 "C:\Users\Admin\Desktop\PetMVC - Copy - Copy - Copy\mvcPet\Views\ThuCung\ViewBills.cshtml"
                                           Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
										
										</tr>
										</tbody>
									</table>
									<!-- End table -->

									<div class=""mt-30""></div>

									

								</div>
								<!-- /.col-md-4 -->
							</div>
							<!-- /.row -->
						</div>
				
										</div>
									</div>
								</div>
							</div>
						</div>

						<div class=""xlg-margin"">
						</div>

					</div>

				</section>


			</section>
			<!-- End checkout section -->


		</div>
		<!-- /.checkout-content -->
	</div>
	<!-- /.ld-subpage-content -->
	<!-- End checkout -->
</section>
<!--End of Checkout Area-->


</main>
<!-- end main content -->
");
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
    <script src=""js/jquery.collapse.js""></script>
    <script src=""js/main.js""></script>
");
            }
            );
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