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
    public partial class AddUpdateProblemViewModel : ObservableObject
    {
        [ObservableProperty]
        private Models.Problem _problemDetail = new Models.Problem();

        private readonly IProblemService _problemService;
        public AddUpdateProblemViewModel(IProblemService problemService)
        {
            _problemService = problemService;
        }

        [ICommand]
        public async void AddUpdateProblem()
        {
            int response;
            if (ProblemDetail.Id > 0)
            {
                response = await _problemService.UpdateProblem(ProblemDetail);
            }
            else
            {
                response = await _problemService.AddProblem(new Models.Problem
                {
                    Title = ProblemDetail.Title,
                    Description = ProblemDetail.Description,
                    PossibleSolution = ProblemDetail.PossibleSolution,
                });
            }

            if(response > 0)
            {
                await Shell.Current.DisplayAlert("Informazioni aggiornate", "Informazioni aggiornate", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Le informazioni non sono state salvate", "Qualcosa è andato storto", "OK");
            }
        }
    }
}
