using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace fftcg
{
    [CreateAssetMenu(menuName = "CardType/Forward")]
    public class ForwardCard : CardType
    {
        public override void OnSetType(CardViz viz)
        {
            base.OnSetType(viz);
            viz.statsHolder.SetActive(true);
        }

    }
}
