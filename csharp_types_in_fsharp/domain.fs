
namespace CsharpTypesInFsharp
 
module domain =

    type Customer(customerId:string, name:string) = 

        let mutable customerName = name 
        member x.CustomerId = customerId 
        member x.Name 
            with get() = customerName
            and set(value) = customerName <- value
             

        


