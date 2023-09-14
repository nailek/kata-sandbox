using System;
using TechTalk.SpecFlow;

namespace theLiftKata.specs.StepDefinitions
{
    [Binding]
    public class LiftStepDefinitions
    {
        [Given(@"the lift is in floor (.*)")]
        public void GivenTheLiftIsInFloor(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"the lift is called from (.*)")]
        public void WhenTheLiftIsCalledFrom(int p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the lift goes to floor (.*)")]
        public void ThenTheLiftGoesToFloor(int p0)
        {
            throw new PendingStepException();
        }
    }
}
