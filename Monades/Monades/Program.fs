open System

type Result<'TSuccess,'TFailure> =
    | Success of 'TSuccess
    | Failure of 'TFailure

type Request = {
    email: string
}
  
let (>=>) switch1 switch2 x =
    match switch1 x with
    | Success s -> switch2 s
    | Failure f -> Failure f
    
    
let receiveRequest request =
    match request.email with
    | "" -> Failure "Email Is Empty"
    |_ -> Success request
    
let validateRequest request =
    if request.email.Contains("@") then
        Success request
    else Failure "Wrong format"
    
let canonicalizeEmail request =
    Success {request with email = request.email.ToLower()}
    
let updateDbFromRequest request =
    Console.WriteLine("Database has been updated")
    Success request

let sendEmail request =
    Console.WriteLine("Email was sent")
    Success request

let returnMessage request =
    Success $"{request.email}"
    
let updateCustomerWithErrorHandling =
    receiveRequest
    >=> validateRequest
    >=> canonicalizeEmail
    >=> updateDbFromRequest
    >=> sendEmail
    >=> returnMessage

let request = {email = "fdfvvf@mail.ru";}
    
Console.WriteLine(updateCustomerWithErrorHandling request)