using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject Settings;
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
        //Time.timeScale = 0;
        Settings.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        }
    }
}
