namespace ImmutableObjectGraph.Generation
{
    using System;
    using System.Collections.Generic;
    //using System.Data.Entity.Design.PluralizationServices;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Validation;
    using Humanizer;

    internal static class Utilities
    {
        //internal static readonly PluralizationService PluralizationService = PluralizationService.CreateService(CultureInfo.GetCultureInfo("en-US"));

        internal static string ToPascalCase(this string name)
        {
            Requires.NotNullOrEmpty(name, "name");

            if (name.StartsWith("@"))
                return "@" + name.Substring(1, 1).ToUpperInvariant() + name.Substring(2);
            return name.Substring(0, 1).ToUpperInvariant() + name.Substring(1);
        }

        internal static string ToCamelCase(this string name)
        {
            Requires.NotNullOrEmpty(name, "name");
            if (name.StartsWith("@"))
                return "@" + name.Substring(1, 1).ToLowerInvariant() + name.Substring(2);
            return name.Substring(0, 1).ToLowerInvariant() + name.Substring(1);
        }

        internal static string ToPlural(this string word)
        {
            //return PluralizationService.Pluralize(word);
            return word.Pluralize(false);
        }

        internal static string ToSingular(this string word)
        {
            //return PluralizationService.Singularize(word);
            return word.Singularize(false);
        }

        internal static string ToSafeName(this string identifier)
        {
            return (CodeGen.IsKeyword(identifier) ? "@" : "") + identifier;
        }

        internal static TTo To<TFrom, TTo>(this TFrom obj, Func<TFrom, TTo> action)
        {
            return action.Invoke(obj);
        }
    }
}
