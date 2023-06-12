namespace Vadharuiskafferiet.Domain.Aggregates.ValueObjects
{
    public class DescriptionValueObject
    {
        private string _description;

        public DescriptionValueObject()
        {

        }

        public DescriptionValueObject(string description)
        {
            if (string.IsNullOrEmpty(description)) 
                throw new ArgumentNullException("value");
            _description = description;
        }

        public string Value
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrEmpty(value)) 
                    throw new ArgumentNullException("value can't be null or empty");
                _description = value;
            }
        }

    }
}
