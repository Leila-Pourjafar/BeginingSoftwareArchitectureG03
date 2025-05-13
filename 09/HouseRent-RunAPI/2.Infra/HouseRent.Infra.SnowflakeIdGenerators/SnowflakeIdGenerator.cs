using HouseRent.Core.ApplicationServices.Contracts;
using IdGen;

namespace HouseRent.Infra.SnowflakeIdGenerators;

public class SnowflakeIdGenerator(IdGen.IdGenerator generator) : Core.ApplicationServices.Contracts.IIdGenerator<long>
{
    private readonly IdGen.IdGenerator _generator = generator;

    public long GetId()
    {
        return _generator.CreateId();
    }
}
