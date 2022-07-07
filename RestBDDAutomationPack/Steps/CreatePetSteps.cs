using System;
using TechTalk.SpecFlow;

namespace RestBDDAutomationPack.Steps
{
    [Binding]
    public class CreatePetSteps
    {
        [Given(@"the valid user with login credintials")]
        public void GivenTheValidUserWithLoginCredintials()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the create request triggered")]
        public void WhenTheCreateRequestTriggered()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be success")]
        public void ThenTheResultShouldBeSuccess()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the details should be correct")]
        public void ThenTheDetailsShouldBeCorrect()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
