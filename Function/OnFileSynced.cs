using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage.Blob;

namespace GrubaIT.Webinar01
{
    public static class OnFileSynced
    {
        [FunctionName("OnFileSynced")]
        public static async Task Run([BlobTrigger("files/{name}", Connection = "webinar01storage_STORAGE")]CloudBlockBlob myBlob, string name, ILogger log)
        {
            using (MemoryStream blobStream = new MemoryStream())
            {
                await myBlob.DownloadToStreamAsync(blobStream);
                await myBlob.DeleteIfExistsAsync();
                byte[] blobBytes = blobStream.ToArray();

                DoSomeFurtherProcessing(log, blobBytes);
            }
        }

        private static void DoSomeFurtherProcessing(ILogger logger, byte[] incomingBlob)
        {
            logger.LogInformation($"Working on Blob with size: {incomingBlob.Length} Bytes. Doing stuff.");
        }
    }
}
