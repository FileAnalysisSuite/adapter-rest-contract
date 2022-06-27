using Microsoft.AspNetCore.Mvc;

namespace AdapterSDK.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        [HttpGet]
        public string GetFileList(string dirName)
        {
            return $"List of files from directory {dirName}";
        }
    }
}
