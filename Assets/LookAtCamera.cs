using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
   [SerializeField] private Transform _targetCamera;

   private void Update()
   {
      Vector3 toCamera = _targetCamera.position - transform.position;
      transform.rotation = Quaternion.LookRotation(toCamera);  
   }
}
