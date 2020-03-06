using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;


namespace Explosive.Contollers
{
  [Route("api/[controller]")]
  [ApiController]

  public class MumblingController : ControllerBase
  {
    [HttpGet]
    public string Mumbling(string s)
    {




      var timesToRepeatTheLetter = 1;
      var answerString = "";

      foreach (var letter in s)
      {

        for (var i = 0; i < timesToRepeatTheLetter; i++)
        {
          if (i == 0)
          {
            answerString += letter.ToString().ToUpper();
          }
          else
          {
            answerString += letter;
          }
        }
        answerString += "-";
        timesToRepeatTheLetter++;
      }
      return answerString.TrimEnd('-');
    }
  }

}


