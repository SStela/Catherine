namespace Catherine.Api.Models.ApiResponse
{
    public class ApiErrorInformation
    {
        public string Message { get; set; }
        public string InternalMessage { get; set; }
        public ApiErrorCode Code { get; set; }
    }
}