using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organitzador
{
    class JSONTools
    {

        public static Llibre ReadJSON(string ruta)
        {
            using (StreamReader r = new StreamReader(ruta))
            {
                string json = r.ReadToEnd();
                Llibre llibre = JsonConvert.DeserializeObject<Llibre>(json);
                return llibre;
            }
        }

        public static bool WriteJSON(string ruta, Llibre llibre)
        {
            using (StreamWriter file = File.CreateText(ruta))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, llibre);
                return true;
            }
        }

    }
}
