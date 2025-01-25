using a2_coursework.View.Interfaces; 

namespace a2_coursework.Presenter; 
public class PersonalInformationSettingsPresenter {
    private IPersonalInformationSettings _view;

    public PersonalInformationSettingsPresenter(IPersonalInformationSettings view) {
        _view = view;
    }

    private bool UpdateStaffNames(int staffId, string forename, string username, out string? errorMessage) {
        throw new NotImplementedException();
    }
}
