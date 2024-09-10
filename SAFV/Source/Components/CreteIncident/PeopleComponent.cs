using NUnit.Framework;
using OpenQA.Selenium;
using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace SAFV.Source.Components
{
    public class PeopleComponent : BaseComponent
    {
        // Elements
        public static IWebElement AddPerson => WaitAndFindElement(By.XPath("//*[@id=\"module-container\"]/div/div[1]/div/div[2]/a"));
        public static IWebElement FirstName => WaitAndFindElement(By.Id("FirstName"));
        public static IWebElement LastName => WaitAndFindElement(By.Id("LastName"));
        public static IWebElement MiddleName => WaitAndFindElement(By.Id("MiddleName"));
        public static IWebElement Alias => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[4]/div/span[1]"));
        public static IWebElement AliasDescription => WaitAndFindElement(By.Id("AliasDesc"));
        public static IWebElement Victim => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[6]/div/div[1]/span"));
        public static IWebElement Suspect => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[6]/div/div[2]/span"));
        public static IWebElement Witness => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[6]/div/div[3]/span"));
        public static IWebElement OtherNotInvolved => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[6]/div/div[4]/span"));
        public static IWebElement VictimWouldLikeToUsePseudonym => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[8]/div[1]/div/span[1]"));
        public static IWebElement EditRealName => WaitAndFindElement(By.XPath("//*[@id=\"displayoreditrealname\"]/div[2]/button"));
        public static IWebElement Confirm => WaitAndFindElement(By.XPath("//*[@id=\"warningForPrivateData\"]/div[2]/div[2]/button"));
        public static IWebElement VictimRealFirstName => WaitAndFindElement(By.Id("VictimRealFirstName"));
        public static IWebElement VictimRealLastName => WaitAndFindElement(By.Id("VictimRealLastName"));
        public static IWebElement VictimRealMiddleName => WaitAndFindElement(By.Id("VictimRealMiddleName"));
        public static IWebElement WasPresent => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[7]/div/span[1]"));
        public static IWebElement IsUnknownPerson => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[9]/div/span[1]"));
        public static IWebElement Race => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[10]/div/span[1]"));
        public static IList<IWebElement> LstRace => WaitAndFindElements(By.XPath("//*[@id=\"RaceId_listbox\"]/li"));
        public static IWebElement Sex => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[1]/div[11]/div/span[1]"));
        public static IList<IWebElement> LstSex => WaitAndFindElements(By.XPath("//*[@id=\"SexId_listbox\"]/li"));
        public static IWebElement DateOfBirth => WaitAndFindElement(By.Id("DateOfBirth"));
        public static IWebElement Age => WaitAndFindElement(By.Id("Age"));
        public static IWebElement Save => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[2]/div/div/button[1]"));
        public static IWebElement Cancel => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[2]/div/div/a"));

        // more info
        public static IWebElement Ethnicity => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[2]/div/span"));
        public static IWebElement EyeColor => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[3]/div/span"));
        public static IWebElement HairColor => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[4]/div/span"));
        public static IWebElement HeightFeet => WaitAndFindElement(By.Id("HeightFt"));
        public static IWebElement HeightInches => WaitAndFindElement(By.Id("HeightIn"));
        public static IWebElement Weight => WaitAndFindElement(By.Id("Weight"));
        public static IWebElement EnableSsnField => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[7]/div[2]/button"));
        public static IWebElement SsnField => WaitAndFindElement(By.Id("SSNAlias"));
        public static IWebElement SaveSsn => WaitAndFindElement(By.XPath("//*[@id=\"createbasicinfoform\"]/div/div[7]/div[3]/button[1]"));

        // search people from master


        public PeopleComponent(IWebDriver driver) : base(driver)
        {
        }
    }
 }
