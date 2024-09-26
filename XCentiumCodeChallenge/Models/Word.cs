using System.ComponentModel.DataAnnotations;

namespace XCentiumCodeChallenge.Models
{
    public class Word
    {
      
        [Display(Name = "Word")]
        public string value { get; set; }

        [Display(Name = "Occurence")]
        public int occurence { get; set; }
    }
}
