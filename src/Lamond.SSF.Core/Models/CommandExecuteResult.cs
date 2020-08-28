using System.Collections.Generic;
using System.Linq;

namespace Lamond.SSF.Core.Models
{
    public class CommandExecuteResult
    {
        private readonly List<BusinessError> executeErrors;

        public bool Success { get; private set; }

        public IEnumerable<BusinessError> Errors => executeErrors.AsEnumerable();

        public CommandExecuteResult()
        {
            executeErrors = new List<BusinessError>();
        }

        public void ExecuteSuccess()
        {
            Success = true;
        }

        public void ExecuteFail(BusinessError error)
        {
            Success = false;

            AddError(error);
        }

        public void ExecuteFail(IEnumerable<BusinessError> errors)
        {
            Success = false;

            AddErrors(errors);
        }

        public void AddError(BusinessError error)
        {
            executeErrors.Add(error);
        }

        public void RemoveError(BusinessError error)
        {
            executeErrors.Remove(error);
        }

        public void AddErrors(IEnumerable<BusinessError> errors)
        {
            executeErrors.AddRange(errors);
        }
    }
}