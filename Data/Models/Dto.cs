using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NTI_NG_MAUI.Models
{
    public class Dto
    {
        public class BarcodeInfoDto
        {

            string barcode, itemcode, tId, NgStatus,ngCode;
            int itemPosition;

            public BarcodeInfoDto(string barcode, string itemcode, int itemPosition, string ngStatus,string tId,string ngCode)
            {
                this.barcode = barcode;
                this.itemcode = itemcode;
                this.itemPosition = itemPosition;
                NgStatus = ngStatus;
                ngCode = ngCode;
                this.tId = tId;
            }

            public string Barcode { get => barcode; set => barcode = value; }
            public string Itemcode { get => itemcode; set => itemcode = value; }
            public int ItemPosition { get => itemPosition; set => itemPosition = value; }
            public string NgStatus1 { get => NgStatus; set => NgStatus = value; }
            public string TID { get => tId; set => tId = value; }
            public string NgCode { get => NgCode; set => ngCode = value; }
        }
        public record NgResultDto(string itemBarcode, string hcResult, string statusHc, string field2, string field3, string status_ocv1, string status_ocv2, string dciRng, string zoneCode,string tId);
        public record NgBarcodePosition(string barcode, string position);
    }
}
