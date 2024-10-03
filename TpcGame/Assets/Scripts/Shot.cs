using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bullet;
    public Transform shotPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, shotPoint.position, quaternion.identity);
        }
    }


}
