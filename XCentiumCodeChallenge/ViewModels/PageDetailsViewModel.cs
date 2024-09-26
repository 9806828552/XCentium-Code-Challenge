using XCentiumCodeChallenge.Models;

namespace XCentiumCodeChallenge.ViewModels
{
    public class PageDetailsViewModel
    {
        public string pageUrl { get; set; }
        public List<Image> images { get; set; }
        public List<Word> words { get; set; }
    }
}
