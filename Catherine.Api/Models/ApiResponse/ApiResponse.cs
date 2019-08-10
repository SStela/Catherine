using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Catherine.Api.Models.ApiResponse
{
    public class ApiResponse
    {
        public HttpStatusCode Code { get; set; }

        public ICollection<ApiErrorInformation> Errors { get; set; }
        
        public object Response { get; set; }

        public static ApiResponse Ok(object data)
        {
            return Ok(data);
        }

        public static ApiResponse Ok(HttpStatusCode statusCode, object data)
        {
            return Ok(statusCode, data, null);
        }
        
        public static ApiResponse Ok(HttpStatusCode statusCode, object data, ICollection<ApiErrorInformation> errors)
        {
            ApiResponse response = new ApiResponse();
            response.Code = statusCode;
            response.Response = data;
            response.Errors = errors; // if any
            return response;
        }

        public static ApiResponse Error(HttpStatusCode statusCode, ICollection<ApiErrorInformation> errors)
        {
            return Ok(statusCode, null, errors);
        }

        public static ApiResponse Error(HttpStatusCode statusCode, ApiErrorInformation error)
        {
            ICollection<ApiErrorInformation> errors = new List<ApiErrorInformation>();
            errors.Add(error);
            return Error(statusCode, errors);
        }
    }
}