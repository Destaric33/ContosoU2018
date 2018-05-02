using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2018.Models.SchoolViewModels
{
    public class EnrollmentDateGroup
    {
        /*
         * This Class is considered to be a ViewModel. A view model allows you to shape
         * multiple entities into a single object, optimized for consumption and rendering
         * by the view. T
         * The purpose of the viewmodel is for the view to have a single object to render
         * 
         * */

            [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}
