using System;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart
{
 public class CurrentDateTimeController : Controller
 {
 [HttpGet("/")]
 public object Get() => DateTime.UtcNow;
 }
}