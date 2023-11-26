using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppByAntDesign.Models
{
    public class LoginModel
    {
        private static LoginModel instance;
        private bool isLogin = false;
        private LoginModel() { }

        public bool IsLogin { get => isLogin; set => isLogin = value; }

        public static LoginModel Instance()
        {
            if (instance == null)
            {
                instance = new LoginModel();
            }
            return instance;
        }
    }
}
