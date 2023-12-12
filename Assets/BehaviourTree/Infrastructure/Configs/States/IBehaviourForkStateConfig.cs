using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourForkStateConfig : IBehaviourStateConfig
    {
        IReadOnlyList<IBehaviourForkConfig> ForkInfos { get; }
    }
}