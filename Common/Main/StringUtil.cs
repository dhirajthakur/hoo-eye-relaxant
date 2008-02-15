using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hush.Common {
    public class StringUtil {

        /// <summary>
        /// Generate one sentence with parameters
        /// </summary>
        /// <param name="text">Main sentence with some parameters. There are at most 9 different parameters from "%1" to "%9".</param>
        /// <param name="args">A variant array of parameters</param>
        /// <returns></returns>
        public static string Join(String text, params object[] args) {
            String result = text;
            int count = args.Length;
            for (int i = 1; i <= count; i++) {
                result = result.Replace("%" + i.ToString(), args[i-1].ToString());
            }
            return result;
        }
    }
}
