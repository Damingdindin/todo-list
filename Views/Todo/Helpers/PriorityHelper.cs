using System;

namespace todolist.Helpers
{
    public static class PriorityHelper
    {
        public static string GetPriorityColor(string priority)
        {
            return priority switch
            {
                "Low" => "blue",
                "Medium" => "orange",
                "High" => "red",
                _ => "black" // 預設情況，處理未涵蓋的值
            };
        }
    }
}
