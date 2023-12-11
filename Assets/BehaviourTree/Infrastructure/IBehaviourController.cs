namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourController<TEntity> where TEntity : IBehaviourEntity
    {
        bool IsPlaying { get; }
        
        void Play();
        void Stop();
    }
}