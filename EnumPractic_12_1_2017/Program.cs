using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractic_12_1_2017
{
  class Program
  {

    public enum Cities
    {
      Benson = 1,
      Ajo = 7,
      Ash_Fork = 2,
      Apache_Junction = 3,
      Arizona_City = 4,
      Avondale = 5,
      Big_Water = 6,

    }

    // Converts and Enum to a List
    static void Main(string[] args)
    {
      List<string> citiesList = new List<string>();
      citiesList = Enum.GetNames(typeof(Cities)).ToList();
      Console.WriteLine(" Here we convert the enum of cites to list and print them");
      foreach (string cities in citiesList)
      {
        Console.WriteLine(cities);
        Console.ReadLine();
      }

      int cityNumber = (int)Cities.Ash_Fork * 2;
      Console.WriteLine(" Here we convert the number for Ash Fork to int and multiply it by two " + cityNumber);
      Console.ReadLine();

      Cities cityName = (Cities)cityNumber;
      Console.WriteLine(" Here we get the above number and find out what city it represents in the enum list by casting the int to a Cities enum " +
        cityName);
      Console.ReadLine();

      Console.WriteLine( " Here we are sorting the list before printing it. " );
      citiesList.Sort();
      foreach (string cities in citiesList)
      {
        Console.WriteLine(cities);
        Console.ReadLine();
      }
    }
  }
}

