using ChartSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartSystem.Data
{
    public class Repository
    {
        private readonly ChartDBEntities enitiy;

        public Repository()
        {
            enitiy = new ChartDBEntities();
        }
         
    }
}
