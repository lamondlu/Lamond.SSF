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
            this.ExecuteResult = new T();
            OccurredOn = DateTime.Now;
        }

        public void ExecuteSuccess()
        {
            this.ExecuteResult.ExecuteSuccess();
        }

        public void ExecuteFail(BusinessError error)
        {
            this.ExecuteResult.ExecuteFail(error);
        }

        public void ExecuteFail(IEnumerable<BusinessError> errors)
        {
            this.ExecuteResult.ExecuteFail(errors);
        }
    }
}