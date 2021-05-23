using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;

namespace TutteeFrame2.Controller
{
    class ClassController
    {
        public bool AddClass(Class _class)
        {
            return ClassDA.Instance.AddClass(_class);
        }
        public bool DeleteClass(string classID)
        {
            return ClassDA.Instance.DeletedClass( classID);
        }
        public bool UpdateClassInfo(Class _class)
        {
            return ClassDA.Instance.UpdateClassInfo(_class);
        }
        public List<Class> GetClasses()
        {
            return ClassDA.Instance.GetClasses();
        }
    }
}
