using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject pathToAppear;

    public GameObject pathToDisappear;
    void OnTriggerEnter(Collider other)
    {
        pathToAppear.SetActive(true);
        pathToDisappear.SetActive(false);
        Destroy(gameObject);
    }

}
