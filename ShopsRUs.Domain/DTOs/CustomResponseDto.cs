using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShopsRUs.Domain.DTOs
{
    public class CustomResponseDto<T>
    {
        public CustomResponseDto()
        {
                Errors = new List<string>();
        }
        public T Data { get; set; }  

        public List<string> Errors { get; set; }

        public static CustomResponseDto<T> Success(T data)
        {
            return new CustomResponseDto<T>() {  Data = data };
        } 
        public static CustomResponseDto<T> Fail(List<string> errors)
        {
            return new CustomResponseDto<T>() {  Errors = errors };
        }
    }
}
