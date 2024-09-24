namespace todolist.Models
{
    public class Todo
    {
        public int Id { get; set; }  // 唯一標識符，用於標識每一個待辦事項
        public string Task { get; set; } = string.Empty; // 待辦事項的描述
        public bool IsCompleted { get; set; }  // 是否完成該事項的狀態
        public string Priority { get; set; } = "Low"; // 新增的 Priority 屬性
    }
}
