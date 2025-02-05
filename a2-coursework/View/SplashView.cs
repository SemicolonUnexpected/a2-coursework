﻿using a2_coursework.Presenter;
using a2_coursework.Theming;
using a2_coursework.View.Interfaces;

namespace a2_coursework.View;

public partial class SplashView : Form, ISplash {
    private SplashPresenter? _presenter;

    public SplashView() {
        InitializeComponent();

        Theme();
        Theming.Theme.AppearanceThemeChanged += (s, e) => Theme();
    }

    public void SetPresenter(SplashPresenter presenter) {
        _presenter = presenter;
    }

    public void Theme() {
        BackColor = ColorScheme.CurrentTheme.Background;

        pnlProgress.BackColor = ColorScheme.CurrentTheme.Foreground;
    }

    /// <summary>
    /// The current displayed progress as a value between 0 and 1
    /// </summary>
    public double Progress {
        get {
            return (double)pnlProgress.Width / Width;
        }
        set {
            if (value < 0 || value > 1) throw new ArgumentOutOfRangeException(nameof(Progress), "Progress must be between 0 and 1");
            pnlProgress.Width = (int)(Width * value);
        }
    }
}
