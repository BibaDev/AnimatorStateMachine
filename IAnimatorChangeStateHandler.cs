using System;

/*
 * Created by BibaDev: (https://biba.dev)
 * Support me (donation): https://biba.dev/donation
 * Contact me: https://biba.dev/feedback
 * YouTube channel: https://bit.ly/39Wbgrj
 * GitHub: https://github.com/BibaDev/AnimatorStateMachine
*/

namespace BibaDev.AnimatorStateMachine
{
    
    public interface IAnimatorChangeStateHandler<in TEnum> where TEnum : Enum
    {

        void OnAnimatorStateChanged(TEnum id);

    }

}
