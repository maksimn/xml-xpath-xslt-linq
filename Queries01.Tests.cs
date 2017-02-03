using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using NUnit.Framework;

using ShriDzXslt;

[TestFixture]
class Queries01xml {
    [Test]
    public void Query01_PersonsWithPhone() {
        var xmlFilePath = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\01.xml";

        var persons = Queries01.PersonsWithPhone(xmlFilePath);
        
        var num = persons.Count();
        
        Assert.AreEqual(3, num);
    }
}
