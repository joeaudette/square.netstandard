# an unofficial port of https://github.com/square/connect-csharp-sdk to netstandard2


### Provide required credentials

Copy the appsettings.json file as appsettings.Development.json 

In this repository appsettings.Development.json is a gitignored file so you can safely put your credentials there. If you are using your own repository be sure to gitignore it there too.

Having the appsettings.Development.json file git ignored means you can safely put your square sandbox credentials there without it going into source control.


## Running the sample

After building the solution, run the demo web app and click the menu item for Square Demo

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

Please follow the Apple Pay instructions on [Square Connect Documentation Site](https://docs.connect.squareup.com/articles/adding-payment-form).