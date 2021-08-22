using UnityEngine;

// INHERITANCE
public class CylenderPrimitive : Primitive
{
    // Start is called before the first frame update
    void Start()
    {
        // INHERITANCE
        base.InitPrimitive();
    }
    
    // POLYMORPHISM
    protected override void PrimitiveClicked(){
        Debug.Log("[CylenderPrimitive] I was clicked : " + this.primitiveName);
    }
}
