using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HyggeAssignment5
{
    public class ParamArgs
    {

        public ParamArgs(string paramID, object val)
        { ParamID = paramID; Value = val; }

        public string ParamID { get; set; } 
        public object Value { get; set; }   

        }
}