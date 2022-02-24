using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public interface IManagement
    {
        void Create(string[] vs);
        void Update(string[] vs);
        void Delete(string[] vs);
        void Read(string[] vs);
        void ReadAll(string[] vs);
    }
}
