using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GenGround : MonoBehaviour
{
    
    private LoadResources.ComputerShaderLoad computershader;
    public int x_size,y_size;
    public MeshGenerator meshGenerator;
    public float cellSize;
    // Start is called before the first frame update
    void Start()
    {
        computershader = new LoadResources.ComputerShaderLoad("Assets/ComputerShader/PerlinNoise/Perlin.compute");
        computershader
        meshGenerator = new MeshGenerator(gameObject);
        meshGenerator.SetData(new Vector3[]{Vector3.zero, Vector3.up,Vector3.left},new int[]{0,1,2});
        

    }

    // Update is called once per frame
    void Update()
    {

    }
}
