using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap22032022
{
    class HoSo
    {
        public bool Anh
        {
            get; set;
        }
        public bool hoc_ba
        {
            get; set;
        }
        public bool Cc_nn
        {
            get; set;
        }
        public override string ToString()
        {
            return Anh.ToString() + " "+hoc_ba.ToString() + " "+Cc_nn.ToString();
        }
    }

}
