using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Common
{
    public static class ApiUrlPath
    {
        // RAM
        public const string RAM_EDIT = "api/Ram/Edit";
        public const string RAM_GET_PAGING = "api/Ram/GetPaging";
        public const string RAM_ADD = "api/Ram/Add";
        public const string RAM_GET_BY_ID = "api/Ram/GetById/{0}";
        public const string RAM_DELETE = "api/Ram/Delete";
        public const string RAM_EDIT_STATUS = "api/Ram/EditStatus";
        public const string RAM_GET_ALL = "api/Ram/GetAll";

        // CPU
        public const string CPU_EDIT = "api/CPU/Edit";
        public const string CPU_GET_PAGING = "api/CPU/GetPaging";
        public const string CPU_ADD = "api/CPU/Add";
        public const string CPU_GET_BY_ID = "api/CPU/GetById/{0}";
        public const string CPU_DELETE = "api/CPU/Delete";
        public const string CPU_EDIT_STATUS = "api/CPU/EditStatus";
        public const string CPU_GET_ALL = "api/CPU/GetAll";

        // Monitor
        public const string MONITOR_EDIT = "api/Monitor/Edit";
        public const string MONITOR_GET_PAGING = "api/Monitor/GetPaging";
        public const string MONITOR_ADD = "api/Monitor/Add";
        public const string MONITOR_GET_BY_ID = "api/Monitor/GetById/{0}";
        public const string MONITOR_DELETE = "api/Monitor/Delete";
        public const string MONITOR_EDIT_STATUS = "api/Monitor/EditStatus";
        public const string MONITOR_GET_ALL = "api/Monitor/GetAll";

        // Monitor size
        public const string MONITOR_SIZE_EDIT = "api/MonitorSize/Edit";
        public const string MONITOR_SIZE_GET_PAGING = "api/MonitorSize/GetPaging";
        public const string MONITOR_SIZE_ADD = "api/MonitorSize/Add";
        public const string MONITOR_SIZE_GET_BY_ID = "api/MonitorSize/GetById/{0}";
        public const string MONITOR_SIZE_DELETE = "api/MonitorSize/Delete";
        public const string MONITOR_SIZE_EDIT_STATUS = "api/MonitorSize/EditStatus";
        public const string MONITOR_SIZE_GET_ALL = "api/MonitorSize/GetAll";
        

        // Speed
        public const string SPEED_EDIT = "api/Speed/Edit";
        public const string SPEED_GET_PAGING = "api/Speed/GetPaging";
        public const string SPEED_ADD = "api/Speed/Add";
        public const string SPEED_GET_BY_ID = "api/Speed/GetById/{0}";
        public const string SPEED_DELETE = "api/Speed/Delete";
        public const string SPEED_EDIT_STATUS = "api/Speed/EditStatus";
        public const string SPEED_GET_ALL = "api/Speed/GetAll";
        // Mouse
        public const string MOUSE_EDIT = "api/Mouse/Edit";
        public const string MOUSE_GET_PAGING = "api/Mouse/GetPaging";
        public const string MOUSE_ADD = "api/Mouse/Add";
        public const string MOUSE_GET_BY_ID = "api/Mouse/GetById/{0}";
        public const string MOUSE_DELETE = "api/Mouse/Delete";
        public const string MOUSE_EDIT_STATUS = "api/Mouse/EditStatus";
        public const string MOUSE_GET_ALL = "api/Mouse/GetAll";
        // Keyboard
        public const string KEYBOARD_EDIT = "api/Keyboard/Edit";
        public const string KEYBOARD_GET_PAGING = "api/Keyboard/GetPaging";
        public const string KEYBOARD_ADD = "api/Keyboard/Add";
        public const string KEYBOARD_GET_BY_ID = "api/Keyboard/GetById/{0}";
        public const string KEYBOARD_DELETE = "api/Keyboard/Delete";
        public const string KEYBOARD_EDIT_STATUS = "api/Keyboard/EditStatus";
        public const string KEYBOARD_GET_ALL = "api/Keyboard/GetAll";
        // Storage Device
        public const string STORAGE_DEVICE_EDIT = "api/StorageDevice/Edit";
        public const string STORAGE_DEVICE_GET_PAGING = "api/StorageDevice/GetPaging";
        public const string STORAGE_DEVICE_ADD = "api/StorageDevice/Add";
        public const string STORAGE_DEVICE_GET_BY_ID = "api/StorageDevice/GetById/{0}";
        public const string STORAGE_DEVICE_DELETE = "api/StorageDevice/Delete";
        public const string STORAGE_DEVICE_EDIT_STATUS = "api/StorageDevice/EditStatus";
        public const string STORAGE_DEVICE_GET_ALL = "api/StorageDevice/GetAll";
        // Storage Capacity
        public const string STORAGE_CAPACITY_EDIT = "api/StorageCapacity/Edit";
        public const string STORAGE_CAPACITY_GET_PAGING = "api/StorageCapacity/GetPaging";
        public const string STORAGE_CAPACITY_ADD = "api/StorageCapacity/Add";
        public const string STORAGE_CAPACITY_GET_BY_ID = "api/StorageCapacity/GetById/{0}";
        public const string STORAGE_CAPACITY_DELETE = "api/StorageCapacity/Delete";
        public const string STORAGE_CAPACITY_EDIT_STATUS = "api/StorageCapacity/EditStatus";
        public const string STORAGE_CAPACITY_GET_ALL = "api/StorageCapacity/GetAll";

        // Optical Disc
        public const string OPTICAL_DISC_EDIT = "api/OpticalDisc/Edit";
        public const string OPTICAL_DISC_GET_PAGING = "api/OpticalDisc/GetPaging";
        public const string OPTICAL_DISC_ADD = "api/OpticalDisc/Add";
        public const string OPTICAL_DISC_GET_BY_ID = "api/OpticalDisc/GetById/{0}";
        public const string OPTICAL_DISC_DELETE = "api/OpticalDisc/Delete";
        public const string OPTICAL_DISC_EDIT_STATUS = "api/OpticalDisc/EditStatus";
        public const string OPTICAL_DISC_GET_ALL = "api/OpticalDisc/GetAll";

        // Computer Room
        public const string COMPUTER_ROOM_EDIT = "api/ComputerRoom/Edit";
        public const string COMPUTER_ROOM_GET_PAGING = "api/ComputerRoom/GetPaging";
        public const string COMPUTER_ROOM_ADD = "api/ComputerRoom/Add";
        public const string COMPUTER_ROOM_GET_BY_ID = "api/ComputerRoom/GetById/{0}";
        public const string COMPUTER_ROOM_DELETE = "api/ComputerRoom/Delete";
        public const string COMPUTER_ROOM_EDIT_STATUS = "api/ComputerRoom/EditStatus";

        // Computer
        public const string COMPUTER_EDIT = "api/Computer/Edit";
        public const string COMPUTER_GET_PAGING_BY_ROOM_ID = "api/Computer/GetPagingByComputerId/{0}";
        public const string COMPUTER_ADD = "api/Computer/Add";
        public const string COMPUTER_GET_BY_ID = "api/Computer/GetById/{0}";
        public const string COMPUTER_DELETE = "api/Computer/Delete";
        public const string COMPUTER_EDIT_STATUS = "api/Computer/EditStatus";

        // Province
        public const string PROVINCE_EDIT = "api/Province/Edit";
        public const string PROVINCE_GET_PAGING_BY_ROOM_ID = "api/Province/GetPagingByComputerId/{0}";
        public const string PROVINCE_ADD = "api/Province/Add";
        public const string PROVINCE_GET_BY_ID = "api/Province/GetById/{0}";
        public const string PROVINCE_DELETE = "api/Province/Delete";
        public const string PROVINCE_EDIT_STATUS = "api/Province/EditStatus";
        public const string PROVINCE_GET_ALL = "api/Province/GetAll";
    }
}
