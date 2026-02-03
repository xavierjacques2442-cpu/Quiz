using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Quiz.Controllers;

namespace Quiz.Serivces
{
    public class SerivceOne
    {
   private string Add2Numbers(int number1, int number2)
        {
           var sum = number1 + number2;
          return $"You put {number1} and {number2} and you add them togeather to get {sum}";
        }
    }
}