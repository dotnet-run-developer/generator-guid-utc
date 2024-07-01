using System;
using TextCopy;

namespace Guid_app
{
  internal abstract class Program
  {
    [STAThread]
    private static void Main()
    {
      while (true)
      {
        Console.WriteLine("Do you want to generate GUID or Date Time UTC? (1-Guid, 2-DateTime)");
        var input = Console.ReadLine()?.ToLower();

        if (input == "1")
        {
          var newGuid = Guid.NewGuid().ToString();
          ClipboardService.SetText(newGuid);
          Console.WriteLine($"New GUID generated and copied to clipboard: {newGuid}");
        }
        else if (input == "2")
        {
          var dateTimeUtc = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
          ClipboardService.SetText(dateTimeUtc);
          Console.WriteLine($"Date Time UTC generated and copied to clipboard: {dateTimeUtc}");
        }
        else
        {
          Console.WriteLine("Invalid input. Please type '1' or '2'.");
          break;
        }
      }
    }
  }
}