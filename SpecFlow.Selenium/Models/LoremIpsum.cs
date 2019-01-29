namespace SpecFlow.Selenium.Models
{
    public class LoremIpsum
    {
        public string Amount { get; set; }
        public TextGenerationType TextGenerationType { get; set; }
        public bool StartWithDefaultText { get; set; }
        public string DefaultText { get; } = "Lorem ipsum dolor sit amet";
    }

    public enum TextGenerationType
    {
        Paras,
        Words,
        Bytes,
        Lists
    }
}