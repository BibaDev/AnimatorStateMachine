/*
 * Created by BibaDev: (https://biba.dev)
 * Support me (donation): https://biba.dev/donation
 * Contact me: https://biba.dev/feedback
 * YouTube channel: https://bit.ly/39Wbgrj
 * GitHub: https://github.com/BibaDev/AnimatorStateMachine
*/

namespace BibaDev.AnimatorStateMachine
{

    public class EmptyState<TContext> : IState<TContext>
    {
        
        public void Enter(TContext context) {}
        public void LogicUpdate(TContext context) {}
        public void PhysicsUpdate(TContext context) {}
        public void OnAnimationEvent(TContext context, int data) {}
        public void Exit(TContext context) {}

    }
    
    public interface IState<in TContext>
    {

        void Enter(TContext context);
        void LogicUpdate(TContext context);
        void PhysicsUpdate(TContext context);
        void OnAnimationEvent(TContext context, int data);
        void Exit(TContext context);

    }
    
}

