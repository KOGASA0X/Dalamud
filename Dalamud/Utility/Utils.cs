using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Serilog;

namespace Dalamud.Utility
{
    public class DeviceUtils
    {
        private static Lazy<string> deviceId = new(() => string.Join(":", GetMacAddress(), GetCPUId(), GetDiskSerialNumber()));

        public static string GetDeviceId()
        {
            return deviceId.Value;
        }

        public static string GetMD5(byte[] payload)
        {
            var check = MD5.Create();
            var md5Bytes = check.ComputeHash(payload);
            return BitConverter.ToString(md5Bytes).Replace("-", string.Empty).ToUpper();
        }

        private static string GetCPUId()
        {
            var result = String.Empty;
            return result;
        }

        public static string GetMacAddress()
        {
            var result = String.Empty;
            return result;
        }

        public static string GetMac()
        {
            var result = String.Empty;
            return result;
        }

        private static string GetDiskSerialNumber()
        {
            var result = String.Empty;
            return result;
        }
    }
}
