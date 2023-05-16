Visual Studio

using System;
using project423.DTO;

namespace project423.Service
{
    public interface IProject423Service
    {
        void Create(Project423DTO data);
        void Update(Project423DTO data);
        void Delete(Guid id);
        Project423DTO GetById(Guid id);
    }
}