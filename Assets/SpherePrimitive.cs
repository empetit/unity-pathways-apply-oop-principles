
// INHERITANCE
using UnityEngine;

public class SpherePrimitive : Primitive
{
  // Start is called before the first frame update
    void Start()
    {
        // INHERITANCE
        base.InitPrimitive();
    }
    
    // POLYMORPHISM
    protected override void PrimitiveClicked(){
        Debug.Log("[SpherePrimitive] I was clicked : " + this.primitiveName);
    }
}
