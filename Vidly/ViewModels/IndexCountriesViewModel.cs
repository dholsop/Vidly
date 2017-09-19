using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.ServiceReturns1;

namespace Vidly.ViewModels
{
    public class IndexCountriesViewModel
    {
        public String Name { get; set; }
        public VATCountryDTO ForHeadings { get; set; }
        public List<VATCountryDTO> Countries { get; set; }
    }
}