using UnityEngine;
using System;

namespace TimeSwitchSystem.Scripts
{

    public enum TimeState
    {
        Present,
        Past,
        Future
    }

    public class EnvironmentStateManager : MonoBehaviour, IEnvironmentStateManager
    {
        private IEnvironStateUI environStateUI;
        private IEnvironmentObjectStateManager environmentObjectStateManager;
        private int _currentIndex = 0;
        private TimeState[] _values = (TimeState[])Enum.GetValues(typeof(TimeState));

        void Start()
        {
            environStateUI = GetComponent<IEnvironStateUI>();
            environmentObjectStateManager = GetComponent<IEnvironmentObjectStateManager>();
        }


        public void SetEnvironState(EnvironStateConfig stateConfig)
        {
            TimeState nextState = _values[_currentIndex];
            _currentIndex = (_currentIndex + 1) % _values.Length;

            if (nextState == TimeState.Future)
            {
                environStateUI.FutureText();
                if (stateConfig.stateName == "Past")
                {
                    environmentObjectStateManager.Disable();
                }
                else
                if (stateConfig.stateName == "Future")
                {
                    environmentObjectStateManager.Enable();
                }
            }
            else
            if (nextState == TimeState.Past)
            {
                environStateUI.PastText();
                if (stateConfig.stateName == "Past")
                {
                    environmentObjectStateManager.Enable();
                }
                else
                if (stateConfig.stateName == "Future")
                {
                    environmentObjectStateManager.Disable();
                }
            }
            else
            if (nextState == TimeState.Present)
            {
                environStateUI.PresentText();
                if (stateConfig.stateName == "Past")
                {
                    environmentObjectStateManager.Enable();
                }
                else
                if (stateConfig.stateName == "Future")
                {
                    environmentObjectStateManager.Enable();
                }
            }
        }
    }
}
