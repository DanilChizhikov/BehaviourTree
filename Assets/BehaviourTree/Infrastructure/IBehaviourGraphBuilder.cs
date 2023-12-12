namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourGraphBuilder
    {
        IBehaviourGraphBuilder SetGraphConfig(IBehaviourGraphConfig value);
        IBehaviourGraph Build();
    }
}