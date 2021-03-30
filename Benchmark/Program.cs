using BenchmarkDotNet.Running;
using Mapster;
using System;
using System.Collections.Generic;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mapstar Mapper test

            // copy single object to object
            var dto = new CustomerDto { Id = 1, FirstName = "Mohammed", LastName = "Tanbir" };
            var vm = dto.Adapt<CustomerVM>();
            Console.WriteLine("Full Name : " + vm.FullName);

            // dest check
            var dmObj = new CustomerVM();
            dto.Adapt(dmObj);

            // copy list object to list object
            var dtoList = new List<CustomerDto>
            {
                new CustomerDto { Id = 1, FirstName = "Mohammed", LastName = "Tanbir" },
                new CustomerDto { Id = 2, FirstName = "Kashem", LastName = "Khan" },
                new CustomerDto { Id = 3, FirstName = "Samrat", LastName = "Hossain" }
            };

            var vmList = dtoList.Adapt<List<CustomerVM>>();
            Console.WriteLine("List - Last Full name : " + vmList[2].FullName);

            var destVM = new List<CustomerVM>();
            dtoList.Adapt(destVM);
            //Console.ReadLine();

            #endregion

            // Benchmark
            var summary = BenchmarkRunner.Run<Md5VsSha256>();
        }
    }
}


// dotnet build -c Release