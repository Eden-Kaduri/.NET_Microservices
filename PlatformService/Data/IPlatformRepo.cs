using PlatformService.Models;
using System.Collections.Generic;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatforms();
        void CreatePlatform(Platform platform);
        Platform GetPlatformById(int id);
    }
}
