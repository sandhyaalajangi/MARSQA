using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class Education
    {
        public static void AddEducationfromExcelsheet()
        {

            //Find Xpath for Education tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();

            ExcelLibHelper.PopulateInCollection(@"C:\sandhya\MarsQA\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Education");
           

            for (int i = 2; i <= 3; i++)
            {
                //Find Xpath for addnew action button
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")).Click();

                //read the data from Excel Sheet

                var Countryexceldata = ExcelLibHelper.ReadData(i, "Country");
                var Universityexceldata = ExcelLibHelper.ReadData(i, "University");
                var Titleexceldata = ExcelLibHelper.ReadData(i, "Title");
                var Degreeexceldata = ExcelLibHelper.ReadData(i, "Degree");
                var GraduationYearexceldata = ExcelLibHelper.ReadData(i, "GraduationYear");


                //findxpath for universityfield and assign input parameter
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")).SendKeys(Universityexceldata);
                    
                    //Sendkeys(Universityexceldata);

                //find xpath for country field and assign input parameter
                //select from drop down
               var Country = Driver.driver.FindElement(By.Name("country"));

                //create select element object
                var Countryselectelement = new SelectElement(Country);

                //select by text
                Countryselectelement.SelectByText(Countryexceldata);

               
                //find xpath for Title field and assign input parameter
                //select from drop down 
               var title = Driver.driver.FindElement(By.Name("title"));

                //create select element object
                var titleselectelement = new SelectElement(title);

                // //select by text
                titleselectelement.SelectByText(Titleexceldata);


                //find xpath for Degree field and assign input parameter
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")).SendKeys(Degreeexceldata);

                // //find xpath for GraduationYear field and assign input parameter
                //select from drop down

                var GraduationYear = Driver.driver.FindElement(By.Name("yearOfGraduation"));

                //create select element object
                var GraduationYearselectelement = new SelectElement(GraduationYear);

                //select by text
                GraduationYearselectelement.SelectByText(GraduationYearexceldata);

                //find xpath for add action andclick
                Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();


                //find xpath for success or failure messege
                 var alerttext = Driver.driver.FindElement(By.XPath("/html/body/div[1]")).Text;

            }
        }



        //update

        public static void UpdateEducation()
        {
            //Find Xpath for Education tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click(); 


            //find xpath for update symbol(pen)
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[1]/i")).Click();



            //find xpath for country field and assign input parameter
            IWebElement CountryElement = Driver.driver.FindElement(By.Name("country"));
           

            //create select element object
            var selectelement = new SelectElement(CountryElement);

            //select by text
            selectelement.SelectByText("India");

            //findxpath for universityfield and assign input parameter
           // var University = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
           // University.Clear();


            //University.SendKeys("JNTU");
            

            //find xpath for Title field and assign input parameter

            IWebElement titleElement = Driver.driver.FindElement(By.Name("title"));

            //create select element object
            var selectElement = new SelectElement(titleElement);

            // //select by text
            selectElement.SelectByText("PHD");


            //find xpath for Degree field and assign input parameter
            //IWebElement DegreeElement = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            //DegreeElement.Clear();
            //DegreeElement.SendKeys("Bachelors");

            // //find xpath for GraduationYear  and assign input parameter
            //select from drop down

            IWebElement GraduationYearElement = Driver.driver.FindElement(By.Name("yearOfGraduation"));

            //create select element object
            var GraduationYearselectElement = new SelectElement(GraduationYearElement);

            //select by text
            GraduationYearselectElement.SelectByText("2020");



            // find xpath for update action button and click
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[3]/input[1]")).Click();
        }
        // "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[3]/input[1]"

        //delete

        public static void DeleteEducation()
        {
            //find xpath for education tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();

            //find xpath for delete mark symbol(cross symbol)
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[2]/i")).Click();


            //assertion
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            //find xpath for success or failure message
            var alerttext = Driver.driver.FindElement(By.XPath("/html/body/div[1]")).Text;
            //assert expected result = actual result
            Assert.AreEqual("Education entry succesfully removed", alerttext);










        }
    }
}
