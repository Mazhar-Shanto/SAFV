using OpenQA.Selenium;
using SAFV.Source.Components.CreateIncident.People.Suspect;

namespace SAFV.Source.Components.CreateIncident
{
    internal class IncidentReviewComponent : BaseComponent
    {
        public static IWebElement CommentButton => WaitAndFindElement(By.Id("existingCommentIcon"));
        public static IWebElement Note => WaitAndFindElement(By.Id("Note"));
        public static IWebElement Save => WaitAndFindElement(By.XPath("//*[@id=\"commentsForm\"]/div/div/div[2]/div/div/input[1]"));
        public static IWebElement Delete => WaitAndFindElement(By.XPath("//*[@id=\"commentsForm\"]/div/div/div[2]/div/div/input[2]"));

        public IncidentReviewComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
