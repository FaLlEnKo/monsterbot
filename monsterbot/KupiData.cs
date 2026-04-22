using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text;

namespace monsterbot
{
  public static class KupiData
  {
    public static KupiDataModel GetMonsterSales()
    {
      var psi = new ProcessStartInfo
      {
        FileName = "py",
        Arguments = "main.py",
        RedirectStandardOutput = true,
        UseShellExecute = false,
        CreateNoWindow = true,
        StandardOutputEncoding = Encoding.UTF8,
      };

      var process = Process.Start(psi);
      string result = process.StandardOutput.ReadToEnd();
      process.WaitForExit();

      string json = JsonConvert.DeserializeObject<string>(result);
      List<KupiDataModel> items = JsonConvert.DeserializeObject<List<KupiDataModel>>(json);
      var jsonRes = items.FirstOrDefault();

      return jsonRes;
    }
  }
}
