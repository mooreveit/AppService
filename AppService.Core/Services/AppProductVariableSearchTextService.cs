// Decompiled with JetBrains decompiler
// Type: AppService.Core.Services.AppProductVariableSearchTextService
// Assembly: AppService.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A79E0FDF-34BB-4EE9-A48B-958643556925
// Assembly location: D:\Moore\Publish\AppService.Core.dll

using AppService.Core.Entities;
using AppService.Core.Interfaces;
using AppService.Core.QueryFilters;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppService.Core.Services
{
  public class AppProductVariableSearchTextService : IAppProductVariableSearchTextService
  {
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public AppProductVariableSearchTextService(IUnitOfWork unitOfWork, IMapper mapper)
    {
      this._unitOfWork = unitOfWork;
      this._mapper = mapper;
    }

    public async Task<List<AppProductVariableSearchText>> GetAll() => await this._unitOfWork.AppProductVariableSearchTextRepository.GetAll();

    public async Task<List<AppProductVariableSearchText>> GetAllByListVariable(
      List<AppVariableSearchCompareQueryFilter> filter)
    {
      return await this._unitOfWork.AppProductVariableSearchTextRepository.GetAllByListVariable(filter);
    }

    public async Task<AppProductVariableSearchText> GetById(int id) => await this._unitOfWork.AppProductVariableSearchTextRepository.GetById(id);

    public async Task<AppProductVariableSearchText> Insert(
      AppProductVariableSearchText appProductVariableSearchText)
    {
      await this._unitOfWork.AppProductVariableSearchTextRepository.Add(appProductVariableSearchText);
      await this._unitOfWork.SaveChangesAsync();
      return appProductVariableSearchText;
    }

    public async Task<List<AppProductVariableSearchText>> AddRange(
      List<AppProductVariableSearchText> appProductVariableSearchText)
    {
      await this._unitOfWork.AppProductVariableSearchTextRepository.AddRange(appProductVariableSearchText);
      await this._unitOfWork.SaveChangesAsync();
      return appProductVariableSearchText;
    }

    public async Task<AppProductVariableSearchText> Update(
      AppProductVariableSearchText appProductVariableSearchText)
    {
      if (await this.GetById(appProductVariableSearchText.Id) == null)
        throw new Exception("Documento No existe");
      this._unitOfWork.AppProductVariableSearchTextRepository.Update(appProductVariableSearchText);
      await this._unitOfWork.SaveChangesAsync();
      return await this.GetById(appProductVariableSearchText.Id);
    }

    public async Task<bool> Delete(int id)
    {
      await this._unitOfWork.AppProductVariableSearchTextRepository.Delete(id);
      await this._unitOfWork.SaveChangesAsync();
      return true;
    }

    public async Task<bool> DeleteByRange(
      List<AppProductVariableSearchText> appProductVariableSearchText)
    {
      await this._unitOfWork.AppProductVariableSearchTextRepository.DeleteByRange(appProductVariableSearchText);
      await this._unitOfWork.SaveChangesAsync();
      return true;
    }
  }
}
