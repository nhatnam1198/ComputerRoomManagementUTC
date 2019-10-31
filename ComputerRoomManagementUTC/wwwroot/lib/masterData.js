var masterData = {
    GetRamSelect2Data: (ramId) => {
        $("#" + ramId).select2({
            dropdownParent: $("#add-form"),
            tags: true,
            allowClear: true,
            ajax: {
                url: '/Ram/GetAll',
                type: 'GET',
                cache: false,
                success: function (respone) {
                    console.log(respone)
                },
                data: function (params) {

                    var filterRules = [];

                    var filterRule = {
                        field: "JobCode",
                        op: "and_contains",
                        value: params.term
                    };

                    filterRules.push(filterRule);

                    var query = {
                        search: params.term,
                        filterRules: JSON.stringify(filterRules),
                        type: 'public',
                        page: params.page || 1,
                        rows: 10
                    };
                    // Query parameters will be ?search=[term]&type=public
                    return query;
                },
                processResults: function (data) {
                    var dataFormat = $.map(data.itemList, function (obj) {
                        obj.id = obj.pK_Id;
                        obj.text = obj.name;
                        return obj;
                    })
                    return {
                        results: dataFormat
                    };
                },
                
            }
        })
    },

    GetCpuSelect2Data: (cpuId) => {
        $("#" + cpuId).select2({
            dropdownParent: $("#add-form"),
            tags: true,
            allowClear: true,
            ajax: {
                url: '/Cpu/GetAll',
                type: 'GET',
                cache: false,
                success: function (respone) {
                    console.log(respone)
                },
                data: function (params) {

                    var filterRules = [];

                    var filterRule = {
                        field: "JobCode",
                        op: "and_contains",
                        value: params.term
                    };

                    filterRules.push(filterRule);

                    var query = {
                        search: params.term,
                        filterRules: JSON.stringify(filterRules),
                        type: 'public',
                        page: params.page || 1,
                        rows: 10
                    };
                    // Query parameters will be ?search=[term]&type=public
                    return query;
                },
                processResults: function (data) {
                    var dataFormat = $.map(data.itemList, function (obj) {
                        obj.id = obj.pK_Id;
                        obj.text = obj.name;
                        return obj;
                    })
                    return {
                        results: dataFormat
                    };
                },

            }
        })
    },

    GetKeyboardSelect2Data: (keyboardId) => {
        $("#" + keyboardId).select2({
            dropdownParent: $("#add-form"),
            tags: true,
            allowClear: true,
            ajax: {
                url: '/Keyboard/GetAll',
                type: 'GET',
                cache: false,
                success: function (respone) {
                    console.log(respone)
                },
                data: function (params) {

                    var filterRules = [];

                    var filterRule = {
                        field: "JobCode",
                        op: "and_contains",
                        value: params.term
                    };

                    filterRules.push(filterRule);

                    var query = {
                        search: params.term,
                        filterRules: JSON.stringify(filterRules),
                        type: 'public',
                        page: params.page || 1,
                        rows: 10
                    };
                    // Query parameters will be ?search=[term]&type=public
                    return query;
                },
                processResults: function (data) {
                    var dataFormat = $.map(data.itemList, function (obj) {
                        obj.id = obj.pK_Id;
                        obj.text = obj.name;
                        return obj;
                    })
                    return {
                        results: dataFormat
                    };
                },

            }
        })
    },

    GetMouseSelect2Data: (mouseId) => {
        $("#" + mouseId).select2({
            dropdownParent: $("#add-form"),
            tags: true,
            allowClear: true,
            ajax: {
                url: '/Mouse/GetAll',
                type: 'GET',
                cache: false,
                success: function (respone) {
                    console.log(respone)
                },
                data: function (params) {

                    var filterRules = [];

                    var filterRule = {
                        field: "JobCode",
                        op: "and_contains",
                        value: params.term
                    };

                    filterRules.push(filterRule);

                    var query = {
                        search: params.term,
                        filterRules: JSON.stringify(filterRules),
                        type: 'public',
                        page: params.page || 1,
                        rows: 10
                    };
                    // Query parameters will be ?search=[term]&type=public
                    return query;
                },
                processResults: function (data) {
                    var dataFormat = $.map(data.itemList, function (obj) {
                        obj.id = obj.pK_Id;
                        obj.text = obj.name;
                        return obj;
                    })
                    return {
                        results: dataFormat
                    };
                },

            }
        })
    },

    GetMonitorSelect2Data: (monitorId) => {
        $("#" + monitorId).select2({
            dropdownParent: $("#add-form"),
            tags: true,
            allowClear: true,
            ajax: {
                url: '/Monitor/GetAll',
                type: 'GET',
                cache: false,
                success: function (respone) {
                    console.log(respone)
                },
                data: function (params) {

                    var filterRules = [];

                    var filterRule = {
                        field: "JobCode",
                        op: "and_contains",
                        value: params.term
                    };

                    filterRules.push(filterRule);

                    var query = {
                        search: params.term,
                        filterRules: JSON.stringify(filterRules),
                        type: 'public',
                        page: params.page || 1,
                        rows: 10
                    };
                    // Query parameters will be ?search=[term]&type=public
                    return query;
                },
                processResults: function (data) {
                    var dataFormat = $.map(data.itemList, function (obj) {
                        obj.id = obj.pK_Id;
                        obj.text = obj.name;
                        return obj;
                    })
                    return {
                        results: dataFormat
                    };
                },

            }
        })
    },

    GetMonitorSizeSelect2Data: (monitorSizeId) => {
        $("#" + monitorSizeId).select2({
            dropdownParent: $("#add-form"),
            tags: true,
            allowClear: true,
            ajax: {
                url: '/MonitorSize/GetAll',
                type: 'GET',
                cache: false,
                success: function (respone) {
                    console.log(respone)
                },
                data: function (params) {

                    var filterRules = [];

                    var filterRule = {
                        field: "JobCode",
                        op: "and_contains",
                        value: params.term
                    };

                    filterRules.push(filterRule);

                    var query = {
                        search: params.term,
                        filterRules: JSON.stringify(filterRules),
                        type: 'public',
                        page: params.page || 1,
                        rows: 10
                    };
                    // Query parameters will be ?search=[term]&type=public
                    return query;
                },
                processResults: function (data) {
                    var dataFormat = $.map(data.itemList, function (obj) {
                        obj.id = obj.pK_Id;
                        obj.text = obj.name;
                        return obj;
                    })
                    return {
                        results: dataFormat
                    };
                },

            }
        })
    },

    GetSpeedSelect2Data: (speedId) => {
        $("#" + speedId).select2({
            dropdownParent: $("#add-form"),
            tags: true,
            allowClear: true,
            ajax: {
                url: '/Speed/GetAll',
                type: 'GET',
                cache: false,
                success: function (respone) {
                    console.log(respone)
                },
                data: function (params) {

                    var filterRules = [];

                    var filterRule = {
                        field: "JobCode",
                        op: "and_contains",
                        value: params.term
                    };

                    filterRules.push(filterRule);

                    var query = {
                        search: params.term,
                        filterRules: JSON.stringify(filterRules),
                        type: 'public',
                        page: params.page || 1,
                        rows: 10
                    };
                    // Query parameters will be ?search=[term]&type=public
                    return query;
                },
                processResults: function (data) {
                    var dataFormat = $.map(data.itemList, function (obj) {
                        obj.id = obj.pK_Id;
                        obj.text = obj.name;
                        return obj;
                    })
                    return {
                        results: dataFormat
                    };
                },

            }
        })
    },

    GetOpticalDiscSelect2Data: (opticalDiscId) => {
        $("#" + opticalDiscId).select2({
            dropdownParent: $("#add-form"),
            tags: true,
            allowClear: true,
            ajax: {
                url: '/OpticalDisc/GetAll',
                type: 'GET',
                cache: false,
                success: function (respone) {
                    console.log(respone)
                },
                data: function (params) {

                    var filterRules = [];

                    var filterRule = {
                        field: "JobCode",
                        op: "and_contains",
                        value: params.term
                    };

                    filterRules.push(filterRule);

                    var query = {
                        search: params.term,
                        filterRules: JSON.stringify(filterRules),
                        type: 'public',
                        page: params.page || 1,
                        rows: 10
                    };
                    // Query parameters will be ?search=[term]&type=public
                    return query;
                },
                processResults: function (data) {
                    var dataFormat = $.map(data.itemList, function (obj) {
                        obj.id = obj.pK_Id;
                        obj.text = obj.name;
                        return obj;
                    })
                    return {
                        results: dataFormat
                    };
                },

            }
        })
    },

    GetStorageSelect2Data: (storageId) => {
        $("#" + storageId).select2({
            dropdownParent: $("#add-form"),
            tags: true,
            allowClear: true,
            ajax: {
                url: '/StorageDevice/GetAll',
                type: 'GET',
                cache: false,
                success: function (respone) {
                    console.log(respone)
                },
                data: function (params) {

                    var filterRules = [];

                    var filterRule = {
                        field: "JobCode",
                        op: "and_contains",
                        value: params.term
                    };

                    filterRules.push(filterRule);

                    var query = {
                        search: params.term,
                        filterRules: JSON.stringify(filterRules),
                        type: 'public',
                        page: params.page || 1,
                        rows: 10
                    };
                    // Query parameters will be ?search=[term]&type=public
                    return query;
                },
                processResults: function (data) {
                    var dataFormat = $.map(data.itemList, function (obj) {
                        obj.id = obj.pK_Id;
                        obj.text = obj.name;
                        return obj;
                    })
                    return {
                        results: dataFormat
                    };
                },

            }
        })
    },

    GetStorageCapacitySelect2Data: (storageCapacityId) => {
        $("#" + storageCapacityId).select2({
            dropdownParent: $("#add-form"),
            tags: true,
            allowClear: true,
            ajax: {
                url: '/StorageCapacity/GetAll',
                type: 'GET',
                cache: false,
                success: function (respone) {
                    console.log(respone)
                },
                data: function (params) {

                    var filterRules = [];

                    var filterRule = {
                        field: "JobCode",
                        op: "and_contains",
                        value: params.term
                    };

                    filterRules.push(filterRule);

                    var query = {
                        search: params.term,
                        filterRules: JSON.stringify(filterRules),
                        type: 'public',
                        page: params.page || 1,
                        rows: 10
                    };
                    // Query parameters will be ?search=[term]&type=public
                    return query;
                },
                processResults: function (data) {
                    var dataFormat = $.map(data.itemList, function (obj) {
                        obj.id = obj.pK_Id;
                        obj.text = obj.name;
                        return obj;
                    })
                    return {
                        results: dataFormat
                    };
                },

            }
        })
    },
}