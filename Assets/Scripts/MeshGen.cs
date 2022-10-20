using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGen : MonoBehaviour
{
    Mesh mesh;

    Vector3[] verticies;
    int[] triangles;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();
        mesh = GetComponent<MeshFilter>().mesh;

        CreateShape();
        UpdateMesh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateShape()
    {
        // hardcoded
        verticies = new Vector3[]
        {
                    new Vector3(0f, 0f, 0f), // 0
                    new Vector3(0f, 0f, 1f), // 1
                    new Vector3(1f, 0f, 0f), // 2
                    new Vector3(1f, 0f, 1f)  // 3

        };

        triangles = new int[]
        {
                    0,1,2,
                    3,2,1
        };

        // randomgen
        /*        verticies = new Vector3[100];
                triangles = new int[300]; // 100 * 3, 3 verticies in 1 triangle

                for (int i = 0; i <= verticies.Length - 1; i++)
                {
                    verticies[i].x = Random.Range(-5, 5);
                    verticies[i].y = 0;
                    verticies[i].z = Random.Range(-5, 5);
                }

                for (int i = 0; i < triangles.Length - 1; i++)
                {
                    triangles[i] = Random.Range(0, 100); // 0 - 99
                }*/

    }

    void UpdateMesh()
    {
        mesh.Clear();

        mesh.vertices = verticies;
        mesh.triangles = triangles;
    }
}
