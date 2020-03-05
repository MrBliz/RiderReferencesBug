using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace RiderTest
{
    public static class HttpResults
    {
        public static ObjectResult InternalServerErrorResult([ActionResultObjectValue] string errorMessage)
        {
            return new ObjectResult(errorMessage)
            {
                StatusCode = StatusCodes.Status500InternalServerError,
            };
        }
    }
}