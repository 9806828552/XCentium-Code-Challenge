namespace XCentiumCodeChallenge.Models
{
    public interface IWordRepo
    {
        List<Word> GetWordsDetails(string pageUrl);
       
    }
}
