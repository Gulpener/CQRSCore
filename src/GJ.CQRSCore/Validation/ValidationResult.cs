﻿namespace GJ.CQRSCore.Validation
{
    public class ValidationResult
    {
        public ValidationResult(string propertyName, string message)
        {
            PropertyName = propertyName;
            Message = message;
        }

        public string PropertyName { get; }
        public string Message { get; }
        public string FormattedMessage => string.Format(Message, PropertyName);
    }
}
