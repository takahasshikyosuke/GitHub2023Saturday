using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPBar : MonoBehaviour
{
    int maxHp = 155;
    int currentHp;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
        currentHp = maxHp;
        Debug.Log("Start currentHp : " + currentHp);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            int damage = Random.Range(1, 100);
            Debug.Log("damage : " + damage);

            currentHp = currentHp - damage;
            Debug.Log("After currentHp : " + currentHp);
            slider.value = (float)currentHp / (float)maxHp; ;
            Debug.Log("slider.value : " + slider.value);
        }
    }
    void Update()
    {
        if (currentHp <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("End");
        }
    }
}


