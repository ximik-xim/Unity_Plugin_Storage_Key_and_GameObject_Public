using UnityEngine; 
using TListPlugin; 
[System.Serializable]
public class IdentifierAndData_StorageKeyGM : AbsIdentifierAndData<IndifNameSO_StorageKeyGM, string, StorageKeyGM>
{

 [SerializeField] 
 private StorageKeyGM _dataKey;


 public override StorageKeyGM GetKey()
 {
  return _dataKey;
 }
}
