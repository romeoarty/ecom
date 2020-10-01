using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, You have made",
                401 => "Authorized, You are not",
                404 => "Resource found, it was not",
                500 => "Errors are the patch to the dark side. Errors lead to anger. Anger leads to hate. Hate leads to carrer change",
                _ => null,
            };
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}