using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class EducationSteps
    {
        [Given(@"i was able to add my educational details to my profile")]
        public void GivenIWasAbleToAddMyEducationalDetailsToMyProfile()
        {
            MarsQA_1.SpecflowPages.Pages.Education.AddEducationfromExcelsheet();
        }
        
        [Given(@"i was able to Update my educational details to my profile")]
        public void GivenIWasAbleToUpdateMyEducationalDetailsToMyProfile()
        {
            MarsQA_1.SpecflowPages.Pages.Education.UpdateEducation();
        }
        
        [Given(@"i was able to Delete my educational details to my profile")]
        public void GivenIWasAbleToDeleteMyEducationalDetailsToMyProfile()
        {
            MarsQA_1.SpecflowPages.Pages.Education.DeleteEducation();
        }
    }
}
