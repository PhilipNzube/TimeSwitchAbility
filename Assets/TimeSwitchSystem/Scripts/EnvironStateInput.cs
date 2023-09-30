using UnityEngine;

namespace TimeSwitchSystem.Scripts
{

    public class EnvironStateInput : MonoBehaviour
    {
        private IEnvironmentStateManager environmentStateManager;
        public KeyCode key = KeyCode.T;
        public EnvironStateConfig stateConfig;

        void Start()
        {
            environmentStateManager = GetComponent<IEnvironmentStateManager>();
        }


        void Update()
        {
            if (Input.GetKeyDown(key))
            {
                environmentStateManager.SetEnvironState(stateConfig);
            }
        }
    }
}