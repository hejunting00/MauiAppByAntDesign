using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppByAntDesign.Data.Service
{
    public class NgTaskService
    {
        //private readonly PlcService plcService;
        //private readonly ModelContext modelContext;

        //public NgTaskService(ModelContext modelContext)
        //{
        //    //this.plcService = plcService ?? throw new ArgumentNullException(nameof(plcService));
        //    this.modelContext = modelContext ?? throw new ArgumentNullException(nameof(modelContext));
        //}

        //public Task<List<BarcodeInfoDto>> GetBarcodeInfos(string barcode)
        //{
        //    // 获取托盘结果
        //    List<NgResultDto> ngResultDtos = new ModelContext().Itemdetails
        //    .Where(a => a.Containerbarcode == barcode)
        //    .OrderBy(a => a.Itemposition)
        //    .Select(a => new NgResultDto(a.Itembarcode.ToString(), a.HcResult, "0" + a.StatusHc, "0" + a.Field2, "0" + a.Field3, "0" + a.StatusOcv1, "0" + a.StatusOcv2, "0" + a.Dcirng, a.Zoneid))
        //    .ToList();

        //    List<BarcodeInfoDto> barcodeInfoDtos = null;
        //    filteringFailedCellsByRegion(ngResultDtos, ref barcodeInfoDtos, barcode);
        //    //plcService.sendBarcodeItemCodeStatus(barcodeInfoDtos);
        //    return Task.FromResult(barcodeInfoDtos);
        //}

        //public Task<int> updateBarcodeInfo(List<BarcodeInfoDto> list)
        //{
        //    string barcode = list.FirstOrDefault().Barcode;
        //    string[] strings = list.Select(t => t.ItemPosition.ToString()).ToArray();

        //    // 查询数据库以获取匹配的 itemdetail 数据
        //    List<Itemdetail> itemDetails = modelContext.Itemdetails
        //        .Where(item => item.Containerbarcode == barcode && strings.Contains(item.Itemposition))
        //        .OrderBy(item => item.Itemposition)
        //        .ToList();

        //    // 根据 barcodeInfoDtos 更新 itemDetailsToUpdate
        //    foreach (Itemdetail itemDetail in itemDetails)
        //    {
        //        BarcodeInfoDto matchingDto = list.FirstOrDefault(dto => dto.Barcode == itemDetail.Containerbarcode && dto.ItemPosition == int.Parse(itemDetail.Itemposition));

        //        if (matchingDto != null)
        //        {
        //            // 更新 itemDetail 数据
        //            // 例如，如果有其他属性需要更新，也在这里进行更新
        //            // itemDetail.SomeProperty = matchingDto.SomeProperty;

        //            // 保存更改
        //            itemDetail.Itembarcode = matchingDto.Itemcode;
        //            modelContext.Database.ExecuteSqlRaw("update itemdetail t set t.itembarcode=" + matchingDto.Itemcode + " where t.containerbarcode=" + itemDetail.Containerbarcode + " and t.itemposition=" + itemDetail.Itemposition + "");

        //            modelContext.SaveChanges();
        //        }
        //    }
        //    int v = 1;
        //    return Task.FromResult(v);
        //}

        //private void filteringFailedCellsByRegion(List<NgResultDto> ngResultDtos, ref List<BarcodeInfoDto> barcodeInfoDtos, string barcode)
        //{
        //    if (ngResultDtos == null || ngResultDtos.Count == 0)
        //    {
        //        return;
        //    }
        //    barcodeInfoDtos = new List<BarcodeInfoDto>();
        //    string zoneId = ngResultDtos.FirstOrDefault().zoneCode;
        //    DataModels.Zone zone = modelContext.Zone.Where(t => t.Zoneid == zoneId).FirstOrDefault();
        //    string propertyName = "";
        //    switch (zone.Code)
        //    {
        //        case "F": propertyName = "statusHc"; break;
        //        case "J": propertyName = "field2"; break;
        //        case "P": propertyName = "field3"; break;
        //    }
        //    if (string.IsNullOrEmpty(propertyName)) return;
        //    var property = typeof(NgResultDto).GetProperty(propertyName);
        //    for (int i = 0; i < ngResultDtos.Count; i++)
        //    {
        //        string ngResult = property.GetValue(ngResultDtos[i]).ToString();
        //        BarcodeInfoDto barcodeInfo = new(barcode, ngResultDtos[i].itemBarcode, i + 1, int.Parse(ngResult));
        //        barcodeInfoDtos.Add(barcodeInfo);
        //    }
        //}
    }
}
