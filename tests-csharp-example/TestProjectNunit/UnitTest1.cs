using NUnit.Framework;
using System;
using Test.Project.Library;


namespace Test.Project.Library
{
    [TestFixture]
    public class Citizen_Test
    {
        /*Data*/
        Citizen Willy = new Citizen()
        {
            Name = "Willy",
            LastName = "Ovalle",
            Document_Number = "00100101010",
            BirthDate = new DateTime(1990, 01, 01),
            Sex = 'M'
        };

        ////[SetUp]
        ////public void Setup()
        ////{
        ////    Citizen_Creation();
        ////}

        [Test]
        public void Citizen_Creation()
        {
            Assert.IsTrue(Willy.Id == Guid.Empty);
            Assert.IsTrue(Willy.Save());
            Assert.AreEqual(Willy.Name, "Willy");
            Assert.AreEqual(Willy.LastName, "Ovalle");
            Assert.AreEqual(Willy.Sex, (char)Citizen.SexType.Male);
            Assert.AreEqual(Willy.BirthDate, new DateTime(1990, 01, 01));
            Assert.AreEqual(Willy.Document_Number, "00100101010");
            Assert.IsTrue(Willy.Id != Guid.Empty);
            Assert.Pass();
        }
    }
}