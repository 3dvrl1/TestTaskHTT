using AutoMapper;
using HTTTest.Infrastructure.Dto;

namespace HTTTest.Core.Configuration;
/// <summary>
/// Статический класс маппера
/// </summary>
public static class AutoMapperConfiguration
{
    public static Mapper CreateMapper()
    {
        return new Mapper(ConfigureMapper());
    }

    /// <summary>
    /// Метод для создания правил маппинга.
    /// </summary>
    /// <returns></returns>
    private static MapperConfiguration ConfigureMapper()
    {
        return new MapperConfiguration(config=>
        {
            config.CreateMap<Item, Entities.Item>();
            config.CreateMap<Category, Entities.Category>();
        });
    }
}