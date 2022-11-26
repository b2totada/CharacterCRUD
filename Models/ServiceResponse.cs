using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    //Wrapper for the return data to the client. Allows us to add additional information to the response.
    public class ServiceResponse<T>
    {
        //Contains the actual data
        public T? Data { get; set; }
        //To inform the receiver about the success/failure of the transaction
        public bool Success { get; set; } = true;
        //Additional explanatory message
        public string Message { get; set; } = string.Empty;
    }
}