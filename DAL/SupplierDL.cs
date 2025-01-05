using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class SupplierDL
    {
        private static SupplierDL Instance;
        public static SupplierDL GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new SupplierDL();
                }
                return Instance;
            }
        }


        #region Lấy Danh sach NCC
        public DataTable GetDanhSachNhaCungCap()
        {
            try
            {
                string sql = @"
                SELECT TOP (1000) [SupplierID]
                      ,[ContactName]
                      ,[ImgSupplier]
                      ,[Phone]
                      ,[Email]
                      ,[Address]
                      ,[CreatedAt]
                        ,[check_Remove]
                  FROM [WatchStoreC#].[dbo].[Supplier]";

                DataTable dt = new DataTable();
                dt = DataProvider.GetTable(sql);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu: " + ex.Message);
                return null;
            }
        }
        #endregion


    }
}
