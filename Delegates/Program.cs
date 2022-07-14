using Delegates;

void RemoveRedEyeFilter(Photo photo)
{
    Console.WriteLine("Apply remove red eye.");
}

var photoProcessor = new PhotoProcessor();
var filters = new PhotoFilters();

Action<Photo> filterHandler = filters.ApplyBrightness;
filterHandler += filters.ApplyContrast;
filterHandler += filters.Resize;
filterHandler += RemoveRedEyeFilter;

photoProcessor.Process("photo.jpg", filterHandler);