using OpenQA.Selenium;

namespace SAFV.Source.Components.Detective.CreateCase
{
    internal class CaseReviewComponent : BaseComponent
    {
        public static IWebElement CommentButton => WaitAndFindElement(By.Id("commentIcon"));
        public static IWebElement Note => WaitAndFindElement(By.Id("Note"));
        public static IList<IWebElement> LstNote => WaitAndFindElements(By.XPath("/html/body/div[1]/div[4]/div[2]/div/div[2]/div/div/div[3]/div/div/div/div/div[2]/table/tbody/tr/td[3]"));
        public static IWebElement Save => WaitAndFindElement(By.XPath("//*[@id=\"commentsForm\"]/div/div/div[2]/div/div/input[1]"));
        public static IWebElement Delete => WaitAndFindElement(By.XPath("//*[@id=\"commentsForm\"]/div/div/div[2]/div/div/input[2]"));

        public CaseReviewComponent(IWebDriver driver) : base(driver)
        {
        }
    }
}
