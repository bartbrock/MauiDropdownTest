using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MauiDropdownTest.Data.DDData;

namespace MauiDropdownTest.Data
{
    public class DDData
    {
        public string? No { get; set; }

        public string? Transfer_from_Code { get; set; }
        public string? Transfer_to_Code { get; set; }

        public IList<DDData> Data { get; set; }
    }

    public class DData
    { 
       

        //public DData()
        //{
        //    var dddata = new DDData();
        //    //Data = new();
        //    for (int i = 0; i < 9; i++)
        //    {
        //        dddata.No = $"{i}";
        //        dddata.Transfer_from_Code = $"Transfer_From_{i}";
        //        dddata.Transfer_to_Code = $"Transfer_To_{i}";
        //        Data.Add(dddata);
        //    }
        //}

    }
}
