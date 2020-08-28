using Lamond.SSF.Core.Abstract.Domain;
using System;
using System.Collections.Generic;

namespace Lamond.SSF.Core.Models
{
    public abstract class Command<T> : ICommand where T : CommandExecuteResult, new()
    {
        public T ExecuteResult { get; protected set; }

        public string Operator { get; set; }
        public DateTime OccurredOn { get; private set; }

        public Command()
        {
            ExecuteResult = new T();
            OccurredOn = DateTime.Now;
        }

        public void ExecuteSuccess()
        {
            ExecuteResult.ExecuteSuccess();
        }

        public void ExecuteFail(BusinessError error)
        {
            ExecuteResult.ExecuteFail(error);
        }

        public void ExecuteFail(IEnumerable<BusinessError> errors)
        {
            ExecuteResult.ExecuteFail(errors);
        }
    }
}