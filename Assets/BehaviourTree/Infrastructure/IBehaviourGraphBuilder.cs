namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourGraphBuilder<TGraph, TConfig>
            where TGraph : IBehaviourGraph
            where TConfig : IBehaviourGraphConfig
    {
        IBehaviourGraphBuilder<TGraph, TConfig> SetGraphConfig(TConfig value);
        TGraph Build();
        void Reset();
    }
}