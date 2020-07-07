using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoAlbum
{
    class AlbumTest
    {
        static void Main(string[] args)
        {
            PhotoAlbum album1 = new PhotoAlbum(20);
            BigPhotoAlbum bigAlbum1 = new BigPhotoAlbum();

            Console.WriteLine(album1.GetNumberOfPages()); 
            Console.WriteLine(bigAlbum1.GetNumberOfPages());

        }
    }
}
