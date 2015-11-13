using System;
using System.ComponentModel;

namespace Charm.Core
{
    public static class EnumExtensions
    {
        public static string Description(this Enum e)
        {
            try
            {
                DescriptionAttribute[] da =
                    (DescriptionAttribute[])
                        (e.GetType().GetField(e.ToString()).GetCustomAttributes(typeof (DescriptionAttribute), false));
                return da.Length > 0 ? da[0].Description : e.ToString();
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
