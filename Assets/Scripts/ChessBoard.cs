
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    
    [SerializeField] private GameObject whiteTilePrefab ; // Prefab o trang
    [SerializeField] private GameObject greenTilePrefab ; // prefab o den 
    private int boradSize = 8; // kich thuoc cua ban co (8x8)

    private void Start() {
        CreateBoard();
    }
    private void CreateBoard() {
        for (int i = 0 ; i < boradSize ; i++){
            for (int j = 0 ; j < boradSize ; j++ ){

                // Tao ra o voi mau sac xen ke 
                GameObject titlePrefab = (i + j) % 2 == 0 ? whiteTilePrefab : greenTilePrefab;
                Vector3 pos = new Vector3 (i,j,0);

                GameObject title = Instantiate(titlePrefab , pos , Quaternion.identity);
                title.name = $"{i} {j}";
                title.transform.parent = this.transform;
               
            }
        }
    

   
    }
}
