using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private DoorTrigger trigger;
    [SerializeField] private Player player;
    private bool isOpened;
    private void Start()
    {
        CloseDoor();
    }
    public void Update()
    {
        if (trigger.playerIsNear && player.hasKey)
        {
            UIManager.Instance.SetActivePressEForDoorGameObject(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!isOpened)
                {
                    OpenDoor();
                }
                else
                {
                    CloseDoor();
                }
            }
        }
        else
        {
            UIManager.Instance.SetActivePressEForDoorGameObject(false);

        }
    }


    //---
    [ContextMenu("OpenDoor")]
    public void OpenDoor()
    {
        isOpened = true;
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }
    [ContextMenu("CloseDoor")]
    public void CloseDoor()
    {
        isOpened = false;
        transform.rotation = Quaternion.Euler(0, 0, 0);

    }
}
