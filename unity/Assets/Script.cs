using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        int a;
        a = 10;
        int b = 20;
        Debug.Log(a);
        {
            Debug.Log(b);
        }
        float fa = 1.5f;
        bool logic = true; //false
        string str = "napis";
        Debug.Log(" fa: " + fa + " logic: " + logic + " str: " + str);
        Debug.Log(a / b);
        Debug.Log(a / fa);
        Debug.Log(Mathf.Sqrt(2));

        Debug.Log(a == b);//rowne
        Debug.Log(a != b);//rozne

        if(a != b)
        {
            Debug.Log("tak , jest");
        }else if (a==b) {
            Debug.Log("else if");
        }else
        {
            Debug.Log("nie jest");
        }

        Debug.Log((a != b) && (a > 0));
        if ((a != b)&& (a > 0))
        {
            //kod
        }
        Kon(a, b);

        int hp = 3, time = 1;
        bool aegis = true;
        if ((hp <= 0 ) || time <= 0){
            if (aegis)
            {
            }
            else { }
        }




        public void Kon(int a, int b)
        {
            

        }







    }

    // Update is called once per frame
    void Update(){

        
    }
}
