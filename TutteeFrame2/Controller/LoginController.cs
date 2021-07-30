using System.Threading.Tasks;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;
using TutteeFrame2.Utils;
using TutteeFrame2.View;

namespace TutteeFrame2.Controller
{
    class LoginController
    {
        bool establishConnection = false;
        readonly LoginView view;
        Account loginAccount;
        public string teacherID;
        public string sessionID;
        public bool logined = false;

        public LoginController(LoginView view)
        {
            this.view = view;
        }
        public async void Login()
        {
            if (!establishConnection)
            {
                view.SetLoading(true, "Đang kết nối đến server...");
                await Task.Delay(500);
                await Task.Run(ConnectToServer);
            }

            if (!establishConnection)
            {
                view.SetLoading(false);
                view.LoginFail(LoginView.LoginFailReason.NoConnection);
            }
            else
            {
                view.SetLoading(true, "Đang đăng nhập...");
                bool success = false;
                LoginView.LoginFailReason failReason = LoginView.LoginFailReason.WrongPassword;

                await Task.Delay(500);
                await Task.Run(() =>
                {
                    loginAccount = view.GetLoginedAccount();

                    Account returnAccount = AccountDA.Instance.GetAccount(loginAccount.TeacherID);

                    if (returnAccount == null)
                        failReason = LoginView.LoginFailReason.InvalidID;
                    else
                    {
                        if (PasswordHasher.Verify(loginAccount.Password, returnAccount.Password))
                        {
                            success = true;
                            string sessionID = IdentifierFactory.GenerateID(length: 10);
                            sessionID = SessionDA.Instance.CreateSession(loginAccount.TeacherID, sessionID);
                            this.sessionID = sessionID;
                            if (string.IsNullOrEmpty(sessionID))
                            {
                                success = false;
                                failReason = LoginView.LoginFailReason.UnbleToCreateSession;
                            }
                        }
                        else
                            failReason = LoginView.LoginFailReason.WrongPassword;
                    }

                });

                view.SetLoading(false);
                if (success)
                    view.LoginSuccess();
                else
                    view.LoginFail(failReason);

            }
        }
        void ConnectToServer()
        {
            if (AppSettings.Instance.ConnectionType == ConnectionType.Local)
                establishConnection = BaseDA.Instance.CreateLocalConnect();
            else
                establishConnection = BaseDA.Instance.CreateConnect(
                    ServerSettings.Instance.ServerName, ServerSettings.Instance.Port.ToString(), ServerSettings.Instance.UserID, ServerSettings.Instance.Password);
        }
    }
}
