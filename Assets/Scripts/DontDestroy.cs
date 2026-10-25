using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private void Awake()
    {
        // Keeps this entire GameObject alive across scene changes
        DontDestroyOnLoad(gameObject);
    }
}
