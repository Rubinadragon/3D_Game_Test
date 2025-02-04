using Unity.Cinemachine;
using UnityEngine;

public class CamManager : MonoBehaviour
{
    //Peke p� kameraene
    [SerializeField] CinemachineCamera OverviewCam;
    [SerializeField] CinemachineCamera OrbitCam;

    //Sette kamera aktiv/ikke aktiv
    private bool isOverviewCamActive = true;
    // Update is called once per frame
    void Update()
    {
        //GetKeydown er en metode
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isOverviewCamActive = !isOverviewCamActive;
            //Debug.Log(isOverviewCamActive);
            //Endre verdien p� scripts
            if (isOverviewCamActive)
            {
                OverviewCam.Priority = 1;
                OrbitCam.Priority = 0;
            } else
            {
                OverviewCam.Priority = 0;
                OrbitCam.Priority = 1;
            }
        };
    }
}
