namespace Common
{
    public class ApiResult
    {
        public string Message { get; set; }
        public bool IsError { get; set; }
        public object Result { get; set; }
    }
}
