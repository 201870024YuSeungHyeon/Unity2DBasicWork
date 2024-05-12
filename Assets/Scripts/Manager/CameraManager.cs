using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private GameObject[] target;
    [SerializeField] private float cameraSpeed;
    private Vector3 targetPos;

    private void LateUpdate()
    {
        if (target.gameObject != null)
        {
            targetPos.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);

            this.transform.position = Vector3.Lerp(this.transform.position, targetPos, cameraSpeed * Time.deltaTime);
        }
    }

 
}
