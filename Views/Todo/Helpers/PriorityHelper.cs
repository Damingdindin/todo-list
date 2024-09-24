namespace todolist.Helpers
{
    public static class PriorityHelper
    {
        public static string GetPriorityColor(string priority)
        {
            return priority switch
            {
                "High" => "red",
                "Medium" => "orange",
                "Low"=> "green",
            };
        }
    }
}
