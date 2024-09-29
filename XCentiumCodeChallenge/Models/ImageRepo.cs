using HtmlAgilityPack;

namespace XCentiumCodeChallenge.Models
{
    public class ImageRepo : IImageRepo
    {
        public List<Image> GetAllImages(string pageUrl)
        {
            List<Image> images = new List<Image>();

            var document = new HtmlWeb().Load(pageUrl);
           

            foreach (string imgPath in document.DocumentNode.Descendants("img")
                                            .Select(e => e.GetAttributeValue("src", null))
                                            .Where(s => !String.IsNullOrEmpty(s)))
            {
                images.Add(new Image() { ImageUrl = pageUrl + "/" + imgPath });
            }

            return images;
        }
    }
}
