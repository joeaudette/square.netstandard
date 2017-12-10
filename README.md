# an unofficial port of https://github.com/square/connect-csharp-sdk to netstandard2

## NuGet Package

https://www.nuget.org/packages/Square.NetStandard/

## Rationale

The official sdk does not currently support .NET Core/NetStandard/ASP.NET Core as seen in [this issue](https://github.com/square/connect-csharp-sdk/issues/30).
I needed to use Square in one of my ASP.NET Core projects so I ported the sdk code. It was relatively straightforward porting the code. I made a netstandard2 class library project and copied in the code files and added these dependencies in the .csproj file:

    <ItemGroup>
    <PackageReference Include="NewtonSoft.Json" Version="10.0.*" />
    <PackageReference Include="RestSharp" Version="106.1.*" />
    <PackageReference Include="System.ComponentModel.Annotations" Version="4.1.0" />
    <PackageReference Include="Microsoft.AspNetCore.WebUtilities" Version="2.0.*" />
  </ItemGroup>
  
There was one file that was using Syste.Web.HttpUtility which I changed to use an equivalent class in ASP.NET Core. There was one place where a RestSharp method required an additional paramter to be passed in. I think those were the only changes needed to make it build. Then I made a demo web app to test it.

Hopefully eventually the official sdk will support NetStandard, but in the mean time so far this port seems to work and meet my needs.


## Running the SquareDemo.Web Sample Project

### Provide required credentials

Copy the appsettings.json file as appsettings.Development.json 

In this repository appsettings.Development.json is a gitignored file so you can safely put your credentials there. If you are using your own repository be sure to gitignore it there too.

Having the appsettings.Development.json file git ignored means you can safely put your square sandbox credentials there without it going into source control.

After building the solution, run the demo web app and click the menu item for Square Demo

The demo web app was implemented based on the older webforms example here:
https://github.com/square/connect-api-examples/tree/master/connect-examples/v2/csharp_payment

If you're using your sandbox credentials, you can test a valid credit card
transaction by providing the following card information in the form:

* Card Number 4532 7597 3454 5858
* Card CVV 111
* Card Expiration (Any time in the future)
* Card Postal Code (Any valid US postal code)

You can find more testing values in this [article](https://docs.connect.squareup.com/articles/using-sandbox)

**Note that if you are _not_ using your sandbox credentials and you enter _real_
credit card information, YOU WILL CHARGE THE CARD.**

After entering the card information, you could click `submit` button to get a 
nonce. Then click `charge` button to send the nonce and you would 
get the transaction repsonse body in an alert window.

## Apple Pay

Apple Pay Requires https and it cannot be tested from localhost so it will be disabled in the demo running on localhost.

Please follow the Apple Pay instructions on [Square Connect Documentation Site](https://docs.connect.squareup.com/articles/adding-payment-form).