using UnityEngine;

public class Primitive : MonoBehaviour
{

    // ENCAPSULATION
    protected string primitiveName { get; private set;}
    // ENCAPSULATION
    protected Color primitiveColor{ get; private set;}

    // ABSTRACTION
    protected void InitPrimitive()
    {
        this.primitiveColor = Random.ColorHSV();
    }

    // ABSTRACTION
    protected void SetColor(Color newColor){
        if(newColor.a < .5){
            throw new System.Exception("Invalid color alpha");
        }

        this.primitiveColor = newColor;
    }
    
    //POLYMORPHISM
    protected virtual void PrimitiveClicked(){
        Debug.Log(this.primitiveName);
    }
}
