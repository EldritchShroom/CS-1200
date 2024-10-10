// Ask for input from user
Console.Write("Enter a Response Code: ");
int code = int.Parse(Console.ReadLine()); 

// We can not forget that the ReadLine method only returns string, use parse to change to integer.

// Console.Write("Code = {0}", code); // Small test to make sure the input is what I need it to be.

if (code >= 100 && code < 200) // Wanted to use switch but multiple if else statements will have to do.
{
    switch(code)
    {
        case 100:
        case 101:
        case 102:
        case 103:
            Console.WriteLine($"{code} is an Informational Response.");
            break;
        default:
            Console.WriteLine($"{code} is not a valid Response.");
            break;
    }
    
}
else if (code >= 200 && code < 300)
{
    switch(code)
    {
        case 200:
        case 201:
        case 202:
        case 203:
        case 204:
        case 205:
        case 206:
        case 207:
        case 208:
        case 226:
            Console.WriteLine($"{code} is a Successful Response.");
            break;
        default:
            Console.WriteLine($"{code} is not a valid Response.");
            break;
    }
    
}
else if (code >= 300 && code < 400)
{
    switch(code)
    {
        case 300:
        case 301:
        case 302:
        case 303:
        case 304:
        case 305:
        case 307:
        case 308:
            Console.WriteLine($"{code} is a Redirection Message.");
            break;
        default:
            Console.WriteLine($"{code} is not a valid Response.");
            break;
    }
    
}
else if (code >= 400 && code < 500)
{
    switch(code)
    {
        case 400:
        case 401:
        case 402:
        case 403:
        case 404:
        case 405:
        case 406:
        case 407:
        case 408:
        case 409:
        case 410:
        case 411:
        case 412:
        case 413:
        case 414:
        case 415:
        case 416:
        case 417:
        case 418:
        case 421:
        case 422:
        case 423:
        case 424:
        case 425:
        case 426:
        case 429:
        case 431:
        case 451:
            Console.WriteLine($"{code} is a Client Error Response.");
            break;
        default:
            Console.WriteLine($"{code} is not a valid Response.");
            break;
    }
    
}
else
{
    switch(code)
    {
        case 500:
        case 501:
        case 502:
        case 503:
        case 504:
        case 505:
        case 506:
        case 507:
        case 508:
        case 510:
        case 511:
            Console.WriteLine($"{code} is a Server Error Response.");
            break;
        default:
            Console.WriteLine($"{code} is not a valid Response.");
            break;
    }
    
}
