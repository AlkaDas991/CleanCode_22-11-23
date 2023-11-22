1. review1.cs
// Readability is Important
public bool IsShopOpen(string day)
{
    if (!string.IsNullOrEmpty(day))
    {
        day = day.ToLower();
        if (day == "friday")
        {
            return true;
        }
        else if (day == "saturday")
        {
            return true;
        }
        else if (day == "sunday")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }

}

// One Approach
public bool IsShopOpen(string currentDay)
{
    if (!string.IsNullOrEmpty(currentDay))
    {
        currentDay = currentDay.ToLower();
        if (currentDay == "friday" || (currentDay == "saturday") ||(currentDay == "sunday"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }

}

//better way: data driven code not code driven code
// avoid nesting too deeply
public bool IsShopOpen(string currentDay)
{
    if (string.IsNullOrEmpty(currentDay))
    {
            return true;
    }
    
    var openingDays = new[]{ "Friday", "Saturday", "Sunday"};
    return openingDays.Any(d => d == currentDay.ToLower());

}

2.review3.cs
public long Fibonacci(int n)
{
    if (n < 50)
    {
        if (n != 0)
        {
            if (n != 1)
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            else
            {
                return 1;
            }
        }
        else
        {
            return 0;
        }
    }
    else
    {
        throw new System.Exception("Not supported");
    }
}

// better way, avoild too much nesting
public long Fibonacci(int n)
{
    if(n >= 50)
        throw new System.Exception("Not supported");
    if( n == 0 || n == 1) 
        return n;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

3. review4.cs
// bettter variable name : what is l?
var l = new[] { "Austin", "New York", "San Francisco" };

// what is li ? give better name.
for (var i = 0; i < l.Count(); i++)
{
    var li = l[i];
  // better method names to make it readable to know what this method is doing
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(li);
}
4.review5.cs

// hard code avoid magic numbers.
if (userRole == 8) // Check if Admin 
{
    
}

5.review6.cs
// redundant code, just have fields may be, no need to create extra methods
public class Car
{
    public string CarMake { get; set; }
    public string CarModel { get; set; }
    public string CarColor { get; set; }

    //...
}

6.review7.cs
//varibale name change
var ymdstr = DateTime.UtcNow.ToString("MMMM dd, yyyy");

7. review9.cs

//CamelCase for brewery
public void CreateMicrobrewery(string name = null)
{
// directly assign the name instead of ternary operator.
  
    var breweryName = !string.IsNullOrEmpty(name) ? name : "Hipster Brew Co.";
    // ...
}

