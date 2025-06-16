using Microsoft.AspNetCore.Builder;

namespace NetBlueprints.BuildingBlocks.WebAPI;

public abstract class EndpointGroupBase
{
    public abstract void Map(WebApplication app);
}