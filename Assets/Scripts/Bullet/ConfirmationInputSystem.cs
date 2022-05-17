using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ConfirmationInputSystem : MonoBehaviour
{
    //[SerializeField]
    //float _scaleObject;
    //[SerializeField]
    //GameObject _originObject;

    //void Start()
    //{
    //    _scaleObject = 0;
    //}

  
    //void Update()
    //{

    //    if (Keyboard.current == null) return;

    //    if (Keyboard.current.spaceKey.isPressed)
    //    {
    //        if (_scaleObject <= 3)
    //        {
    //            _scaleObject += 0.1f;
    //            Mathf.Round(_scaleObject);
    //        }
    //    }
    //    if (Keyboard.current.spaceKey.wasReleasedThisFrame)
    //    {
    //        GameObject cube = GameObject.Instantiate(_originObject)as GameObject ;
    //        cube.transform.localScale = new Vector3(_scaleObject, _scaleObject, _scaleObject);
    //        _scaleObject = 0;
    //    }
        
    //    float dist = Vector3.Distance(new Vector3 (0,0,0), transform.position);
    //    if (dist < 5.0f)
    //    {
    //        Destroy(_originObject);
    //    }
    //}

    //void OnGUI()
    //{
    //    if (Keyboard.current == null) return;
    //    {
    //        GUILayout.Label($"SpaceKey:{Keyboard.current.spaceKey.isPressed}");
    //    }
    //}
}
