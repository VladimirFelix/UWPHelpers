using Windows.System.Profile;
using Windows.UI.ViewManagement;

namespace UWPHelpers.Helpers
{
    public static class DeviceFamilyHelper
    {
        public static DeviceFamilyType GetDeviceFamilyType()
        {
            switch (AnalyticsInfo.VersionInfo.DeviceFamily)
            {
                case "Windows.Mobile":
                    return DeviceFamilyType.Phone;
                case "Windows.Desktop":
                    return UIViewSettings.GetForCurrentView().UserInteractionMode == UserInteractionMode.Mouse ? DeviceFamilyType.Desktop : DeviceFamilyType.Tablet;
                case "Windows.Universal":
                    return DeviceFamilyType.IoT;
                case "Windows.Team":
                    return DeviceFamilyType.SurfaceHub;
                default:
                    return DeviceFamilyType.Other;
            }
        }
    }

    public enum DeviceFamilyType
    {
        Phone,
        Desktop,
        Tablet,
        IoT,
        SurfaceHub,
        Other
    }
}