using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleancodeDemo.DTO
{
    public class CustomerDiscountDTO
    {
        public decimal DiscountRate { get; set; }
        public decimal Price { get; set; }

        #region Properties
        private bool _isStudent, _isOfficer = false;
        public bool IsStudent
        {
            get { return _isStudent; }
            set { _isStudent = value; }
        }

        public bool IsOfficer
        {
            get { return _isOfficer; }
            set { _isOfficer = value; }
        }
        #endregion
    }
}
