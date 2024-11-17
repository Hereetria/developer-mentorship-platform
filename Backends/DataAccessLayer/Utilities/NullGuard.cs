using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Utilities
{
    public static class NullGuard
    {
        public static void CheckNull(params object[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                var paramName = parameters[i]?.GetType().GetProperties().FirstOrDefault()?.Name;

                if (parameters[i] == null)
                {
                    throw new ArgumentNullException(paramName, $"{paramName} cannot be null.");
                }
            }
        }
    }
}
