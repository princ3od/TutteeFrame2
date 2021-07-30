using System.Collections.Generic;
using System.Threading.Tasks;
using TutteeFrame2.Model;
using TutteeFrame2.DataAccess;
using TutteeFrame2.View;

namespace TutteeFrame2.Controller
{
    class ScheduleController
    {
        public List<Subject> subject;
        readonly Schedule schedule;
        public string scheduleID;
        public List<Session> sessions;
        public List<Class> classes;
        public ScheduleController(Schedule schedule)
        {
            this.schedule = schedule;
        }
        public async void FetchData()
        {
            await Task.Delay(600);
            await Task.Run(() =>
            {
                subject = SubjectDA.Instance.GetSubjects();
            });
            schedule.GetSubject();
        }
        public async void GetSchedule(string lop, int hk, int nam)
        {
            //await Task.Delay(600);
            await Task.Run(() =>
            {
                scheduleID = ScheduleDA.Instance.GetSchedule(lop, hk, nam);
            });
            schedule.GetSchedule();
        }
        public async void FetchSchedule(string scheduleid)
        {
            //await Task.Delay(600);
            await Task.Run(() =>
            {
                sessions = ScheduleDA.Instance.GetSessions(scheduleid);
            });
            schedule.FetchSchedule();
        }
        public async void Add(Session s, string scheduleid)
        {
            await Task.Delay(600);
            await Task.Run(() =>
            {
                ScheduleDA.Instance.AddSession(s, scheduleid);
            });
        }
        public async void Detele(string id)
        {
            await Task.Delay(600);
            await Task.Run(() =>
            {
                ScheduleDA.Instance.Delete(id);
            });
        }
        public async void GetClass(string grade)
        {
            schedule.homeView.SetLoad(true, "Đang tải danh sách lớp...");
            await Task.Delay(600);
            await Task.Run(() =>
            {
                classes = ClassDA.Instance.GetClasses(grade);
            });
            schedule.AddClasses();
            schedule.homeView.SetLoad(false);
        }
    }
}
