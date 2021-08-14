using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemie _template;

    private Transform _coordinates;

    [System.Obsolete]
    public void Spawn()
    {
        float Xcoord = Random.RandomRange(transform.position.x-2, transform.position.x + 2);
        float Ycoord = Random.RandomRange(transform.position.y-2, transform.position.y + 2);
        Instantiate(_template, new Vector3(Xcoord, Ycoord, 0), Quaternion.identity);
    }

}

