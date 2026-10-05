using UnityEngine;

public class boostpad : MonoBehaviour
{
    public float boostforce = 30f;

    private void OnTriggerStay(Collider other)
    {
        other.attachedRigidbody.AddForce(transform.forward * boostforce);
    }
}
