using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ShriDzXslt {
    public class Queries01 {
        public static IEnumerable<XElement> PersonsWithPhone(string xmlFile) {
            XElement root = XElement.Load(xmlFile);

            IEnumerable<XElement> persons =  
                from person in root.Elements("person")
                where person.Descendants(XName.Get("phone")).Count() >= 1
                select person;
 
            return persons;
        }
    }
}
