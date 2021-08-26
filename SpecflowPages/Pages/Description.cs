using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System.Threading;

namespace MarsQA_1.Pages
{
    public static class DescriptionPages
    {
     public static void AddDescription()
     {
            var Descriptiontext = "Profile Description sandhya automation tester";

            //xpath for edit button for description
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")).Click();


             //clear the existing text from the description field
            // Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).Clear();

            //xpath for text 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).SendKeys(Descriptiontext);

        //xpath for savebutton
        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();

           //Thread.Sleep(2000);
           




     }

    }
}
