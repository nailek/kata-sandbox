using System;
using TechTalk.SpecFlow;

namespace theLiftKata.specs.StepDefinitions
{
    [Binding]
    public class LiftStepDefinitions
    {
        private Lift _lift;

        [Given(@"the lift is in floor (.*)")]
        public void GivenTheLiftIsInFloor(int currentFloor)
        {
            _lift = new Lift(currentFloor);
        }

        [When(@"the lift is called from (.*)")]
        public void WhenTheLiftIsCalledFrom(int destinationFloor)
        {
            _lift.CallTo(destinationFloor));
            throw new PendingStepException();
        }

        [Then(@"the lift goes to floor (.*)")]
        public void ThenTheLiftGoesToFloor(int p0)
        {
            throw new PendingStepException();
        }
    }

    public class Lift
    {
        public Lift(int currentFloor)
        {
            throw new NotImplementedException();
        }
    }
}
