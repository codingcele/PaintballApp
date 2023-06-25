using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using PaintballApp.Models;
using PaintballApp.Services;
using PaintballApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintballApp.ViewModels
{
    public partial class ProblemsListPageViewModel : ObservableObject
    {
        public ObservableCollection<Problem> Problems { get; set; } = new ObservableCollection<Problem>();
        private readonly IProblemService _problemService;

        public ProblemsListPageViewModel(IProblemService problemService) 
        { 
            _problemService = problemService;
        }

        [ICommand]
        public async void GetProblemsList()
        {
            var problemsList = await _problemService.GetProblemsList();
            if (problemsList?.Count > 0) 
            {
                Problems.Clear();
                foreach(var problem in problemsList)
                {
                    Problems.Add(problem);
                }
            }
        }


        [ICommand]
        public async void AddUpdProblem()
        {
            await AppShell.Current.GoToAsync(nameof(AddUpdateProblem));
        }


        [ICommand]
        public async void DisplayAction(Problem selectedProblem)
        {
            var response = await AppShell.Current.DisplayActionSheet("Select Option", "OK", null, "Details", "Edit", "Delete");
            if (response == "Edit")
            {
                var navParam = new Dictionary<string, object>();
                navParam.Add("ProblemDetail", selectedProblem);
                await AppShell.Current.GoToAsync(nameof(AddUpdateProblem), navParam);
            }
            else if (response == "Delete")
            {
                var delResponse = await _problemService.DeleteProblem(selectedProblem);
                if (delResponse > 0)
                {
                    GetProblemsList();
                }
            }
            else
            {
                var navParam = new Dictionary<string, object>();
                navParam.Add("ProblemDetail", selectedProblem);
                await AppShell.Current.GoToAsync(nameof(ProblemDetails), navParam);
            }
        }
    }
}
