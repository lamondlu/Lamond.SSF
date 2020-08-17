using Lamond.SSF.Core.Models;
using System;
using System.Collections.Generic;

namespace Lamond.SSF.Core.Abstract.Domain
{
    public interface ICommand
    {
        string Operator { get; set; }

        DateTime OccurredOn { get; }

        void ExecuteSuccess();

        void ExecuteFail(BusinessError error);

        void ExecuteFail(IEnumerable<BusinessError> errors);
    }
}