﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Bancario.Application.Result
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }

        public T? Value { get; set; }

        public string? Error { get; set; }

        public static Result<T> Success(T? value) => new Result<T> { 
            
            IsSuccess = true,
            Value = value
        };


        public static Result<T> Failure(string error) => new Result<T>
        {

            IsSuccess = false,
            Error = error
        };

        /* Método no estático (requiere una instancia de Result<T>)
        public Result<T> Success(T? value)
        {
            return new Result<T>
            {
                IsSuccess = true,
                Value = value
            };
        }
        */
    }
}
