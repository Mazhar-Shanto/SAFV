using OpenQA.Selenium;

namespace SAFV.Source.Components.CreateIncident.People.Suspect
{
    public class InterviewComponent : BaseComponent
    {
        // Elements
        public static IWebElement PersonWasInterviewed => WaitAndFindElement(By.XPath("//*[@id=\"personInterviewform\"]/div/div[1]/div/span[1]"));
        public static IWebElement WhyNotInterviewed => WaitAndFindElement(By.Id("ReasonNotConducted"));
        public static IWebElement PersonInterviewedOnAudioVideo => WaitAndFindElement(By.XPath("//*[@id=\"personInterviewform\"]/div/div[3]/div[1]/div/span[1]"));
        public static IWebElement PersonInterviewedOnCustody => WaitAndFindElement(By.XPath("//*[@id=\"personInterviewform\"]/div/div[3]/div[2]/div/span[1]"));
        public static IWebElement PersonInterviewedByAnotherOfficer => WaitAndFindElement(By.XPath("//*[@id=\"personInterviewform\"]/div/div[3]/div[3]/div/span[1]"));
        public static IWebElement InitialContact => WaitAndFindElement(By.Id("IntialContact"));
        public static IWebElement DescribeEvents => WaitAndFindElement(By.Id("DescribeEvents"));
        public static IWebElement IntervieweeRole => WaitAndFindElement(By.Id("DescribeRole"));
        public static IWebElement UseOfForce => WaitAndFindElement(By.XPath("//*[@id=\"personInterviewform\"]/div/div[3]/div[8]/div/span[1]"));
        public static IWebElement ReportedInjuries => WaitAndFindElement(By.Id("ReportedInjuries"));
        public static IWebElement DeEscalation => WaitAndFindElement(By.XPath("//*[@id=\"personInterviewform\"]/div/div[3]/div[11]/div/span[1]"));
        public static IWebElement IndicationOfViolence => WaitAndFindElement(By.XPath("//*[@id=\"personInterviewform\"]/div/div[3]/div[13]/div/span[1]"));
        public static IWebElement InjuriesToOthers => WaitAndFindElement(By.Id("OtherInjuries"));
        public static IWebElement SuspectIdentfied => WaitAndFindElement(By.XPath("//*[@id=\"personInterviewform\"]/div/div[3]/div[17]/div[1]/div/span[1]"));


        public InterviewComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
