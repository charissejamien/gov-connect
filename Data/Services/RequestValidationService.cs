using System.Text.RegularExpressions;

namespace gov_connect.Data.Services;

public class RequestValidationService
{
    public List<string> ValidateLogin(string email, string password)
    {
        var errors = new List<string>();

        if (string.IsNullOrWhiteSpace(email))
        {
            errors.Add("Email is required.");
        }
        else if (!IsValidEmail(email))
        {
            errors.Add("Email format is invalid.");
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            errors.Add("Password is required.");
        }

        return errors;
    }

    public List<string> ValidateSignUp(string fullName, string email, string password, string confirmPassword)
    {
        var errors = new List<string>();

        if (string.IsNullOrWhiteSpace(fullName))
        {
            errors.Add("Full name is required.");
        }

        if (string.IsNullOrWhiteSpace(email))
        {
            errors.Add("Email is required.");
        }
        else if (!IsValidEmail(email))
        {
            errors.Add("Email format is invalid.");
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            errors.Add("Password is required.");
        }
        else if (password.Length < 8)
        {
            errors.Add("Password must be at least 8 characters long.");
        }

        if (!string.Equals(password, confirmPassword, StringComparison.Ordinal))
        {
            errors.Add("Passwords do not match.");
        }

        return errors;
    }

    public List<string> ValidateRequest(string purpose, string firstName, string lastName, string deliveryMethod, string address)
    {
        var errors = new List<string>();

        if (string.IsNullOrWhiteSpace(purpose))
        {
            errors.Add("Purpose is required.");
        }

        if (string.IsNullOrWhiteSpace(firstName))
        {
            errors.Add("First name is required.");
        }

        if (string.IsNullOrWhiteSpace(lastName))
        {
            errors.Add("Last name is required.");
        }

        if (string.IsNullOrWhiteSpace(deliveryMethod))
        {
            errors.Add("Delivery method is required.");
        }
        else if (string.Equals(deliveryMethod, "Delivery", StringComparison.OrdinalIgnoreCase) && string.IsNullOrWhiteSpace(address))
        {
            errors.Add("Delivery address is required.");
        }

        return errors;
    }

    private static bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$");
    }
}
