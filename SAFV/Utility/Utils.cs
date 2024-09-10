using AngleSharp.Dom;
using OpenQA.Selenium;
using System.Reflection.Emit;

namespace SAFV.Utility
{
    public class Utils
    {
        private Random random;
        private int value;
        private string text;

        public string GetRandomNumber(int len)
        {
            random = new Random();
            int range = 1;
            string format = "";

            while (len > 0)
            {
                range *= 10;
                format += "0";
                len--;
            }

            value = random.Next(range);
            text = value.ToString(format);
            Console.WriteLine(text);

            return text;
        }

        public static string GetProjectRoot()
        {
            var projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", ".."));

            return projectRoot;
        }

        public static string GetLabelName(IWebElement element)
        {
            string label = "";

            // First try: Find label from a sibling element
            try
            {
                label = element.FindElement(By.XPath("./../label")).Text;
            }
            catch (Exception)
            {
                // Ignoring the exception, move to the next attempt
            }

            // If label is still empty, try getting the label from parent's sibling element
            if (string.IsNullOrEmpty(label))
            {
                try
                {
                    label = element.FindElement(By.XPath("./../../label")).Text;
                }
                catch (Exception)
                {
                    // Ignoring the exception, move to the next attempt
                }
            }

            // If label is still empty, try getting the element's "value" attribute
            if (string.IsNullOrEmpty(label))
            {
                try
                {
                    label = element.GetAttribute("value");
                }
                catch (Exception)
                {
                    // Ignoring the exception, move to the next attempt
                }
            }

            // If label is still empty, try getting the element's text
            if (string.IsNullOrEmpty(label))
            {
                try
                {
                    label = element.Text;
                }
                catch (Exception)
                {
                    // Ignoring the exception, nothing more to attempt
                }
            }

            return label;
        }
    }
}
