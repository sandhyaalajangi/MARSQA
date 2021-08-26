using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class DescriptionSteps
    {
        [Given(@"I can add the description in description box")]
        public void GivenICanAddTheDescriptionInDescriptionBox()
        {
            MarsQA_1.Pages.DescriptionPages.AddDescription();
        }
    }
}
