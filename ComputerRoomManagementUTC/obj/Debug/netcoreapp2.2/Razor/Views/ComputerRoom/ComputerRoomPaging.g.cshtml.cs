#pragma checksum "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76a294d5a332706cef2e0faa57f6a99ea7d2ca21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ComputerRoom_ComputerRoomPaging), @"mvc.1.0.view", @"/Views/ComputerRoom/ComputerRoomPaging.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ComputerRoom/ComputerRoomPaging.cshtml", typeof(AspNetCore.Views_ComputerRoom_ComputerRoomPaging))]
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
#line 1 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\_ViewImports.cshtml"
using ComputerRoomManagementUTC;

#line default
#line hidden
#line 2 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\_ViewImports.cshtml"
using ComputerRoomManagementUTC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76a294d5a332706cef2e0faa57f6a99ea7d2ca21", @"/Views/ComputerRoom/ComputerRoomPaging.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f79d72fb9017f3df9fd6c8ba51a5b114861306c5", @"/Views/_ViewImports.cshtml")]
    public class Views_ComputerRoom_ComputerRoomPaging : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Common.Common.ReturnResult<Common.Entity.Models.ComputerRoom.ComputerRoom>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
  
    const int ACTIVATE = 1;
    const int DEACTIVATE = 0;


#line default
#line hidden
            BeginContext(152, 1369, true);
            WriteLiteral(@"<div class=""main-content"">
    <section class=""section"">
        <h1 class=""section-header"">
            <div>Manage Computers</div>
        </h1>
        <div class=""section-body"">
            <div class=""row"">
                <div class=""col-12 col-md-12 col-lg-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <h4>Computer Room List</h4>
                        </div>
                        <div class=""card-body p-0"">
                            <div class=""table-responsive"">
                                <table class=""table table-striped"">
                                    <tr>
                                        <th>#</th>
                                        <th>Name</th>
                                        <th>Number of computers</th>
                                        <th>Phone Number</th>
                                        <th>Address</th>
                                        <th>S");
            WriteLiteral(@"tatus</th>
                                        <th>
                                            Action
                                            <br />
                                            <button id=""add-btn"" class=""ion-plus""></button>
                                        </th>
                                    </tr>
");
            EndContext();
#line 35 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                                     foreach (var computerRoom in Model.ItemList)
                                    {

#line default
#line hidden
            BeginContext(1643, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1722, 18, false);
#line 38 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                                   Write(computerRoom.PK_Id);

#line default
#line hidden
            EndContext();
            BeginContext(1740, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1788, 17, false);
#line 39 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                                   Write(computerRoom.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1805, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1853, 30, false);
#line 40 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                                   Write(computerRoom.NumberOfComputers);

#line default
#line hidden
            EndContext();
            BeginContext(1883, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1931, 24, false);
#line 41 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                                   Write(computerRoom.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1955, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2003, 20, false);
#line 42 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                                   Write(computerRoom.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2023, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 43 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                                     if (@computerRoom.Status == ACTIVATE)
                                    {

#line default
#line hidden
            BeginContext(2145, 100, true);
            WriteLiteral("                                        <td><a href=\"javascript:void(0)\" class=\"badge badge-success\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2245, "\"", 2327, 9);
            WriteAttributeValue("", 2255, "UpdateStatus(\'", 2255, 14, true);
#line 45 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
WriteAttributeValue("", 2269, computerRoom.PK_Id, 2269, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2288, "\',", 2288, 2, true);
            WriteAttributeValue(" ", 2290, "\'", 2291, 2, true);
#line 45 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
WriteAttributeValue("", 2292, computerRoom.Name, 2292, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 2310, "\',", 2310, 2, true);
            WriteAttributeValue(" ", 2312, "\'", 2313, 2, true);
#line 45 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
WriteAttributeValue("", 2314, DEACTIVATE, 2314, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2325, "\')", 2325, 2, true);
            EndWriteAttribute();
            BeginContext(2328, 18, true);
            WriteLiteral(">Active</a></td>\r\n");
            EndContext();
#line 46 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2466, 99, true);
            WriteLiteral("                                        <td><a href=\"javascript:void(0)\" class=\"badge badge-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2565, "\"", 2645, 9);
            WriteAttributeValue("", 2575, "UpdateStatus(\'", 2575, 14, true);
#line 49 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
WriteAttributeValue("", 2589, computerRoom.PK_Id, 2589, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2608, "\',", 2608, 2, true);
            WriteAttributeValue(" ", 2610, "\'", 2611, 2, true);
#line 49 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
WriteAttributeValue("", 2612, computerRoom.Name, 2612, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 2630, "\',", 2630, 2, true);
            WriteAttributeValue(" ", 2632, "\'", 2633, 2, true);
#line 49 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
WriteAttributeValue("", 2634, ACTIVATE, 2634, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2643, "\')", 2643, 2, true);
            EndWriteAttribute();
            BeginContext(2646, 20, true);
            WriteLiteral(">Deactive</a></td>\r\n");
            EndContext();
#line 50 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2705, 84, true);
            WriteLiteral("                                    <td>\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2789, "\"", 2920, 1);
#line 52 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
WriteAttributeValue("", 2796, Url.Action("GetPagingByComputerId", "Computer", new {PAGE_INDEX = 1, PAGE_SIZE = 10, computerRoomId = computerRoom.PK_Id }), 2796, 124, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2921, 135, true);
            WriteLiteral(" id=\"edit-btn\" class=\"ion-edit\" width=\"50px\"></a>\r\n                                        <a href=\"javascript:void(0)\" id=\"delete-btn\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3056, "\"", 3117, 6);
            WriteAttributeValue("", 3066, "Delete(\'", 3066, 8, true);
#line 53 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
WriteAttributeValue("", 3074, computerRoom.PK_Id, 3074, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 3093, "\',", 3093, 2, true);
            WriteAttributeValue(" ", 3095, "\'", 3096, 2, true);
#line 53 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
WriteAttributeValue("", 3097, computerRoom.Name, 3097, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 3115, "\')", 3115, 2, true);
            EndWriteAttribute();
            BeginContext(3118, 109, true);
            WriteLiteral(" class=\"ion-trash-a\"></a>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 56 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3266, 532, true);
            WriteLiteral(@"                                </table>
                            </div>
                        </div>
                        <div class=""card-footer text-right"">
                            <nav class=""d-inline-block"">
                                <ul class=""pagination mb-0"">
                                    <li class=""page-item disabled"">
                                        <a class=""page-link"" href=""#"" tabindex=""-1""><i class=""ion ion-chevron-left""></i></a>
                                    </li>

");
            EndContext();
#line 67 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                                      
                                        var numberOfPages = Model.TotalRows / ViewBag.PAGE_SIZE;
                                        for (int i = 0; i <= numberOfPages; i++)
                                        {

#line default
#line hidden
            BeginContext(4061, 87, true);
            WriteLiteral("                                            <li class=\"page-item \"><a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4148, "\"", 4246, 1);
#line 71 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
WriteAttributeValue("", 4155, Url.Action("ComputerRoomPaging", "ComputerRoom", new { PAGE_INDEX = i+1, PAGE_SIZE = 10 }), 4155, 91, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4247, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4250, 3, false);
#line 71 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                                                                                                                                                                                       Write(i+1);

#line default
#line hidden
            EndContext();
            BeginContext(4254, 49, true);
            WriteLiteral("<span class=\"sr-only\">(current)</span></a></li>\r\n");
            EndContext();
#line 72 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                                        }
                                    

#line default
#line hidden
            BeginContext(4385, 439, true);
            WriteLiteral(@"                                    <li class=""page-item"">
                                        <a class=""page-link"" href=""#""><i class=""ion ion-chevron-right""></i></a>
                                    </li>
                                </ul>
                            </nav>
                        </div>

                    </div>
                </div>
            </div>

        </div>
    </section>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4841, 249, true);
                WriteLiteral("\r\n    <script src=\"//cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.js\"></script>\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\"#add-btn\").click(function () {\r\n                window.location.href = \'");
                EndContext();
                BeginContext(5091, 33, false);
#line 93 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                                   Write(Url.Action("Add", "ComputerRoom"));

#line default
#line hidden
                EndContext();
                BeginContext(5124, 501, true);
                WriteLiteral(@"';
            });
        })
        function Delete (id, name) {
            // Tạo thông tin xóa ComputerRoom
            var deleteInfo = {
                Title: 'Xác nhận xóa ComputerRoom',
                Content: 'Bạn có muốn xóa <b>' + name + '</b> không?',
                ConfirmButton: 'Xác nhận',
                CancelButton: 'Hủy bỏ',
                Id: id,
                RequestVerificationToken: $(""input[name=__RequestVerificationToken]"").val(),
                Url: '");
                EndContext();
                BeginContext(5626, 36, false);
#line 105 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                 Write(Url.Action("Delete", "ComputerRoom"));

#line default
#line hidden
                EndContext();
                BeginContext(5662, 743, true);
                WriteLiteral(@"',
                errorTitle: 'Thông báo lỗi',
                errorContent: 'Thay đổi trạng thái thất bại'
            };

            
            // Gọi hàm common để xóa
            common.delete(deleteInfo);
        };  

    function UpdateStatus(Id, Name, Status) {
            var updateStatusInfo = {
                Title: 'Xác nhận thay đổi trạng thái ComputerRoom',
                Content: 'Bạn có muốn thay đổi trạng thái của <b>' + Name + '</b> không?',
                ConfirmButton: 'Xác nhận',
                CancelButton: 'Hủy bỏ',
                Id: Id,
                Status: Status,
                RequestVerificationToken: $(""input[name=__RequestVerificationToken]"").val(),
                Url: '");
                EndContext();
                BeginContext(6406, 40, false);
#line 124 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\ComputerRoom\ComputerRoomPaging.cshtml"
                 Write(Url.Action("EditStatus", "ComputerRoom"));

#line default
#line hidden
                EndContext();
                BeginContext(6446, 208, true);
                WriteLiteral("\',\r\n                errorTitle: \'Thông báo lỗi\',\r\n                errorContent: \'Thay đổi trạng thái thất bại\'\r\n            }\r\n            common.updateStatus(updateStatusInfo);\r\n        };  \r\n    </script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Common.Common.ReturnResult<Common.Entity.Models.ComputerRoom.ComputerRoom>> Html { get; private set; }
    }
}
#pragma warning restore 1591