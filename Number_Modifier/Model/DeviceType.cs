using System;
using System.Collections.Generic;

namespace Number_Modifier.Model
{
    public partial class DeviceType
    {
        public int Id { get; set; }
        public string DeviceName { get; set; } = null!;
        public string? Description { get; set; }
        public string? Specs { get; set; }
        public int DeviceCount { get; set; }
        public DateTime Created { get; set; }
        public int DeviceCategoryId { get; set; }
        public int ScoreMin { get; set; }
        public int ScoreMax { get; set; }
        public DateTime Modified { get; set; }
        public string MainPhoto { get; set; } = null!;
        public string PhotoGallery { get; set; } = null!;
        public string DeviceRam { get; set; } = null!;
        public string ScreenSize { get; set; } = null!;
        public string Storage { get; set; } = null!;
        public string Battery { get; set; } = null!;
        public string? OsUi { get; set; }
        public string? Sim { get; set; }
        public string? Weight { get; set; }
        public string? Dimension { get; set; }
        public string? Netw { get; set; }
        public string? Display { get; set; }
        public string? Camera { get; set; }
        public string? Chipset { get; set; }
        public string? Usb { get; set; }
        public string? Bluetooth { get; set; }
        public string? Wlan { get; set; }
        public string? Sensors { get; set; }
        public float FullPriceNaira { get; set; }
        public bool IsActive { get; set; }
    }
}
