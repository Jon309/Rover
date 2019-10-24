using System.Data;
using System.Threading.Tasks;

namespace Rover.DataAccess
{
    public interface IConnectionFactory
    {
        IDbConnection ConnectRover();
    }
}