using System.Linq;
using Core.Models;

namespace Core.Helpers
{
    public class PropertyCopier<TSource, TDestination> where TSource : BaseEntity
                                                where TDestination : BaseEntity
    {
        public static void Copy(TSource source, TDestination destination, bool skipBaseEntityProperties = true, params string[] ignoredProperties)
        {
            var sourceProperties = source.GetType().GetProperties();
            var destinationProperties = destination.GetType().GetProperties();

            foreach (var sourceProperty in sourceProperties)
            {
                if (skipBaseEntityProperties && (sourceProperty.Name == "Id" || sourceProperty.Name == "Created"))
                    continue;
                    
                foreach (var destinationProperty in destinationProperties)
                {
                    if (sourceProperty.Name == destinationProperty.Name && sourceProperty.PropertyType == destinationProperty.PropertyType)
                    {
                        if (ignoredProperties.Contains(destinationProperty.Name))
                        {
                            continue;
                        }
                        
                        destinationProperty.SetValue(destination, sourceProperty.GetValue(source));
                        break;
                    }
                }
            }
        }
    }
}