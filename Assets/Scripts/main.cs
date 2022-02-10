using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class main : MonoBehaviour
{
    public Animator animator;
    public Input setMax;
    int SS = 0;
    int Ss = 0;
    int ss = 0;
    int max = 100;
    float SSpercent = 0.0f;
    float Sspercent = 0.0f;
    float sspercent = 0.0f;
    int random1 = 0;
    int random2 = 0;
    public Text SStext;
    public Text SsText;
    public Text ssText;
    public Text text1;
    public Text text2;
    public Text Ratio;
    public GameObject done;
    public Text Side1;
    public Text Side2;
    bool doneBool = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(random1.ToString() + "/" + random2.ToString());
        SStext.text = "SS: " + SS.ToString();
        SsText.text = "Ss: " + Ss.ToString();
        ssText.text = "ss: " + ss.ToString();
        Ratio.text = (SS + ss + Ss).ToString() + "/" + max.ToString();
    }
    public void reset() {
        ss = 0;
        Ss = 0;
        SS = 0;
        max = 100;
        done.SetActive(false);
        doneBool = false;
    }
    public void SetMax(string s) {
       max = int.Parse(s);
       Debug.Log(max.ToString());
    }
    public void flip () {
        if (!doneBool) {
        animator.SetBool("flipping", true);
        random1 = Random.Range(1, 3);
        random2 = Random.Range(1, 3);
        text1.text = "";
        text2.text = "";
        }
    }
    public void showresults() {
        if (!doneBool) {
        animator.SetBool("flipping", false);
        if (random1 == 1) {
            text1.text = "S";
        } else if (random1 == 2) {
            text1.text = "s";
        }
        if (random2 == 1) {
            text2.text = "S";
        } else if (random2 == 2) {
            text2.text = "s";
        }
        if (random1 == 1 && random2 == 1) {
            SS++;
        }
        if ((random1 == 1 && random2 == 2) || (random1 == 2 && random2 == 1)) {
            Ss++;
        }
        if (random1 == 2 && random2 == 2) {
            ss++;
        }
        if ((SS + ss + Ss) == max) {
            done.SetActive(true);
            doneBool = true;
        }
       }
    }
}
