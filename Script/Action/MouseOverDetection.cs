using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace fftcg.GameStates
{
    [CreateAssetMenu(menuName = "Action/MouseOverDetection")]
    public class MouseOverDetection : Action
    {
        public override void Execute(float d)
        {
            PointerEventData pointerData = new PointerEventData(EventSystem.current)
            {
                position = Input.mousePosition
            };

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);

            IClickable c = null;

            foreach (RaycastResult r in results)
            {
                c = r.gameObject.GetComponentInParent<IClickable>();
                if (c != null)
                {
                    c.OnHighLigth();
                    break;
                }
            }
                        
        }
    }
}
