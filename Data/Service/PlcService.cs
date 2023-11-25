using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppByAntDesign.Data.Service
{
    public class PlcService
    {
        //private int DBAddress = 201;
        //private int StartDBAddress = 12;
        //private SiemensS7Net siemens = new SiemensS7Net(SiemensPLCS.S1200)
        //{
        //    IpAddress = "172.168.11.***",
        //    Slot = 1,
        //    ConnectTimeOut = 1000,
        //    Port = 102
        //};
        //public void sendBarcodeItemCodeStatus(List<BarcodeInfoDto> barcodeInfos)
        //{
        //    if (barcodeInfos == null || barcodeInfos.Count <= 0) return;

        //    byte[] bytes = new byte[32];

        //    List<int> ngStatus = barcodeInfos.OrderBy(item => item.ItemPosition).Select(t => t.NgStatus1).ToList();

        //    for (int i = 0; i < ngStatus.Count; i++)
        //    {
        //        bytes[i] = (byte)ngStatus[i];
        //    }

        //    string DbAdd = string.Format("DB{0}.{1}", DBAddress, StartDBAddress);
        //    siemens.Write(DbAdd, bytes);
        //}
    }
}
