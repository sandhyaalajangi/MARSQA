using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class LanguagesSteps
    {
        [Given(@"I was able to add my Languaage to the profile")]
        public void GivenIWasAbleToAddMyLanguaageToTheProfile()
        {
            MarsQA_1.Pages.Language.AddLanguageFromExcelSheet();
        }
        
        [Given(@"I was able to update my details to the profile")]
        public void GivenIWasAbleToUpdateMyDetailsToTheProfile()
        {
            MarsQA_1.Pages.Language.UpdateLanguageinput();
        }
        
        [Given(@"I was able to Delete my language Details from my profile")]
        public void GivenIWasAbleToDeleteMyLanguageDetailsFromMyProfile()
        {
            MarsQA_1.Pages.Language.DeleteLanguageinput();
        }
    }
}
