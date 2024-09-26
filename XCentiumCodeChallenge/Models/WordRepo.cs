using HtmlAgilityPack;

namespace XCentiumCodeChallenge.Models
{
    public class WordRepo : IWordRepo
    {
        public List<Word> GetWordsDetails(string pageUrl)
        {
            List<Word> words = new List<Word>();
            var document = new HtmlWeb().Load(pageUrl);
            var fulltext = document.DocumentNode.InnerText.Replace("\n", " ").Replace("\r", " ").Replace("|", " ").Replace("  ", " ").Replace(" ", "|").Replace("||", "|");
            string[] allwords = fulltext.Split("|");

            var filteredWords = allwords.Select(x=>x.Trim()).Where(x=> x!=null && x!="").GroupBy(x => x).OrderByDescending(x => x.Count()).Take(10);

            filteredWords.ToList().ForEach(x =>
                words.Add(new Word() { value = x.Key, occurence = x.Count() })
            );
            return words;

        }
    }
}
