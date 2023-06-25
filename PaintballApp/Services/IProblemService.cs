using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintballApp.Services
{
    public interface IProblemService
    {
        Task<List<Models.Problem>> GetProblemsList();
        Task<int> AddProblem(Models.Problem problem);
        Task<int> DeleteProblem(Models.Problem problem);
        Task<int> UpdateProblem(Models.Problem problem);
    }
}
