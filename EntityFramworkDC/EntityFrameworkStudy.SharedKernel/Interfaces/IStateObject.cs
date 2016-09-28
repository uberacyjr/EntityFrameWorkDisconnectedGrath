using SharedKernel.Data.Enums;

namespace SharedKernel.Data.Interfaces
{
    public interface IStateObject
    {
        ObjectState State { get; set; }
    }
}
