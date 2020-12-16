namespace Services
{
    public class WebResponse<T>
    {
        public ResponseStatus ResponseStatus { get; set; }
        public string Describtion { get; set; }
        public T Data { get; set; }


        public WebResponse(ResponseStatus status, string describtion = "", T data = default)
        {
            ResponseStatus = status;
            Describtion = describtion;
            Data = data;
        }
        public WebResponse()
        {

        }
    }
}
