namespace Core.Utilities.Results
{
    public class ErrorResult :Result
    {
        public ErrorResult(string message) : base(false, message)
        {
            
        }
        public ErrorResult() : base(false)
        {
            
        }
        public bool Success { get; }

        public string Message{ get; }
    }
}