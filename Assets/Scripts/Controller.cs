using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    MeshRenderer meshRendHead, meshRendTorso, meshRendWingL, meshRendWingR, meshRendTail, meshRendFootL, meshRendFootR, meshRendArmR, meshRendArmL, meshRendBobble;

    void Start()
    {
        CharacterData characterData = new CharacterData();
        meshRendHead = GameObject.Find("Dummy008").GetComponent<MeshRenderer>();
        meshRendTorso = GameObject.Find("Dummy003").GetComponent<MeshRenderer>();
        meshRendWingL = GameObject.Find("Dummy004").GetComponent<MeshRenderer>();
        meshRendWingR = GameObject.Find("Dummy005").GetComponent<MeshRenderer>();
        meshRendTail = GameObject.Find("Dummy006").GetComponent<MeshRenderer>();
        meshRendFootL = GameObject.Find("Dummy009").GetComponent<MeshRenderer>();
        meshRendFootR = GameObject.Find("Dummy010").GetComponent<MeshRenderer>();
        meshRendArmR = GameObject.Find("Dummy011").GetComponent<MeshRenderer>();
        meshRendArmL = GameObject.Find("Dummy012").GetComponent<MeshRenderer>();
        meshRendBobble = GameObject.Find("Dummy013").GetComponent<MeshRenderer>();
    }


    void Update()
    {
        UpdateStats();
    }

    public void UpdateMaterial(Material newMaterial)
    {
        meshRendHead.material = newMaterial;
        meshRendTorso.material = newMaterial;
        meshRendWingL.material = newMaterial;
        meshRendWingR.material = newMaterial;
        meshRendTail.material = newMaterial;
        meshRendFootL.material = newMaterial;
        meshRendFootR.material = newMaterial;
        meshRendArmR.material = newMaterial;
        meshRendArmL.material = newMaterial;
        meshRendBobble.material = newMaterial;
    }

    void UpdateStats()
    {

    }
}
