﻿using System.Collections.Generic;
using CSharpFunctionalExtensions;
using ReactiveUI.Validation.Helpers;
using TestApp.Samples.Wizard.Pages;
using Zafiro.Avalonia.Model;

namespace TestApp.Samples.Wizard;

public class WizardSampleViewModel : ReactiveValidationObject
{
    public WizardSampleViewModel()
    {
        Wizard = new Zafiro.Avalonia.Model.Wizard(Pages);
    }

    private List<IWizardPage> Pages { get; } = new()
    {
        new WizardPageContainer(new FirstPageViewModel(), "Continue"),
        new WizardPageContainer(new SecondPageViewModel(), Maybe<string>.None),
    };

    public IWizard Wizard { get; }
}