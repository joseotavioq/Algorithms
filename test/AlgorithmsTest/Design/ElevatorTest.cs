using Algorithms.Design;
using Xunit;

namespace AlgorithmsTest.Design
{
    public class ElevatorTest
    {
        [Fact]
        public void Create_Elevator()
        {
            var elevator = new Elevator(10, 5, 300);

            Assert.Equal(0, elevator.CurrentFloor);
            Assert.Equal(0, elevator.NumberOfPeople);
            Assert.Equal(0, elevator.CurrentWeight);
        }

        [Fact]
        public void Add_One_People_In_The_Elevator()
        {
            var elevator = new Elevator(10, 5, 300);
            var people = new People(80);

            elevator.Add(people, 1);

            Assert.Equal(0, elevator.CurrentFloor);
            Assert.Equal(1, elevator.NumberOfPeople);
            Assert.Equal(80, elevator.CurrentWeight);
        }

        [Fact]
        public void Add_Two_People_That_Goes_To_Different_Floor()
        {
            var elevator = new Elevator(10, 5, 300);

            elevator.Add(new People(80), 1);
            elevator.Add(new People(120), 3);

            Assert.Equal(0, elevator.CurrentFloor);
            Assert.Equal(2, elevator.NumberOfPeople);
            Assert.Equal(200, elevator.CurrentWeight);
        }

        [Fact]
        public void Add_Two_People_That_Exceed_The_Weight()
        {
            var elevator = new Elevator(10, 5, 300);

            elevator.Add(new People(160), 1);
            elevator.Add(new People(150), 3);

            Assert.Equal(0, elevator.CurrentFloor);
            Assert.Equal(1, elevator.NumberOfPeople);
            Assert.Equal(160, elevator.CurrentWeight);
        }

        [Fact]
        public void Add_People_That_Exceed_To_Capacity()
        {
            var elevator = new Elevator(10, 1, 300);

            elevator.Add(new People(80), 1);
            elevator.Add(new People(120), 3);

            Assert.Equal(0, elevator.CurrentFloor);
            Assert.Equal(1, elevator.NumberOfPeople);
            Assert.Equal(80, elevator.CurrentWeight);
        }

        [Fact]
        public void Move_Elevator_Up()
        {
            var elevator = new Elevator(10, 5, 300);

            elevator.Add(new People(80), 1);
            elevator.Add(new People(120), 3);

            elevator.Move();

            Assert.Equal(3, elevator.CurrentFloor);
            Assert.Equal(0, elevator.NumberOfPeople);
            Assert.Equal(0, elevator.CurrentWeight);
        }

        [Fact]
        public void Call_Elevator_At_5_Floor()
        {
            var elevator = new Elevator(10, 5, 300);

            elevator.Call(5);
            elevator.Move();

            Assert.Equal(5, elevator.CurrentFloor);
            Assert.Equal(0, elevator.NumberOfPeople);
            Assert.Equal(0, elevator.CurrentWeight);
        }

        [Fact]
        public void Bring_One_People_To_4_And_Call_Elevator_At_5_Floor()
        {
            var elevator = new Elevator(10, 5, 300);

            elevator.Add(new People(80), 4);
            elevator.Call(5);
            elevator.Move();

            Assert.Equal(5, elevator.CurrentFloor);
            Assert.Equal(0, elevator.NumberOfPeople);
            Assert.Equal(0, elevator.CurrentWeight);
        }

        [Fact]
        public void Bring_One_People_To_5_And_Call_Elevator_At_4_Floor()
        {
            var elevator = new Elevator(10, 5, 300);

            elevator.Add(new People(80), 5);
            elevator.Call(4);
            elevator.Move();

            Assert.Equal(5, elevator.CurrentFloor);
            Assert.Equal(0, elevator.NumberOfPeople);
            Assert.Equal(0, elevator.CurrentWeight);
        }
    }
}