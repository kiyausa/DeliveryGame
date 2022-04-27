using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManeger : MonoBehaviour
{
    [SerializeField] private List<GameObject> labels = new List<GameObject>(16);

    private TextWrapper _textMesh;

    [SerializeField] private List<string> uiLabels = new List<string>(16);

    private void Start()
    {
        int i = 0;
        foreach(GameObject gameObject in labels)
        {
            _textMesh = gameObject.GetComponent<TextWrapper>();
            _textMesh.SetTextMesh(uiLabels[i]);
            
            Debug.Log(uiLabels[i]);
            i++;
        }
    }

    private void FixedUpdate()
    {
    }

    private void AddText(string _text)
    {
    }
}
