namespace Faker
{
    public class Image : FakerBase
    {
        public Image()
        { }
        public Image(LocaleType type) : base(type) { }

        // default static interface
        public static Image Default { get { return defaultValue; } }
        private static Image defaultValue = new Image();

        private string[] imageTypes = { "abstract", "animals", "business", "cats", "city", "food", "nightlife", "fashion", "people", "nature", "sports", "technics", "transport" };

        public string GetAvatarURL()
        {
            return Internet.Default.GetAvatarURL();
        }

        public string GetImageURL()
        {
            return this.GetImageURL(640, 480);
        }

        public string GetImageURL(ImageType type)
        {
            return this.GetImageURL(640, 480, type);
        }

        public string GetImageURL(int width, int height)
        {
            return string.Format("http://lorempixel.com/{0}/{1}", width, height);
        }

        public string GetImageURL(int width, int height, ImageType type)
        {
            return string.Format("http://lorempixel.com/{0}/{1}/{2}", width, height, imageTypes[(int)type]);
        }
    }

    public enum ImageType
    {
        Abstract,
        Animals,
        Business,
        Cats,
        City,
        Food,
        Nightlife,
        Fashion,
        Nature,
        Sports,
        Technics,
        Transport
    }
}
