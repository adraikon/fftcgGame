using UnityEngine;
using System.Collections;

namespace fftcg.GameElements
{
    [CreateAssetMenu(menuName = "GameElements/My Hand Card")]
    public class MyHandCard : GE_Logic
    {
        public SO.GameEvent onCurrentCardSelected;
        public CardVariable currentCard;
        public fftcg.GameStates.State holdingCard;
        
        public override void OnClick(CardIstance inst)
        {
            currentCard.Set(inst);
            Settings.gameManager.SetState(holdingCard);
            onCurrentCardSelected.Raise();
            
        }

        public override void OnHighLigth(CardIstance inst)
        {
            
        }
    }
}
