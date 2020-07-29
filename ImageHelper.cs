using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;


namespace SagaUtil
{
    public static class ImageHelper
    {
        public static byte[] DownloadImage(string fromUrl)
        {
            WebClient webClient = new WebClient();
            byte[] data = webClient.DownloadData(fromUrl);
            return data;
        }
    }
}
