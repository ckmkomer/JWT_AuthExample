﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
	public class Response<T> where T : class
	{
		public T Data { get; private set; }
		public int StatusCode { get; private set; } // bu class içerisnde set edilecek o yüzden private yaptık.

		[JsonIgnore] // serilaze edilmemesi için 
		public bool IsSuccessful { get; private set; }//kullnıcıya göstermiyeceğiz kendi iç yapımızda kullanacağız.
		 
		public ErrorDto Error { get; private set; }

		public static Response<T> Success(T data, int statusCode)
		{
			return new Response<T> { Data = data, StatusCode = statusCode, IsSuccessful = true };
		}

		public static Response<T> Success(int statusCode)
		{
			return new Response<T> { Data = default, StatusCode = statusCode, IsSuccessful = true };
		}

		public static Response<T> Fail(ErrorDto errorDto, int statusCode)
		{
			return new Response<T>
			{
				Error = errorDto,
				StatusCode = statusCode,
				IsSuccessful = false
			};
		}

		public static Response<T> Fail(string errorMessage, int statusCode, bool isShow) //isShow gelen hatayı kullanıcya gösterip göstermemme 
		{
			var errorDto = new ErrorDto(errorMessage, isShow);

			return new Response<T> { Error = errorDto, StatusCode = statusCode, IsSuccessful = false };
		}
	}
}
