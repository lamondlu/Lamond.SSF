using Lamond.SSF.Core.Models;
using System.Collections.Generic;

namespace Lamond.SSF.Core.Abstract
{
    public interface IDomainLogger
    {
        bool IsEmpty { get; }

        void WriteBusinessLog(string stepName, string message);

        void WriteCustomLog(string message);

        void WriteJson(string stepName, object o);

        void WriteSystemLog(string stepName, string message);

        void WriteHandledErrorLog(string step, string message);

        void WriteValidationError(List<BusinessError> errors);

        void WriteUnhandledErrorLog(string message);

        void WriteDbLog(string stepName, string message);

        void Flush();
    }
}