using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshCreator : MonoBehaviour
{
    public MeshFilter filter;
    public Vector3[] verts;
    public int[] tris;

    private void Start()
    {
        Mesh nMesh = new Mesh();
        nMesh.vertices = verts;
        nMesh.triangles = tris;

        filter.mesh = nMesh;
    }

    private void Update()
    {
        
    }

}
