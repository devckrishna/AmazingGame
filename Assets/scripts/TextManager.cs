using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI testMesh;
    public static TextManager instance;
    int score;

    public void IncreaseScore(){
        score++;
        instance.testMesh.text="Score: "+score;
    }

    // Start is called before the first frame update
    void Start()
    {
        if(instance==null){
            instance=this;
        }
        score=0;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
