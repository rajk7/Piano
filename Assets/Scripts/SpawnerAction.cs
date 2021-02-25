using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAction : MonoBehaviour
{
    public float width = 11f;
    public float height = 5f;
    public GameObject pianoTile;
    public float delay = 0.5f;
    float min = -5f;
    float max = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("1");
        spwaner();
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if(CheckForEmpty())
        {
            SpwanerUntill();
        }
        //Debug.Log("3");
    }

    private void SpwanerUntill()
    {
        Transform position = FreePosition();
        float rand = Random.Range(min, max);
        Vector3 offset = new Vector3(0, rand, 0);
            if(position)
            {
                GameObject piano = Instantiate(pianoTile, position.transform.position+offset, Quaternion.identity);
                piano.transform.parent = position;
            }
            if(FreePosition())
            {
                Invoke("SpwanerUntill", delay);
            }
    }

    private void spwaner()
    {
        foreach(Transform child in transform)
        {
            GameObject piano = Instantiate(pianoTile, child.position, Quaternion.identity);
            piano.transform.parent = child;
        }
    }
    
    bool CheckForEmpty()
    {
        foreach(Transform child in transform)
        {
            if (child.childCount > 0)
            return false;
        }
        return true;
    }
    Transform FreePosition()
    {
        foreach(Transform child in transform)
        {
            if (child.childCount == 0)
            return child;
        }
        return null;
    }
}
