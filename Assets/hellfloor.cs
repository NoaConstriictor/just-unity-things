using UnityEngine;

public class hellfloor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        baller player = other.GetComponent<baller>();
        if (player != null)

            player.Respawn();

    }
}
