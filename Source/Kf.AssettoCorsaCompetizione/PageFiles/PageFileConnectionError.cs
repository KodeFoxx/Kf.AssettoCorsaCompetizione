using Kf.Essentials.CleanArchitecture.Model;
using LanguageExt;
using System;
using System.Collections.Generic;

namespace Kf.AssettoCorsaCompetizione.PageFiles
{
    public sealed class PageFileConnectionError : ValueObject
    {
        public static PageFileConnectionError None = new PageFileConnectionError();

        public string Message { get; }
        public Exception InnerException { get; }

        private PageFileConnectionError() { }

        public PageFileConnectionError(string message)
            : this(message, null)
        { }

        public PageFileConnectionError(string message, Exception innerException)
        {
            Message = message;
            InnerException = innerException;
        }

        protected override IEnumerable<object> EquatableValues
            => new object[] { Message, InnerException };

        public Exception ToException()
            => new Exception(Message, InnerException);
    }
}
