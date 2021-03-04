using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Image
    {
        public IFormFile FormFiles { get; set; }
    }
}
