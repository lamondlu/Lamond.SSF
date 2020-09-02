using Lamond.SSF.Core.Abstract;
using Lamond.SSF.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lamond.SSF.Core.Concrete.Domain
{
    public class ConsoleDomainLogger : IDomainLogger
    {
        public bool IsEmpty => throw new NotImplementedException();

        public void Flush()
        {
            throw new NotImplementedException();
        }

        public void WriteBusinessLog(string stepName, string message)
        {
            Console.WriteLine($"[{stepName}]{message}");
        }

        public void WriteCustomLog(string message)
        {
            Console.WriteLine($"[Custom]{message}");
        }

        public void WriteDbLog(string stepName, string message)
        {
            Console.WriteLine($"[{stepName}]{message}");
        }

        public void WriteHandledErrorLog(string step, string message)
        {
            Console.WriteLine($"[{step}]{message}");
        }

        public void WriteJson(string stepName, object o)
        {
            Console.WriteLine($"[{stepName}]{JsonConvert.SerializeObject(o)}");
        }

        public void WriteSystemLog(string stepName, string message)
        {
            Console.WriteLine($"[{stepName}]{message}");
        }

        public void WriteUnhandledErrorLog(string message)
        {
            Console.WriteLine($"[Unhandled Error]{message}");
        }

        public void WriteValidationError(List<BusinessError> errors)
        {
            foreach (var item in errors)
            {
                Console.WriteLine($"[Validation Error]{item}");
            }

        }
    }
}
