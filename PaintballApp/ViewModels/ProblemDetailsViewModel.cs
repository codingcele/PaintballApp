using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using PaintballApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintballApp.ViewModels
{
    [QueryProperty(nameof(ProblemDetail), "ProblemDetail")]
    public partial class ProblemDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private Models.Problem _problemDetail;
    }
}
