using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class ManagerProces : MonoBehaviour
{
    public int Cont = 1;
    public TextMeshProUGUI lblCPU;
    public TextMeshProUGUI lblRAM;
    public TextMeshProUGUI lblHHDD;
    public TextMeshProUGUI lblStatusFilesManager;
    public TextMeshProUGUI lblStatusFilesManagerTwo;
    public TextMeshProUGUI lblNameManagerProcess;
    public TextMeshProUGUI lblResourceManagerProcess;
    public TextMeshProUGUI lblCPUManagerProcess;
    public TextMeshProUGUI lblRAMManagerProcess;
    public TextMeshProUGUI lblHHDManagerProcess;
    public TextMeshProUGUI lblNameManagerProcessTwo;
    public TextMeshProUGUI lblResourceManagerProcessTwo;
    public TextMeshProUGUI lblCPUManagerProcessTwo;
    public TextMeshProUGUI lblRAMManagerProcessTwo;
    public TextMeshProUGUI lblHHDManagerProcessTwo;
    public GameObject imgStatusManagerProcess;
    public GameObject imgStatusManagerProcessTwo;

    /// <summary>
    /// Star process and configure field names
    /// </summary>
    public void StartProcces()
    {

        //Firts proccess
        lblNameManagerProcess.text = "Excel";
        lblResourceManagerProcess.text = "50%";
        lblCPUManagerProcess.text = "80%";
        lblRAMManagerProcess.text = "20%";
        lblHHDManagerProcess.text = "60%";
        StartCoroutine(WaitAndPrint(3.0f));
    }

    /// <summary>
    /// Methods for sleep the aplication
    /// </summary>
    /// <param name="waitTime"></param>
    /// <returns></returns>
    IEnumerator WaitAndPrint(float waitTime)
    {
        if (Cont == 1)
        {
            lblCPU.text = "60%";
            lblRAM.text = "80%";
            lblHHDD.text = "20%";

            // delay 2 seconds 
            yield return new WaitForSeconds(waitTime);
            lblCPU.text = "80%";
            lblRAM.text = "100%";
            lblHHDD.text = "60%";

            yield return new WaitForSeconds(waitTime);
            lblCPU.text = "40%";
            lblRAM.text = "30%";
            lblHHDD.text = "80%";

            yield return new WaitForSeconds(waitTime);
            lblCPU.text = "70%";
            lblRAM.text = "40%";
            lblHHDD.text = "40%";

            yield return new WaitForSeconds(waitTime);
            lblCPU.text = "90%";
            lblRAM.text = "20%";
            lblHHDD.text = "60%";
            lblStatusFilesManager.text = "Procesado";

            yield return new WaitForSeconds(waitTime);
            imgStatusManagerProcess.SetActive(true);

            //Second Process
            Cont = 2;
            lblNameManagerProcessTwo.text = "Word";
            lblResourceManagerProcessTwo.text = "30%";
            lblCPUManagerProcessTwo.text = "40%";
            lblRAMManagerProcessTwo.text = "80%";
            lblHHDManagerProcessTwo.text = "90%";
            StartCoroutine(WaitAndPrint(3.0f));
        }
        else
        {
            lblCPU.text = "60%";
            lblRAM.text = "80%";
            lblHHDD.text = "20%";

            // delay 2 seconds 
            yield return new WaitForSeconds(waitTime);
            lblCPU.text = "80%";
            lblRAM.text = "100%";
            lblHHDD.text = "60%";

            yield return new WaitForSeconds(waitTime);
            lblCPU.text = "40%";
            lblRAM.text = "30%";
            lblHHDD.text = "80%";

            yield return new WaitForSeconds(waitTime);
            lblCPU.text = "70%";
            lblRAM.text = "40%";
            lblHHDD.text = "40%";

            yield return new WaitForSeconds(waitTime);
            lblCPU.text = "90%";
            lblRAM.text = "20%";
            lblHHDD.text = "60%";
            lblStatusFilesManagerTwo.text = "Procesado";
            imgStatusManagerProcessTwo.SetActive(true);
            Console.WriteLine("Proceso Terminado");
        }
    }
}
