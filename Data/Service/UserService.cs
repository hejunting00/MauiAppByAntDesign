using MauiAppByAntDesign.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppByAntDesign.Data.Service
{
    internal class UserService
    {
        private readonly ModelContext modelContext;

        public UserService(ModelContext modelContext)
        {
            this.modelContext = modelContext;
        }

        public string Login(string username, string password)
        {
            StaticMap.zoneMap.Clear();
            StaticMap.zoneMap = modelContext.Zones.ToDictionary(t => t.Zoneid, t => t.Code);
            LmepSystemUser lmepSystemUser = modelContext.LmepSystemUsers.FirstOrDefault(t => t.Userid == username && t.Userpswd == password);
            if (lmepSystemUser != null)
            {
                StaticMap.userName = lmepSystemUser.Username;
                return lmepSystemUser.Username;
            }
            return "";
        }
    }
}
