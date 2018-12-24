using UnityEngine;
using System.Collections;

namespace fftcg.GameElements
{
    public class Area : MonoBehaviour
    {
        public AreaLogic logic;

        public void onDrop()
        {
            logic.Execute();
        }
    }
}
