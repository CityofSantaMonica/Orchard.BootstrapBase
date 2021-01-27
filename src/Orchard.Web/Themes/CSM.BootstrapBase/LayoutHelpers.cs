using System;
using System.Linq;

namespace CSM.BootstrapBase
{
    public class LayoutHelpers
    {
        public static string CalcuClassify(dynamic model, string[] zoneNames, string classNamePrefix)
        {
            var zoneCounter = 0;
            var zoneNumsFilled = string.Join("", zoneNames.Select(zoneName => { ++zoneCounter; return model[zoneName] != null ? zoneCounter.ToString() : ""; }).ToArray());
            return HasText(zoneNumsFilled) ? classNamePrefix + zoneNumsFilled : "";
        }

        public static bool HasItems(dynamic model)
        {
            return model != null && model.Items != null && model.Items.Count > 0;
        }

        public static bool HasText(object thing)
        {
            return !String.IsNullOrWhiteSpace(Convert.ToString(thing));
        }
    }
}