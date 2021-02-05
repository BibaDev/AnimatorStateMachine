using System;
using System.Collections.Generic;

/*
 * Created by BibaDev: (https://biba.dev)
 * Support me (donation): https://biba.dev/donation
 * Contact me: https://biba.dev/feedback
 * YouTube channel: https://bit.ly/39Wbgrj
 * GitHub: https://github.com/BibaDev/AnimatorStateMachine
*/

namespace BibaDev.AnimatorStateMachine
{
    
    public class StateMachine<TEnum, TContext> where TEnum : Enum
    {

        public TEnum CurrentId => _currentId;
        public IState<TContext> CurrentState => _currentState;
        
        private static readonly EmptyState<TContext> EmptyState = new EmptyState<TContext>();
        private readonly TContext _context;
        private readonly Dictionary<TEnum, IState<TContext>> _states = new Dictionary<TEnum, IState<TContext>>();
        private TEnum _currentId;
        private IState<TContext> _currentState = EmptyState;

        public StateMachine(TContext context) => _context = context;
        public void AddState(TEnum id, IState<TContext> state) => _states.Add(id, state);
        public void LogicUpdate() => _currentState.LogicUpdate(_context);
        public void PhysicsUpdate() => _currentState.PhysicsUpdate(_context);
        public void OnAnimationEvent(int data) => _currentState.OnAnimationEvent(_context, data);

        public void ChangeState(TEnum id)
        {

            if (!_states.TryGetValue(id, out var state))
                state = EmptyState;
            
            _currentId = id;
            
            _currentState.Exit(_context);
            _currentState = state;
            _currentState.Enter(_context);
            
        }

    }
    
}

