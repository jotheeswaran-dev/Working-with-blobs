using System;
using Azure.Storage.Blobs;

namespace Working_with_blobs
{
    class Program
    {
        private static string _container_name = "dataone";
        private static string _connection_string = "DefaultEndpointsProtocol=https;AccountName=demostorageaccount1001;AccountKey=Zk345gT01Z+Kh+ZM4JejapnuYenCiJdOWA/fGvGiOUPO1lW1wq2m7kIbVTzng/KHm8mi33VYLGF/cG/7dqjymw==;EndpointSuffix=core.windows.net";


        static void Main(string[] args)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(_connection_string);
            blobServiceClient.CreateBlobContainer(_container_name);
            Console.ReadKey();
        }
    }
}
