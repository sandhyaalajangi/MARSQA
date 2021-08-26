using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddSkillsSteps
    {
        [Given(@"I will be add some skills for the profile")]
        public void GivenIWillBeAddSomeSkillsForTheProfile()
        {
            MarsQA_1.Pages.ProfileSkillsPage.AddSkills();
        }
      
      
        
        [Given(@"I able to update skill details")]
        public void GivenIAbleToUpdateSkillDetails()
        {
            MarsQA_1.Pages.ProfileSkillsPage.UpdateSkill();
        }
        
        [Given(@"I able to delete skill details")]
        public void GivenIAbleToDeleteSkillDetails()
        {
            MarsQA_1.Pages.ProfileSkillsPage.DeleteSkill();
        }
    }
}
