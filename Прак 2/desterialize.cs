using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Прак_2
{
    internal class desterialize
    {
        public static void MySerialize<T>(T zalupa)
        {
            string json = JsonConvert.SerializeObject(zalupa);
            File.WriteAllText("C:\\Users\\well\\OneDrive\\Рабочий стол", json);
        }
        public static T MyDeserialize<T>()
        {
            string json = File.ReadAllText("C:\\Users\\well\\OneDrive\\Рабочий стол");
            T zalupa = JsonConvert.DeserializeObject<T>(json);
            return zalupa;
        }
    }
}
