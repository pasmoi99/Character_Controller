using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Camera _camera;
    
    private CharaController _chara;
    [SerializeField] private float _spacingUp;
    [SerializeField] private float _spacingZ;
    // Start is called before the first frame update
    void Start()
    {
        //_camera = GetComponent<Camera>();
        _chara = MainGame.Main.MainCharacter;
        CenterCameraOnPlayer(_chara.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        CenterCameraOnPlayer(_chara.transform.position);
    }

    public void CenterCameraOnPlayer(Vector3 Chara)
    {
        
        transform.position = new Vector3(Chara.x,Chara.y + _spacingUp,Chara.z + _spacingZ);
    }
}
