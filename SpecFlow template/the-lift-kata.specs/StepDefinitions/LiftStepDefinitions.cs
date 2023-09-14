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
        public void WhenTheLiftIsCalledFrom(int requestedFloor)
        {
            _lift.CallTo(requestedFloor);
        }

        [Then(@"the lift goes to floor (.*)")]
        public void ThenTheLiftGoesToFloor(int expectedFloor)
        {
            _lift.CurrentFloor.Should().Be(expectedFloor);
        }
    }

    public class Lift
    {
        public int CurrentFloor { get; private set; }

        public Lift(int currentFloor)
        {
            CurrentFloor = currentFloor;
        }

        public void CallTo(int destinationFloor)
        {
            CurrentFloor = destinationFloor;
        }
    }
}
