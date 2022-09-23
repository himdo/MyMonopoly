using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyTextureInitialization : MonoBehaviour
{
    public Texture2DArray MoneyTextures;
    float currentTime;
    int TextureIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float now = Time.time;
        if (currentTime < now - 3)
        {
            Debug.Log("UpdateTime");
            currentTime = now;
        }   
    }
}
