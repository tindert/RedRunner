using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDepthController : MonoBehaviour
{
   public Camera cam;

   void Start()
   {
       // Get the camera component
       cam = GetComponent<Camera>();

       // Set the camera depth
       //SetCameraDepth(2);
   }

   public void SetCameraDepth(float depth)
   {
       cam.depth = depth;
   }

}
