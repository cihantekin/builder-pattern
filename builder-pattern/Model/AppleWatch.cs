namespace builder_pattern.Model
{
    public class AppleWatch
    {
        public string Size { get; set; } = new("");
        public string Type { get; set; } = new("");
        public string Color { get; set; } = new("");
        public string StrapSize { get; set; } = new("");
        public string StrapType { get; set; } = new("");
        public string StrapColor { get; set; } = new("");

        public string GetWatchSummary() => $"Apple Watch {Size} {Type} {Color}. Strap choice: {StrapSize} {StrapType} {StrapColor} ";
    }
}
