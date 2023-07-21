using System.Collections.Generic;
using System.Linq;
using TMPro;

namespace InternalAssets.Scripts.Other
{
    public static class Utilities
    {
        public static void AddNewDropDownOption(TMP_Dropdown dropdown, string optionText)
        {
            var newOption = new TMP_Dropdown.OptionData(optionText);
            dropdown.options.Add(newOption);
        }

        public static Enums.Items FindCurrentOptionIndex(string option, Dictionary<Enums.Items, bool> items)
        {
            return items.Where(pair => pair.Value.ToString() == option).Select(pair => pair.Key).FirstOrDefault();
        }
    }
}
