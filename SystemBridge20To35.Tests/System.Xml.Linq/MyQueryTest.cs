using System.Linq;
using System.Xml.Linq;
using NUnit.Framework;

namespace MonoTests.System.Xml.Linq
{
	[TestFixture]
	public class MyQueryTest
	{
		[Test]
		public void Test1()
		{
			XDocument doc = new XDocument(
				new XDeclaration("1.0", "utf-8", "yes"),
				new XComment("Starbuzz Customer Loyalty Data"),
				new XElement("starbuzzData",
					new XAttribute("storeName", "Park Slope"),
					new XAttribute("location", "Brooklyn, NY"),
					new XElement("person",
						new XElement("personalInfo",
							new XElement("name", "Janet Venutian"),
							new XElement("zip", 11215)),
						new XElement("favoriteDrink", "Choco Macchiato"),
						new XElement("moneySpent", 255),
						new XElement("visits", 50)),
					new XElement("person",
						new XElement("personalInfo",
							new XElement("name", "Liz Nelson"),
							new XElement("zip", 11238)),
						new XElement("favoriteDrink", "Double Cappuccino"),
						new XElement("moneySpent", 150),
						new XElement("visits", 35)),
					new XElement("person",
						new XElement("personalInfo",
							new XElement("name", "Matt Franks"),
							new XElement("zip", 11217)),
						new XElement("favoriteDrink", "Zesty Lemon Chai"),
						new XElement("moneySpent", 75),
						new XElement("visits", 15)),
					new XElement("person",
						new XElement("personalInfo",
							new XElement("name", "Joe Ng"),
							new XElement("zip", 11217)),
						new XElement("favoriteDrink", "Banana Split in a Cup"),
						new XElement("moneySpent", 60),
						new XElement("visits", 10)),
					new XElement("person",
						new XElement("personalInfo",
							new XElement("name", "Sarah Kalter"),
							new XElement("zip", 11215)),
						new XElement("favoriteDrink", "Boring Coffee"),
						new XElement("moneySpent", 110),
						new XElement("visits", 15))));

			var data = from item in doc.Descendants("person")
				select new
					{
						drink = item.Element("favoriteDrink").Value,
						moneySpent = item.Element("moneySpent").Value,
						zipCode = item.Element("personalInfo").Element("zip").Value
					};
			Assert.AreEqual(5, data.Count());

			// Do a more complex query and print the results to the console
			var zipcodeGroups = from item in doc.Descendants("person")
			group item.Element("favoriteDrink").Value
				by item.Element("personalInfo").Element("zip").Value
			into zipcodeGroup
				select zipcodeGroup;
			Assert.AreEqual(3, zipcodeGroups.Count());
		}
	}
}