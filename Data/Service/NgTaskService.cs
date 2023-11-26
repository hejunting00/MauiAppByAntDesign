using MauiAppByAntDesign.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MauiAppByAntDesign.Models.Dto;

namespace MauiAppByAntDesign.Data.Service
{
    public class NgTaskService
    {
        private readonly PlcService plcService;
        private readonly ModelContext modelContext;

        public NgTaskService(ModelContext modelContext)
        {
            //this.plcService = plcService ?? throw new ArgumentNullException(nameof(plcService));
            this.modelContext = modelContext ?? throw new ArgumentNullException(nameof(modelContext));
        }

        public Task<List<BarcodeInfoDto>> GetBarcodeInfos(string barcode)
        {
            // 获取托盘结果
            List<NgResultDto> ngResultDtos = new ModelContext().Itemdetails
            .Where(a => a.Containerbarcode == barcode)
            .OrderBy(a => a.Itemposition)
            .Select(a => new NgResultDto(a.Itembarcode.ToString(), a.HcResult, "0" + a.StatusHc, "0" + a.Field2, "0" + a.Field3, "0" + a.StatusOcv1, "0" + a.StatusOcv2, "0" + a.Dcirng, a.Zoneid,a.TId))
            .ToList();

            List<BarcodeInfoDto> barcodeInfoDtos = null;
            filteringFailedCellsByRegion(ngResultDtos, ref barcodeInfoDtos, barcode);
            //plcService.sendBarcodeItemCodeStatus(barcodeInfoDtos);
            return Task.FromResult(barcodeInfoDtos);
        }

        public Task<int> updateBarcodeInfo(List<BarcodeInfoDto> list)
        {
            string barcode = list.FirstOrDefault()?.Barcode;

            if (barcode == null)
            {
                return Task.FromResult(0); // 或抛出异常、记录错误等。
            }
            try
            {
                List<string> ngTid = list.Select(t => t.TID).ToList();
                List<Itemdetail> itemdetails = modelContext.Itemdetails.Where(t => t.Containerbarcode.Equals(barcode)).ToList();

                foreach (string item in ngTid)
                {
                    Itemdetail itemdetail = itemdetails.FirstOrDefault(t => t.TId.Equals(item));
                    itemdetail.Itembarcode = list.FirstOrDefault(t => t.TID.Equals(item)).Itemcode;
                }
                //modelContext.Itemdetails.UpdateRange(barcodeInfoDtos);            
                return Task.FromResult(modelContext.SaveChangesAsync().Result);
            }
            catch (Exception ex)
            {
                return Task.FromResult(0);
            }
        }

        private void filteringFailedCellsByRegion(List<NgResultDto> ngResultDtos, ref List<BarcodeInfoDto> barcodeInfoDtos, string barcode)
        {
            if (ngResultDtos == null || ngResultDtos.Count == 0)
            {
                return;
            }
            barcodeInfoDtos = new List<BarcodeInfoDto>();
            string zoneId = ngResultDtos.FirstOrDefault().zoneCode;
            DataModels.Zone zone = modelContext.Zones.Where(t => t.Zoneid == zoneId).FirstOrDefault();
            string propertyName = "";
            switch (zone.Code)
            {
                case "F": propertyName = "statusHc"; break;
                case "J": propertyName = "field2"; break;
                case "P": propertyName = "field3"; break;
            }
            if (string.IsNullOrEmpty(propertyName)) return;
            var property = typeof(NgResultDto).GetProperty(propertyName);
            for (int i = 0; i < ngResultDtos.Count; i++)
            {
                string ngResult = property.GetValue(ngResultDtos[i]).ToString();
                // 托盘 电芯 结果 tid  代码
                BarcodeInfoDto barcodeInfo = new(barcode, ngResultDtos[i].itemBarcode, i + 1, ngResult, ngResultDtos[i].tId, ngResultDtos[i].hcResult);
                barcodeInfoDtos.Add(barcodeInfo);
            }
        }
    }
}
