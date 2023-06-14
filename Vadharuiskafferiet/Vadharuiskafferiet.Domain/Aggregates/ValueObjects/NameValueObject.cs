namespace Vadharuiskafferiet.Domain.Aggregates.ValueObjects
{
    public class NameValueObject
    {
        private string _name;

        public NameValueObject()
        {

        }

        public NameValueObject(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("name cant be null or empty");
            _name = name;
        }

        public string Value
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) 
                    throw new ArgumentException("value");
                _name = value;
            }
        }
    }
}
