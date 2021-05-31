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
            await FetchClasses();
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
            await Task.Run(() => originalPunishments = PunishmentDA.Instance.GetPunishmentsByClass(view.classIDFilter));
            await Task.Run(() =>
            {
                foreach (Punishment punishment in originalPunishments)
                {
                    Student student = StudentDA.Instance.GetStudentByID(punishment.StudentID);
                    studentName.Add(punishment.ID, student.GetName());
                    studentClass.Add(punishment.ID, student.ClassID);
                }
            });
            punishments = originalPunishments;
            view.ShowData();
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
    }
}
