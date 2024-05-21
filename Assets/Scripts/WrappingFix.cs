using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WrappingFix : MonoBehaviour
{
    void Start()
    {
        TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.enableWordWrapping = true;
    }
}
