using UnityEngine;
using System.Collections;

namespace fftcg
{
    public static class Settings
    {
        public static ResourcesManager _resourcesManager;

        public static ResourcesManager GetResourcesManager()
        {
            if (_resourcesManager == null)
            {
                _resourcesManager = Resources.Load("resourcesManager") as ResourcesManager;
            }

            return _resourcesManager;
        }

    }
}
