using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine_System.ErrorHandler
{
    public class ErrorHandler : Exception
    {
        public ErrorHandler(string message, string title, MessageBoxIcon icon) : base(message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }
    }
    public class ValidationException : ErrorHandler
    {
        public ValidationException(string message = "Validation failed.")
            : base(message, "Validation Error", MessageBoxIcon.Warning) { }
    }

    public class AuthenticationMissingException : ErrorHandler
    {
        public AuthenticationMissingException(string message = "Authentication required.")
            : base(message, "Authentication Error", MessageBoxIcon.Exclamation) { }
    }

    public class AuthorizationException : ErrorHandler
    {
        public AuthorizationException(string message = "You are not authorized to perform this action.")
            : base(message, "Authorization Error", MessageBoxIcon.Stop) { }
    }

    public class DatabaseException : ErrorHandler
    {
        public DatabaseException(string message = "Database operation failed.")
            : base(message, "Database Error", MessageBoxIcon.Error) { }
    }
    public class MissingValuesException : ErrorHandler
    {
        public MissingValuesException(string message = "Please fill all fields.")
            : base(message, "Missing Fields", MessageBoxIcon.Error) { }
    }

}
