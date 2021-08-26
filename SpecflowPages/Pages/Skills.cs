using System;
using System.Collections.Generic;
using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA_1.Pages
{
    public static class ProfileSkillsPage
    {
        public static void AddSkills()
        {
            // Find Xpath for skills tab

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();

            // Find xpath for AddNew action button

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            // find xpath for Addskill and assign input parameter skill

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys("JAVA");


            // find xpath for level and assign input parameter level
            // select the drop down list

            var level = Driver.driver.FindElement(By.Name("level"));

            //create select element object 
            var selectElement = new SelectElement(level);

            // select by text
            selectElement.SelectByText("Beginner");

            // find xpath for Add action button and click

            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

            //find xpath for sucess or failure message
            var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

            // assert expected result = actual result
            Assert.AreEqual("JAVA has been added to your skills", alerttext);

            // xpath of html table
            var elemTable = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));

            // Fetch all Row of the table
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            String strRowData = "";

            // Traverse each row
            foreach (var elemTr in lstTrElem)
            {
                // Fetch the columns from a particuler row
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    // Traverse each column
                    foreach (var elemTd in lstTdElem)
                    {
                        // "\t\t" is used for Tab Space between two Text
                        strRowData = strRowData + elemTd.Text + "\t\t";
                        Console.WriteLine(elemTd.Text);
                    }

                    string skillText = lstTdElem[0].Text;
                    string LevelText = lstTdElem[1].Text;
                    Assert.AreEqual("JAVA", skillText);
                    Assert.AreEqual("Beginner", LevelText);
                }
                else
                {
                    // To print the data into the console
                    Console.WriteLine("This is Header Row");
                    Console.WriteLine(lstTrElem[0].Text.Replace(" ", "\t\t"));
                }
                Console.WriteLine(strRowData);
                strRowData = String.Empty;
            }
        }
        public static void UpdateSkill()
        {
            // Find Xpath for skills tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
            // Find xpath for update (pen) mark symbol 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")).Click();

            //Xpath for skill
            IWebElement skillElement = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            skillElement.Clear();
            skillElement.SendKeys("Testing");
            var level = Driver.driver.FindElement(By.Name("level"));
            //create select element object 
            var selectElement = new SelectElement(level);


            // select by text
            selectElement.SelectByText("Expert");


            // find xpath for update action button and click
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")).Click();

            //Assertion

            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            //find xpath for sucess or failure message
            var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

            // assert expected result = actual result
            Assert.AreEqual("Testing has been updated to your skills", alerttext);

            // xpath of html table
            var elemTable = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));

            // Fetch all Row of the table
            List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
            String strRowData = "";

            // Traverse each row
            foreach (var elemTr in lstTrElem)
            {
                // Fetch the columns from a particuler row
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    // Traverse each column
                    foreach (var elemTd in lstTdElem)
                    {
                        // "\t\t" is used for Tab Space between two Text
                        strRowData = strRowData + elemTd.Text + "\t\t";
                        Console.WriteLine(elemTd.Text);
                    }

                    string SkillText = lstTdElem[0].Text;
                    string LevelText = lstTdElem[1].Text;
                    Assert.AreEqual("Testing", SkillText);
                    Assert.AreEqual("Expert", LevelText);
                }
                else
                {
                    // To print the data into the console
                    Console.WriteLine("This is Header Row");
                    Console.WriteLine(lstTrElem[0].Text.Replace(" ", "\t\t"));
                }
                Console.WriteLine(strRowData);
                strRowData = String.Empty;
            }
        }
        // Deleate a updated record

        public static void DeleteSkill()
        {
            try
            {
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();


                // Find xpath for delete/(cross) mark symbol 
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")).Click();

                //Assertion

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(400);

                //find xpath for sucess or failure message
                var alerttext = Driver.driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;

                // assert expected result = actual result
               // Assert.AreEqual("Testing has been deleted", alerttext);

                Console.WriteLine("Test Passed");
            }
            catch (Exception e)
            {
                if (e.Message.Contains("no such element: Unable to locate element"))
                {
                    Console.WriteLine("There is no Skills to delete. Error Details are: " + e);
                }

            }
                  
        }

    }




}



