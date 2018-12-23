using UnityEngine;
using System.Collections;

namespace fftcg.GameElements
{
    public abstract class GE_Logic : ScriptableObject
    {
        public abstract void OnClick(CardIstance inst);

        public abstract void OnHighLigth(CardIstance inst);
    }
}
