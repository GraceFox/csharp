using System;
using System.Linq;

public class PhoneNumber
{
    public string _phoneNumber;
    public string Number => _phoneNumber;
    public string LocalNumber { get; set; }
    public string AreaCode { get; }

    private const string WrongNumber = "0000000000";

    public PhoneNumber(string phoneNumber)
    {
        var cleanNumber = new string(phoneNumber.Where(Char.IsDigit).ToArray());

        if (cleanNumber.Length > 10)
        {
            _phoneNumber = cleanNumber.StartsWith("1") ? cleanNumber.Substring(1) : WrongNumber;
        }

        else if (cleanNumber.Length == 10)
        {
            AreaCode = cleanNumber.Substring(0, 3);
            LocalNumber = cleanNumber.Substring(3, 7);
            _phoneNumber = AreaCode + LocalNumber;
        }

        else 
        {
            _phoneNumber = WrongNumber;
        }
    }

        public override string ToString()
    {
        return Formatter();
    }

    private string Formatter()
    {
        return string.Format("({0}) {1}-{2}", AreaCode, LocalNumber.Substring(0, 3), LocalNumber.Substring(3, 4));
    }
}