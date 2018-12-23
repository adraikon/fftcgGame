using UnityEngine;
using System.Collections;

namespace fftcg
{
    public class CardIstance : MonoBehaviour, IClickable
    {
        public CardViz viz;
        public fftcg.GameElements.GE_Logic currentLogic;

        void Start()
        {
            viz = GetComponent<CardViz>();
        }

        public void OnClick()
        {
            if(currentLogic == null)            
                return;
            
            currentLogic.OnClick(this);
        }

        public void OnHighLigth()
        {
            if (currentLogic == null)
                return;
                        
            currentLogic.OnHighLigth(this);

            
        }
    }
}
