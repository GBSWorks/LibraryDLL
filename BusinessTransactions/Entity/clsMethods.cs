using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessTransactions.Entity
{
    public class Parameters
    { 
        public string FieldName { get; set; }
        public string DataType { get; set; }
        public int Length { get; set; }
    }
    public class clsMethods
    {
        public string MethodName { get; set; }
        public string Description { get; set; }
        public List<Parameters> Parameters { get; set; }            
    }
}
