namespace Vadharuiskafferiet.Domain.Aggregates.ValueObjects
{
    public class RecepieStepValueObject
    {
        private string _steps;

        public RecepieStepValueObject()
        {
            _steps = string.Empty;
        }

        public RecepieStepValueObject(List<string> steps)
        {
            _steps = string.Join('-', steps);
        }

        public List<string> ValuesToList => _steps.Split("-").ToList();

        public string Value
        {
            get { return _steps; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                _steps = value;
            }
        }

        public void AddStep(string step)
        {
            if (string.IsNullOrEmpty(step)) throw new ArgumentException(nameof(step));
            ValuesToList.Add($"-{step}");
        }
    }
}
