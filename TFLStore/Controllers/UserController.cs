using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TFLStore.Models;
using SAL;
using BOL;
namespace TFLStore.Controllers;

public class UserController : Controller{
    private readonly  ILogger<UserController>_Logger;

    public UserController(ILogger<UserController>logger){
           
           _Logger=logger;
    }

    [HttpGet]
    public IActionResult Login(){
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email,string Password){
         UserService us = new UserService();
         List<User> ulist = us.GetAll();
         foreach(User u in ulist){
            if(u.Uname.Equals(email) && u.Password.Equals(Password)){
                return RedirectToAction("Index","Home");
            }
         }

         return View();

         
        
    }

   [HttpGet]
   public IActionResult Register(){
       return View();
   }

   [HttpPost]
   public IActionResult Register(string email,string password,string role){
        UserService us = new UserService();
        Console.WriteLine(email);
        bool status = us.AddRegister(email,password,role);
        Console.WriteLine(status);
        if(status){
            return RedirectToAction("Login","User");
        }

        return View();
   }   
}
