using UnityEngine;
using System.Collections;

namespace fftcg.GameElements
{
    [CreateAssetMenu(menuName = "GameElements/My Hand Card")]
    public class MyHandCard : GE_Logic
    {
        public SO.GameEvent onCurrentCardSelected;
        public CardVariable currentCard;

        
        public override void OnClick(CardIstance inst)
        {
            currentCard.Set(inst);
            onCurrentCardSelected.Raise();
            
        }

        public override void OnHighLigth(CardIstance inst)
        {
            
        }
    }
}
