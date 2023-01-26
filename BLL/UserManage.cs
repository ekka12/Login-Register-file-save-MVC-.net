using BOL;
using DAL;
namespace BLL;

public class UserManage{
    public static UserManage instance=null;

    public static UserManage GetManage(){
        if(instance==null){
            instance=new UserManage();
        }
        return instance;
    }

    public List<User>GetAllUser(){
        UserIoManage mgr = new UserIoManage();
        return mgr.GetAll();
    }

    public bool AddReg(string email,string password,string role){
        UserIoManage mgr = new UserIoManage();
        return mgr.AddReg(email,password,role);
    }
}