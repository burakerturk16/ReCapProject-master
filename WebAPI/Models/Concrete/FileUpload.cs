using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Abstract;

namespace WebAPI.Models.Concrete
{
    public class FileUpload : IModel
    {
        public IFormFile files { get; set; }

    }
}
