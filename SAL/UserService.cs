namespace SAL;
using BOL;
using BLL;

public class UserService{
    public List<User> GetAll(){
        UserManage mgr=UserManage.GetManage();
        return mgr.GetAllUser();
    }
    public bool AddRegister(string email,string password,string role){
        UserManage mgr = UserManage.GetManage();
        return mgr.AddReg(email,password,role);
    }
}