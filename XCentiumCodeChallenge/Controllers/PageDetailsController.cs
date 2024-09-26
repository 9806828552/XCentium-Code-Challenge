using Microsoft.AspNetCore.Mvc;
using XCentiumCodeChallenge.Models;

namespace XCentiumCodeChallenge.Controllers
{
    public class PageDetailsController : Controller
    {
        private readonly IImageRepo imageRepo;
        private readonly IWordRepo wordRepo;

        // initializing objects
        public PageDetailsController(IImageRepo _imageRepo, IWordRepo _wordRepo)
        {
            imageRepo = _imageRepo;
            wordRepo = _wordRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        // fetch all the images, Keep in partial view and return to index page
        [HttpPost]
        public IActionResult GetImages(string pageUrl) 
        {
            List<Image> images = new List<Image>();
            images = imageRepo.GetAllImages(pageUrl);

            return PartialView("ImageSliderPartial",images);
        }

        // fetch all the words, Keep in partial view and return to index page
        [HttpPost]
        public IActionResult GetWordsInfo(string pageUrl)
        {
            List<Word> words = new List<Word>();
            words = wordRepo.GetWordsDetails(pageUrl);

            return PartialView("WordsInfoPartial", words);
        }
        
    }
}
