using System.Collections.Generic;

namespace Algorithms.ArraysAndStrings
{
    public class MappingCommands
    {
        public Dictionary<char, Position> _mappings = new Dictionary<char, Position>();

        public MappingCommands()
        {
            LoadMappers();
        }

        private void LoadMappers()
        {
            for (int i = 'a'; i <= 'z'; i++)
            {
                int j = i - 'a';
                _mappings.Add((char)i, new Position(j, j));
            }
        }

        public Commands[] GetCommands(string words)
        {
            if (words == null)
            {
                return null;
            }

            List<Commands> commands = new List<Commands>();

            Position currentPosition = new Position(0, 0);

            for (int i = 0; i < words.Length; i++)
            {
                char c = words[i];
                Position position = _mappings[c];

                while (currentPosition.X < position.X)
                {
                    currentPosition.X++;
                    commands.Add(Commands.Right);
                }

                while (currentPosition.Y < position.Y)
                {
                    currentPosition.Y++;
                    commands.Add(Commands.Down);
                }

                while (currentPosition.X > position.X)
                {
                    currentPosition.X--;
                    commands.Add(Commands.Left);
                }

                while (currentPosition.Y > position.Y)
                {
                    currentPosition.Y--;
                    commands.Add(Commands.Up);
                }

                commands.Add(Commands.Click);
            }

            return commands.ToArray();
        }
    }
    public enum Commands
    {
        Right,
        Left,
        Down,
        Up,
        Click
    }

    public class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}