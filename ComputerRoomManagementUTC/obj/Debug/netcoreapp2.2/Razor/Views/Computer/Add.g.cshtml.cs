#pragma checksum "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\Computer\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0ebbd6652e2bd8adca312bb5820b5fb58568037"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Computer_Add), @"mvc.1.0.view", @"/Views/Computer/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Computer/Add.cshtml", typeof(AspNetCore.Views_Computer_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0ebbd6652e2bd8adca312bb5820b5fb58568037", @"/Views/Computer/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f79d72fb9017f3df9fd6c8ba51a5b114861306c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Computer_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("add-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\Computer\Add.cshtml"
  
    int computerRoomId = (int)ViewBag.ComputerRoomId;

#line default
#line hidden
            BeginContext(62, 558, true);
            WriteLiteral(@"
<div class=""main-content"">
    <section class=""section"">
        <h1 class=""section-header"">
            <div>Manage Computers</div>
        </h1>
        <div class=""section-body"">
            <div class=""row"">
                <div class=""col-12 col-md-12 col-lg-12"">
                    <div class=""card"">
                        <div class=""row"">
                            <div class=""col-12 col-md-12 col-lg-12"">
                                <div class=""login-brand"">
                                    Create a new Computer for room ");
            EndContext();
            BeginContext(621, 14, false);
#line 17 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\Computer\Add.cshtml"
                                                              Write(computerRoomId);

#line default
#line hidden
            EndContext();
            BeginContext(635, 208, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"card card-primary\">\r\n                                    <div class=\"card-body\">\r\n                                        ");
            EndContext();
            BeginContext(843, 6519, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0ebbd6652e2bd8adca312bb5820b5fb585680376626", async() => {
                BeginContext(902, 5359, true);
                WriteLiteral(@"
                                            <div class=""form-group"">
                                                <label for=""ComputerName"">Computer Name</label>
                                                <input id=""ComputerName"" type=""text"" class=""form-control"" name=""Name"" tabindex=""1"" autofocus>
                                                <span target=""ComputerName"" class=""error""></span>
                                            </div>

                                            <div class=""form-group"">
                                                <label for=""CpuName"">CPU Name</label>
                                                <select id=""CpuName"" class=""select2"" style=""width:300px"" tabindex=""1""></select>
                                                <span target=""CpuName"" class=""error""></span>
                                            </div>

                                            <div class=""form-group"">
                                                <label ");
                WriteLiteral(@"for=""RamName"">Ram Name</label>
                                                <select id=""RamName"" class=""select2"" style=""width:300px"" tabindex=""1""></select>
                                                <span target=""RamName"" class=""error""></span>
                                            </div>

                                            <div class=""form-group"">
                                                <label for=""KeyboardName"">Keyboard Name</label>
                                                <select id=""KeyboardName"" class=""select2"" style=""width:300px"" tabindex=""1""></select>
                                                <span target=""KeyboardName"" class=""error""></span>
                                            </div>

                                            <div class=""form-group"">
                                                <label for=""MouseName"">Mouse Name</label>
                                                <select id=""MouseName"" class=""select2"" style=""width:");
                WriteLiteral(@"300px"" tabindex=""1""></select>
                                                <span target=""MouseName"" class=""error""></span>
                                            </div>

                                            <div class=""form-group"">
                                                <label for=""Monitor"">Monitor Name</label>
                                                <select id=""Monitor"" class=""select2"" style=""width:300px"" tabindex=""1""></select>
                                                <span target=""Monitor"" class=""error""></span>
                                            </div>

                                            <div class=""form-group"">
                                                <label for=""MonitorSize"">Monitor Size Name</label>
                                                <select id=""MonitorSize"" class=""select2"" style=""width:300px"" tabindex=""1""></select>
                                                <span target=""MonitorSize"" class=""error""></span>
    ");
                WriteLiteral(@"                                        </div>

                                            <div class=""form-group"">
                                                <label for=""OpticalDisc"">Optical disc Name</label>
                                                <select id=""OpticalDisc"" class=""select2"" style=""width:300px"" tabindex=""1""></select>
                                                <span target=""OpticalDisc"" class=""error""></span>
                                            </div>

                                            <div class=""form-group"">
                                                <label for=""Speed"">Speed</label>
                                                <select id=""Speed"" class=""select2"" style=""width:300px"" tabindex=""1""></select>
                                                <span target=""Speed"" class=""error""></span>
                                            </div>

                                            <div class=""form-group"">
                        ");
                WriteLiteral(@"                        <label for=""Storage"">Storage Name</label>
                                                <select id=""Storage"" class=""select2"" style=""width:300px"" tabindex=""1""></select>
                                                <span target=""Storage"" class=""error""></span>
                                            </div>

                                            <div class=""form-group"">
                                                <label for=""StorageCapacity"">Storage Capacity Name</label>
                                                <select id=""StorageCapacity"" class=""select2"" style=""width:300px"" tabindex=""1""></select>
                                                <span target=""StorageCapacity"" class=""error""></span>
                                            </div>

                                            <div class=""form-group"">
                                                <label for=""Status"">
                                                    Computer Status
");
                WriteLiteral("                                                </label>\r\n                                                <select id=\"Status\" name=\"Status\" class=\"js-example-basic-single\" tabindex=\"2\">\r\n                                                    ");
                EndContext();
                BeginContext(6261, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0ebbd6652e2bd8adca312bb5820b5fb5856803712740", async() => {
                    BeginContext(6279, 6, true);
                    WriteLiteral("Active");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6294, 54, true);
                WriteLiteral("\r\n                                                    ");
                EndContext();
                BeginContext(6348, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0ebbd6652e2bd8adca312bb5820b5fb5856803714258", async() => {
                    BeginContext(6366, 8, true);
                    WriteLiteral("Deactive");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6383, 972, true);
                WriteLiteral(@"
                                                </select>
                                                <span target=""Status"" class=""error""></span>
                                            </div>
                                            <span target=""ErrorMessage"" class=""error""></span>
                                            <div class=""form-group"">
                                                <button id=""submit-btn"" type=""submit"" class=""btn btn-primary btn-block "" tabindex=""3"">
                                                    Submit
                                                </button>
                                                <button id=""cancel-btn"" on=""cancel()"" class=""btn btn-primary btn-block"" tabindex=""4"">
                                                    Cancel
                                                </button>
                                            </div>
                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7362, 270, true);
            WriteLiteral(@"
                                    </div>
                                </div>

                            </div>
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
                BeginContext(7649, 94, true);
                WriteLiteral("\r\n    <script>\r\n    $(document).ready(function () {\r\n        // Retrive data from datasource\r\n");
                EndContext();
                BeginContext(8299, 601, true);
                WriteLiteral(@"
        masterData.GetCpuSelect2Data(""CpuName"");
        masterData.GetRamSelect2Data(""RamName"");
        masterData.GetKeyboardSelect2Data(""KeyboardName"");
        masterData.GetMouseSelect2Data(""MouseName"");
        masterData.GetMonitorSelect2Data(""Monitor"");
        masterData.GetMonitorSizeSelect2Data(""MonitorSize"");
        masterData.GetSpeedSelect2Data(""Speed"");
        masterData.GetOpticalDiscSelect2Data(""OpticalDisc"");
        masterData.GetStorageSelect2Data(""Storage"");
        masterData.GetStorageCapacitySelect2Data(""StorageCapacity"");
        $(""#Status"").select2();
");
                EndContext();
                BeginContext(10371, 204, true);
                WriteLiteral("\r\n\r\n        $(\"#submit-btn\").click(function (event) {\r\n            event.preventDefault();\r\n            var dataModel = {\r\n                Name: $(\"#ComputerName\").val(),\r\n                ComputerRoomId: ");
                EndContext();
                BeginContext(10576, 14, false);
#line 187 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\Computer\Add.cshtml"
                           Write(computerRoomId);

#line default
#line hidden
                EndContext();
                BeginContext(10590, 760, true);
                WriteLiteral(@",
                StorageDeviceId: $(""#Storage"").select2('val'),
                StorageCapacityId: $(""#StorageCapacity"").select2('val'),
                CpuId: $(""#CpuName"").select2('val'),
                RamId: $(""#RamName"").select2('val'),
                SpeedId: $(""#Speed"").select2('val'),
                MonitorId: $(""#Monitor"").select2('val'),
                MonitorSizeId: $(""#MonitorSize"").select2('val'),
                MouseId: $(""#MouseName"").select2('val'),
                KeyboardId: $(""#KeyboardName"").select2('val'),
                OpticalDiscId: $(""#OpticalDisc"").select2('val'),
                Status: $(""#Status"").val()
            };
            
            validateInput
            $.ajax({
                url: '");
                EndContext();
                BeginContext(11351, 29, false);
#line 203 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\Computer\Add.cshtml"
                 Write(Url.Action("Add", "Computer"));

#line default
#line hidden
                EndContext();
                BeginContext(11380, 478, true);
                WriteLiteral(@"',
                data: dataModel,
                type: 'POST',
                success: function (respone) {
                    if (respone.errorCode != 0) {
                        $('span[target=""ErrorMessage""]').text(respone.errorMessage);
                    } else {
                        $('span[target=""ErrorMessage""]').text(""Add Computer successfully"");
                        setTimeout(function () {
                            window.location.href = '");
                EndContext();
                BeginContext(11859, 131, false);
#line 212 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\Computer\Add.cshtml"
                                               Write(Html.Raw(@Url.Action("GetPagingByComputerId", "Computer", new { PAGE_SIZE = 10, PAGE_INDEX = 1,  computerRoomId = computerRoomId})));

#line default
#line hidden
                EndContext();
                BeginContext(11990, 780, true);
                WriteLiteral(@"';
                        }, 1000)
                    }
                },
                error: function (error) {
                    console.log(error);
                },
                complete: function () {

                }
            });
        });

        $(""#cancel-btn"").click(function (event) {
            event.preventDefault();
            $.confirm({
                title: 'Are you want to cancel?',
                useBootstrap: false,
                theme: 'material',
                type: 'red',
                boxWidth: '500px',
                buttons: {
                    confirm: {
                        text: 'Yes',
                        action: function () {
                            window.location.href = '");
                EndContext();
                BeginContext(12771, 131, false);
#line 237 "C:\Users\Asus\Desktop\Projects\ComputerRoomManagementUTC\ComputerRoomManagementUTC\Views\Computer\Add.cshtml"
                                               Write(Html.Raw(@Url.Action("GetPagingByComputerId", "Computer", new { PAGE_SIZE = 10, PAGE_INDEX = 1, computerRoomId = computerRoomId })));

#line default
#line hidden
                EndContext();
                BeginContext(12902, 3707, true);
                WriteLiteral(@"';
                        }
                    },
                    cancel: {
                        text: 'No',
                        keys: ['esc'],
                        action: function () {
                        }
                    },
                }
            });
        })
    });

    function validateInput() {
        var Name = $(""#ComputerName"").val();
        var StorageDeviceId= $(""#Storage"").select2('val');
        var StorageCapacityId = $(""#StorageCapacity"").select2('val');
        var CpuId = $(""#CpuName"").select2('val');
        var RamId = $(""#RamName"").select2('val');
        var SpeedId = $(""#Speed"").select2('val');
        var MonitorId = $(""#Monitor"").select2('val');
        var MonitorSizeId = $(""#MonitorSize"").select2('val');
        var MouseId = $(""#MouseName"").select2('val');
        var KeyboardId = $(""#KeyboardName"").select2('val');
        var OpticalDiscId = $(""#OpticalDisc"").select2('val');
        if (Name == '' || Name == null) {
  ");
                WriteLiteral(@"          $('span[target=""ComputerName""]').text('Computer Name is required');
            return false;
        } else {
            $('span[target=""ComputerName""]').text('');
        };

        if (StorageDeviceId == '' || StorageDeviceId == null) {
            $('span[target=""Storage""]').text('Storage is required');
            return false;
        }else {
            $('span[target=""Storage""]').text('');
        };
        console.log(StorageCapacityId == '');
        if (StorageCapacityId == '' || StorageCapacityId == null) {
            $('span[target=""StorageCapacity""]').text('Storage Capacity is required');
            return false;
        }else {
            $('span[target=""StorageCapacitys""]').text('');
        };
        if (CpuId == '' || CpuId == null) {
            $('span[target=""CpuName""]').text('Cpu Name is required');
            return false;
        }else {
            $('span[target=""CpuName""]').text('');
        };
        if (RamId == '' || RamId == null) {
 ");
                WriteLiteral(@"           $('span[target=""RamName""]').text('Ram Name is required');
            return false;
        }else {
            $('span[target=""RamName""]').text('');
        };
        if (SpeedId == '' || SpeedId == null) {
            $('span[target=""Speed""]').text('Speed is required');
            return false;
        }else {
            $('span[target=""Speed""]').text('');
        };
        if (MonitorId == '' || MonitorId == null) {
            $('span[target=""Monitor""]').text('Monitor is required');
            return false;
        }else {
            $('span[target=""Monitor""]').text('');
        };
        if (MonitorSizeId == '' || MonitorSizeId == null) {
            $('span[target=""MonitorSize""]').text('Monitor Size is required');
            return false;
        }else {
            $('span[target=""MonitorSize""]').text('');
        };
        if (MouseId == '' || MouseId == null) {
            $('span[target=""MouseName""]').text('Mouse Name is required');
            return fal");
                WriteLiteral(@"se;
        }else {
            $('span[target=""MouseName""]').text('');
        };
        if (KeyboardId == '' || KeyboardId == null) {
            $('span[target=""KeyboardName""]').text('Keyboard Name is required');
            return false;
        }else {
            $('span[target=""KeyboardName""]').text('');
        };
        if (OpticalDiscId == '' || OpticalDiscId == null) {
            $('span[target=""OpticalDisc""]').text('OpticalDisc is required');
            return false;
        }else {
            $('span[target=""OpticalDisc""]').text('');
        };
        return true;
    }



    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
