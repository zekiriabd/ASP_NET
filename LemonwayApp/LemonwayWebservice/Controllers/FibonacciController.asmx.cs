using LemonwayWebservice.Services;
using log4net;
using System;
using System.Web.Script.Services;
using System.Web.Services;

namespace LemonwayWebservice
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class FibonacciController : System.Web.Services.WebService
    {
        FibonacciService fibonacciService = new FibonacciService();
        private static readonly ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int? Fibonacci(int n)
        {
            Log.Debug("Call FibonacciAsync");
            try
            {
                Log.Info("Call FibonacciAsync");
                return fibonacciService.FibonacciAsync(n).Result;
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
