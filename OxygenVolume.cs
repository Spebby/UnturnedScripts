using UnityEngine;

namespace SDG.Unturned
{
    // The New Volumes use the Scale of the GameObject as the Size for the Volume, No Colliders Required
    // This Volume Script should be attached to an Empty GameObject with Tag and Layer :: Trap
    // To Visualize the Size of the Volume Temporarily Attach either a BoxCollider or a SphereCollider. Making sure that the Collider Component uses the default Radius ( 0.5 ) or Size ( 1 1 1 )
    public class OxygenVolume : MonoBehaviour
    {
        public bool isBreathable
        {
            get
            {
                return this._isBreathable;
            }
            set
            {
                if (!base.enabled)
                {
                    this._isBreathable = value;
                    return;
                }
                this._isBreathable = value;
            }
        }

        [SerializeField]
        private bool _isBreathable = true;

        public ELevelVolumeShape Shape;

        public float falloffDistance;
    }
}