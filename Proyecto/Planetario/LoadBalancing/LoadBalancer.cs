using System.Data.Common;
using Planetario.Data;

namespace Planetario.LoadBalancing;

public abstract class LoadBalancer
{
    public void SELECT(PlanetarioServer? planetarioServer)
    {
        if (planetarioServer != null)
        {

        }
    }
}