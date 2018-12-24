using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace fftcg
{
    public static class Settings
    {

        public static GameManager gameManager;
        public static ResourcesManager _resourcesManager;

        public static ResourcesManager GetResourcesManager()
        {
            if (_resourcesManager == null)
            {
                _resourcesManager = Resources.Load("resourcesManager") as ResourcesManager;
            }

            return _resourcesManager;
        }

        public static List<RaycastResult> GetUIObjs()
        {
            PointerEventData pointerData = new PointerEventData(EventSystem.current)
            {
                position = Input.mousePosition
            };

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);
            return results;
        }
    }
}
