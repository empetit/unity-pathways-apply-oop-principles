using UnityEngine;

public class Primitive : MonoBehaviour
{

    [SerializeField]
    protected string primitiveName = "BasePrimitive";
    // ENCAPSULATION
    protected Color primitiveColor{ get; private set;}

    // ABSTRACTION
    protected void InitPrimitive()
    {
        this.primitiveColor = Random.ColorHSV();
    }

    void Update(){
        this.GetComponent<Renderer>().materials[0].color = this.primitiveColor;
    }

    // ABSTRACTION
    protected void SetColor(Color newColor){
        if(newColor.a < .5){
            throw new System.Exception("Invalid color alpha");
        }

        this.primitiveColor = newColor;
    }
    
    //POLYMORPHISM
    public virtual void PrimitiveClicked(){
        Debug.Log(this.primitiveName);
    }
}
