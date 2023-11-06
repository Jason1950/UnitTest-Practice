using System.Reflection.Metadata;
using Microsoft.VisualBasic;
using NUnit.Framework;

namespace TestProject1;

[TestFixture]
public class TennisTest
{
       [Test]
       public void Lova_All()
       {
              var tennis = new Tennis();
              Assert.AreEqual("Love All", tennis.Score());
       }
}

public class Tennis
{
       
}

