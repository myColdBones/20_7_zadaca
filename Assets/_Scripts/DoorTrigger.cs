using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public bool playerIsNear = false;

    // fixed happens before trigger and update happens after trigger
    void FixedUpdate()
    {
        playerIsNear = false;
    }

    public void OnTriggerStay(Collider other)
    {
        playerIsNear = true;
    }
}
