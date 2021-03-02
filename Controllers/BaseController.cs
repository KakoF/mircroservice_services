using System;
using System.Linq;
using System.Security.Claims;
using apiAuth.Models;
using Microsoft.AspNetCore.Mvc;

public abstract class BaseController : ControllerBase
{
  protected UserModel AuthUser()
  {
    UserModel user = new UserModel();
    user.Id = int.Parse(User.FindFirst(ClaimTypes.PrimarySid).Value);
    user.Role = User.FindFirst(ClaimTypes.Role).Value;
    return user;
  }
}