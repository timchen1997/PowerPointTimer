using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PowerPointTimer
{
    public class Setting
    {
        public int CountdownLen { set; get; }
        public int DefaultLocation { set; get; }
        public ObservableCollection<Presentation> PresentationList { set; get; }

        public Setting()
        {
            CountdownLen = 300;
            DefaultLocation = 1;
            PresentationList = new ObservableCollection<Presentation>();
        }

        public void Save()
        {
            using (FileStream fs = new FileStream("config.xml", FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(Helper.XmlSerialize(this));
                }
            }
        }

        public int GetLength(string filepath)
        {
            var t = from presentation in PresentationList
                where presentation.Path == filepath
                select presentation.Length();
            if (!t.Any())
                return CountdownLen;
            return t.First();
        }

        public bool PresentationExist(string filepath)
        {
            return (from p in PresentationList
                    where p.Path == filepath
                    select p).Count() != 0;
        }
    }
}
