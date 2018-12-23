using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using fftcg.GameStates;

namespace fftcg
{
    public class GameManager : MonoBehaviour
    {
        public State currentState;

        private void Update()
        {
            currentState.Tick(Time.deltaTime);
        }
    }
}
