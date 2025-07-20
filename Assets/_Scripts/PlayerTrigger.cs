using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private bool isNearDoor;

    public void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Door door))
        {
            isNearDoor = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Door door))
        {
            isNearDoor = false;
        }
    }
    
}
