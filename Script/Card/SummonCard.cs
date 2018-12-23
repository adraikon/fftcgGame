using UnityEngine;
using System.Collections;

namespace fftcg
{
    [CreateAssetMenu(menuName = "CardType/Summon")]
    public class SummonCard : CardType
    {
        public override void OnSetType(CardViz viz)
        {
            base.OnSetType(viz);

            viz.statsHolder.SetActive(false);
        }
    }
}
