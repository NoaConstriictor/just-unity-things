using UnityEngine;

public class winTrigger : MonoBehaviour
{
    public GameObject WinPanel;

    public void OnTriggerEnter(Collider other)


    {
        WinPanel.SetActive(true);
        Time.timeScale = 0f;

    }
}
