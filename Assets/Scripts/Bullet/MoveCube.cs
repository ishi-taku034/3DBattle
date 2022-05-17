using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MoveCube : MonoBehaviour
{
    //public GameObject cube;
    //public float shootSpeed;
    //public int shootCount;
    //private float shootInterval;

    //private void Update()
    //{
    //    if (Keyboard.current.gKey.wasPressedThisFrame)
    //    {
    //        shootInterval += 1;

    //        if (shootInterval %5 == 0 && shootCount > 0)
    //        {
    //            shootCount += 1;

    //            GameObject bullet = (GameObject)Instantiate(cube,transform.position, 
    //                Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
    //            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();

    //            Destroy(bullet, 3.0f);
    //        }
    //    }
    //    else if (Keyboard.current.vKey.wasPressedThisFrame)
    //    {
    //        shootCount = 30;
    //    }

    //}
}
