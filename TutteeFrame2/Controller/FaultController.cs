using MaterialSurface;
using System.Collections.Generic;
using System.Threading.Tasks;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;
using TutteeFrame2.View;

namespace TutteeFrame2.Controller
{
    class FaultController
    {
        FaultView view;
        public bool isLoading;
        public List<Punishment> punishments = new List<Punishment>();
        public Dictionary<string, string> studentName = new Dictionary<string, string>();

        public FaultController(FaultView _view)
        {
            view = _view;
        }

        public async Task FetchFault()
        {
            if (isLoading)
                return;
            isLoading = true;
            view.Home.SetLoad(isLoading, "Đang tải danh sách vi phạm...");
            await Task.Run(() =>
            {
                punishments = PunishmentDA.Instance.GetPunishments(view.mainTeacher.FormClassID, view.mainTeacher.FormClassID.Substring(0, 2));
                if (punishments == null)
                {
                    Dialog.Show(view.Home, "Đã có lỗi xảy ra, vui lòng thử lại!", "Lỗi");
                    return;
                }
                for (int i = 0; i < punishments.Count; i++)
                {
                    if (studentName.ContainsKey(punishments[i].StudentID))
                        continue;
                    Student student = new Student();
                    student = StudentDA.Instance.GetStudentByID(punishments[i].StudentID);
                    if (student != null)
                    {
                        studentName.Add(student.ID, student.GetName());
                    }
                    else
                    {
                        studentName.Add(punishments[i].StudentID, "");
                    }
                }
            });
            view.ShowData();
            isLoading = false;
            view.Home.SetLoad(isLoading);
        }

        public async void DeletePunishment(string punishmentID)
        {
            view.Home.SetLoad(true, "Đang xoá vi phạm...");
            await Task.Run(() => punishmentID = PunishmentDA.Instance.DeletePunishment(punishmentID));
            if (punishmentID == null)
                view.ShowDeleteResult(TeacherController.DeleteResult.Fail);
            else
                view.ShowDeleteResult(TeacherController.DeleteResult.Success);
            view.Home.SetLoad(false);
        }
    }
}
