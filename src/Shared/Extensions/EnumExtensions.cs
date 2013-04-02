using System;
using System.ComponentModel;
using System.Linq;

namespace ViperSoft.Saturn.Shared.Extensions
{
    public static class EnumExtensions
    {
         public static string GetDescription(this Enum enumValue)
         {
             var descriptionAttribute =
                 enumValue.GetType().GetCustomAttributes(typeof (DescriptionAttribute), true).SingleOrDefault() as DescriptionAttribute;

             string returnValue = null;

             if (descriptionAttribute != null)
             {
                 returnValue = descriptionAttribute.Description;
             }

             return returnValue;
         }
    }
}