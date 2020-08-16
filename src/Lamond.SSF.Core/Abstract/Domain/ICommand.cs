using System;
using System.Collections.Generic;
using Lamond.SSF.Core.Models;

namespace Lamond.SSF.Core.Abstract.Domain
{
    public interface ICommand
    {
         void ExecuteSuccess();

        void ExecuteFail(BusinessError error);

        void ExecuteFail(IEnumerable<BusinessError> errors);
    }
}