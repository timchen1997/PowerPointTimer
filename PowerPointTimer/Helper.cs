using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace PowerPointTimer
{
    class Helper
    {
        public static string Time2Str(int second)
        {
            int hour = second / 3600;
            int minute = second % 3600 / 60;
            second %= 60;
            return hour.ToString().PadLeft(2, '0') + ":"
                   + minute.ToString().PadLeft(2, '0') + ":"
                   + second.ToString().PadLeft(2, '0');
        }

        public static int GetScreenWidth()
        {
            return (int) SystemParameters.PrimaryScreenWidth;
        }

        public static Setting LoadSetting()
        {
            try
            {
                using (FileStream fs = new FileStream("config.xml", FileMode.OpenOrCreate))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        return XmlDeserialize(sr.ReadToEnd());
                    }
                }
            }
            catch
            {
                return new Setting();
            }
        }

        private static Setting XmlDeserialize(string XMLStr)
        {
            using (StringReader sr = new StringReader(XMLStr))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Setting));
                return (Setting) serializer.Deserialize(sr);
            }
        }

        public static string XmlSerialize<T>(T obj)
        {
            using (StringWriter sw = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(sw, obj);
                sw.Close();
                return sw.ToString();
            }
        }
    }
}
