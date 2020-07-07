using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoAlbum
{
    class PhotoAlbum
    {

        protected int numberOfPages { get; set; }

        public PhotoAlbum(int n)
        {
           numberOfPages = n;
        }

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages; 
        }

    }
}
