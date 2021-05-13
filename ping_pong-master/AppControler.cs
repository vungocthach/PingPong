using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
namespace pong
{
    public class AppControler
    {
        private static string mac;
        public static string MAC
        {
            get
            {
                 if (mac == null)
                 {
                     mac= LayDiaChiMac();
                 }
                 return mac;
            }

        }
        private static string LayDiaChiMac()
        {
            string DanhSachMAC = "";
            NetworkInterface[] DanhSachCardMang = NetworkInterface.GetAllNetworkInterfaces();
            for (int i = 0; i < 1; i++)
            {
                PhysicalAddress DiaChiMAC = DanhSachCardMang[i].GetPhysicalAddress();

                byte[] ByteDiaChi = DiaChiMAC.GetAddressBytes();
                for (int j = 0; j < ByteDiaChi.Length; j++)
                {
                    DanhSachMAC += ByteDiaChi[j].ToString("X2");
                    if (j != ByteDiaChi.Length - 1)
                    {
                        DanhSachMAC += "-";
                    }
                }
            }
            return DanhSachMAC;
        }
        private static void LayThoiGian()
        {
            string time=DateTime.Now.ToString("dd/mm/yyyy");
        }
        
    }
}
