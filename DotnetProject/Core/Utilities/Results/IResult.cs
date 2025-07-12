namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç noktası
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}