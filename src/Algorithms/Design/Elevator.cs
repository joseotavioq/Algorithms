using System;
using System.Collections.Generic;

namespace Algorithms.Design
{
    public class Elevator
    {
        private readonly int _maxFloors;
        private readonly int _maxCapacity;
        private readonly double _maxWeight;

        private Dictionary<int, IList<People>> _peoplePerFloor = new Dictionary<int, IList<People>>();
        private int _currentMaxFloors;
        private Direction _direction;

        public int CurrentFloor { get; private set; } = 0;
        public int NumberOfPeople { get; private set; } = 0;
        public double CurrentWeight { get; private set; } = 0;

        public Elevator(int maxFloors, int maxCapacity, double maxWeight)
        {
            _maxFloors = maxFloors;
            _maxCapacity = maxCapacity;
            _maxWeight = maxWeight;
            _direction = Direction.Up;

            for (int i = 0; i < _maxFloors; i++)
                _peoplePerFloor.Add(i, new List<People>());
        }

        public void Add(People people, int whichFloor)
        {
            if (hasCapacity(people.Weight) && whichFloor < _maxFloors)
            {
                NumberOfPeople++;
                CurrentWeight += people.Weight;
                _currentMaxFloors = Math.Max(whichFloor, _currentMaxFloors);
                _peoplePerFloor[whichFloor].Add(people);
            }
        }

        public void Call(int whichFloorAreYou)
        {
            if (CurrentFloor <= whichFloorAreYou)
            {
                _direction = Direction.Up;
                _currentMaxFloors = Math.Max(whichFloorAreYou, _currentMaxFloors);
            }
            else
                _direction = Direction.Down;
        }

        public void Move()
        {
            while (CurrentFloor < _maxFloors && CurrentFloor <= _currentMaxFloors)
            {
                if (_peoplePerFloor[CurrentFloor].Count > 0)
                {
                    for (var i = _peoplePerFloor[CurrentFloor].Count - 1; i >= 0; i--)
                    {
                        CurrentWeight -= _peoplePerFloor[CurrentFloor][i].Weight;
                        NumberOfPeople--;
                        _peoplePerFloor[CurrentFloor].RemoveAt(i);
                    }
                }

                if (_direction == Direction.Up)
                    CurrentFloor++;
                else
                    CurrentFloor--;
            }

            CurrentFloor--;
        }

        private bool hasCapacity(double actualWeight)
        {
            bool doesItFit = NumberOfPeople < _maxCapacity;
            bool holdsTheWeight = CurrentWeight + actualWeight < _maxWeight;

            return doesItFit && holdsTheWeight;
        }
    }

    public enum Direction
    {
        Up,
        Down
    }
}