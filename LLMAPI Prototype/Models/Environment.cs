using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLMAPI_Prototype.Models
{
    internal static class Environment
    {
        public static string apiKey = "AIzaSyAWQFXjZ0_WCjotztQTI2Q0-x7JbDUXzKU";
        public static string apiUrl = "https://api.openai.com/v1/chat/completions";
        public static string model = "gpt-4o";
        public static int maxTokens = 8000;
        public static double temperature = 0.7;
        public static int topP = 1;

    }
}
