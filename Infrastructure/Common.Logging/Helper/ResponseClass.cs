namespace Common.Logging.Helper
{
    public class ResponseContext<T>
    {
        public T? Response { get; set; }
        public IEnumerable<T>? Responses { get; set; }
        public string? SuceessText { get; set; }
        public string? ErrorText { get; set; }
        public int StatusCode { get; set; }
        public string? AdditionalData { get; set; }

    }

}
