#pragma checksum "C:\Users\User\Desktop\Peterna\Peterna Back\Peterna\Peterna\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7da18f52241973bf9761aa751970b19a486399c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Peterna\Peterna Back\Peterna\Peterna\Views\Home\Index.cshtml"
using Peterna.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da18f52241973bf9761aa751970b19a486399c0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Desktop\Peterna\Peterna Back\Peterna\Peterna\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- main start -->
<main>
    <!-- mainpage section start  -->
    <section id=""mainpage"">
        <div class=""mainpage"">
            <div class=""mainpage-inner"">
                <div class=""mainpage-item"">
                    <p class=""title-main"">
                        GET PAGE DONE
                    </p>
                    <p class=""main-text"">
                        It take efforts
                    </p>
                    <p class=""main-context"">Lorem ipsum dolor sit ametLorem ipsum dolor sit amet</p>
                    <div class=""download-main"">
                        <div class=""download-box"">
                            <a href=""www"" class=""download"">DOWNLOAD THIS THEME NOW</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- mainpage section end  -->
    <!-- our services section start  -->
    <section id=""our-services"">
        <div class=""our-services"">
            <d");
            WriteLiteral(@"iv class=""our-services-inner"">
                <div class=""our-services-item services-main"">
                    <div class=""our-services-item-inner our-context"">
                        <div class=""our-context-item our-title"">
                            <p>OUR SERVICES :</p>
                        </div>
                        <div class=""all-wrappers"">
                            <div class=""wrapper"">
                                <div class=""our-context-item"">
                                    <p class=""main-services-title"">Lorem ipsum dolor sit amet</p>
                                </div>
                                <div class=""our-context-item"">
                                    <p class=""main-services-context"">
                                        Lorem ipsum dolor sit amet, consectetur
                                        adipiscing
                                        elit. <br>
                                        Curabitur nec nisl odio. br <br> Mauris veh");
            WriteLiteral(@"icula at nunc id posuere.
                                        <br>
                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. <br> Curabitur nec
                                        nisl
                                        odio.
                                        Mauris
                                        vehicula at nunc id posuere.
                                    </p>
                                </div>
                            </div>
                            <div class=""wrapper"">
                                <div class=""our-context-item"">
                                    <p class=""main-services-title"">Lorem ipsum dolor sit amet</p>
                                </div>
                                <div class=""our-context-item"">
                                    <p class=""main-services-context"">
                                        Lorem ipsum dolor sit amet, consectetur
                                   ");
            WriteLiteral(@"     adipiscing
                                        elit. <br>
                                        Curabitur nec nisl odio. br <br> Mauris vehicula at nunc id posuere.
                                        <br>
                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. <br> Curabitur nec
                                        nisl
                                        odio.
                                        Mauris
                                        vehicula at nunc id posuere.
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""our-services-item"">
                    <!-- card istems start  -->
                    <div class=""cards"">

");
#nullable restore
#line 86 "C:\Users\User\Desktop\Peterna\Peterna Back\Peterna\Peterna\Views\Home\Index.cshtml"
                         foreach (var service in Model.Services)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"all-cards\">\r\n                                <div class=\"cards-item\">\r\n                                    <div class=\"icon\"><i");
            BeginWriteAttribute("class", " class=\"", 4318, "\"", 4339, 1);
#nullable restore
#line 90 "C:\Users\User\Desktop\Peterna\Peterna Back\Peterna\Peterna\Views\Home\Index.cshtml"
WriteAttributeValue("", 4326, service.Icon, 4326, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></div>\r\n                                    <div class=\"card-context\">\r\n                                        <p class=\"card-title\">");
#nullable restore
#line 92 "C:\Users\User\Desktop\Peterna\Peterna Back\Peterna\Peterna\Views\Home\Index.cshtml"
                                                         Write(service.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p class=\"card-description\">\r\n                                           ");
#nullable restore
#line 94 "C:\Users\User\Desktop\Peterna\Peterna Back\Peterna\Peterna\Views\Home\Index.cshtml"
                                      Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 99 "C:\Users\User\Desktop\Peterna\Peterna Back\Peterna\Peterna\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <!-- card istems end  -->
                </div>
                <div class=""our-services-item"">
                    <div class=""services-last-part-main"">
                        <div class=""services-last-part"">
                            <div class=""wrapper"">
                                <div class=""our-context-item"">
                                    <p class=""main-services-title"">Lorem ipsum dolor sit amet</p>
                                </div>
                                <div class=""our-context-item"">
                                    <p class=""main-services-context"">
                                        Lorem ipsum dolor sit amet, consectetur
                                        adipiscing
                                        elit. Curabitur nec nisl odio. Mauris vehicula at nunc id posuere.
                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl
            ");
            WriteLiteral(@"                            odio.
                                        Mauris vehicula at nunc id posuere.
                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl
                                        odio.
                                        Mauris vehicula at nunc id posuere.
                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl
                                        odio.
                                        Mauris vehicula at nunc id posuere.
                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl
                                        odio.
                                        Mauris vehicula at nunc id posuere.
                                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl
                                        odio.
                         ");
            WriteLiteral(@"               Mauris vehicula at nunc id posuere.
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- our services section end  -->
    <!-- futured section start  -->
    <section id=""futured"">
        <div class=""futured"">
            <div class=""futured-inner"">
                <div class=""futured-inner-item"">
                    <p class=""futured-title"">Featured In Wall Street</p>
                    <p class=""futured-description"">and many other magzines..</p>
                </div>
                <div class=""futured-inner-item"">
                    <p class=""futured-title"">300+</p>
                    <p class=""futured-description"">Reports</p>
                </div>
            </div>
        </div>
    </section>
    <!-- futured section end  -->
    <!-- our plans section star");
            WriteLiteral(@"t  -->
    <section id=""our-plans"">
        <div class=""main-our-plans"">
            <div class=""our-plans"">

                <div class=""our-plans-context"">

                    <div class=""plans-context-item"">
                        <div class=""our-plans-inner"">
                            <p class=""our-plans-title"">
                                OUR PLANS :
                            </p>

                        </div>
                        <p class=""plans-title"">Lorem ipsum dolor sit amet</p>
                        <p class=""plans-description"">
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris
                            vehicula at nunc id posuere.
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris
                            vehicula at nunc id posuere.
                        </p>
                    </div>
                    <div class=""pla");
            WriteLiteral(@"ns-context-item"">
                        <div class=""our-plans-inner"">
                            <p class=""our-plans-title hidden"">
                                OUR PLANS :
                            </p>

                        </div>
                        <p class=""plans-title"">Lorem ipsum dolor sit amet</p>
                        <p class=""plans-description"">
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris
                            vehicula at nunc id posuere.
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur nec nisl odio. Mauris
                            vehicula at nunc id posuere.
                        </p>
                    </div>
                </div>


            </div>
            <div class=""our-plans-card-main"">
                <div class=""our-plans-cards"">
                    <div class=""plan-card-items"">
                        <div class=""");
            WriteLiteral(@"plan-name"">
                            <p>BASIC PLAN</p>
                        </div>
                        <div class=""main-plan-list"">
                            <div class=""plan-list"">
                                <ul>
                                    <li>12 Accounts</li>
                                    <li>52 Emails</li>
                                    <li>50 GB Space</li>
                                    <li>Free Support</li>
                                </ul>
                            </div>
                        </div>
                        <div class=""plan-price"">
                            <p>$99 only</p>
                        </div>
                        <div class=""read-more red"">
                            <p>Read More</p>
                        </div>
                    </div>
                    <div class=""plan-card-items"">
                        <div class=""plan-name"">
                            <p>BASIC PLAN</p>
                ");
            WriteLiteral(@"        </div>
                        <div class=""main-plan-list"">
                            <div class=""plan-list"">
                                <ul>
                                    <li>12 Accounts</li>
                                    <li>52 Emails</li>
                                    <li>50 GB Space</li>
                                    <li>Free Support</li>
                                </ul>
                            </div>
                        </div>
                        <div class=""plan-price"">
                            <p>$99 only</p>
                        </div>
                        <div class=""read-more green"">
                            <p>Read More</p>
                        </div>
                    </div>
                    <div class=""plan-card-items"">
                        <div class=""plan-name"">
                            <p>BASIC PLAN</p>
                        </div>
                        <div class=""main-plan-list"">
    ");
            WriteLiteral(@"                        <div class=""plan-list"">
                                <ul>
                                    <li>12 Accounts</li>
                                    <li>52 Emails</li>
                                    <li>50 GB Space</li>
                                    <li>Free Support</li>
                                </ul>
                            </div>
                        </div>
                        <div class=""plan-price"">
                            <p>$99 only</p>
                        </div>
                        <div class=""read-more blue"">
                            <p>Read More</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- our plans section end  -->
    <!-- project section start -->
    <section id=""project"">
        <div class=""futured project-box"">
            <div class=""futured-inner project"">
                <div class=""futured-inner-i");
            WriteLiteral(@"tem"">
                    <p class=""futured-title"">5000+</p>
                    <p class=""futured-description"">Projects</p>
                </div>
                <div class=""futured-inner-item"">
                    <p class=""futured-title"">5000+</p>
                    <p class=""futured-description"">Projects</p>
                </div>
                <div class=""futured-inner-item"">
                    <p class=""futured-title"">205+</p>
                    <p class=""futured-description"">Countries</p>
                </div>
                <div class=""futured-inner-item"">
                    <p class=""futured-title"">1300+</p>
                    <p class=""futured-description"">Offices</p>
                </div>
            </div>
        </div>
    </section>
    <!-- project section end -->

</main>

<!--main end -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591