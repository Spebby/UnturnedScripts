using UnityEngine;

namespace SDG.Framework.Devkit
{
    // Produces a Deadzone inside of the BoxCollider on the base Game Object
    // BoxCollider must have 'isTrigger' set to True
    public class DeadzoneVolume : MonoBehaviour
    {
        [SerializeField]
		private EDeadzoneType _deadzoneType;
	
		[SerializeField]
		private float _unprotectedDamagePerSecond;
	
		[SerializeField]
		private float _protectedDamagePerSecond;
	
		[SerializeField]
		private float _unprotectedRadiationPerSecond = 6.25f;
	
		[SerializeField]
		private float _maskFilterDamagePerSecond = 0.4f;
    }
}
