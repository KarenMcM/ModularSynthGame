using UnityEngine;
using UnityEngine.InputSystem;

public class TestWwiseSound : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            AkSoundEngine.PostEvent("Play_Mysterious_Atmos", gameObject);
        }
    }
}