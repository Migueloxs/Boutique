using BoutiqueWebAppSol.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueWebAppSol.Data.Interfaces
{
    public interface IWebRepository
    {

        bool AddWeb(Web web);
    }
}
