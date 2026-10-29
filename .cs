using System;
namespace PersonalTracker
{
    public class InvalidTrackerDataException : Exception
    {
        public InvalidTrackerDataException(string message) : base(message) { }
    }
    public class CoffeeRecord
    {
        private string _name;
        private int _voluemM1;
        private bool _isWithMilk;
        private object hrow;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new InvalidTrackerDataException("Название напитка не может быть пустым!");
                _name = value;
            }
    }
}
    public decimal Price
        {
            get;
            set
            {
                if (value < 0)
                    hrow new InvalidTrackerDataException("Стоимость не может быть отрицательной!");
                field = value;
            }
        }
    }
