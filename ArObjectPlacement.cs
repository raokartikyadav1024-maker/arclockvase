using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARObjectPlacement : MonoBehaviour
{
    public GameObject clockPrefab;
    public GameObject vasePrefab;

    private ARRaycastManager raycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        if (Input.touchCount == 0)
            return;

        if (Input.GetTouch(0).phase != TouchPhase.Began)
            return;

        Vector2 touchPosition = Input.GetTouch(0).position;

        if (raycastManager.Raycast(
            touchPosition,
            hits,
            TrackableType.PlaneWithinPolygon))
        {
            ARPlane plane = hits[0].trackable as ARPlane;

            if (plane == null)
                return;

            // Horizontal plane → Clock
            if (plane.alignment == PlaneAlignment.HorizontalUp ||
                plane.alignment == PlaneAlignment.HorizontalDown)
            {
                Instantiate(
                    clockPrefab,
                    hits[0].pose.position,
                    hits[0].pose.rotation
                );
            }

            // Vertical plane → Flower Vase
            else if (plane.alignment == PlaneAlignment.Vertical)
            {
                Instantiate(
                    vasePrefab,
                    hits[0].pose.position,
                    hits[0].pose.rotation
                );
            }
        }
    }
}
