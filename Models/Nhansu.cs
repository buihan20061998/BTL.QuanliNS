using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace BTL.QuanliNS.Models
{
    public class Nhansu
    {
        [Key]
        public string MaNS { Get; Set; }
        public string HoTen { Get; Set; }
        public string Gioitinh { Get; Set; }
        public string Quequan { Get; Set; }
        public string Email { Get; Set; }
        public string Sodienthoai { Get; Set; }

    }
}