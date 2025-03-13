using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    public static MainPanel Inst;

    private void Awake()
    {
        Inst = this;
    }

    public Button replaybtn;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        replaybtn.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        });
    }

    public void Show()
    {
        gameObject.SetActive(true); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
