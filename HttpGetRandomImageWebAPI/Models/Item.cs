namespace HttpGetRandomImageWebAPI.Models
{
    public class Item
    {
        public long Id { get; set; }
        public string? ImgName { get; set; }
        public bool IsLike { get; set; }
    }
}