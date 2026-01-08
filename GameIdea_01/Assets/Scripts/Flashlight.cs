using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light flashlight;
    public bool isOn = false;

    void Start()
    {
        flashlight.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isOn = !isOn;
            flashlight.enabled = isOn;
        }
    }
}
        