using UnityEngine;


public class MeshGenerator
{
    private MeshFilter fliter;
    private MeshRenderer renderer;
    Mesh mesh = new Mesh();
    public MeshGenerator(GameObject parent)
    {

        mesh = new Mesh();
        renderer = parent.AddComponent<MeshRenderer>();
        fliter = parent.AddComponent<MeshFilter>();
        

    }
    public void SetData(Vector3[]vertices,int[]triangles)
    {
        mesh.Clear();
        fliter.mesh = mesh;
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }
}