using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Bullet : MonoBehaviour
{
    /// <summary>基本 /// </summary>
    [SerializeField] float _scaleObject;
    [SerializeField] float _bulletSpeed;
    private float shootInterval;
    public float shootCount;
    /// <summary>弾をばらける際に必要 /// </summary>
    [SerializeField] Transform _randomBulletTransformRangeScale_PointA;
    [SerializeField] Transform _randomBulletTransformRangeScale_PointB;

    /// <summary>弾を形成する際に必要/// </summary>
    public GameObject _mainBullet;//Bulletを分ける際に元になる弾
    public Material subBulletMaterial;
    public Vector3 sectionCount;
    private Vector3 sizeOfOriginalBullet;
    private Vector3 sectionSize;
    private Vector3 fillstartPostion;
    private Transform parentTransform;
    private GameObject _subBullet;

    /// <summary>敵を狙う際に必要/// </summary>
    public Vector3 _mousePostion;

    void Start()
    {
        _scaleObject = 0;
    }

    void Update()
    {
        
    }

    void Devide()
    {
        if (_mainBullet == null)
            _mainBullet = gameObject;

        sizeOfOriginalBullet = _mainBullet.transform.localScale;
        sectionSize = new Vector3(
            sizeOfOriginalBullet.x / sectionCount.x,
            sizeOfOriginalBullet.y / sectionCount.y,
            sizeOfOriginalBullet.z / sectionCount.z 
            );

        fillstartPostion = _mainBullet.transform.TransformPoint(new Vector3(-0.5f, -0.5f, -0.5f))
            + _mainBullet.transform.TransformDirection(new Vector3(sectionSize.x, -sectionSize.y, sectionSize.z)/ 2.0f);

        parentTransform = new GameObject(_mainBullet.name + "CubeParent").transform;
        StartCoroutine(DivideIntoCuboids());
        
    }

    void DivideLooper()
    {
        Destroy(parentTransform.gameObject);
        parentTransform = new GameObject(_mainBullet + "Parent").transform;

        StartCoroutine(DivideIntoCuboids());
    }

    IEnumerator DivideIntoCuboids()
    {
        for (int x = 0; x < sectionCount.x; x++)
        {
            for (int y = 0; y < sectionCount.y; y++)
            {
                for (int z = 0; z < sectionCount.z; z++)
                {
                    _subBullet = GameObject.CreatePrimitive(PrimitiveType.Cube);

                    _subBullet.transform.localScale = sectionSize;
                    _subBullet.transform.position = fillstartPostion + 
                        _mainBullet.transform.TransformDirection(new Vector3((sectionSize.x) * x * 1.5f, -(sectionSize.y) * y * 1.5f, (sectionSize.z) * z * 1.5f));
                    _subBullet.transform.rotation = _mainBullet.transform.rotation;

                    _subBullet.transform.SetParent(parentTransform);
                    _subBullet.GetComponent<MeshRenderer>().material = subBulletMaterial;

                    yield return new WaitForSeconds(1.0f);
                }
            }
        }
        Destroy(_mainBullet);

        foreach (Transform subeCube in parentTransform)
        {
            subeCube.gameObject.AddComponent<Rigidbody>();
        }

        DivideLooper();
    }

    void RandomPostion()
    {
        float x = Random.Range(_randomBulletTransformRangeScale_PointA.position.x, _randomBulletTransformRangeScale_PointB.position.x);
        float y = Random.Range(_randomBulletTransformRangeScale_PointA.position.y, _randomBulletTransformRangeScale_PointB.position.y);
        float z = Random.Range(_randomBulletTransformRangeScale_PointA.position.z, _randomBulletTransformRangeScale_PointB.position.z);
    }

    void ObjectScale()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.spaceKey.isPressed)
        {
            if (_scaleObject <= 2)
            {
                _scaleObject += 0.01f;
                Mathf.Sign(_scaleObject);
            }
        }
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GameObject scaleBullet = GameObject.Instantiate(_mainBullet)as GameObject;
            scaleBullet.transform.localScale = new  Vector3(_scaleObject, _scaleObject, _scaleObject);
            _scaleObject = 0;
        }

    }

    void Shoot()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            shootInterval += 1;

            if (shootInterval %5 == 0 && shootCount > 0)
            {
                shootCount += 1;
                GameObject bullet = (GameObject)Instantiate(_mainBullet, transform.position,
               Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            }

            Destroy(_mainBullet, 3.0f);
        }
    }
}
