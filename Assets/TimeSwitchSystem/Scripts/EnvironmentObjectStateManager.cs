using UnityEngine;

namespace TimeSwitchSystem.Scripts
{
    public class EnvironmentObjectStateManager : MonoBehaviour, IEnvironmentObjectStateManager
    {
        private Renderer[] renderers;
        private Collider[] colliders;


        void Start()
        {
            renderers = GetComponentsInChildren<Renderer>();
            colliders = GetComponentsInChildren<Collider>();
        }


        public void Disable()
        {
            foreach (Renderer renderer in renderers)
            {
                renderer.enabled = false;
                foreach (Collider colliders in colliders)
                {
                    colliders.enabled = false;
                }

            }
        }

        public void Enable()
        {
            foreach (Renderer renderer in renderers)
            {
                renderer.enabled = true;
                foreach (Collider colliders in colliders)
                {
                    colliders.enabled = true;
                }
            }
        }

    }
}
