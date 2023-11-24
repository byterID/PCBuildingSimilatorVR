using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ram : MonoBehaviour
{
    Progress progress;
    [SerializeField] private GameObject _content;

    private void Update()
    {
        _content = GameObject.Find("ContentLearning");
        progress = _content.GetComponent<Progress>();
    }
    public void RamScoreCount()
    {
        progress._ramCount++;
    }
}
