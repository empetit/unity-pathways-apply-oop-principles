
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
    public override void PrimitiveClicked(){
        Debug.Log("[SpherePrimitive] I was clicked : " + this.primitiveName);

        var color =  Random.ColorHSV();
        
        // always red-ish
        color.r = 255;

        this.SetColor( color );
    }
}
