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

        [Then(@"traveled through floor/s (.*)")]
        public void ThenTravelledThroughFloorS(string p0)
        {
            var numbers = p0.Split(',').Select(x => int.Parse(x));
            numbers.SequenceEqual(_lift.TraveledPath).Should().BeTrue();
        }

    }

    public class Lift
    {
        public int CurrentFloor { get; private set; }

        public List<int> TraveledPath { get; private set; }

        public Lift(int currentFloor)
        {
            CurrentFloor = currentFloor;
            TraveledPath = new List<int>();
        }

        public void CallTo(int destinationFloor)
        {
            for (int i = 0; i < destinationFloor; i++)
            {
                TraveledPath.Add(i);
            }
            CurrentFloor = destinationFloor;
        }
    }
}
