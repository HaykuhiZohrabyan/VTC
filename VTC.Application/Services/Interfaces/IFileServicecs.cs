using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTC.Data.Enums;
namespace VTC.Application.Services.Interfaces
{
    public interface IFileService
    {
        public void Upload(IFormFile file,FolderType type, string fileName);
        public bool CheckFolderExistingStatus(FolderType folderType);
    }
}
