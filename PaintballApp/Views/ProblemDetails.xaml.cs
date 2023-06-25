using PaintballApp.ViewModels;

namespace PaintballApp.Views;

public partial class ProblemDetails : ContentPage
{
    public ProblemDetails(ProblemDetailsViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}