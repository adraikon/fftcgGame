﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace fftcg.GameStates
{
    [CreateAssetMenu(menuName = "Action/MouseHoldWithCard")]
    public class MouseHoldWithCard : Action
    {
        public CardVariable currentCard;
        public State playerControlState;
        public SO.GameEvent onPlayerControlState;

        public override void Execute(float d)
        {
            bool MouseIsDown = Input.GetMouseButton(0);

            if (!MouseIsDown)
            {
                List<RaycastResult> results = Settings.GetUIObjs();

                foreach (RaycastResult r in results)
                {
                    GameElements.Area a = r.gameObject.GetComponentInParent<GameElements.Area>();
                    if(a != null)
                    {
                        a.onDrop();
                        break;
                    }
                }

                
                currentCard.value.gameObject.SetActive(true);
                currentCard.value = null;

                Settings.gameManager.SetState(playerControlState);
                onPlayerControlState.Raise();
                return;
            }
        }
    }
}
