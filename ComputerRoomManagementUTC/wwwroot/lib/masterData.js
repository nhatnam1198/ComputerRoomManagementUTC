var masterData = {

    GetComputerSelect2Data: (computerId) => {
        $.ajax({
            url: '/Computer/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });



                $("#" + computerId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },


    GetRamSelect2Data: (ramId) => {
        $.ajax({
            url: '/Ram/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + ramId).select2({
                    placeholder: "Select a Review",
                    data: data,
                    allowClear: true
                });
            }
        });
    },
    
    GetCpuSelect2Data: (cpuId) => {
        $.ajax({
            url: '/Cpu/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + cpuId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetKeyboardSelect2Data: (keyboardId) => {
        $.ajax({
            url: '/Keyboard/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + keyboardId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetMouseSelect2Data: (mouseId) => {
        $.ajax({
            url: '/Mouse/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + mouseId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetMonitorSelect2Data: (monitorId) => {
        $.ajax({
            url: '/Monitor/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + monitorId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetMonitorSizeSelect2Data: (monitorSizeId) => {
        $.ajax({
            url: '/MonitorSize/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + monitorSizeId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetSpeedSelect2Data: (speedId) => {
        $.ajax({
            url: '/Speed/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + speedId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetOpticalDiscSelect2Data: (opticalDiscId) => {
        $.ajax({
            url: '/OpticalDisc/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });


                $("#" + opticalDiscId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetStorageSelect2Data: (storageId) => {
        $.ajax({
            url: '/StorageDevice/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + storageId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },

    GetStorageCapacitySelect2Data: (storageCapacityId) => {
        $.ajax({
            url: '/StorageCapacity/GetAll',
            success: function (respone) {
                var data = $.map(respone.itemList, function (obj) {
                    obj.id = obj.pK_Id;
                    obj.text = obj.name;
                    return obj;
                });

                

                $("#" + storageCapacityId).select2({
                    placeholder: "Select a Review",
                    data: data
                });
            }
        });
    },
}