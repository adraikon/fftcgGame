﻿using UnityEngine;
using System.Collections;

namespace fftcg
{
    [CreateAssetMenu(menuName ="Area/MyForwardWhenHolding")]
    public class MyForwardZoneAreaLogic : AreaLogic
    {
        public CardVariable card;
        public CardType forwardCard;
        public TransformVariable areaGridForward;

        public override void Execute()
        {
            if (card.value == null)
                return;
            if (card.value.viz.card.cardType == forwardCard)
            {
                Debug.Log("place Forward card down");

                card.value.transform.SetParent(areaGridForward.value.transform);
                card.value.transform.localPosition = Vector3.zero;
                card.value.transform.localEulerAngles = Vector3.zero;
                card.value.transform.localScale = Vector3.one;
                card.value.gameObject.SetActive(true);
                //place card down
            }
        }

    }
}
