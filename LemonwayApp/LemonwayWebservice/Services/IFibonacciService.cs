using System.Threading.Tasks;

namespace LemonwayWebservice.Services
{
    public interface IFibonacciService
    {
        Task<int?> FibonacciAsync(int n);
    }
}