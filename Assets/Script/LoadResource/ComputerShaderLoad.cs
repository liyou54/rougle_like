using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace LoadResources
{
    

    
    public class ComputerShaderLoad 
    {
        const int Multiply0 = 8;
        const int Multiply1 = 8;

        private ComputeShader computershader;

        public ComputerShaderLoad(string path)
        {
            AssetDatabase.LoadAssetAtPath<ComputeShader>(path);
        }

        public int FindKernel(string name)
        {
            return computershader.FindKernel(name);
        }
        public void SetFloat(int kernel,string attr,float value)
        {
            
        }

        public void Calculate()
        {
            
        }

    }
}

