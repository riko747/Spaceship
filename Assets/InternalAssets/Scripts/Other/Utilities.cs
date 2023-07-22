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
    }
}
