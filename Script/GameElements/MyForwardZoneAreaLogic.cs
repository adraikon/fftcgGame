using UnityEngine;
using System.Collections;

namespace fftcg
{
    [CreateAssetMenu(menuName ="Area/MyForwardWhenHolding")]
    public class MyForwardZoneAreaLogic : AreaLogic
    {
        public CardVariable card;
        public CardType forwardType;
        public SO.TransformVariable areaGrid;

        public override void Execute()
        {
            if (card.value != null)
                return;
            if (card.value.viz.card.cardType == forwardType)
            {
                Debug.Log("place card down");

                card.value.transform.SetParent(areaGrid.value.transform);
                //place card down
            }
        }

    }
}
