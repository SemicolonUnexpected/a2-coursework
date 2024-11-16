using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter;
internal class SplashPresenter {
    private ISplash _view;
    public Task ShowLoading() => _view.StartLoading(5000);
    public void Close() => _view.Close();

    public SplashPresenter(ISplash view) {
        _view = view;
        _view.Show();
    }
}
