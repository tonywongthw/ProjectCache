namespace HttpGetRandomImageWebAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? ImgName { get; set; }
        public bool IsLike { get; set; }
    }
}