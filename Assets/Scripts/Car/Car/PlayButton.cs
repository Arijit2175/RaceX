using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public CarHandler car;
    public GameObject uiRoot;

    public void PlayGame()
    {
        car.canDrive = true;
        uiRoot.SetActive(false);
    }
}
