namespace a2_coursework.Model.Staff;
public enum PrivilegeLevel {
    Office = 1,
    Admin = 2,
    Manager = 3,
    CleaningManager = 4,
    Cleaner = 5,
}

public static class PrivilegeLevelExtensions {
    public static string ConvertToString(this PrivilegeLevel privilegeLevel) => privilegeLevel switch {
        PrivilegeLevel.Office => "Office",
        PrivilegeLevel.Admin => "Administrator",
        PrivilegeLevel.Manager => "Manager",
        PrivilegeLevel.CleaningManager => "Cleaning Manager",
        PrivilegeLevel.Cleaner => "Cleaner",
        _ => throw new NotImplementedException(),
    };

    public static PrivilegeLevel ConvertFromString(this string privilegeLevel) => privilegeLevel switch {
        "Office" => PrivilegeLevel.Office,
        "Administrator" => PrivilegeLevel.Admin,
        "Manager" => PrivilegeLevel.Manager,
        "Cleaning Manager" => PrivilegeLevel.CleaningManager,
        "Cleaner" => PrivilegeLevel.Cleaner,
        _ => throw new ArgumentOutOfRangeException(nameof(privilegeLevel)),
    };
}
