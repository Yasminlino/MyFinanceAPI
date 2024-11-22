using System;
using MongoDB.Bson;
using MyFinanceAPI.Application.DTO;
using MyFinanceAPI.Domain.Entities;

namespace MyFinanceAPI.Application.Interfaces;

public interface ICategoryService
{
    Task Add(CategoryDTO categoryDTO);
    Task<IEnumerable<CategoryDTO>> GetCategories();
    Task<CategoryDTO> GetCategoryById(ObjectId id);
    Task Update(CategoryDTO categoryDTO);
    Task Remove(CategoryDTO categoryDTO);
}
