using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Griz.Core
{
	public interface IEntity<TKey>
	{
		TKey Id { get; set; }
	}
}
