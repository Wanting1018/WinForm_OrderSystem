using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0428期中
{
    internal class GlobalVar
    {

        public static string 訂購人資訊 = "";

        public static List<ArrayList> list訂購品項資料 = new List<ArrayList>();


        public static bool is外帶 = false;
        public static bool is買購物袋 = false;


        //public static string image_dir = @"D:\0428期中"; 
        public static string image_dir = @"D:\0428期中123";
        public static string strDBConnectionString = "";  // 這樣都可以用

        // 以下FormLogin 用到 
        public static bool is登入認證成功 = false;
        //public static int int權限 = 0;  //此處也可以用列舉
        //                              //一般會員:10000以上，特殊會員:5000-9999，店員:1000-4999，店長:100-999，系統管理員sys:10-99  
        public static string str使用者名稱 = "";

        ////   public static List<string> list熱飲品項 = new List<string>();

        //public static List<string> list熱飲品項 = new List<string>();
        //public static List<string> list冷飲品項 = new List<string>();
        //public static List<string> list蛋糕品項 = new List<string>();

        //public static List<int> list熱飲價格 = new List<int>();
        //public static List<int> list冷飲價格 = new List<int>();
        //public static List<int> list蛋糕價格 = new List<int>();




    }
}
