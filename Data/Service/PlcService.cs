using HslCommunication.Profinet.Siemens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MauiAppByAntDesign.Models.Dto;

namespace MauiAppByAntDesign.Data.Service
{
    public class PlcService
    {
        private int DBAddress = 201;
        private int offset = 12;
        private SiemensS7Net siemens = new SiemensS7Net(SiemensPLCS.S1200)
        {
            IpAddress = "172.168.11.237",
            Slot = 1,
            ConnectTimeOut = 1000,
            Port = 102
        };
        public void sendBarcodeItemCodeStatus(List<BarcodeInfoDto> barcodeInfos)
        {
            if (barcodeInfos == null || barcodeInfos.Count <= 0) return;

            Int16[] intArray = new Int16[32];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = 0;
            }

            foreach (BarcodeInfoDto barcode in barcodeInfos)
            {
                intArray[barcode.ItemPosition - 1] = 1;
            }
            string DbAdd = string.Format("DB{0}.{1}", DBAddress, offset);
            siemens.Write(DbAdd, intArray);
        }
    }
}
