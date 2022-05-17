using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplitCube : MonoBehaviour
{
    //public GameObject TargetCube;

    //public Vector3 SectionCount;
    //public Material SubCubeMaterial;

    //private Vector3 SizeOfOriginalCube;
    //private Vector3 SectionSize;
    //private Vector3 FillStartPosition;
    //private Transform ParentTransform;
    //private GameObject SubCube;

    //void Start()
    //{
    //    if (TargetCube == null)
    //        TargetCube = gameObject;

    //    SizeOfOriginalCube = TargetCube.transform.lossyScale;
    //    SectionSize = new Vector3(
    //        SizeOfOriginalCube.x / SectionCount.x,
    //        SizeOfOriginalCube.y / SectionCount.y,
    //        SizeOfOriginalCube.z / SectionCount.z
    //        );

    //    FillStartPosition = TargetCube.transform.TransformPoint(new Vector3(-0.5f, 0.5f, -0.5f))
    //                        + TargetCube.transform.TransformDirection(new Vector3(SectionSize.x, -SectionSize.y, SectionSize.z) / 2.0f);

    //    ParentTransform = new GameObject(TargetCube.name + "CubeParent").transform;

    //    StartCoroutine(DivideIntoCuboids());
    //    //InstantDivideIntoCuboids();
    //}

    //#region AnimatedAppear

    //void Looper()
    //{
    //    Destroy(ParentTransform.gameObject);
    //    ParentTransform = new GameObject(TargetCube.name + "Parent").transform;

    //    StartCoroutine(DivideIntoCuboids());

    //}

    //IEnumerator DivideIntoCuboids()
    //{
    //    for (int x = 0; x < SectionCount.x; x++)
    //    {
    //        for (int y = 0; y < SectionCount.y; y++)
    //        {
    //            for (int z = 0; z < SectionCount.z; z++)
    //            {
    //                SubCube = GameObject.CreatePrimitive(PrimitiveType.Cube);

    //                SubCube.transform.localScale = SectionSize;
    //                SubCube.transform.position = FillStartPosition +
    //                                               TargetCube.transform.TransformDirection(new Vector3((SectionSize.x) * x * 1.5f, -(SectionSize.y) * y * 1.5f, (SectionSize.z) * z * 1.5f));
    //                SubCube.transform.rotation = TargetCube.transform.rotation;

    //                SubCube.transform.SetParent(ParentTransform);
    //                SubCube.GetComponent<MeshRenderer>().material = SubCubeMaterial;

    //                yield return new WaitForSeconds(0.1f);
    //            }
    //        }
    //    }
    //    Destroy(TargetCube);


    //    // foreach (Transform subCube in ParentTransform)
    //    // {
    //    // subCube.gameObject.AddComponent<Rigidbody>();
    //    // }

    //    //Looper();
    //}

    //#endregion

}
