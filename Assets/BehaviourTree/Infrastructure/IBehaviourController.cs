namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourController
    {
        bool IsPlaying { get; }
        
        void Play();
        void Stop();
    }
}