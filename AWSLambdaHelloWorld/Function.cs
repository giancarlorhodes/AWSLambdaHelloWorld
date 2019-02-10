using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AWSLambdaHelloWorld
{


    /// <summary>
    /// DESCRIPTION: https://www.youtube.com/watch?v=Swh5TENpoKo
    /// AWS lambda in C# - Getting Started
    /// </summary>
    public class Function
    {

        /// <summary>
        /// DESCRIPTION: A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(Student input, ILambdaContext context)
        {
            // return input?.ToUpper();

            input.Email = "grhodes29@gmail.com";



            // SAMPLE INPUT TO THE FUNCTION
            //  {
            //      "FirstName":"Giancarlo",
            //      "LastName":"Rhodes",
            //      "Email":"giancarlo.rhodes@gmail.com"
            //  }
            //
            //

            return $"FirstName:{input.FirstName}, LastName:{input.LastName}, Email:{input.Email}";
        }
    }
}
