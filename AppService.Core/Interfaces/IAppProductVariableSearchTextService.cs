using AppService.Core.Entities;
using AppService.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface IAppProductVariableSearchTextService
    {


        Task<List<AppProductVariableSearchText>> GetAll();

        Task<List<AppProductVariableSearchText>> GetAllByListVariable(List<AppVariableSearchCompareQueryFilter> filter);

        Task<AppProductVariableSearchText> GetById(int id);

        Task<AppProductVariableSearchText> Insert(AppProductVariableSearchText appProductVariableSearchText);

        Task<AppProductVariableSearchText> Update(AppProductVariableSearchText appProductVariableSearchText);

        Task<bool> Delete(int id);


    }
}
