using System.Collections.Generic;
using System.Threading.Tasks;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;
using TutteeFrame2.View;

namespace TutteeFrame2.Controller
{
    class PunishmentController
    {
        public bool isLoading;
        public List<Punishment> punishments;
        List<Punishment> originalPunishments;
        public Dictionary<string, string> studentName;
        public Dictionary<string, string> studentClass;
        PunishmentView view;
        public PunishmentController(PunishmentView view)
        {
            this.view = view;
            studentName = new Dictionary<string, string>();
            studentClass = new Dictionary<string, string>();
        }
        public async void FetchData()
        {
            if (view.firstLoad)
            {
                await FetchClasses();
                view.firstLoad = false;
            }
            await FetchPunishments();
        }
        public async Task FetchPunishments()
        {
            if (isLoading)
                return;
            isLoading = true;
            view.Home.SetLoad(isLoading, "Đang tải danh sách kỉ luật...");
            studentClass.Clear();
            studentName.Clear();
            await Task.Run(() => originalPunishments = PunishmentDA.Instance.GetPunishments(view.classIDFilter, view.gradeFilter));
            if (originalPunishments == null)
                return;
            for (int i = 0; i < originalPunishments.Count; i++)
            {
                Student student = new Student();
                await Task.Run(() => student = StudentDA.Instance.GetStudentByID(originalPunishments[i].StudentID));
                if (student != null)
                {
                    studentClass.Add(originalPunishments[i].ID, student.ClassID);
                    studentName.Add(originalPunishments[i].ID, student.GetName());
                }
                else
                {
                    studentClass.Add(originalPunishments[i].ID, "");
                    studentName.Add(originalPunishments[i].ID, "");
                }
            }
            FilterSearch();
            isLoading = false;
            view.Home.SetLoad(isLoading);
        }

        public async Task FetchClasses()
        {
            view.Home.SetLoad(isLoading, "Đang tải danh sách kỉ luật...");
            List<Class> classes = new List<Class>();
            await Task.Run(() => classes = ClassDA.Instance.GetClasses(view.gradeFilter));
            view.ShowClasses(classes);
            isLoading = false;
            view.Home.SetLoad(isLoading);
        }
        public void FilterSearch(string searchParam = "")
        {
            if (string.IsNullOrEmpty(searchParam))
                punishments = originalPunishments;
            else
                punishments = GetPunishmentsBySearch(searchParam, originalPunishments);
            view.ShowData();
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
        List<Punishment> GetPunishmentsBySearch(string searchParam, List<Punishment> _origin)
        {
            List<Punishment> result = new List<Punishment>();
            foreach (Punishment punishment in _origin)
            {
                if (punishment.ID.Contains(searchParam) || studentClass[punishment.ID].Contains(searchParam)
                    || studentName[punishment.ID].Contains(searchParam))
                    result.Add(punishment);
            }
            return result;
        }
    }
}
