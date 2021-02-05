using System;
using UnityEngine;

/*
 * Created by BibaDev: (https://biba.dev)
 * Support me (donation): https://biba.dev/donation
 * Contact me: https://biba.dev/feedback
 * YouTube channel: https://bit.ly/39Wbgrj
 * GitHub: https://github.com/BibaDev/AnimatorStateMachine
*/

namespace BibaDev.AnimatorStateMachine
{

    public abstract class EnterStateBehaviourBase<TEnum> : StateMachineBehaviour where TEnum : Enum
    {

        [SerializeField] private TEnum _id;
        private IAnimatorChangeStateHandler<TEnum> _handler;

        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

            if (_handler == null)
                _handler = animator.GetComponent<IAnimatorChangeStateHandler<TEnum>>();
            
            _handler.OnAnimatorStateChanged(_id);

        }
    
    }

}
