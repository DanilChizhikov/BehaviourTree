using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourForkStateConfig
    {
        IReadOnlyList<IBehaviourForkConfig> ForkInfos { get; }
    }
}