using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace KnowYourCustomer.Framework.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            try
            {
                var name = enumValue.GetType()
                    .GetMember(enumValue.ToString())
                    .First()
                    .GetCustomAttribute<DisplayAttribute>()
                    .GetName();

                return name;
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public static IEnumerable<SelectListItem> GetEnumAsSelectList<T>(this Enum e) where T : Enum
        {
            var items = new List<SelectListItem>();

            var enumValues = Enum.GetValues(e.GetType());

            for (var i = 0; i < enumValues.Length; i++)
            {
                var value = (T)enumValues.GetValue(i);

                items.Add(new SelectListItem
                {
                    Value = value.ToString(),
                    Text = string.IsNullOrWhiteSpace(value.GetDisplayName()) ? value.ToString() : value.GetDisplayName()
                });
            }

            return new SelectList(items, "Value", "Text");
        }
    }
}
