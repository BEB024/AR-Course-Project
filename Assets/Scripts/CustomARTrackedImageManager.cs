using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class CustomARTrackedImageManager : MonoBehaviour
{
    [SerializeField] private ARTrackedImageManager imageManager;

    void OnEnable()
    {
        imageManager.trackablesChanged.AddListener(OnChanged);
    }

    void OnDisable()
    {
        imageManager.trackablesChanged.RemoveListener(OnChanged);
    }

    void OnChanged(ARTrackablesChangedEventArgs<ARTrackedImage> eventArgs)
    {
        // Handle added images
        foreach (var newImage in eventArgs.added)
        {
            // Handle added event
        }

        // Handle updated images
        foreach (var updatedImage in eventArgs.updated)
        {
            // Handle updated event
        }

        // Handle removed images
        foreach (var removed in eventArgs.removed)
        {
            TrackableId removedImageTrackableId = removed.Key;
            ARTrackedImage removedImage = removed.Value;

            // Handle removed event
        }
    }
}
