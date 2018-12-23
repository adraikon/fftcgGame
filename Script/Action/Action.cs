using UnityEngine;
using System.Collections;

namespace fftcg.GameStates
{
    public abstract class Action : ScriptableObject
    {
        public abstract void Execute(float d);

    }
}
