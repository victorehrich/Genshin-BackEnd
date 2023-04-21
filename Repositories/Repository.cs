using GenshinApplication.DataContext;
using GenshinApplication.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GenshinApplication.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly DataBaseContext _context;
        public Repository(DataBaseContext context)
        {
            _context = context;
        }
        //Needs to implement
        public string ConvertEnumToString<TEnum>(TEnum value) where TEnum : struct, Enum
        {
            var enumType = typeof(TEnum);
            if (!enumType.IsEnum)
            {
                throw new ArgumentException("Tipo genérico deve ser um enum");
            }
            var name = Enum.GetName(enumType, value);

            return name;
        }
    }
}
