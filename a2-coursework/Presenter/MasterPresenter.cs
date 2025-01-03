﻿using a2_coursework.View.Interfaces;

namespace a2_coursework.Presenter; 
internal class MasterPresenter {
    private IMaster _view;

    public MasterPresenter(IMaster view) {
        _view = view;

        SetupBindings();
    }

    public void SetupBindings() {
        _view.FormClosed += CloseApplication;
    }

    private void CloseApplication(object? sender, EventArgs e) => Application.Exit();
}
