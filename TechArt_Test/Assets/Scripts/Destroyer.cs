using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] GameObject objectToDestroy;
    [SerializeField] float destroyAfter;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyPrefab());
    }

    public IEnumerator DestroyPrefab()
    {
        yield return new WaitForSeconds(destroyAfter);
        Destroy(objectToDestroy);
    }

}
