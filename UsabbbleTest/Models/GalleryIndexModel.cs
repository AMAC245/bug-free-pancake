using System;
using System.Collections.Generic;


namespace UsabbbleTest.Models
{
    public class GalleryIndexModel
    {
        //CollectionExtensions of gallery images, prop is called image
        public IEnumerable<GalleryImage> Images { get; set; }
        public string SearchQuery { get; set; }
    }
}
