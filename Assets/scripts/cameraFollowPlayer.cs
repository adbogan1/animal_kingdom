using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowPlayer : MonoBehaviour
{
    [SerializeField]
    private RectTransform player;
    [SerializeField]
    private RectTransform UIElems;

    private Camera cam;
    private float viewPosX;
    private float leftCameraBounds = 0.2f;
    private float rightCameraBounds = 0.8f;
    private Vector3 camMoveSpeed = new Vector3(.025f, 0, 0);

    bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        cam = UnityEngine.Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        checkPlayerPos();
    }
    public void checkPlayerPos()
    {
        Vector3 viewPos = cam.WorldToViewportPoint(player.position);
        viewPosX = viewPos.x;
        if (viewPosX < leftCameraBounds || viewPosX > rightCameraBounds)
        {
            // object out of range, move camera
            isMoving = true;
            moveCamera();
        }
        else
        {
            isMoving = false;
        }
    }
    public void moveCamera()
    {
        if (viewPosX < leftCameraBounds)
        {
            cam.transform.position -= camMoveSpeed;
            UIElems.transform.position -= camMoveSpeed;
        }
        else
        {
            cam.transform.position += camMoveSpeed;
            UIElems.transform.position += camMoveSpeed;
        }
    }
}
