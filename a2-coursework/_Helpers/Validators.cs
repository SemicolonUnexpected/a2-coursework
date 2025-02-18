using PhoneNumbers;
using System.Net.Mail;

namespace a2_coursework._Helpers;
public static class Validators {
    public static bool IsValidPhoneNumber(string number) {
        PhoneNumberUtil util = PhoneNumberUtil.GetInstance();
        try {
            PhoneNumber phoneNumber = util.Parse(number, "GB");
            return util.IsValidNumber(phoneNumber);
        }
        catch (NumberParseException) {
            return false;
        }
    }

    public static bool IsValidEmail(string email) => MailAddress.TryCreate(email, out _);
}
