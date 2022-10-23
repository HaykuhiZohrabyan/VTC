using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Application.Services.Interfaces;
using VTC.Data.Enums;

namespace VTC.Application.Services
{
    public class FileService : IFileService
    {
        public bool CheckFolderExistingStatus(FolderType folderType)
        {
            throw new NotImplementedException();
        }

        public void Upload(IFormFile file, FolderType type, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
