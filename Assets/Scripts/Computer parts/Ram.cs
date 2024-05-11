using UnityEngine;

public class Ram : MonoBehaviour
{
    public void RamScoreCount()
    {
        Progress.Instance._ramCount++;
        if (Progress.Instance._ramCount == 4)
        {
            Progress.Instance.RevialCoolerSocket();
        }
    }
}
