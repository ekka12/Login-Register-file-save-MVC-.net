namespace DAL;
using BOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public class UserIoManage{

      public List<User> GetAll(){
         string path = @"C:\Users\MACBAY\Desktop\.Net\Practice12\TFLStore\wwwroot\User.Json";
         List<User>ulist=Load(path);
         return ulist;
      }

      public bool AddReg(string email,string password,string role){
        string path = @"C:\Users\MACBAY\Desktop\.Net\Practice12\TFLStore\wwwroot\User.Json";
        User u=new User{Uname=email,Password=password,Role=role};
        List<User>ulist=new List<User>();
        ulist.Add(u);
        save(path,ulist); 
        // List<User>ulist = Load(path);
        // ulist.Add(new User{Uname=email,Password=password,Role=role});
        // Console.WriteLine("UserIOMAnge1");
        // save(path,ulist);
        // Console.WriteLine("UserIOMAnge2");
        return true;

      }

      public bool save(string path,List<User>user){
        bool status = false;
      try{string jsonstr =JsonSerializer.Serialize(user);
        File.WriteAllText(path,jsonstr);
        status = true;
         }catch(Exception e){
            Console.WriteLine(e.Message);
         }
        
        return status; 
      }

      public List<User> Load(string path){
        string jsonstr = File.ReadAllText(path);
        List<User>ulist=JsonSerializer.Deserialize<List<User>>(jsonstr);
        return ulist;
      }

         
      
}

