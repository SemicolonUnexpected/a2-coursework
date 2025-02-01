using PhoneNumbers;

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
}
