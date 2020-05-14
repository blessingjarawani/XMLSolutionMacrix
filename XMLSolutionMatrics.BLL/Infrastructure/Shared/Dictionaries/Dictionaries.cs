using System;
using System.Collections.Generic;
using System.Text;

namespace XMLSolutionMatrics.BLL.Infrastructure.Shared.Dictionaries
{
    public static class Dictionaries
    {
        public enum Town
        {
            Zlotow = 1,
            Poznan = 2,
            Warsaw = 3,
            Krakow = 4,
            Pila = 5,
        }

        public static Dictionary<int, string> PostalCodes = new Dictionary<int, string>()
        {
            { 1, "77-400" },
            { 2, "77-444" },
            { 3, "77-888" },
            { 4, "77-999" },
            { 5, "77-997" }
        };
    }
}
