using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
    public class AppProductVariableSearchTextService: IAppProductVariableSearchTextService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AppProductVariableSearchTextService(IUnitOfWork unitOfWork,
                                        IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<AppProductVariableSearchText>> GetAll()
        {

            var variables = await _unitOfWork.AppProductVariableSearchTextRepository.GetAll();

            return variables;
        }

        public async Task<List<AppProductVariableSearchText>> GetAllByListVariable(List<AppVariableSearchCompareQueryFilter> filter)
        {
            var filtered = await _unitOfWork.AppProductVariableSearchTextRepository.GetAllByListVariable(filter);


            return filtered;

        }

        public async Task<AppProductVariableSearchText> GetById(int id)
        {
            return await _unitOfWork.AppProductVariableSearchTextRepository.GetById(id);
        }

        public async Task<AppProductVariableSearchText> Insert(AppProductVariableSearchText appProductVariableSearchText)
        {


            await _unitOfWork.AppProductVariableSearchTextRepository.Add(appProductVariableSearchText);
            await _unitOfWork.SaveChangesAsync();
            return appProductVariableSearchText;
        }




        public async Task<AppProductVariableSearchText> Update(AppProductVariableSearchText appProductVariableSearchText)
        {

            var variables = await GetById(appProductVariableSearchText.Id);
            if (variables == null)
            {
                throw new Exception("Documento No existe");
            }

            _unitOfWork.AppProductVariableSearchTextRepository.Update(appProductVariableSearchText);
            await _unitOfWork.SaveChangesAsync();

            return await GetById(appProductVariableSearchText.Id);

        }

        public async Task<bool> Delete(int id)
        {
            await _unitOfWork.AppProductVariableSearchTextRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

    }
}
