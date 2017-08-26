using UnityEngine;
using System.Collections;

public class buildMesh : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        MeshFilter filter = GetComponent<MeshFilter>();
        Mesh mesh = filter.mesh;

        Vector3[] vertices = new Vector3[]
        {
            new Vector3(-1, -1, 0),
            new Vector3 (1, -1, 0),
            new Vector3(0, 1, 0)
        };

        int[] triangles = new int[3] { 0, 2, 1 };

        Vector2[] uvs = new Vector2[]
        {
            new Vector2(0, 0),
            new Vector2(0.5f, 1.0f),
            new Vector2(1, 1)
        };

        Color[] colors = new Color[]
        {
            new Color(1, 0, 0, 1),
            new Color(0, 1, 0, 1),
            new Color(0, 0, 1, 1)
        };

        mesh.Clear();

        mesh.vertices = vertices;
        mesh.uv = uvs;
        mesh.triangles = triangles;
        mesh.colors = colors;

        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
    }

   
}
