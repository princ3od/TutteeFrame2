using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;
using TutteeFrame2.View;

namespace TutteeFrame2.Controller
{
    class ClassController
    {
        ClassView view;
        public List<Class> classes;
        public ClassController(ClassView view)
        {
            this.view = view;
        }
        public async void FetchData()
        {
            if (view.firstLoad)
                view.firstLoad = false;
            view.Home.SetLoad(true, "Đang tải danh sách lớp...");
            await Task.Run(() => classes = ClassDA.Instance.GetClasses(view.gradeFilter));
            view.ShowData();
            view.Home.SetLoad(false);
        }
        public async void DeleteClass(string classID)
        {
            view.Home.SetLoad(true, "Đang xoá vi phạm...");
            await Task.Run(() => classID = ClassDA.Instance.DeletedClass(classID));
            if (classID == null)
                view.ShowDeleteResult(TeacherController.DeleteResult.Fail);
            else
                view.ShowDeleteResult(TeacherController.DeleteResult.Success);
            view.Home.SetLoad(false);
        }
    }
}
