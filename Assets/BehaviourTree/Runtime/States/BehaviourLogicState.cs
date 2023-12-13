using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public class BehaviourLogicState : BehaviourState, IBehaviourLogicState
    {
        public IReadOnlyList<IBehaviourAction> Actions { get; set; }
        public IReadOnlyList<IBehaviourTransition> Transitions { get; set; }

        private IBehaviourState _nextState;
        private bool _hasNextState;

        public BehaviourLogicState()
        {
            _hasNextState = default;
            _hasNextState = false;
        }
        
        public override void Enter()
        {
            SetNextState(null);
            EnterToActions();
            EnterToTransitions();
        }

        public override void Update()
        {
            UpdateActions();
            UpdateTransitions();
        }

        public override bool TryGetNextState(out IBehaviourState nextState)
        {
            nextState = _nextState;
            return _hasNextState;
        }

        public override void Exit()
        {
            SetNextState(null);
            ExitFromActions();
            ExitFromTransitions();
        }

        protected void EnterToActions()
        {
            int actionsCount = Actions.Count;
            for (int i = 0; i < actionsCount; i++)
            {
                Actions[i].Enter();
            }
        }

        protected void EnterToTransitions()
        {
            int transitionsCount = Transitions.Count;
            for (int i = 0; i < transitionsCount; i++)
            {
                IBehaviourTransition transition = Transitions[i];
                int decisionsCount = transition.Decisions.Count;
                for (int j = 0; j < decisionsCount; j++)
                {
                    transition.Decisions[i].Enter();
                }
            }
        }

        protected void UpdateActions()
        {
            int actionsCount = Actions.Count;
            for (int i = 0; i < actionsCount; i++)
            {
                Actions[i].Processing();
            }
        }

        protected void UpdateTransitions()
        {
            int transitionsCount = Transitions.Count;
            for (int i = 0; i < transitionsCount; i++)
            {
                IBehaviourTransition transition = Transitions[i];
                bool result = true;
                int decisionsCount = transition.Decisions.Count;
                for (int j = 0; j < decisionsCount; j++)
                {
                    IBehaviourDecision decision = transition.Decisions[i];
                    if (!decision.GetDecision())
                    {
                        result = false;
                        break;
                    }
                }

                IBehaviourPort nextPort = result ? transition.TruePort : transition.FalsePort;
                if (nextPort != null)
                {
                    SetNextState(nextPort.NextState);
                }

                if (_hasNextState)
                {
                    break;
                }
            }
        }
        
        protected void ExitFromActions()
        {
            int actionsCount = Actions.Count;
            for (int i = 0; i < actionsCount; i++)
            {
                Actions[i].Exit();
            }
        }

        protected void ExitFromTransitions()
        {
            int transitionsCount = Transitions.Count;
            for (int i = 0; i < transitionsCount; i++)
            {
                IBehaviourTransition transition = Transitions[i];
                int decisionsCount = transition.Decisions.Count;
                for (int j = 0; j < decisionsCount; j++)
                {
                    transition.Decisions[i].Exit();
                }
            }
        }

        protected void SetNextState(IBehaviourState value)
        {
            _nextState = value;
            _hasNextState = _nextState != null;
        }
    }
}