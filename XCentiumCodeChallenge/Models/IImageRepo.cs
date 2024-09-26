namespace XCentiumCodeChallenge.Models
{
    public interface IImageRepo
    {
        List<Image> GetAllImages(string pageUrl);
        
    }
}
