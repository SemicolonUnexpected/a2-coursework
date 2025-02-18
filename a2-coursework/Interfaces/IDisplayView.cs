using System.ComponentModel;

namespace a2_coursework.Interfaces;
public interface IDisplayView<TDisplayModel> : IView where TDisplayModel : INotifyPropertyChanged {
    public void DisplayItems(BindingList<TDisplayModel> items);
}
