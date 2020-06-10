using LiteCommerce.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
    public interface ICountryDAL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Countries> List();
    }
}
