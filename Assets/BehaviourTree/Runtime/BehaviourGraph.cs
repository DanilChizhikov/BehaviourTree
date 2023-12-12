using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourGraph : IBehaviourGraph
    {
        public bool IsPlaying { get; private set; }
        
        protected IBehaviourState EnterState { get; }
        protected IReadOnlyList<IBehaviourState> States { get; }
        protected IBehaviourState CurrentState { get; private set; }
        protected bool HasState { get; private set; }

        public BehaviourGraph(IBehaviourState enterState, IEnumerable<IBehaviourState> states)
        {
            IsPlaying = false;
            EnterState = enterState;
            States = new List<IBehaviourState>(states);
            CurrentState = null;
        }

        public virtual void Enter()
        {
            Play();
        }

        public virtual void Update()
        {
            UpdateState();
        }

        public virtual void Exit()
        {
            Stop();
        }

        protected void Play()
        {
            if (IsPlaying)
            {
                return;
            }
            
            SetCurrentState(EnterState);
            IsPlaying = true;
        }

        protected void UpdateState()
        {
            if (!IsPlaying || !HasState)
            {
                return;
            }
            
            if (CurrentState.TryGetNextState(out IBehaviourState nextState))
            {
                SetCurrentState(nextState);
            }
        }

        protected void Stop()
        {
            if (!IsPlaying)
            {
                return;
            }
            
            SetCurrentState(null);
            IsPlaying = false;
        }
        
        protected void SetCurrentState(IBehaviourState value)
        {
            if (HasState)
            {
                CurrentState.Exit();
            }
            
            CurrentState = value;
            HasState = CurrentState != null;
            if (HasState)
            {
                CurrentState.Enter();
            }
        }
    }
}