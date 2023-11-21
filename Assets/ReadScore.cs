using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using UnityEngine;

public class ReadScore : MonoBehaviour
{
    public GameObject Note;
    void Start()
    {
        foreach (var line in File.ReadAllLines("Assets/song.txt"))
        {
            string[] parts = line.Split(":");
            if(parts.Length == 2)
            {
                float x, z;
                string zString = parts[0];
                if( float.TryParse(zString, out z))
                {
                    foreach ( var xString in parts[1].Split())
                    {
                        if ( float.TryParse(xString, out x) )
                        {
                            GameObject go = Instantiate(Note);
                            go.transform.parent = transform;
                            go.transform.localPosition = new Vector3(x, 0f, z);
                        }
                    }
                }
            }
        }
    }

}
