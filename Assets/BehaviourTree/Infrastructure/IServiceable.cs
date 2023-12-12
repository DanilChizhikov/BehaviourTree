using System;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IServiceable
    {
        Type ServicedType { get; }
    }
}