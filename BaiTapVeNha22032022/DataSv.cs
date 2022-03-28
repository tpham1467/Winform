using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap22032022
{
    public class DataSv
    {
        
        public DataTable Sv
        {
            get;
            set;
        }

        public DataSv(String s)
        {
            Sv = new DataTable( );
            Sv.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn { DataType =typeof(int) , ColumnName = "Ma Sinh Vien"},
                new DataColumn { DataType =typeof(string) , ColumnName = "Ho Va Ten"},
                new DataColumn { DataType =typeof(string) , ColumnName = "Lop Sinh Hoat"},
                new DataColumn { DataType =typeof(bool) , ColumnName = "Gioi Tinh"},
                new DataColumn { DataType =typeof(DateTime) , ColumnName = "Ngay Sinh"},
                new DataColumn { DataType =typeof(float) , ColumnName = "Diem Trung Binh"},
                new DataColumn { DataType =typeof(HoSo) , ColumnName = "Ho So"}
                });
            
            Sv.Rows.Add(
                 102200998, "Pham Van Tien Truong", s ,true, new DateTime(2002, 11, 18), 3.4, new HoSo
                 { Anh = true, Cc_nn = false, hoc_ba = true }
                );
            Sv.Rows.Add(
                 102200999, "Pham Cong Huy", s, false, new DateTime(2002, 11, 18), 3.4, new HoSo
                 { Anh = true, Cc_nn = true, hoc_ba = true }
                );
            Sv.Rows.Add(
                 102200200, "Tran Van Hai", s, true, new DateTime(2002, 11, 18), 3.4, new HoSo
                 { Anh = true, Cc_nn = false, hoc_ba = true }
                );
            Sv.Rows.Add(
                 102200201, "Nguyen Hoang Vu", s, false, new DateTime(2002, 11, 18), 3.4, new HoSo
                 { Anh = true, Cc_nn = true, hoc_ba = true }
                );
            Sv.Rows.Add(
                 102200202, "Nguyen Hoang Phong ", s, true, new DateTime(2002, 11, 18), 3.4, new HoSo
                 { Anh = true, Cc_nn = false, hoc_ba = true }
                );

        }
        
    }
    public class DataClass
    {
        public List<DataSv> ListClass
        {
            get; set;
        }
        public DataClass()
        {
            ListClass = new List<DataSv>();
            for(int i=0;i<10;i++)
            {
                ListClass.Add(new DataSv("20TCLC_DT" + i.ToString()));
            }
        }
    }
    
}
