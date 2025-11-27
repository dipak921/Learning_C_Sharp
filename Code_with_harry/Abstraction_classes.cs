using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ABSTRACT KEYWORD
//--> Abstract Method : it has no body and it is necessary to provide its implementation in derived class.
//--> Abstract Class : it cannot instantiated and implemention must be provided in derived class to use it. Can have bot Abstract and Non-Abstract Methods. WAP to show example of Abstradt Mehtod and class.
//                   - The word abstract means a concept or an idea not associated with any specific instance. In porgraming we apply the same meaning of abstraction by making classes not associated with any specific instance.
//                   - The abstraction is done when we need to only inherit from a certain class, but not need to instantiate object of that class.
//                   - In c#, abstraction is achieved using abstract classes and interfaces.
//                   - 1.C# Abstract classes are used to declare common characteristics of subclasees.
//                   -2. A class which contain the abstract keyword in its declaration is known as abstract class.
//                   - 3. It can only be used as a BASE class for other classes that extend the abstract class.
//                   -4. Abstract classes may or may not contain abstract methods, i.e methods without body(public void get(); ).
//                   -5. Like any other class, an abstracto class can contain fields that describe the characteristics and methods that describe the actions that a class can perfrom.
//                   -6. But, if a class has at least one abstract method, then the class must be declared abstract.
//                   -7. if a class is declared abstract, it cannot be instantiated.
//                   - 8. To use an abstract class you have to inherit it from another class, provide implementations to the abstract methods in it.
//                   -9. If you inherit an abstract class, you have to provide implemntations to all the abstract method in it.
//                   - 10. An abstract class can implement code with non-abstract methods.
//                   - 11. An abstract class can have modifiers for methodds, properties etc.
//                   - 12. An Abstract class can have constant and fields.
//                   - 13. an abstrct class can implement a property.
//                   - 14. An abstract class can have constructors or destructors.
namespace Code_with_harry
{
    internal class Abstraction_classes
    {
        static void Main(string[] args)
        {


            Console.ReadLine();
        }
    }
}
