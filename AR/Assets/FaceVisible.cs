using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FaceMaskToggle : MonoBehaviour
{
    public GameObject faceMask;  // Reference to the face mask GameObject
    private ARSessionOrigin arSessionOrigin;

    void Start()
    {
        // Initialize AR session origin if needed
        arSessionOrigin = FindObjectOfType<ARSessionOrigin>();
        if (faceMask == null)
        {
            Debug.LogError("Face Mask object is not assigned!");
        }
    }

    void Update()
    {
        // Check for screen touches (e.g., when user taps the screen)
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                // Toggle the face mask visibility when the screen is touched
                if (faceMask != null)
                {
                    faceMask.SetActive(!faceMask.activeSelf);  // Toggle visibility
                }
            }
        }
    }
}