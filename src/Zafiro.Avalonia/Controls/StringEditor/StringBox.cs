using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation.Extensions;
using ReactiveUI.Validation.Helpers;

namespace Zafiro.Avalonia.Controls.StringEditor;

public class StringBox : ReactiveValidationObject, IModel
{
    public StringBox(string str)
    {
        Text = str;
    }

    [Reactive]
    public string Text { get; set; }

    public IObservable<bool> IsValid => this.IsValid();
}